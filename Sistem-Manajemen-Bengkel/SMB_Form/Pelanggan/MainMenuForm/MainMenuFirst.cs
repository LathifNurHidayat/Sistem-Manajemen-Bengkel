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
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal.SessionLogin;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.BookingForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.LandingPage;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.RiwayatForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm
{
    public partial class MainMenuFirst : Form
    {

        public static Form _mainForm = new Form();
        private string? _username;
        public bool _isLogin = true;

        private bool _isClosingByCode = false;

        public MainMenuFirst()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _mainForm = this;
            _username = SessionLogin._sessionLoginPelanggan?.nama_pelanggan == null ? "" : SessionLogin._sessionLoginPelanggan?.nama_pelanggan;

            LabelUsername.Text = _username;

            ShowFormHelper.SetPanel(PanelMain);
            IsLogin();

            RegisterControlEvent();
        }

        private void IsLogin()
        {

            if (string.IsNullOrEmpty(_username))
            {
                ButtonHome.Location = ButtonRiwayat.Location;
                ButtonLogout.Text = "Login";

                ButtonBooking.Visible = false;
                ButtonRiwayat.Visible = false;

                _isLogin = false;
            }
        }

        private void RegisterControlEvent()
        {
            this.Load += (s, e) => ButtonHome.PerformClick();

            ButtonHome.Click += ButtonDashboard_Click;
            ButtonBooking.Click += ButtonBooking_Click;
            ButtonRiwayat.Click += ButtonRiwayat_Click;
            ButtonLogout.Click += ButtonLogout_Click;

            this.FormClosing += MainMenuFirst_FormClosing;
        }

        private void MainMenuFirst_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;

            if (!MesboxHelper.ShowConfirm("Apakah anda yakin ingin keluar aplikasi ?"))
                e.Cancel = true;
        }

        private void ButtonDashboard_Click(object sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new LandingPageForm(_isLogin));
        }

        private void ButtonBooking_Click(object sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new BookingPelanggan());
        }

        private void ButtonRiwayat_Click(object sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new RiwayatPelanggan());
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            if (ButtonLogout.Text == "Login")
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                return;
            }
            else if (MesboxHelper.ShowConfirm("Apakah anda yakin ingin keluar?"))
            {
                
            }
        }
    }
}
