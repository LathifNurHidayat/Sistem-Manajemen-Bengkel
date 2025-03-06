using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.BookingForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Dashboard;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.KendaraanForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.RiwayatForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm
{
    public partial class MainMenuPelanggan : Form
    {
        public MainMenuPelanggan(string username)
        {
            InitializeComponent();
            LabelUsername.Text = username;
            ShowFormHelper.SetPanel(PanelMain);


            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            this.Load += (s, e) => ButtonDashboard.PerformClick();

            ButtonDashboard.Click += ButtonDashboard_Click;
            ButtonBooking.Click += ButtonBooking_Click;
            ButtonKendaraan.Click += ButtonKendaraan_Click;
            ButtonRiwayat.Click += ButtonRiwayat_Click;
            ButtonLogout.Click += ButtonLogout_Click;
        }

        private void ButtonDashboard_Click(object sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new DashboardPelanggan());
        }

        private void ButtonBooking_Click(object sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new BookingPelanggan());
        }

        private void ButtonKendaraan_Click(object sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new KendaraanPelanggan());
        }

        private void ButtonRiwayat_Click(object sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new RiwayatPelanggan());
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Apakah anda yakin ingin keluar?"))
            {
                this.Close();
            }
        }
    }
}
