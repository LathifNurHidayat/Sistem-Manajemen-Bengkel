using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            RegisterControlEvent();
            CustomSyncfusion();
        }

        private void CustomSyncfusion()
        {
        }

        private void RegisterControlEvent()
        {
            PanelBooking.Resize += (s, e) => PanelBooking.Invalidate();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }

        private void lathifButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
