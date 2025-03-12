using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.WinForms.Controls.Styles;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class TamuBookingForm : Form
    {
        private readonly BookingDal _bookingDal;
        public TamuBookingForm()
        {
            InitializeComponent();
            _bookingDal = new BookingDal(); 
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            InitialComponent();

            RegisterControlEvent();
        }

        private void InitialComponent()
        {
            List<string> transmisi = new List<string>() { "Transmisi Otomatis", "Transmisi Manual" };
            ComboTransmisi.DataSource = transmisi;
        }

        private void CekKetersediaan(DateTime tanggal)
        {
            var validasiOperasionalBengkel = _bookingDal.CekOperasionalBengkel(tanggal);
            if (validasiOperasionalBengkel != "")
            {
                MesboxHelper.ShowInfo(validasiOperasionalBengkel);
                return;
            }

            var booking = _bookingDal.CekKuotaBooking(tanggal);

            if (booking.AntreanBaru == -1)
            {
                MesboxHelper.ShowInfo($"Mohon Maaf \nKuota booking pada \"{tanggal.ToString("dddd, dd-MM-yyyy", new System.Globalization.CultureInfo("id-ID"))}\" sudah penuh. \n Silahkan pilih hari lain");
                return;
            }

            AntreanForm antreanForm = new AntreanForm(booking.AntreanBaru, booking.AntreanDikerjakan);
            if (antreanForm.ShowDialog() == DialogResult.OK)
            {
                SaveData(booking.AntreanBaru);
                NontifikasiFormHelper nontifikasi = new NontifikasiFormHelper("Booking berhasil");
                nontifikasi.Show();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void SaveData(int antrean)
        {
            var booking = new BookingModel
            {
                no_ktp_pelanggan = null,
                id_kendaraan = null,
                id_jasa_servis = null,
                no_hp = "-",

                nama_pelanggan = TextNama.Text.Trim(),
                no_polisi = TextNoPolisi.Text.Trim(),
                merek = TextMerek.Text.Trim(),
                transmisi = (string)ComboTransmisi.SelectedValue == "Transmisi Otomatis" ? 1 : 2,
                kapasitas_mesin = Convert.ToInt32(TextKapasitasMesin.Text),
                tanggal = PickerBookingTanggal.Value ?? DateTime.Now,
                keluhan = TextKeluhan.Text.Trim(),
                antrean = antrean,
                status = 1
            };

            _bookingDal.InsertData(booking);
        }

        private void RegisterControlEvent()
        {
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonCekKetersediaan.Click += ButtonCekKetersediaan_Click;
        }

        private void ButtonCekKetersediaan_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextNama.Text) || string.IsNullOrEmpty(TextNoPolisi.Text) || string.IsNullOrEmpty(TextMerek.Text) || string.IsNullOrEmpty(TextKapasitasMesin.Text) || string.IsNullOrEmpty(TextKeluhan.Text))
            {
                MesboxHelper.ShowWarning("Semua data wajib diisi");
                return;
            }

            DateTime date = (DateTime)PickerBookingTanggal.Value;
            CekKetersediaan(date);

            this.DialogResult = DialogResult.OK;
        }


        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
