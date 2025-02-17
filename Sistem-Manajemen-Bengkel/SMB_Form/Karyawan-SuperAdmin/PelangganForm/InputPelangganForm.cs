using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Microsoft.Win32;
using System.Windows.Automation.Text;
using System.Text.RegularExpressions;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm;
using Sistem_Manajemen_Bengkel.Helper;
using Syncfusion.Licensing;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    public partial class InputPelangganForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        private string _noKTP;
        private string _noHP;
        private string _email;
        private bool _isPasswordReset = false;
        private bool _isUserTyping = false;
        private DateTime _lastUserTyping;

        public InputPelangganForm(string no_ktp_pelanggan)
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            if (!string.IsNullOrEmpty(no_ktp_pelanggan))
            {
                GetData(no_ktp_pelanggan);
                LabelJudul.Text = "Update Data Pelanggan";
                LinkReset.Visible = true;
                LabelResetPass.Visible = true;
                BoolReadonlyTextbox(true);
            }

            RegisterControlEvent();
        }

        private void BoolReadonlyTextbox(bool kondisi)
        {
            TextPassword.ReadOnly = kondisi;
            TextConfirmPassword.ReadOnly = kondisi;
            
            if (kondisi)
            {
                panel8.BackColor = TextPassword.BackColor;
                panel9.BackColor = TextPassword.BackColor;
            }
            if (!kondisi)
            {
                panel8.BackColor = TextConfirmPassword.BackColor;
                panel9.BackColor = TextConfirmPassword.BackColor;
            }
        }

        private void GetData(string no_ktp_pelanggan)
        {
            var pelanggan = _pelangganDal.GetData(no_ktp_pelanggan);
            if (pelanggan == null) return;

            TextNoKTP.Text = pelanggan.no_ktp_pelanggan;
            TextNomorHP.Text = pelanggan.no_hp;
            TextNamaLengkap.Text = pelanggan.nama_pelanggan;
            TextAlamat.Text = pelanggan.alamat;
            TextEmail.Text = pelanggan.email;
            TextPassword.Text = pelanggan.password;
            TextConfirmPassword.Text = pelanggan.password;

            _noKTP = TextNoKTP.Text.Trim();
            _noHP = TextNomorHP.Text.Trim();
            _email = TextEmail.Text.Trim();
        }

        private void SaveData()
        {
            var pelanggan = new PelangganModel
            {
                no_ktp_pelanggan = TextNoKTP.Text.Trim(),
                nama_pelanggan = TextNamaLengkap.Text.Trim(),
                no_hp = TextNomorHP.Text.Trim(),
                alamat = TextAlamat.Text.Trim(),
                email = TextEmail.Text.Trim(),
            };


            if (string.IsNullOrEmpty(_noKTP))
            {
                pelanggan.password = HashPasswordHelper.HashPassword(TextConfirmPassword.Text.Trim());
                _pelangganDal.InsertData(pelanggan);
            }
            else
            {
                if (_isPasswordReset == true)
                    pelanggan.password = HashPasswordHelper.HashPassword(TextConfirmPassword.Text.Trim());

                    _pelangganDal.UpdateData(pelanggan, _noKTP, _isPasswordReset);
            }
        }

        private void ValidasiInput(TextBox textbox)
        {
            if (textbox.Tag == "Email")
            {
                if (!Regex.IsMatch(TextEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    LabelEmail.Text = "⚠ Masukan email yang valid";
                    LabelEmail.Visible = true;
                    return;
                }
                else
                {
                    LabelEmail.Visible = false;
                    LabelEmail.Text = "⚠ Email sudah terdaftar";
                }
            }
            else if (textbox.Tag == "NIK")
            {
                if (!Regex.IsMatch(TextNoKTP.Text, @"^[0-9]{16}$"))
                {
                    LabelNIK.Text = "⚠ NIK harus 16 digit";
                    LabelNIK.Visible = true;
                    return;
                }
                else
                {
                    LabelNIK.Visible = false;
                    LabelNIK.Text = "⚠ NIK sudah terdaftar";
                }
            }
            else if (textbox.Tag == "NoHP")
            {
                if (!Regex.IsMatch(TextNomorHP.Text, @"^[0-9]{10,13}$"))
                {
                    LabelNoHP.Text = "⚠ No HP harus 10-13 digit";
                    LabelNoHP.Visible = true;
                    return;
                }
                else
                {
                    LabelNoHP.Text = "⚠ No HP sudah terdaftar";
                    LabelNoHP.Visible = false;
                }
            }
            else if (textbox.Tag == "Password")
            {
                string password = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$";
                if (!Regex.IsMatch(TextPassword.Text, password))
                {
                    LabelPassword.Visible = true;
                    return;
                }
                else
                {
                    LabelPassword.Visible = false;
                }
            }
            else if (textbox.Tag == "ConfirmPassword")
            {
                if (TextConfirmPassword.Text != TextPassword.Text)
                {
                    LabelConfirmPass.Visible = true;
                    return;
                }
                else
                {
                    LabelConfirmPass.Visible = false;
                }
            }

            string no_ktp = TextNoKTP.Text.Trim() != _noKTP ? TextNoKTP.Text.Trim() : string.Empty;
            string no_hp = TextNomorHP.Text.Trim() != _noHP ? TextNomorHP.Text.Trim() : string.Empty;
            string email = TextEmail.Text.Trim() != _email ? TextEmail.Text.Trim() : string.Empty;

            var cekData = _pelangganDal.ValidasiDaftar(no_ktp, no_hp, email);
            if (cekData == 0)
                return;

            if (cekData == 1)
            {
                RestorePelangganForm restore = new RestorePelangganForm(no_ktp);
                if (restore.ShowDialog(this) == DialogResult.OK)
                    this.Close();
            }
            if (cekData == 2)
                LabelNIK.Visible = true;
            else
                LabelNIK.Visible = false;
            if (cekData == 3)
                LabelNoHP.Visible = true;
            else
                LabelNoHP.Visible = false;
            if (cekData == 4)
                LabelEmail.Visible = true;
            else
                LabelEmail.Visible = false;
        }

     
        #region EVENT

        private void RegisterControlEvent()
        {
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;

            TextNoKTP.TextChanged += TextInput_TextChanged;
            TextNomorHP.TextChanged += TextInput_TextChanged;
            TextEmail.TextChanged += TextInput_TextChanged;
            TextEmail.TextChanged += TextInput_TextChanged;
            TextConfirmPassword.TextChanged += TextInput_TextChanged;
            TextPassword.TextChanged += TextInput_TextChanged;
            LinkReset.Click += LinkReset_Click;

            TextNoKTP.KeyPress += TextBox_KeyPress;
            TextNomorHP.KeyPress += TextBox_KeyPress;

        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void LinkReset_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Apakah anda yakin ingin mereset password ?"))
            {
                TextPassword.Clear();
                TextConfirmPassword.Clear();
                _isPasswordReset = true;
                TextPassword.Focus();
                BoolReadonlyTextbox(false);
            }
        }

        private async void TextInput_TextChanged(object? sender, EventArgs e)
        {
            _isUserTyping = true;
            _lastUserTyping = DateTime.Now;

            await Task.Delay(800);

            if ((DateTime.Now - _lastUserTyping).TotalMilliseconds >= 800 && _isUserTyping)
            {
                _isUserTyping = false;
                TextBox textbox = (TextBox)sender;
                if (textbox == null) return;
                ValidasiInput(textbox);
            }
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (LabelNIK.Visible || LabelNoHP.Visible || LabelEmail.Visible || LabelConfirmPass.Visible || LabelPassword.Visible)
            {
                MesboxHelper.ShowWarning("Data yang dimasukan tidak valid");
                return;
            }
            if (string.IsNullOrEmpty(TextNoKTP.Text) || string.IsNullOrEmpty(TextNamaLengkap.Text) || string.IsNullOrEmpty(TextNomorHP.Text) ||
                string.IsNullOrEmpty(TextEmail.Text) || string.IsNullOrEmpty(TextPassword.Text) || string.IsNullOrEmpty(TextConfirmPassword.Text))
                {
                    MesboxHelper.ShowWarning("Harap lengkapi data yang diperlukan");
                    return;
                }
            SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Anda yakin ingin membatalkan perubahan ?"))
                this.Close();
        }
        #endregion
    }
}
