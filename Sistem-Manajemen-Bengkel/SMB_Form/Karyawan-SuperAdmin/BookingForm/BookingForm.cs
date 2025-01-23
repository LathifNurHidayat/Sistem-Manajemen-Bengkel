using System;
using System.Linq;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class BookingForm : Form
    {
        private readonly UserDal _userDal;

        public BookingForm()
        {
            InitializeComponent();

            // Inisialisasi DAL
            _userDal = new UserDal();
            GridListBooking.DataSource = _userDal.ListUser();


        }

    }
}
