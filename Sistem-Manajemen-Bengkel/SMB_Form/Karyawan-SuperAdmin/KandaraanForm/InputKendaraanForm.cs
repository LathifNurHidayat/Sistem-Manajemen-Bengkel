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
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.KandaraanForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    public partial class InputKendaraanForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        private readonly KendaraanDal _kendaraanDal;
        private int _idKendaraan;
        private bool _isInputFromBooking = false;
        public string _noKTP { get; set; }

        public InputKendaraanForm(int id_kendaraan)
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();
            _kendaraanDal = new KendaraanDal();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            _idKendaraan = id_kendaraan;

            if (id_kendaraan != 0)
            { 
                GetDataAll(id_kendaraan);
            }

            List<string> transmisi = new List<string>() { "Transmisi Otomatis", "Transmisi Manual"};
            ComboTransmisi.DataSource = transmisi;

            RegisterControlEvent();
        }

        private void GetDataPelanggan(string no_ktp)
        {
            var pelanggan = _pelangganDal.GetData(no_ktp);
            if (pelanggan == null) return;

            TextNomorKTP.Text = pelanggan.no_ktp_pelanggan;
            TextNama.Text = pelanggan.nama_pelanggan;
            TextTelepon.Text = pelanggan.no_hp;
            TextAlamat.Text = pelanggan.alamat;
            TextEmail.Text = pelanggan.email;
        }

        private void GetDataAll(int idKendaraan)
        {
            var kendaraan = _kendaraanDal.GetData(idKendaraan);
            if (kendaraan == null) return;

            TextNoPolisi.Text = kendaraan.no_polisi;
            TextMerek.Text = kendaraan.merek;
            if (kendaraan.transmisi == 1)
                ComboTransmisi.SelectedValue = "Transmisi Otomatis";
            else
                ComboTransmisi.SelectedValue = "Transmisi Manual";
            TextKapasitasMesin.Text = kendaraan.kapasitas_mesin.ToString();
            TextTahun.Text = kendaraan.tahun.ToString();

            GetDataPelanggan(kendaraan.no_ktp_pelanggan);
        }


        private void SaveData()
        {
            var kendaraan = new KendaraanModel
            {
                id_kendaraan = _idKendaraan,
                no_ktp_pelanggan = TextNomorKTP.Text,
                no_polisi = TextNoPolisi.Text,
                merek = TextMerek.Text,
                transmisi = ComboTransmisi.SelectedValue == "Transmisi Otomatis" ? 1 : 2,
                kapasitas_mesin = Convert.ToInt32(TextKapasitasMesin.Text),
                tahun = Convert.ToInt32(TextTahun.Text)
            };

            if (_idKendaraan == 0)
                _kendaraanDal.InsertData(kendaraan);
            else
                _kendaraanDal.UpdateData(kendaraan);
        }

        private void RegisterControlEvent()
        {
            ButtonShowPelanggan.Click += ButtonShowPelanggan_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
            ButtonBatal.Click += ButtonBatal_Click;
            TextKapasitasMesin.KeyPress += TextBox_KeyPress;
            TextTahun.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
 
        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextNomorKTP.Text) || string.IsNullOrWhiteSpace(TextNama.Text) || string.IsNullOrWhiteSpace(TextAlamat.Text) ||
                string.IsNullOrWhiteSpace(TextEmail.Text) || string.IsNullOrWhiteSpace(TextNoPolisi.Text) || string.IsNullOrWhiteSpace(TextMerek.Text) ||
                string.IsNullOrWhiteSpace(TextKapasitasMesin.Text) || string.IsNullOrWhiteSpace(TextTahun.Text))
            {
                MesboxHelper.ShowWarning("Mohon lengkapi semua data yang dibutuhkan");
                return;
            }

            SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonShowPelanggan_Click(object? sender, EventArgs e)
        {
            DataPelangganFormHelper pelangganForm = new DataPelangganFormHelper();
            if (pelangganForm.ShowDialog() == DialogResult.OK)
                GetDataPelanggan(pelangganForm._no_ktp_pelanggan);
        }
    }
}