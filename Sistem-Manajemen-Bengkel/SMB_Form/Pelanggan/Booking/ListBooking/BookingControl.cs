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
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking
{
    public partial class BookingControl : UserControl
    {
        private static  BookingDal _bookingDal;
        private static FlowLayoutPanel _flowPanelMain ;
        public BookingControl()
        {
            InitializeComponent();
            _bookingDal = new BookingDal();
            _flowPanelMain = FlowPanelMain;
            InitializeFlowPanel();
        }

        private void InitializeFlowPanel()
        {
            _flowPanelMain.FlowDirection = FlowDirection.TopDown;
            _flowPanelMain.Dock = DockStyle.Fill;
            _flowPanelMain.WrapContents = false;
            _flowPanelMain.AutoScroll = true;
        }

        public static void LoadData()
        {
            _flowPanelMain.Controls.Clear(); // Bersihkan panel sebelum mengisi ulang
              
            var bookingList = _bookingDal.ListDataByNoKtp(SessionLoginHelper._sessionLoginPelanggan.no_ktp_pelanggan);

            if (bookingList?.Any() ?? false)
            {
                foreach (var booking in bookingList)
                {
                    var listBooking = new ListBookingControl(booking.id_booking)
                    {
                        Width = _flowPanelMain.ClientSize.Width,
                    };

                    _flowPanelMain.Controls.Add(listBooking);
                }
            }
        }
    }
}
