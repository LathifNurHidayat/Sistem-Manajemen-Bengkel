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
    public partial class TamuBookingForm : Form
    {
        private readonly BookingDal _bookingDal;
        public TamuBookingForm()
        {
            InitializeComponent();
            _bookingDal = new BookingDal(); 
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMost = true;
        }
    }
}
