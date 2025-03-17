using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking.FormBooking;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking
{
    public partial class PilihBookingControl : UserControl
    {
        public PilihBookingControl()
        {
            InitializeComponent();

            ButtonBookingServis.Click += ButtonBookingServis_Click;
            ButtonDataBooking.Click += ButtonDataBooking_Click;
        }

        private void ButtonDataBooking_Click(object? sender, EventArgs e)
        {
            MainMenuFirst.ShowUserControlInPanel(new BookingControl());
        }

        private void ButtonBookingServis_Click(object? sender, EventArgs e)
        {
            MainMenuFirst.ShowUserControlInPanel(new FormBookingControl());
        }
    }
}
