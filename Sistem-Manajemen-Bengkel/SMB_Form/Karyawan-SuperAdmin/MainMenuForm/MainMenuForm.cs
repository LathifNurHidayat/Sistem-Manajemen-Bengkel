using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm;
using Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.DashboardForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.SparepartForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Form.LoginRegisterForm;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm;


namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.MainMenuForm
{
    public partial class MainMenuForm : Form
    {
        private readonly BookingDal _bookingDal;
        private bool _isExitApplication = true;
        private readonly List<Button> _listButton = new List<Button>();

        public MainMenuForm(string username, string role, byte[]? profile)
        {
            InitializeComponent();
            _bookingDal = new BookingDal();

            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            LabelUsername.Text = username;
            LabelRole.Text = role;
            PictureProfiles.Image = profile != null ? ImageHelper.ByteToImage(profile) : ImageDirectoryHelper._defaultProfiles;

            PegawaiRole();
            InitialButton();
            RegisterControlEvent();
            ShowFormHelper.SetPanel(PanelMain);
            DeleteBooking();
        }


        private void PegawaiRole()
        {
            string role = SessionLoginHelper._sessionLoginPegawai.role;

            if (role == "Petugas")
            {
                ButtonPegawai.Visible = false;
                ButtonMekanik.Visible = false;
                ButtonSparepart.Visible = false;
                ButtonServis.Visible = false;
            }
        }

        private void DeleteBooking()
        {
            _bookingDal.DeleteAfterDateChange();
        }


        private void InitialButton()
        {
            _listButton.AddRange(new[] 
             {
                ButtonDashboard, ButtonBooking, ButtonServis,
                ButtonRiwayat, ButtonPelanggan, ButtonKendaraan,
                ButtonPegawai,ButtonMekanik, ButtonSparepart, ButtonLogout
             });

            foreach  (var btn in _listButton)
            {
                btn.Tag = "NoClick";
            }
        }

        private void StyleButton(Button button)
        {
            foreach (Button coloringButton in _listButton)
            {
                if (coloringButton == button)
                {
                    coloringButton.ForeColor = Color.Black;
                    coloringButton.BackColor = Color.WhiteSmoke;
                }
                else if (coloringButton.Tag == "Click")
                {
                    coloringButton.ForeColor = Color.Gray;
                    coloringButton.BackColor = Color.Transparent;
                }
            }
        }


        private void RegisterControlEvent()
        {
            this.FormClosing += MainMenuForm_FormClosing;
            this.Load += MainMenuForm_Load;
            ButtonDashboard.Click += ButtonDashboard_Click;
            ButtonBooking.Click += ButtonBooking_Click;
            ButtonServis.Click += ButtonServis_Click;
            ButtonRiwayat.Click += ButtonRiwayat_Click;
            ButtonPelanggan.Click += ButtonPelanggan_Click;
            ButtonKendaraan.Click += ButtonKendaraan_Click;
            ButtonPegawai.Click += ButtonKaryawan_Click;
            ButtonSparepart.Click += ButtonSparepart_Click;
            ButtonLogout.Click += ButtonLogout_Click;
            ButtonMekanik.Click += ButtonMekanik_Click;
            ButtonEditProfiles.Click += ButtonEditProfiles_Click;

        }

        private void ButtonEditProfiles_Click(object? sender, EventArgs e)
        {
            string no_ktp = SessionLoginHelper._sessionLoginPegawai.no_ktp_pegawai;

            EditProfilForm editProfilForm = new EditProfilForm(no_ktp);
            if (editProfilForm.ShowDialog() == DialogResult.OK)
            {
                PictureProfiles.Image = editProfilForm.ProfilPhoto ?? ImageDirectoryHelper._defaultProfiles;
                LabelUsername.Text = editProfilForm.ProfilName;
            }
        }

        private void MainMenuForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!_isExitApplication) return;

            if (!MesboxHelper.ShowConfirm("Apakah anda yakin ingin keluar aplikasi ?"))
                e.Cancel = true;
            else
                SetupFormHelper._setupForm.Close();
        }

        private void ButtonMekanik_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            if (sender is Button button) button.Tag = "Click";

            ShowFormHelper.ShowFormInPanel(new MekanikForm.MekanikForm()); 
        }

        private void MainMenuForm_Load(object? sender, EventArgs e)
        {
            ButtonDashboard.PerformClick();
        }


        private void ButtonLogout_Click(object? sender, EventArgs e)
        {
          if (MesboxHelper.ShowConfirm("Apakah anda yakin ingin logout?"))
            {
                SessionLoginHelper.ClearSessionLoginPegawai();

                _isExitApplication = false;
                MainMenuFirst main = new MainMenuFirst();
                main.Show();
                this.Close();
            }
        }

        private void ButtonSparepart_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);            
            if (sender is Button button) button.Tag = "Click";

            ShowFormHelper.ShowFormInPanel(new SMB_Form.Karyawan_SuperAdmin.SparepartForm.SparepartForm());

        }

        private void ButtonKaryawan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            if (sender is Button button) button.Tag = "Click";

            ShowFormHelper.ShowFormInPanel(new SuperAdminForm.PegawaiForm());
        }

        private void ButtonKendaraan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            if (sender is Button button) button.Tag = "Click";

            ShowFormHelper.ShowFormInPanel(new KendaraanForm());
        }

        private void ButtonPelanggan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            if (sender is Button button) button.Tag = "Click";

            ShowFormHelper.ShowFormInPanel(new PelangganForm());
        }

        private void ButtonRiwayat_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            if (sender is Button button) button.Tag = "Click";

            ShowFormHelper.ShowFormInPanel(new SMB_Form.Karyawan_SuperAdminForm.RiwayatForm());
        }

        private void ButtonServis_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            if (sender is Button button) button.Tag = "Click";

            ShowFormHelper.ShowFormInPanel(new JasaServisForm());
        }

        private void ButtonBooking_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            if (sender is Button button) button.Tag = "Click";

            ShowFormHelper.ShowFormInPanel(new Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm.BookingForm());
        }

        private void ButtonDashboard_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            if (sender is Button button) button.Tag = "Click";

            if (SessionLoginHelper._sessionLoginPegawai.role == "Petugas")
                ShowFormHelper.ShowFormInPanel(new DashboardPetugasForm());
            else
                ShowFormHelper.ShowFormInPanel(new SMB_Form.Karyawan_SuperAdmin.DashboardForm.DashboardSuperAdminForm());
        }
    }
}