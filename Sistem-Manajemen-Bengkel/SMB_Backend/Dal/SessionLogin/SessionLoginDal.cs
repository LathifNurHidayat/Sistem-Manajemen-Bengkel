using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal.SessionLogin
{
    public class SessionLoginDal
    {
        public void GetSessionLogin(string no_ktp_pegawai)
        {
            const string sql = @"EXEC sp_set_session_context @key=N'no_ktp_pegawai', @value=@no_ktp_pegawai";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());

            Conn.Execute(sql, new { no_ktp_pegawai });
        }
        
        
        
        public void ClearSessionLogin()
        {
            const string sql = @"EXEC sp_set_session_context @key=N'no_ktp_pegawai', @value=NULL";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());

            Conn.Execute(sql);
        }
    }
}
