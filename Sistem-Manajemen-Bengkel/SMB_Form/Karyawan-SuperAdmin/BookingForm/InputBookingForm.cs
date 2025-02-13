using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    public partial class InputBookingForm : Form
    {
        public InputBookingForm()
        {
            InitializeComponent();
            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            ButtonBack.Click += ButtonBack_Click;
        }

        private void ButtonBack_Click(object? sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm.BookingForm());
        }
    }
}
