using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PegawaiForm
{
    public partial class RestorePegawaiForm : Form
    {
        private readonly PegawaiDal _pegawaiDal;
        private string _noKTP;

        public RestorePegawaiForm( string no_ktp)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _pegawaiDal = new PegawaiDal();
            _noKTP = no_ktp;
            GetData(no_ktp);

            ButtonRestore.Click += ButtonRestore_Click;
        }

        private void ButtonRestore_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Anda yakin ingin memulihkan data ?"))
            {
                _pegawaiDal.RestoreData(_noKTP);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void GetData(string no_ktp_pegawai)
        {
            var pegawai = _pegawaiDal.GetData(no_ktp_pegawai);
            if (pegawai == null) return;

            PictureProfiles.Image = ImageHelper.ByteToImage(pegawai.image_data) != null ?
                                    ImageHelper.ByteToImage(pegawai.image_data) :
                                    ImageDirectoryHelper._defaultProfilesOnGrid;
            LabelNoKTP.Text = $": {pegawai.no_ktp_pegawai}";
            LabelNama.Text = $": {pegawai.nama_pegawai}";
            LabelNoHP.Text = $": {pegawai.no_hp}";
            LabelAlamat.Text = $": {pegawai.alamat}";
            LabelEmail.Text = $": {pegawai.email}";
        }
    }
}
