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
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.MekanikForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    public partial class InputMekanikForm : Form
    {
        private readonly MekanikDal _mekanikDal;
        private string _noKTP;
        private string _noHP;
        private bool _isUserTyping = false;
        private DateTime _lastUserTyping;

        public InputMekanikForm(string no_ktp_mekanik)
        {
            InitializeComponent();
            _mekanikDal = new MekanikDal();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            if (!string.IsNullOrEmpty(no_ktp_mekanik))
            {
                GetData(no_ktp_mekanik);
            }

            RegisterControlEvent();
        }

        private void GetData(string no_ktp)
        {
            var mekanik = _mekanikDal.GetData(no_ktp);
            if (mekanik == null) return;

            PictureProfiles.Image = ImageHelper.ByteToImage(mekanik.image_data) == null ? ImageDirectoryHelper._defaultProfilesMekanik : ImageHelper.ByteToImage(mekanik.image_data);
            TextNoKTP.Text = mekanik.no_ktp_mekanik;
            TextNoHP.Text = mekanik.no_hp;
            TextNamaLengkap.Text = mekanik.nama_mekanik;
            TextAlamat.Text = mekanik.alamat;
            TextSpesialis.Text = mekanik.spesialis;

            _noKTP = TextNoKTP.Text.Trim();
            _noHP = TextNoHP.Text.Trim();
        }

        private void SaveData()
        {
            Image image = ImageHelper.GetCircularImage(PictureProfiles.Image == ImageDirectoryHelper._defaultProfilesMekanik ? null : PictureProfiles.Image);

            var mekanik = new MekanikModel
            {
                no_ktp_mekanik = TextNoKTP.Text.Trim(),
                no_hp = TextNoHP.Text.Trim(),
                nama_mekanik = TextNamaLengkap.Text.Trim(),
                alamat = TextAlamat.Text.Trim(),
                spesialis = TextSpesialis.Text.Trim(),
                image_data = ImageHelper.ImageToByteArray(image)
            };

            if (_noKTP == string.Empty)
                _mekanikDal.InsertData(mekanik);
            if (_noKTP != string.Empty)
                _mekanikDal.UpdateData(mekanik,_noKTP);

        }

        private void ValidasiInput(TextBox textbox)
        {
            if (textbox.Tag == "NIK")
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
                    LabelNoHP.Text = "⚠ No. HP harus 10-13 digit";
                    LabelNoHP.Visible = true;
                    return;
                }
                else
                {
                    LabelNoHP.Text = "⚠ No. HP sudah terdaftar";
                    LabelNoHP.Visible = false;
                }
            }

            string no_ktp = TextNoKTP.Text.Trim() != _noKTP ? TextNoKTP.Text.Trim() : string.Empty;
            string no_hp = TextNoHP.Text.Trim() != _noHP ? TextNoHP.Text.Trim() : string.Empty;

            int cekValidasiData = _mekanikDal.ValidasiData(no_ktp, no_hp);
            if (cekValidasiData == 0) return;
            if (cekValidasiData == 1)
            {
                using var restoreMekanik = new RestoreMekanikForm(no_ktp);
                if (restoreMekanik.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }


            if (cekValidasiData == 2)
                LabelNIK.Visible = true;
            else
                LabelNIK.Visible = false;

            if (cekValidasiData == 3)
                LabelNoHP.Visible = true;
            else
                LabelNoHP.Visible = false;
        }

        private void RegisterControlEvent()
        {
            ButtonEditProfiles.Click += ButtonEditProfiles_Click;
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
            TextNoKTP.TextChanged += TextInput_TextChanged;
            TextNoHP.TextChanged += TextInput_TextChanged;
            TextNamaLengkap.TextChanged += TextInput_TextChanged;
            TextSpesialis.TextChanged += TextInput_TextChanged; 
            TextAlamat.TextChanged += TextInput_TextChanged;

            TextNoKTP.KeyPress += TextBox_KeyPress;
            TextNoHP.KeyPress += TextBox_KeyPress;
            
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private async void TextInput_TextChanged(object? sender, EventArgs e)
        {
            _isUserTyping = true;
            _lastUserTyping = DateTime.Now;
            await Task.Delay(800);

            if ((DateTime.Now - _lastUserTyping).Milliseconds  >= 500 && _isUserTyping)
            {
                _isUserTyping = false;
                TextBox textbox = (TextBox)sender;
                if (textbox == null) return;
                ValidasiInput(textbox);
            }
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (LabelNIK.Visible || LabelNoHP.Visible )
            {
                MesboxHelper.ShowWarning("Data yang dimasukan tidak valid");
                return;
            }
            if (string.IsNullOrEmpty(TextNoKTP.Text) || string.IsNullOrEmpty(TextNamaLengkap.Text) || string.IsNullOrEmpty(TextNoHP.Text) ||
                string.IsNullOrEmpty(TextAlamat.Text)|| string.IsNullOrEmpty(TextSpesialis.Text))
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

        private void ButtonEditProfiles_Click(object? sender, EventArgs e)
        {
            CropProfilesFormHelper cropProfilesForm = new CropProfilesFormHelper();
            if (cropProfilesForm.ShowDialog() == DialogResult.OK)
                PictureProfiles.Image = cropProfilesForm._hasilCrop;
        }
    }
}
