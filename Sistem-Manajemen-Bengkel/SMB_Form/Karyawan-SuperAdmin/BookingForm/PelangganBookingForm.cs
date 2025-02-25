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
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class PelangganBookingForm : Form
    {

        private readonly BookingDal _bookingDal;

        public PelangganBookingForm()
        {
            InitializeComponent();
            _bookingDal = new BookingDal();

            new System.Globalization.CultureInfo("id-ID");
            InitialComponent();

            RegisterControlEvent();
        }

        private void InitialComponent()
        {
            PickerBookingTanggal.MinDateTime = DateTime.Today;
        }

        private  void SaveData()
        {
            var booking = new BookingModel
            {
                no_ktp_pelanggan = TextNomorKTP.Text.Trim(),
                id_kendaraan = (int)ComboKendaraan.SelectedValue,
                tanggal = PickerBookingTanggal.Value ?? DateTime.Now,
                keluhan = TextKeluhan.Text.Trim(),
                antrean = 
                status = 1
            };
        }

        private void RegisterControlEvent()
        {
            ButtonShowPelanggan.Click += ButtonShowPelanggan_Click;
            ButtonTambahKendaraan.Click += ButtonTambahKendaraan_Click;
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonCekKetersediaan.Click += ButtonCekKetersediaan_Click;
        }

        private void ButtonCekKetersediaan_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new BookingForm());
        }

        private void ButtonTambahKendaraan_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonShowPelanggan_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
