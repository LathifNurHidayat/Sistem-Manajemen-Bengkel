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
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal.SessionLogin;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan
{
    public partial class EditInputKendaraanForm : Form
    {
        private readonly KendaraanDal _kendaraanDal;
        private int _id_kendaraan;

        public EditInputKendaraanForm(int id_kendaraan)
        {
            InitializeComponent();
            _kendaraanDal = new KendaraanDal();
            InitialComponent();
            _id_kendaraan = id_kendaraan;
            GetDataAll(id_kendaraan);
            RegisterControlEvent();
        }

        private void InitialComponent()
        {
            List<string> transmisi = new List<string>() { "Transmisi Otomatis", "Transmisi Manual" };
            ComboTransmisi.DataSource = transmisi;
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
        }

        private void SaveData()
        {
            var kendaraan = new KendaraanModel
            {
                id_kendaraan = _id_kendaraan,
                no_ktp_pelanggan = SessionLogin._sessionLoginPelanggan.no_ktp_pelanggan,
                no_polisi = TextNoPolisi.Text,
                merek = TextMerek.Text,
                transmisi = ComboTransmisi.SelectedValue == "Transmisi Otomatis" ? 1 : 2,
                kapasitas_mesin = Convert.ToInt32(TextKapasitasMesin.Text),
                tahun = Convert.ToInt32(TextTahun.Text)
            };

            if (_id_kendaraan == 0)
                _kendaraanDal.InsertData(kendaraan);
            else
                _kendaraanDal.UpdateData(kendaraan);
        }        

        private void RegisterControlEvent()
        {
            TextKapasitasMesin.KeyPress += TextBox_KeyPress;
            TextTahun.KeyPress += TextBox_KeyPress;
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextNoPolisi.Text) || string.IsNullOrEmpty(TextMerek.Text) || string.IsNullOrEmpty(TextKapasitasMesin.Text) || string.IsNullOrEmpty(TextTahun.Text))
            {
                MesboxHelper.ShowError("Semua data wajib diisi");
                return;
            }
            SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
