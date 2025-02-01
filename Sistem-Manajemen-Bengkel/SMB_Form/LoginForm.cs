using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            TextEmail.TextChanged += TextEmail_TextChanged;
        }

        private void TextEmail_TextChanged(object? sender, EventArgs e)
        {
            if (!Regex.IsMatch(TextEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                LabelEmail.Visible = true;
                return;
            }
            else
                LabelEmail.Visible = false;
        }

        private void ButtonMasuk_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextEmail.Text) || string.IsNullOrWhiteSpace(TextPassword.Text))
            {
                MessageBox.Show("Data tidak boleh kosong !", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            int idPelanggan = _pelangganDal.ValidasiLoginPelanggan(TextEmail.Text.Trim(), TextPassword.Text.Trim());
            var dataPetugas = _petugasDal.ValidasiLoginPetugas(TextEmail.Text.Trim(), TextPassword.Text.Trim());

            if (idPelanggan == 0 && dataPetugas == null)
            {
                MessageBox.Show("Username atau password yang Anda masukkan salah. Silakan coba lagi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearForm();
                TextEmail.Focus();
                return;
            }
            string role = idPelanggan != 0 ? "Pelanggan" : dataPetugas?.role == "Super Admin" ? "Super Admin" : "Karyawan";
            int id = idPelanggan != 0 ? idPelanggan : dataPetugas?.id_petugas ?? 0;
            new Dashboard(this, id, role).Show();
            this.Hide();
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
