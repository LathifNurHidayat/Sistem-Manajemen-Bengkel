using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class InformationPembatalanBookingForm : Form
    {
        public InformationPembatalanBookingForm()
        {
            InitializeComponent();
            ButtonClose.Click += ButtonClose_Click;
        }

        private void ButtonClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
