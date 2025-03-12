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


namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.MainMenuForm
{
    public partial class MainMenuForm : Form
    {
        private readonly BookingDal _bookingDal;

        private string _role;
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


            InitialButton();
            RegisterControlEvent();
            ShowFormHelper.SetPanel(PanelMain);
            DeleteBooking();
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
                ButtonKaryawan, ButtonSparepart, ButtonLogout
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
            ButtonKaryawan.Click += ButtonKaryawan_Click;
            ButtonSparepart.Click += ButtonSparepart_Click;
            ButtonLogout.Click += ButtonLogout_Click;
            ButtonMekanik.Click += ButtonMekanik_Click;

        }

        private void MainMenuForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;

            if (!MesboxHelper.ShowConfirm("Apakah anda yakin ingin keluar aplikasi ?"))
                e.Cancel = true;
            else
                Application.Exit();
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
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
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

            ShowFormHelper.ShowFormInPanel(new SMB_Form.Karyawan_SuperAdmin.DashboardForm.DashboardForm());
        }
    }
}