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
        private readonly PelangganDal _pelangganDal;
        private readonly BookingDal _bookingDal;
        private string _no_ktp;
        private int _id_kendaraan;

        public FormBookingControl()
        {
            InitializeComponent();
            _kendaraanDal = new KendaraanDal();
            _pelangganDal = new PelangganDal();
            _bookingDal = new BookingDal();

            PickerBookingTanggal.Culture = new System.Globalization.CultureInfo("id-ID");
            PickerBookingTanggal.MinDateTime = DateTime.Today;

            _no_ktp = SessionLoginHelper._sessionLoginPelanggan.no_ktp_pelanggan;
            GetDataPelanggan();
           
            InitialDataKendaraan();

            RegisterControlEvent();
        }

        private void GetDataPelanggan()
        {
            var pelanggan = _pelangganDal.GetData(_no_ktp);
            
            if (pelanggan == null) return;
            TextNomorKTP.Text = pelanggan.no_ktp_pelanggan;
            TextNama.Text = pelanggan.nama_pelanggan;
            TextAlamat.Text = pelanggan.alamat;
            TextTelepon.Text = pelanggan.no_hp;
        }

        private void GetData(int id_kendaraan)
        {
            var data = _kendaraanDal.GetData(id_kendaraan);

            if (data == null) return;

            TextMerek.Text = data.merek;
            TextTransmisi.Text = data.transmisi == 1 ? "Otomatis" : "Manual";
            TextKapasitasMesin.Text = $"{data.kapasitas_mesin} cc";
            TextTahun.Text = data.tahun.ToString();
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
            PanelMain.Resize += PanelMain_Resize;
            ButtonKembali.Click += ButtonKembali_Click;
        }

        private void ButtonKembali_Click(object? sender, EventArgs e)
        {
            MainMenuFirst.ShowUserControlInPanel(new PilihBookingControl());
        }

        private void PanelMain_Resize(object? sender, EventArgs e)
        {
            int widthPanelMain = PanelMain.Width;
            int jarakAntarPanel = 30;
            int widthPerPanel = (widthPanelMain - (30 * 4)) / 3;
            int jarakDenganTop = 140;

            PanelDataPribadi.Width = widthPerPanel;
            PanelDataKendaraan.Width = widthPerPanel;
            PanelBookingServis.Width = widthPerPanel;

            PanelDataPribadi.Location = new Point(jarakAntarPanel, jarakDenganTop);
            PanelDataKendaraan.Location = new Point((jarakAntarPanel * 2) + widthPerPanel, jarakDenganTop);
            PanelBookingServis.Location = new Point((jarakAntarPanel * 3) + widthPerPanel * 2, jarakDenganTop);
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
