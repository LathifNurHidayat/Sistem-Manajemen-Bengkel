using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.DashboardForm
{
    public partial class DashboardSuperAdminForm : Form
    {
        private readonly DashboardDal _dashboardDal;
        public DashboardSuperAdminForm()
        {
            InitializeComponent();
            _dashboardDal = new DashboardDal();
            CustomComponentHelper.CustomDataGrid(GridListPeringkatSparepart);
            CustomComponentHelper.CustomDataGrid(GridListPeringkatServis);

            RegisterControlEvent();
            GetData();

        }

        private void GetData()
        {
            int totalpelanggan = _dashboardDal.GetDashboardMetrics(DateTime.Today).TotalDataPelanggan;
            int totalBookingHariIni = _dashboardDal.GetDashboardMetrics(DateTime.Today).TotalBookingHariIni;
            int totalServisHariIni = _dashboardDal.GetDashboardMetrics(DateTime.Today).TotalSelesaiServisHariIni;
            decimal pendapatanHariIni = _dashboardDal.GetDashboardMetrics(DateTime.Today).TotalPendapatanHariIni;

            LabelTotalPelanggan.Text = totalpelanggan.ToString();
            LabelTotalBooking.Text = totalBookingHariIni.ToString();
            LabelTotalService.Text = totalServisHariIni.ToString();
            LabelPendapatan.Text = pendapatanHariIni.ToString("C", new CultureInfo("id-ID"));

            var peringkatServisPelanggan = _dashboardDal.GetDashboardMetrics(DateTime.Today).TopPelanggan.Select((x, index) => new
            {
                No = index + 1,
                Nama = x.NamaPelanggan,
                TotalServis = x.TotalServis
            }).ToList();

            var peringkatSparepartTerjual = _dashboardDal.GetDashboardMetrics(DateTime.Today).TopSpareparts
                .OrderByDescending(x => x.JumlahTerjual)
                .Select((x, Index) => new
                {
                    No = Index + 1,
                    Sparepart = x.NamaSparepart,
                    Terjual = x.JumlahTerjual
                }).ToList();



            GridListPeringkatServis.DataSource = peringkatServisPelanggan;
            GridListPeringkatSparepart.DataSource = peringkatSparepartTerjual;


            CustomGrid(GridListPeringkatServis);
            CustomGrid(GridListPeringkatSparepart);


            void CustomGrid(DataGridView grid)
            {
                grid.BorderStyle = BorderStyle.None;
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    column.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
                }

                if (grid.Name == "GridListPeringkatServis")
                {
                    grid.Columns["TotalServis"].HeaderText = "Total Servis";

                    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    grid.Columns["No"].FillWeight = 20;
                    grid.Columns["Nama"].FillWeight = 50;
                    grid.Columns["TotalServis"].FillWeight = 30;
                }

                else
                {
                    grid.Columns["Terjual"].HeaderText = "Total Terjual";

                    grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    grid.Columns["No"].FillWeight = 20;
                    grid.Columns["Sparepart"].FillWeight = 50;
                    grid.Columns["Terjual"].FillWeight = 30;
                }
            }
        }

        private void RegisterControlEvent()
        {
            PanelBackground.Resize += PanelBackground_Resize;
            PanelData.Resize += (s, e) => PanelData.Invalidate();

            ButtonJamKerja.Click += ButtonJamKerja_Click;
            ButtonJadwalLibur.Click += ButtonJadwalLibur_Click;
            ButtonProfilBengkel.Click += ButtonProfilBengkel_Click;

        }

        private void ButtonProfilBengkel_Click(object? sender, EventArgs e)
        {
            ProfilBengkelForm profilBengkelForm = new ProfilBengkelForm();
            profilBengkelForm.ShowDialog();
        }

        private void ButtonJadwalLibur_Click(object? sender, EventArgs e)
        {
            JadwalLiburForm jadwalLiburForm = new JadwalLiburForm();
            jadwalLiburForm.ShowDialog();
        }

        private void ButtonJamKerja_Click(object? sender, EventArgs e)
        {
            JamKerjaForm jamKerjaForm = new JamKerjaForm();
            jamKerjaForm.ShowDialog();
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

            CustomPanel(PanelPelanggan);
            CustomPanel(PanelAntrean);
            CustomPanel(PanelService);
            CustomPanel(PanelBackground);
        }

        private void CustomPanel(Panel panel)
        {
            int cornerRadius = 10;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // kiri atas
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // kanan atas
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // kanan bawah
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // kiri bawah
            path.CloseAllFigures();

            panel.Region?.Dispose();
            panel.Region = new Region(path);

            using (Graphics g = panel.CreateGraphics())
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
        }
    }
}