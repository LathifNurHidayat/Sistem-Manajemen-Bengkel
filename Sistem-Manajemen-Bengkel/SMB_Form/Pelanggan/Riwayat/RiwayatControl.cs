using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accessibility;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal.SessionLogin;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Riwayat
{
    public partial class RiwayatControl : UserControl
    {
        private static RiwayatDal _riwayatDal;
        private static FlowLayoutPanel _flowPanelMain;

        public RiwayatControl()
        {
            InitializeComponent();
            _riwayatDal = new RiwayatDal();
            _flowPanelMain = FlowPanelMain;
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

            _flowPanelMain.Controls.Clear(); 

            var riwayatList = _riwayatDal.ListDataWhereNoKtp(SessionLogin._sessionLoginPelanggan.no_ktp_pelanggan);

            if (riwayatList?.Any() ?? false)
            {
                foreach (var riwayat in riwayatList)
                {
                    var listriwayat = new ListRiwayatControl(riwayat.id_kendaraan)
                    {
                        Dock = DockStyle.Top,
                        Width = _flowPanelMain.Width,
                    };
                    _flowPanelMain.Controls.Add(listriwayat);
                }
            }
        }
    }
}
