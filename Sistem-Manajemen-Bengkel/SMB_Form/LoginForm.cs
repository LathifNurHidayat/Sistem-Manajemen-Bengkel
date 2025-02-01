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
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Form.LoginRegister;

namespace Sistem_Manajemen_Bengkel.SMB_Form
{
    public partial class LoginForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        private readonly PetugasDal _petugasDal;
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            _pelangganDal = new PelangganDal();
            _petugasDal = new PetugasDal();

            CustomPanel(panel1);
            RegisterControlEvent();
        }

        private void CustomPanel(Panel panel)
        {
            int cornerRadius = 20;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }

        private void RegisterControlEvent()
        {
            LinkDaftar.Click += LinkRegistrasi_Click;
            ButtonMasuk.Click += ButtonMasuk_Click;
        }

        private void ButtonMasuk_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextEmail.Text) || string.IsNullOrWhiteSpace(TextPassword.Text))
            {
                MessageBox.Show("Data tidak boleh kosong !", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            int idPelanggan = _pelangganDal.ValidasiLoginPelanggan(TextEmail.Text.Trim(), TextPassword.Text.Trim());
            int idPetugas = _petugasDal.ValidasiLoginPetugas(TextEmail.Text.Trim(), TextPassword.Text.Trim());

            if (idPelanggan == 0 && idPetugas == 0)
            {
                MessageBox.Show("Username atau password yang Anda masukkan salah. Silakan coba lagi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearForm();
                TextEmail.Focus();
                return;
            }

            new Dashboard(this).Show();


        }

        private void ClearForm()
        {
            TextEmail.Clear();
            TextPassword.Clear();
        }

        private void LinkRegistrasi_Click(object? sender, EventArgs e)
        {
            new RegisterForm(this).Show();
            this.Hide();
        }
    }
}
