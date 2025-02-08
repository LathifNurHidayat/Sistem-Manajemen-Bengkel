using System;
using System.Linq;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class BookingForm : Form
    {
        private readonly PelangganDal _userDal;

        public BookingForm()
        {
            InitializeComponent();
            _userDal = new PelangganDal();

            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            ButtonTambah.Click += ButtonTambah_Click;
        }

        private void ButtonTambah_Click(object? sender, EventArgs e)
        {
            if (new InputEditBooking().ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}