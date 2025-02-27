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
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.WinForms.Input.Enums;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class PelangganBookingForm : Form
    {

        private readonly BookingDal _bookingDal;
        private readonly PelangganDal _pelangganDal;
        private readonly KendaraanDal _kendaraanDal;
        private string _no_ktp;

        public PelangganBookingForm()
        {
            InitializeComponent();
            _bookingDal = new BookingDal();
            _pelangganDal = new PelangganDal();
            _kendaraanDal = new KendaraanDal();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            new System.Globalization.CultureInfo("id-ID");
            PickerBookingTanggal.MinDateTime = DateTime.Today;

            CustomComponentHelper.CustomPanel(panel1);

            InitialDataKendaraan();
            RegisterControlEvent();
        }

        private void InitialDataKendaraan()
        {
            var data = _kendaraanDal.LoadNamaKendaraan(_no_ktp).Select(x => new
            {
                Id = x.id_kendaraan,
                NamaKendaraan = $"{x.merek} {x.kapasitas_mesin} cc"
            }).ToList();

            data.Insert(0, new { Id = 0, NamaKendaraan = "Pilih Kendaraan" });

            ComboKendaraan.DataSource = data;
            ComboKendaraan.ValueMember = "Id";
            ComboKendaraan.DisplayMember = "NamaKendaraan";
        }

        private void SaveData(int antrean)
        {
            var booking = new BookingModel
            {
                no_ktp_pelanggan = TextNomorKTP.Text.Trim(),
                id_kendaraan = (int)ComboKendaraan.SelectedValue,
                id_jasa_servis = null,
                tanggal = PickerBookingTanggal.Value ?? DateTime.Now,
                keluhan = TextKeluhan.Text.Trim(),
                antrean = antrean,
                status = 1
            };

            _bookingDal.InsertData(booking);
        }

        private void CekKetersediaan(DateTime tanggal)
        {
            var booking = _bookingDal.CekKuotaBooking(tanggal);

            if (booking.AntreanBaru == -1)
            {
                MesboxHelper.ShowInfo($"Mohon Maaf \nKuota booking pada \"{tanggal.ToString("dddd, dd-MM-yyyy", new System.Globalization.CultureInfo("id-ID"))}\" sudah penuh. \n Silahkan pilih hari lain");
                return;
            }

            AntreanForm antreanForm = new AntreanForm(booking.AntreanBaru, booking.AntreanDikerjakan);
            if (antreanForm.ShowDialog()== DialogResult.OK )
            {
                SaveData(booking.AntreanBaru);
                NontifikasiFormHelper nontifikasi = new NontifikasiFormHelper("Booking berhasil");
                nontifikasi.Show();
                ShowFormHelper.ShowFormInPanel(new BookingForm());
            }
        }

        private void ClearKendaraanForm()
        {
            TextMerek.Clear();
            TextTransmisi.Clear();
            TextKapasitasMesin.Clear();
            TextTahun.Clear();
        }

        private void GetDataKendaraan(int id_kendaraan)
        {
            var kendaraan = _kendaraanDal.GetData(id_kendaraan);
            if (kendaraan == null) return;

            TextMerek.Text = kendaraan.merek;
            TextTransmisi.Text = kendaraan.transmisi == 1 ? "Transmisi Otomatis" : "Transmisi Manual";
            TextKapasitasMesin.Text = $"{kendaraan.kapasitas_mesin.ToString()} cc";
            TextTahun.Text = kendaraan.tahun.ToString();
        }

        private void GetDataPelanggan(string no_ktp)
        {
            var pelanggan = _pelangganDal.GetData(no_ktp);
            if (pelanggan == null) return;

            TextNomorKTP.Text = pelanggan.no_ktp_pelanggan;
            TextNama.Text = pelanggan.nama_pelanggan;
            TextTelepon.Text = pelanggan.no_hp;
            TextAlamat.Text = pelanggan.alamat;
        }

        private void RegisterControlEvent()
        {
            ButtonShowPelanggan.Click += ButtonShowPelanggan_Click;
            ButtonTambahKendaraan.Click += ButtonTambahKendaraan_Click;
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonCekKetersediaan.Click += ButtonCekKetersediaan_Click;
            ComboKendaraan.SelectedValueChanged += ComboKendaraan_SelectedValueChanged;
        }

        private void ComboKendaraan_SelectedValueChanged(object? sender, EventArgs e)
        {
            int value = Convert.ToInt32(ComboKendaraan.SelectedValue);
            if (value == 0)
            {
                ClearKendaraanForm();
                return;
            }

            GetDataKendaraan(value);
        }

        private void ButtonCekKetersediaan_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextNomorKTP.Text) || ComboKendaraan.SelectedIndex == 0 || string.IsNullOrEmpty(TextKeluhan.Text))
            {
                MesboxHelper.ShowWarning("Mohon lengkapi semua data yang dibutuhkan");
                return;
            }

            DateTime date = DateTime.Today;
            CekKetersediaan(date);
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new BookingForm());
        }

        private void ButtonTambahKendaraan_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_no_ktp))
            {
                MesboxHelper.ShowWarning("Masukan data pelanggan terlebih dahulu!");
                return;
            }

            TambahKendaraanForm tambahKendaraanForm = new TambahKendaraanForm(_no_ktp);
            if (tambahKendaraanForm.ShowDialog() == DialogResult.OK)
            {
                InitialDataKendaraan();
            }
        }

        private void ButtonShowPelanggan_Click(object? sender, EventArgs e)
        {
            DataPelangganFormHelper dataPelangganFormHelper = new DataPelangganFormHelper();
            if (dataPelangganFormHelper.ShowDialog() == DialogResult.OK)
            {
                _no_ktp = dataPelangganFormHelper._no_ktp_pelanggan;
                GetDataPelanggan(_no_ktp);
                InitialDataKendaraan();
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}