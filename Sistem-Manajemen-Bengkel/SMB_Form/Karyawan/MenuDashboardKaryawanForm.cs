using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.Windows.Forms.Chart;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;
using OxyPlot.Series;
using OxyPlot.Wpf;

namespace Sistem_Manajemen_Bengkel.SMB_Form.KaryawanForm
{
    public partial class MenuDashboardKaryawanForm : Form
    {
        public MenuDashboardKaryawanForm()
        {
            InitializeComponent();
            RegisterControlEvent();
            LoadChart();
        }

        private void RegisterControlEvent()
        {
            PanelBackground.Resize += PanelBackground_Resize;
            PanelData.Resize += (s, e) => PanelData.Invalidate();
        }

        private void PanelBackground_Resize(object? sender, EventArgs e)
        {
            int childPanelWidth = (PanelBackground.Width - 60) / 3;

            PanelPelanggan.Width = childPanelWidth;
            PanelAntrean.Width = childPanelWidth;
            PanelService.Width = childPanelWidth;

            PanelPelanggan.Location = new Point(15, PanelPelanggan.Location.Y);
            LabelTotalPelanggan.Location = new Point((PanelPelanggan.Width - LabelTotalPelanggan.Width) / 2, LabelTotalPelanggan.Location.Y);

            PanelAntrean.Location = new Point(childPanelWidth + 30, PanelAntrean.Location.Y);
            LabelTotalBooking.Location = new Point((PanelAntrean.Width - LabelTotalBooking.Width) / 2, LabelTotalBooking.Location.Y);

            PanelService.Location = new Point(childPanelWidth * 2 + 45, PanelService.Location.Y);
            LabelTotalService.Location = new Point((PanelService.Width - LabelTotalService.Width) / 2, LabelTotalService.Location.Y);


            CustomComponentHelper.CustomPanel(PanelPelanggan);
            CustomComponentHelper.CustomPanel(PanelAntrean);
            CustomComponentHelper.CustomPanel(PanelService);
            CustomComponentHelper.CustomPanel(PanelBackground);

        }



        private void LoadChart()
        {
            string connectionString = "Server=(local);Database=coba;Integrated Security=True;";
            string query = @"
                SELECT FORMAT(TanggalServis, 'yyyy-MM') AS Bulan, COUNT(*) AS JumlahServis
                FROM Servis
                WHERE TanggalServis >= DATEADD(MONTH, -6, GETDATE())
                GROUP BY FORMAT(TanggalServis, 'yyyy-MM')
                ORDER BY Bulan;";

            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            // Pastikan Chart memiliki Series
            if (chartControl1.Series.Count == 0)
            {
                ChartSeries s = new ChartSeries("Jumlah Servis", ChartSeriesType.Column);
                chartControl1.Series.Add(s);
            }

            ChartSeries series = chartControl1.Series[0];
            series.Points.Clear(); // Hapus data lama sebelum mengisi ulang

            foreach (DataRow row in dt.Rows)
            {
                string bulan = row.Field<string>("Bulan"); // Format bulan "yyyy-MM"
                int jumlah = row.Field<int>("JumlahServis");

                series.Points.Add(bulan, jumlah); // Gunakan bulan sebagai kategori pada X-Axis
            }

            // Konfigurasi Chart
            chartControl1.PrimaryXAxis.ValueType = ChartValueType.Category; // Agar X-Axis berupa kategori (bulan)
            chartControl1.PrimaryXAxis.LabelRotate = true; // Putar label agar lebih terbaca
            chartControl1.PrimaryXAxis.LabelRotateAngle = 45; // Putar label 45 derajat
            chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows; // Gunakan multiple rows jika label panjang

            // Set judul dan tampilan chart
            chartControl1.ForeColor = Color.Black;
            chartControl1.Text = "Jumlah Servis per Bulan (6 Bulan Terakhir)";
            chartControl1.PrimaryXAxis.Title = "Bulan";
            chartControl1.PrimaryYAxis.Title = "Jumlah Servis";
            chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 100, 10); // Sesuaikan range jika perlu
        }



        public class ServisChartModel
        {
            public DateTime TanggalServis { get; set; }
            public int JumlahServis { get; set; }
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
