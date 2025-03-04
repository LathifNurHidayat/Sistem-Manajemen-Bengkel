using System;
using System.Collections.Generic;
using System.Data;
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
            using var Conn = new SqlConnection(ConnStringHelper.GetConnSession());
            var Dp = new DynamicParameters();
            Dp.Add("@no_ktp_pegawai", no_ktp_pegawai, DbType.String, ParameterDirection.Input);
            Conn.Execute("prd_GetSessionLogin", Dp, commandType: CommandType.StoredProcedure);
        }

        public void ClearSessionLogin()
        {
            using var Conn = new SqlConnection(ConnStringHelper.GetConnSession());
            Conn.Execute("prd_ClearSessionLogin", commandType: CommandType.StoredProcedure);
        }

    }
}
