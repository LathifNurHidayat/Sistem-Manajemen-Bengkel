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

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    public partial class InputKendaraanForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        private readonly KendaraanDal _kendaraanDal;
        public InputKendaraanForm()
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();
            _kendaraanDal
        }

        private void GetData(string no_ktp)
        {
            var pelanggan = _pelangganDal.GetData(no_ktp);
            if (pelanggan == null) return;

            TextNama.Text = pelanggan.nama_pelanggan;
            TextTelepon.Text = pelanggan.no_hp;
            TextAlamat.Text = pelanggan.alamat;
            TextEmail.Text = pelanggan.email;
        }

        private void SaveData()
        {

        }
    }
}
