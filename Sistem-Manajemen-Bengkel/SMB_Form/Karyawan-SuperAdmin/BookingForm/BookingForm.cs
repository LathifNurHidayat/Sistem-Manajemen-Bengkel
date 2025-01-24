using System;
using System.Linq;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Syncfusion.Windows.Forms.Tools;
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
            GridListBooking.DataSource = _userDal.ListUser().Select(x => new
            {
                UserId = x.id_user,
                Username = x.username,
                Password = x.password,
                Role = x.role,
            });

            GridListBooking.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;

            GridListBooking.Columns["UserId"].Width = 50;
            GridListBooking.Columns["Username"].AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            GridListBooking.Columns["Password"].Width = 150;
            GridListBooking.Columns["Role"].Width = 150;


            List<string> d = new List<string>()
            {
                "sdfsd", "sfsfd", "sefsdfs"
            };

        }
    }
}