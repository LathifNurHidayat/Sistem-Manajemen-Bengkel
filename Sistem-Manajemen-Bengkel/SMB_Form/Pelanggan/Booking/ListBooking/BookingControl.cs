using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal.SessionLogin;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking
{
    public partial class BookingControl : UserControl
    {
        private readonly BookingDal _bookingDal;
        public BookingControl()
        {
            InitializeComponent();
            _bookingDal = new BookingDal();

            InitializeFlowPanel();
            LoadData();
        }

        private void InitializeFlowPanel()
        {
            FlowPanelMain.FlowDirection = FlowDirection.TopDown;
            FlowPanelMain.WrapContents = false;
            FlowPanelMain.AutoScroll = true;
        }

        private void LoadData()
        {
            FlowPanelMain.Controls.Clear(); // Bersihkan panel sebelum mengisi ulang

            var bookingList = _bookingDal.ListDataByNoKtp(SessionLogin._sessionLoginPelanggan.no_ktp_pelanggan);

            if (bookingList?.Any() ?? false)
            {
                foreach (var booking in bookingList)
                {
                    var listBooking = new ListBookingControl(booking.id_booking)
                    {
                        Width = FlowPanelMain.Width
                    };
                    FlowPanelMain.Controls.Add(listBooking);
                }
            }
        }
    }
}
