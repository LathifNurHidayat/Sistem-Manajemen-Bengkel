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

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.KandaraanForm
{
    public partial class TambahKendaraanForm : Form
    {
        private readonly KendaraanDal _kendaraanDal;
        private string _no_ktp_pelanggan;

        public TambahKendaraanForm(string no_ktp_pelanggan)
        {
            InitializeComponent();
            _kendaraanDal = new KendaraanDal();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            _no_ktp_pelanggan = no_ktp_pelanggan;

            InitialComponent();
            RegisterControlEvent();
        }

        private void InitialComponent()
        {
            List<string> transmisi = new List<string>() { "Transmisi Otomatis", "Transmisi Manual" };
            ComboTransmisi.DataSource = transmisi;
        }

        private void SaveData()
        {
            var kendaraan = new KendaraanModel
            {
                no_ktp_pelanggan = _no_ktp_pelanggan,
                no_polisi = TextNoPolisi.Text,
                merek = TextMerek.Text,
                transmisi = ComboTransmisi.SelectedValue == "Transmisi Otomatis" ? 1 : 2,
                kapasitas_mesin = Convert.ToInt32(TextKapasitasMesin.Text),
                tahun = Convert.ToInt32(TextTahun.Text)
            };
            
            _kendaraanDal.InsertData(kendaraan);
        }

        private void RegisterControlEvent()
        {
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(TextNoPolisi.Text) || string.IsNullOrWhiteSpace(TextMerek.Text) ||
                          string.IsNullOrWhiteSpace(TextKapasitasMesin.Text) || string.IsNullOrWhiteSpace(TextTahun.Text))
            {
                MesboxHelper.ShowWarning("Semua data wajib diisi");
                return;
            }

            SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
