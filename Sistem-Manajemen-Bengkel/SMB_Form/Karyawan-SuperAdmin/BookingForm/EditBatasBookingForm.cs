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
    public partial class EditBatasBookingForm : Form
    {
        private readonly BatasBookingDal _batasBookingDal;
        public EditBatasBookingForm(int batas)
        {
            InitializeComponent();
            _batasBookingDal = new BatasBookingDal();

            TextBatas.Text = batas.ToString();
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            _batasBookingDal.UpdateBatasBooking(Convert.ToInt32(TextBatas.Text));
            this.Close();
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
