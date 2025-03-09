using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PegawaiForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    public partial class InputPegawaiForm : Form
    {
        private readonly PegawaiDal _pegawaiDal;
        private string _noKTP;
        private string _noHP;
        private string _email;
        private bool _isPasswordReset = false;
        private bool _isUserTyping = false;
        private DateTime _lastUserTyping;

        public InputPegawaiForm(string no_ktp_pegawai)
        {
            InitializeComponent();
            _pegawaiDal = new PegawaiDal();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            if (!string.IsNullOrEmpty(no_ktp_pegawai))
            {
                GetData(no_ktp_pegawai);
                LabelJudul.Text = "Edit Data Pegawai";
                LabelResetPass.Visible = true;
                LinkReset.Visible = true;
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

                ButtonShowHideConfrmPassword.Visible = false;
                ButtonShowHidePassword.Visible = false;
            }
            if (!kondisi)
            {
                panel8.BackColor = TextConfirmPassword.BackColor;
                panel9.BackColor = TextConfirmPassword.BackColor;

                ButtonShowHideConfrmPassword.Visible = true;
                ButtonShowHidePassword.Visible = true;
            }
        }

        private void GetData(string no_ktp_pegawai)
        {
            var pegawai = _pegawaiDal.GetData(no_ktp_pegawai);
            if (pegawai == null) return;

            PictureProfiles.Image = ImageHelper.ByteToImage(pegawai.image_data) == null ? ImageDirectoryHelper._defaultProfiles : ImageHelper.ByteToImage(pegawai.image_data);
            TextNamaLengkap.Text = pegawai.nama_pegawai;
            TextNoKTP.Text = pegawai.no_ktp_pegawai;
            TextNoHP.Text = pegawai.no_hp;
            TextAlamat.Text = pegawai.alamat;
            TextEmail.Text = pegawai.email;
            TextPassword.Text = pegawai.password;
            TextConfirmPassword.Text = pegawai.password;
            if (pegawai.role == 2)
                RadioKaryawan.Checked = true;
            if (pegawai.role == 1)
                RadioSuperAdmin.Checked = true;

            _noKTP = TextNoKTP.Text.Trim();
            _noHP = TextNoHP.Text.Trim();
            _email = TextEmail.Text.Trim();
        }

        private void SaveData()
        {
            Image? image = PictureProfiles.Image == ImageDirectoryHelper._defaultProfiles ? null : ImageHelper.GetCircularImage(PictureProfiles.Image);

            var pegawai = new PegawaiModel
            {
                image_data = ImageHelper.ImageToByteArray(image),
                no_ktp_pegawai = TextNoKTP.Text,
                no_hp = TextNoHP.Text,
                alamat = TextAlamat.Text,
                nama_pegawai = TextNamaLengkap.Text,
                email = TextEmail.Text,
                password = TextConfirmPassword.Text.Trim(),
                role = RadioKaryawan.Checked ? 2 : RadioSuperAdmin.Checked ? 1 : 0
            };

            if (string.IsNullOrEmpty(_noKTP))
            {
                pegawai.password = HashPasswordHelper.HashPassword(TextConfirmPassword.Text.Trim());
                _pegawaiDal.InsertData(pegawai);
            }
            else
            {
                if (_isPasswordReset == true)
                    pegawai.password = HashPasswordHelper.HashPassword(TextConfirmPassword.Text.Trim());

                    _pegawaiDal.UpdateData(pegawai, _noKTP, _isPasswordReset);
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
                    LabelNIK.Text = "⚠ No. KTP harus 16 digit";
                    LabelNIK.Visible = true;
                    return;
                }
                else
                {
                    LabelNIK.Visible = false;
                    LabelNIK.Text = "⚠ No. KTP sudah terdaftar";
                }
            }
            else if (textbox.Tag == "NoHP")
            {
                if (!Regex.IsMatch(TextNoHP.Text, @"^[0-9]{10,13}$"))
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
            string no_hp = TextNoHP.Text.Trim() != _noHP ? TextNoHP.Text.Trim() : string.Empty;
            string email = TextEmail.Text.Trim() != _email ? TextEmail.Text.Trim() : string.Empty;

            var cekData = _pegawaiDal.ValidasiDaftar(no_ktp, no_hp, email);
            if (cekData == 0)
                return;

            if (cekData == 1)
            {
                RestorePegawaiForm restore = new RestorePegawaiForm(no_ktp);
                if (restore.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    return;
                }
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


        private void RegisterControlEvent()
        {
            ButtonEditProfiles.Click += ButtonEditProfiles_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;

            TextNoKTP.TextChanged += TextInput_TextChanged;
            TextNoHP.TextChanged += TextInput_TextChanged;
            TextEmail.TextChanged += TextInput_TextChanged;
            TextEmail.TextChanged += TextInput_TextChanged;
            TextConfirmPassword.TextChanged += TextInput_TextChanged;
            TextPassword.TextChanged += TextInput_TextChanged;
            ButtonBatal.Click += ButtonBatal_Click;
            LinkReset.Click += LinkReset_Click;

            TextNoKTP.KeyPress += TextBox_KeyPress;
            TextNoHP.KeyPress += TextBox_KeyPress;

            ButtonShowHideConfrmPassword.Click += ButtonShowHidePassword_Click;
            ButtonShowHidePassword.Click += ButtonShowHidePassword_Click;
        }

        private void ButtonShowHidePassword_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                int b = button.Name == "ButtonShowHidePassword" ? 1 : 0;

                bool isVisible = (button.Tag as bool?) ?? false;

                if (b == 1) TextPassword.PasswordChar = isVisible ? '•' : '\0';
                if (b == 0) TextConfirmPassword.PasswordChar = isVisible ? '•' : '\0';

                button.BackgroundImage = isVisible ? Properties.Resources.HidePassword : Properties.Resources.ShowPassword;
                button.Tag = !isVisible;
            }
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

        private void ButtonBatal_Click(object? sender, EventArgs e) 
        {
            if (MesboxHelper.ShowConfirm("Anda yakin ingin membatalkan perubahan ?"))
                this.Close();
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


        private async void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (LabelNIK.Visible || LabelNoHP.Visible || LabelEmail.Visible || LabelConfirmPass.Visible || LabelPassword.Visible)
            {
                MesboxHelper.ShowWarning("Data yang dimasukan tidak valid");
                return;
            }
            if (string.IsNullOrEmpty(TextNoKTP.Text) || string.IsNullOrEmpty(TextNamaLengkap.Text) || string.IsNullOrEmpty(TextNoHP.Text) ||
                string.IsNullOrEmpty(TextEmail.Text) || string.IsNullOrEmpty(TextPassword.Text) || string.IsNullOrEmpty(TextConfirmPassword.Text))
            {
                MesboxHelper.ShowWarning("Harap lengkapi data yang diperlukan");
                return;
            }

            SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonEditProfiles_Click(object? sender, EventArgs e)
        {
            CropProfilesFormHelper cropProfilesForm = new CropProfilesFormHelper();
            if (cropProfilesForm.ShowDialog(this) == DialogResult.OK)
            {
                PictureProfiles.Image = null;
                PictureProfiles.Image = cropProfilesForm._hasilCrop;
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
