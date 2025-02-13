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
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    public partial class InputPegawai : Form
    {
        private readonly PegawaiDal _pegawaiDal;
        public InputPegawai(string no_ktp_pegawai)
        {
            InitializeComponent();
            _pegawaiDal = new PegawaiDal();

            if (!string.IsNullOrEmpty(no_ktp_pegawai))
                GetData(no_ktp_pegawai);

            RegisterControlEvent();
        }

        private void GetData(string no_ktp_pegawai) 
        {
            var pegawai = _pegawaiDal.GetData(no_ktp_pegawai);
            if (pegawai == null) return;

            PictureProfiles.Image = ImageHelper.ByteToImage(pegawai.image_data);
            TextNamaLengkap.Text = pegawai.nama_pegawai;
            TextNoKTP.Text = pegawai.no_ktp_pegawai;
            TextNoHP.Text = pegawai.no_hp;
            TextEmail.Text = pegawai.email;
            TextPassword.Text = pegawai.password;
            TextConfirmPassword.Text = pegawai.password;
            if (pegawai.role == "Karyawan")
                RadioKaryawan.Checked = true;
            if (pegawai.role == "Super Admin")
                RadioSuperAdmin.Checked = true;
        }

        private void SaveData()
        {
            var pegawai = new PegawaiModel
            {
                image_data = ImageHelper.ImageToByteArray(PictureProfiles.Image),
                no_ktp_pegawai = TextNoKTP.Text,
                no_hp = TextNoHP.Text,
                nama_pegawai=TextNamaLengkap.Text,
                email = TextEmail.Text,
                password = TextConfirmPassword.Text,
            };
            _pegawaiDal.InsertData(pegawai);
        }


        private void RegisterControlEvent()
        {
            ButtonEditProfiles.Click += ButtonEditProfiles_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
        }

        private async void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            await Task.Delay(500);
            TextBox textbox = (TextBox)sender;

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
            string no_hp = TextNomorHP.Text.Trim() != _noHP ? TextNomorHP.Text.Trim() : string.Empty;
            string email = TextEmail.Text.Trim() != _email ? TextEmail.Text.Trim() : string.Empty;

            var cekData = _pelangganDal.ValidasiDaftar(no_ktp, no_hp, email);
            if (cekData == 0)
                return;

            if (cekData == 1)
            {
                RestorePelangganForm restore = new RestorePelangganForm(no_ktp);
                restore.ShowDialog(this);
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

        private void ButtonEditProfiles_Click(object? sender, EventArgs e)
        {
            CropProfilesForm cropProfilesForm = new CropProfilesForm();
            if (cropProfilesForm.ShowDialog(this) == DialogResult.OK)
            {
                PictureProfiles.Image = null;
                PictureProfiles.Image = cropProfilesForm._hasilCrop;
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
