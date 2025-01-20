using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            RegisterControlEvent();

        }

        private void RegisterControlEvent()
        {

        }

        private void ShowFormInPanel(Form form)
        {
            if (PanelMain.Controls.Count > 0)
                PanelMain.Controls.RemoveAt(0);

            if (form == null) return;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            PanelMain.Tag = form;
            form.Show();
        }

    }
}