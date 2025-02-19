using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm.InputForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class MainInputForm : Form
    {
        public MainInputForm()
        {
            InitializeComponent();
            RegisterControlEvent();
            ShowFormHelper.SetPanel(PanelMain);
            PelangganToolStripMenuItem.PerformClick();
        }

        private void RegisterControlEvent()
        {
            PelangganToolStripMenuItem.Click += PelangganToolStripMenuItem_Click;
            TamuToolStripMenuItem.Click += TamuToolStripMenuItem_Click;
        }

        private void TamuToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new TamuBookingForm());
        }

        private void PelangganToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new PelangganBookingForm());
        }
    }
}
