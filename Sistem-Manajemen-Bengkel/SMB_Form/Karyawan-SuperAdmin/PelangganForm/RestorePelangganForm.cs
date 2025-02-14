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
using Syncfusion.Windows.Forms.Chart;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm
{
    public partial class RestorePelangganForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        private string _noKTP;
        public RestorePelangganForm(string no_ktp)
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _noKTP = no_ktp;
            GetData(no_ktp);

            ButtonHapus.Click += ButtonHapus_Click;
            ButtonRestore.Click += ButtonRestore_Click;
        }

        private void ButtonRestore_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Anda yakin ingin memulihkan data ?"))
            {
                _pelangganDal.RestoreData(_noKTP);
                MesboxHelper.ShowInfo("Data berhasil dipulihkan");
                ShowFormHelper.ShowFormInPanel(new PelangganForm());
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ButtonHapus_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm(" Anda yakin ingin menghapus data ini secara permanen?"))
            {
                _pelangganDal.DeleteDataPermanent(_noKTP);
                this.Close();
            }
        }

        private void GetData(string no_ktp_pelanggan)
        {
            var pelanggan = _pelangganDal.GetData(no_ktp_pelanggan);
            if (pelanggan == null) return;

            LabelNoKTP.Text = $": {pelanggan.no_ktp_pelanggan}";
            LabelNama.Text = $": {pelanggan.nama_pelanggan}";
            LabelNoHP.Text = $": {pelanggan.no_hp}";
            LabelAlamat.Text = $": {pelanggan.alamat}";
            LabelEmail.Text = $": {pelanggan.email}";
        }

    }
}
