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
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Form.LoginRegister;
using Sistem_Manajemen_Bengkel.SMB_Helper;

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
            this.WindowState = FormWindowState.Maximized;

            _pelangganDal = new PelangganDal();
            _petugasDal = new PetugasDal();

            CustomComponentHelper.CustomPanel(panel1);
            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            LinkDaftar.Click += LinkRegistrasi_Click;
            ButtonMasuk.Click += ButtonMasuk_Click;
            TextEmail.TextChanged += TextEmail_TextChanged;
            TextPassword.KeyDown += TextPassword_KeyDown;
        }

        private void TextPassword_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonMasuk.PerformClick();
        }

        private async void TextEmail_TextChanged(object? sender, EventArgs e)
        {
            await Task.Delay(500);
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
            string email = TextEmail.Text.Trim();
            string password = TextPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MesboxHelper.ShowWarning("Data tidak boleh kosong !");
                return;
            } 
            var dataPelanggan = _pelangganDal.ValidasiLoginPelanggan(email, HashPasswordHelper.HashPassword(password));
            var dataPetugas = _petugasDal.ValidasiLoginPetugas(email, HashPasswordHelper.HashPassword(password));

            if (dataPelanggan == null && dataPetugas == null)
            {
                MesboxHelper.ShowWarning("Username atau password yang Anda masukkan salah. Silakan coba lagi!");    
                ClearForm();
                TextEmail.Focus();
                return;
            }
            string role = dataPelanggan != null ? "Pelanggan" : dataPetugas?.role == "Super Admin" ? "Super Admin" : "Karyawan";
            string username = dataPelanggan?.nama_pelanggan != null ? dataPelanggan.nama_pelanggan : dataPetugas?.nama_petugas ?? "";
            long id = dataPelanggan?.no_ktp != null ? long.Parse(dataPelanggan?.no_ktp) : dataPetugas?.id_petugas ?? 0;

            ClearForm();
            new Dashboard(id, username, role).Show();
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
            ClearForm();
            this.Hide();
        }
    }
}