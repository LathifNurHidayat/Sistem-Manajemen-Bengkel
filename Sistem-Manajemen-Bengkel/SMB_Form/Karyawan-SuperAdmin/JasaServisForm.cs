using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.JasaServisForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class JasaServisForm : Form
    {
        public JasaServisForm()
        {
            InitializeComponent();

            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            ButtonBaru.Click += ButtonTambah_Click;
        }

        private void ButtonTambah_Click(object? sender, EventArgs e)
        {
            if (new InputEditJasaServis().ShowDialog(this) == DialogResult.OK)
            {

            }
        }
    }
}
