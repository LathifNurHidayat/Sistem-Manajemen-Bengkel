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

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking
{
    public partial class ListBookingControl : UserControl
    {
        private readonly BookingDal _bookingDal;
        private int _id_booking;
        private string _no_ktp_pelanggan = SessionLoginHelper._sessionLoginPelanggan.no_ktp_pelanggan;

        public ListBookingControl(int id_booking)
        {
            InitializeComponent();
            _bookingDal = new BookingDal();
            _id_booking = id_booking;

            SetData(id_booking);
            RegisterControlEvent();
        }

        private void SetData(int id_booking)
        {
            var booking = _bookingDal.GetData(id_booking);
            if (booking == null) return;

            LabelNoPolisi.Text = $": {booking.no_polisi ?? "-"}";
            LabelMerek.Text = $": {booking.merek ?? "-"}";
            LabelKapasitasMesin.Text = $": {booking.kapasitas_mesin.ToString() ?? "-"}";
            LabelKeluhan.Text = $": {booking.keluhan ?? "-"}";

            PictureStatus.Image = booking.status == 1 ? ImageDirectoryHelper._statusMenunggu :
                                  booking.status == 2 ? ImageDirectoryHelper._statusDikerjakan :
                                  booking.status == 3 ? ImageDirectoryHelper._statusSelesai :
                                                        ImageDirectoryHelper._statusDibatalkan;

            LabelTanggal.Text = $": {booking.tanggal.ToString("dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID"))}";
            LabelAntrean.Text = booking.antrean.ToString();

            if (booking.status != 1)
                ButtonBatalkanBooking.Visible = false;
        }

        private void RegisterControlEvent()
        {
            ButtonBatalkanBooking.Click += ButtonBatalkanBooking_Click;
        }

        private void ButtonBatalkanBooking_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Apakah anda yakin ingin membatalkan booking ini?"))
            {
                var booking = new BookingModel
                {
                    id_booking = _id_booking,
                    status = 4
                };
                _bookingDal.UpdateData(booking);
                MesboxHelper.ShowInfo("Pembatalan booking berhasil");
                SetData(_id_booking);
            }
        }
    }
}
