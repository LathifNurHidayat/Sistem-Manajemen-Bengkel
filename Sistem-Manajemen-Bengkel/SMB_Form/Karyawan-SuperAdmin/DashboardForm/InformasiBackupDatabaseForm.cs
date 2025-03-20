using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.DashboardForm
{
    public partial class InformasiBackupDatabaseForm : Form
    {
        public InformasiBackupDatabaseForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            ButtonClose.Click += ButtonClose_Click;
            ButtonBackupDatabase.Click += ButtonBackupDatabase_Click;
            ButtonRestoreDatabase.Click += ButtonRestoreDatabase_Click;
        }

        private void ButtonRestoreDatabase_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonBackupDatabase_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
