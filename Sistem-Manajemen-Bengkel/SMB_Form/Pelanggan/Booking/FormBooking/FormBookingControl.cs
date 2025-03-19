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
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.WinForms.DataGrid.Events;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking.FormBooking
{
    public partial class FormBookingControl : UserControl
    {
        private readonly KendaraanDal _kendaraanDal;
        private readonly BookingDal _bookingDal;
        private string _no_ktp;
        private int _id_kendaraan;

        public FormBookingControl()
        {
            InitializeComponent();
            _kendaraanDal = new KendaraanDal();
            _bookingDal = new BookingDal();

            PickerBookingTanggal.Culture = new System.Globalization.CultureInfo("id-ID");
            PickerBookingTanggal.MinDateTime = DateTime.Today;

            _no_ktp = SessionLoginHelper._sessionLoginPelanggan.no_ktp_pelanggan;

           
            InitialDataKendaraan();

            RegisterControlEvent();
        }

        private void GetData(int id_kendaraan)
        {
            var data = _kendaraanDal.GetData(id_kendaraan);

            if (data == null) return;

            TextMerekBooking.Text = data.merek;
            TextTransmisiBooking.Text = data.transmisi == 1 ? "Otomatis" : "Manual";
            TextKapasitasMesinBooking.Text = $"{data.kapasitas_mesin} cc";
            TextTahunBooking.Text = data.tahun.ToString();

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
                MesboxHelper.ShowInfo($"Mohon Maaf \nKuota booking pada \"{tanggal.ToString("dddd, dd-MM-yyyy", new System.Globalization.CultureInfo("id-ID"))}\" sudah penuh. \nSilahkan pilih hari lain");
                return;
            }

            AntreanForm antreanForm = new AntreanForm(booking.AntreanBaru, booking.AntreanDikerjakan);
            if (antreanForm.ShowDialog() == DialogResult.OK)
            {
                SaveData(booking.AntreanBaru);
                ClearFormBooking();
                MainMenuFirst.ShowUserControlInPanel(new PilihBookingControl());
            }
        }


        private void SaveData(int antrean)
        {
            var booking = new BookingModel
            {
                no_ktp_pelanggan = _no_ktp,
                id_kendaraan = (int)ComboKendaraan.SelectedValue,
                id_jasa_servis = null,
                tanggal = PickerBookingTanggal.Value ?? DateTime.Now,
                keluhan = TextKeluhanBooking.Text.Trim(),
                antrean = antrean,
                status = 1
            };

            _bookingDal.InsertData(booking);
        }

        private void ClearFormBooking()
        {
            ComboKendaraan.SelectedIndex = 0;
            TextKeluhanBooking.Clear();
            PickerBookingTanggal.Value = DateTime.Today;
            this.Dispose();  
        }




        private void RegisterControlEvent()
        {
            ButtonCekKetersediaan.Click += ButtonCekKetersediaan_Click;
            ComboKendaraan.SelectedValueChanged += ComboKendaraan_SelectedValueChanged;
            ButtonTambahKendaraan.Click += ButtonTambahKendaraan_Click;
        }

        private void ButtonTambahKendaraan_Click(object? sender, EventArgs e)
        {
            EditInputKendaraanForm editInputKendaraanForm = new EditInputKendaraanForm(0);

            if (editInputKendaraanForm.ShowDialog() == DialogResult.OK)
            {
                InitialDataKendaraan();
            }
        }

        private void ComboKendaraan_SelectedValueChanged(object? sender, EventArgs e)
        {
            int id = (int)ComboKendaraan.SelectedValue;

            if (id == 0) return;

            GetData(id);
        }

        private void ButtonCekKetersediaan_Click(object? sender, EventArgs e)
        {
            if (ComboKendaraan.SelectedIndex == 0 || string.IsNullOrEmpty(TextKeluhanBooking.Text))
            {
                MesboxHelper.ShowWarning("Mohon lengkapi semua data yang dibutuhkan");
                return;
            }

            DateTime date = (DateTime)PickerBookingTanggal.Value;
            CekKetersediaan(date);
        }
    }
}
