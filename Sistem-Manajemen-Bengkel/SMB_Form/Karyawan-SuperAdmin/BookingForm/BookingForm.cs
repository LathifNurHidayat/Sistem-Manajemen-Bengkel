using System;
using System.Linq;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Globalization;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class BookingForm : Form
    {
        private readonly PelangganDal _userDal;
        private Timer _timer;

        public BookingForm()
        {
            InitializeComponent();
            _userDal = new PelangganDal();

            InitialComponent();
            RegisterControlEvent();
        }

        private void InitialComponent()
        {
            LabelHariTanggal.Text = DateTime.Now.ToString("dddd, dd - MM - yyyy", new CultureInfo("id-ID"));

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += (s, e) =>
            {
                LabelJam.Text = DateTime.Now.ToString("HH:mm:ss");
            };
            _timer.Start();
        }

        private void RegisterControlEvent()
        {
            ButtonTambah.Click += ButtonTambah_Click;
        }

        private void ButtonTambah_Click(object? sender, EventArgs e)
        {
           // ShowFormHelper.ShowFormInPanel(new InputBookingForm());
        }
    }
}