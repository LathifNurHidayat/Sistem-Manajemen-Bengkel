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

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class DetailBookingForm : Form
    {
        private readonly BookingDal _bookingDal;
        public DetailBookingForm()
        {
            InitializeComponent();
            _bookingDal = new BookingDal();
        }

        
        private void GetData(int id_booking)
        {
            var data = _bookingDal.GetData(id_booking);
            if (data == null) return;

            LabelIdBooking.Text = data.id_booking.ToString();
            LabelNama.Text = data.nama_pelanggan;
            LabelNoKTP.Text = data.no_ktp_pelanggan;
            LabelNoPol.Text = data.no_polisi;
            LabelKendaraan.Text = data.nama_kendaraan;
            LabelTanggal.Text = data.tanggal.ToString("dd MMMM yyyy");
            LabelKeluhan.Text = data.keluhan;

            ComboMekanik.SelectedValue = string.IsNullOrEmpty(data.no_ktp_mekanik) ? "" : data.no_ktp_mekanik;
            ComboJenisServis.SelectedValue = data.id_jasa_servis ?? 0;
            TextSparepart.Text = 
        }

    } 
}
