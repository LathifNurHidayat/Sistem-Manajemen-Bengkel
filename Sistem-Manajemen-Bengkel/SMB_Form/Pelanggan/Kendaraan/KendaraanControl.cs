using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Packaging;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal.SessionLogin;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan
{
    public partial class KendaraanControl : UserControl
    {
        private static KendaraanDal _kendaraanDal;
        private static FlowLayoutPanel _flowPanelMain;


        public KendaraanControl()
        {
            InitializeComponent();
            _flowPanelMain = FlowPanelMain;
            _kendaraanDal = new KendaraanDal();

            InitializeComponent();
            InitializeFlowPanel();
            LoadData();

        }

        private void InitializeFlowPanel()
        {
            _flowPanelMain.FlowDirection = FlowDirection.TopDown;
            _flowPanelMain.WrapContents = false;
            _flowPanelMain.AutoScroll = true;
        }

        public static void LoadData()
        {
            if (_flowPanelMain == null) return;

            _flowPanelMain.Controls.Clear(); // Bersihkan panel sebelum mengisi ulang

            var tambahKendaraan = new TambahKendaraanControl()
            {
                Width = _flowPanelMain.ClientSize.Width - 2
            };
            _flowPanelMain.Controls.Add(tambahKendaraan);

            var kendaraanList = _kendaraanDal.LoadNamaKendaraan(SessionLogin._sessionLoginPelanggan.no_ktp_pelanggan);

            if (kendaraanList?.Any() ?? false)
            {
                foreach (var kendaraan in kendaraanList)
                {
                    var listKendaraan = new ListKendaraanControl(kendaraan.id_kendaraan)
                    {
                        Width = _flowPanelMain.ClientSize.Width - 2
                    };
                    _flowPanelMain.Controls.Add(listKendaraan);
                }
            }
        }
    }
}