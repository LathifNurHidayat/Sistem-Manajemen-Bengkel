﻿using System;
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
using Org.BouncyCastle.Tls;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.MainMenuForm;
using Sistem_Manajemen_Bengkel.SMB_Form.LoginRegisterForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.LoginRegisterForm
{
    public partial class LoginForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        private readonly PegawaiDal _petugasDal;

        private bool _isExitApplication = true;

        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.WindowState = FormWindowState.Maximized;

            _pelangganDal = new PelangganDal();
            _petugasDal = new PegawaiDal();

            CustomComponentHelper.CustomPanel(panel1);
            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            LinkDaftar.Click += LinkRegistrasi_Click;
            ButtonMasuk.Click += ButtonMasuk_Click;
            TextPassword.KeyDown += TextPassword_KeyDown;
            ButtonShowHidePassword.Click += ButtonShowHidePassword_Click;
            TextEmail.TextChanged += TextEmail_TextChanged;

            ButtonBack.Click += ButtonBack_Click;
            this.FormClosing += LoginForm_FormClosing;
        }

        private async void TextEmail_TextChanged(object? sender, EventArgs e)
        {
            await Task.Delay(800);

            if (!Regex.IsMatch(TextEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                LabelEmail.Text = "⚠ Masukan email yang valid";
                LabelEmail.Visible = true;
                return;
            }
            else
            {
                LabelEmail.Visible = false;
            }
        }

        private void LoginForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!_isExitApplication) return;

            if (MesboxHelper.ShowConfirm("Apakah anda yakin ingin keluar aplikasi ?"))
                SetupFormHelper._setupForm.Close();
            else
                e.Cancel = true;
        }

        private void ButtonBack_Click(object? sender, EventArgs e)
        {
            _isExitApplication = false;
            MainMenuFirst mainMenu = new MainMenuFirst();
            mainMenu.Show();
            this.Close();
        }

        private void ButtonShowHidePassword_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                bool isVisible = (button.Tag as bool?) ?? false;
                TextPassword.PasswordChar = isVisible ? '•' : '\0';
                button.BackgroundImage = isVisible ? Properties.Resources.HidePassword : Properties.Resources.ShowPassword;
                button.Tag = !isVisible;
            }
        }


        private void TextPassword_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonMasuk.PerformClick();
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


            if (dataPelanggan == null &&dataPetugas == null )
            {
                string pesanError = "Login gagal, masukan username dan password yang valid";

                MesboxHelper.ShowWarning(pesanError);
                TextEmail.Focus();
                return;
            }


            string role = dataPelanggan != null ? "Pelanggan" : dataPetugas?.role == 1 ? "Super Admin" : "Petugas";
            string username = dataPelanggan?.nama_pelanggan != null ? dataPelanggan.nama_pelanggan : dataPetugas?.nama_pegawai ?? "";
            byte[]? profile = null;


            ClearForm();

            if(role == "Pelanggan")
            {
                SessionLoginHelper.GetSessionLoginPelanggan(dataPelanggan.no_ktp_pelanggan, username);

                _isExitApplication = false;
                MainMenuFirst mainMenu = new MainMenuFirst();
                mainMenu.Show();
                this.Close();
            }
            if (role == "Super Admin" || role == "Petugas")
            {
                SessionLoginHelper.GetSessionLoginPegawai(dataPetugas.no_ktp_pegawai, username, role);

                _isExitApplication = false;
                profile = dataPetugas?.image_data ?? null;
                MainMenuForm main = new MainMenuForm(username, role, profile);
                main.Show();
                this.Close();
            }
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