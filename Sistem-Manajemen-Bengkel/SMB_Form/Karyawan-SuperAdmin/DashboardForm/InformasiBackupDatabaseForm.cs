using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;

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
            if (MesboxHelper.ShowConfirm("Apakah anda yakin ingin merestore database ?"))
            {
                BackupDatabaseDal backupDatabaseDal = new BackupDatabaseDal();
                backupDatabaseDal.RestoreDatabase();
            }
        }

        private void ButtonBackupDatabase_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Apakah anda yakin ingin membackup database ?"))
            {
                BackupDatabaseDal backupDatabaseDal = new BackupDatabaseDal();
                backupDatabaseDal.BackupDatabase();
            }
        }

        private void ButtonClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
