using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistem_Manajemen_Bengkel.SMB_Database;
using Dapper;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class PetugasDal
    {
        public int ValidasiLoginPetugas(string email, string password)
        {
            const string sql = "SELECT id_petugas FROM tb_petugas WHERE email = @email AND password = @password";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<int>(sql, new { email, password });
        }
    }
}
