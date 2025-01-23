using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Database;
using System.Data;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class UserDal
    {
        public bool CekUser (UserModel model)
        {
            const string sql = "SELECT COUNT(*) FROM tb_user WHERE username = @username AND password = @password";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            var Dp = new DynamicParameters();

            Dp.Add("@username", model.username, DbType.String);
            Dp.Add("@password", model.password, DbType.String);

            return Conn.QueryFirstOrDefault<bool>(sql, Dp);
        }

        public IEnumerable<UserModel> ListUser ()
        {
            const string sql = "SELECT * FROM tb_user";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());

            return Conn.Query<UserModel>(sql);
        }
    }
}
