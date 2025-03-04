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

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.DashboardForm
{
    public partial class ProfilBengkelForm : Form
    {
        private readonly InformasiBengkelDal _informasiBengkelDal;
        public ProfilBengkelForm()
        {
            InitializeComponent();
            _informasiBengkelDal = new InformasiBengkelDal();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            GetData();

            RegisterControlEvent();
        }

        private void GetData()
        {
            var data = _informasiBengkelDal.GetData();
            if (data == null) return;

            TextNamaBengkel.Text = data.nama_bengkel;
            TextAlamatBengkel.Text = data.alamat;
            TextEmail.Text = data.email;
            TextNoTelepon.Text = data.no_telp;
        }

        public void SaveData()
        {
            var data = new InformasiBengkelDal.InformasiBengkelModel
            {
                nama_bengkel = TextNamaBengkel.Text,
                alamat = TextAlamatBengkel.Text,
                email = TextEmail.Text,
                no_telp = TextNoTelepon.Text
            };
            _informasiBengkelDal.UpdateData(data);
        }

        private void RegisterControlEvent()
        {
            ButtonSimpan.Click += ButtonSimpan_Click;
            ButtonBatal.Click += ButtonBatal_Click;
            TextNoTelepon.KeyPress += TextNoTelepon_KeyPress;
        }

        private void TextNoTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextNamaBengkel.Text) || string.IsNullOrEmpty(TextAlamatBengkel.Text) || string.IsNullOrEmpty(TextEmail.Text) || string.IsNullOrEmpty(TextNoTelepon.Text))
            {
                MesboxHelper.ShowWarning("Data tidak boleh kosong");
                return;
            }

            SaveData();
            this.Close();
        }
    }
}
