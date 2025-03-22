using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class BackupDatabaseDal
    {
        public void BackupDatabase()
        {
            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Sistem-Manajemen-Bengkel");

            if (Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }

            try
            {
                string fullPath = Path.Combine(appDataPath, "Db_Bengkel.bak");
                string sql = $@"BACKUP DATABASE Db_Bengkel TO DISK = '{appDataPath}' WITH FORMAT, 
                                MEDIANAME = 'SQLServerBackup', NAME = 'Full Backup of Db_Bengkel';";
                using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());

                Conn.Execute(sql);

                MesboxHelper.ShowInfo("Backup database berhsil");
            }
            catch(Exception ex)
            {
                MesboxHelper.ShowError("Error " + ex.Message);
            }
        }


        public void RestoreDatabase()
        {
            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Sistem-Manajemen-Bengkel");
            string backupFile = Path.Combine(appDataPath, "Db_Bengkel.bak");

            if (!File.Exists(backupFile))
            {
                MesboxHelper.ShowError("File backup tidak ditemukan!");
                return;
            }

            try
            {
                string sql = $@"ALTER DATABASE Db_Bengkel SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                RESTORE DATABASE Db_Bengkel FROM DISK = '{backupFile}' WITH REPLACE;
                                ALTER DATABASE Db_Bengkel SET MULTI_USER;";

                using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
                Conn.Execute(sql);

                MesboxHelper.ShowInfo("Restore database berhasil!");
            }
            catch (Exception ex)
            {
                MesboxHelper.ShowError("Error saat restore: " + ex.Message);
            }
        }

    }
}
