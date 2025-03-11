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
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.MekanikForm
{
    public partial class RestoreMekanikForm : Form
    {
        private readonly MekanikDal _mekanikDal;
        private string _noKTP;

        public RestoreMekanikForm(string no_ktp)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _mekanikDal = new MekanikDal();
            _noKTP = no_ktp;
            GetData(no_ktp);

            ButtonRestore.Click += ButtonRestore_Click;
        }

        private void GetData(string no_ktp)
        {
            var mekanik = _mekanikDal.GetData(no_ktp);
            if (mekanik == null) return;

            PictureProfiles.Image = ImageHelper.ByteToImage(mekanik.image_data) ?? ImageDirectoryHelper._defaultProfilesMekanik;
            LabelNoKTP.Text = mekanik.no_ktp_mekanik;
            LabelNoHP.Text = $": {mekanik.no_hp}";
            LabelNama.Text = $": {mekanik.nama_mekanik}";
            LabelAlamat.Text =  $": {mekanik.alamat}";
            TextSpesiali.Text =  $": {mekanik.spesialis}";
        }

        private void ButtonRestore_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Anda yakin ingin memulihkan data ?"))
            {
                _mekanikDal.RestoreData(_noKTP);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
