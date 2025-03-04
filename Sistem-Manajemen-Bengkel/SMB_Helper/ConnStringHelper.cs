using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.Helper
{
    public class ConnStringHelper 
    {
        public static SqlConnection _sqlConnection = new SqlConnection(GetConnSession());

        public static string GetConn()
        {
            return "Server=(local); Database=DB_Bengkel; User ID=sa; Password=Lathif98; TrustServerCertificate=True; Connect Timeout=120;";
        }


        public static string GetConnSession()
        {
            return "Server=(local); Database=DB_Bengkel; User ID=sa; Password=Lathif98; TrustServerCertificate=True; Connect Timeout=120; Pooling=false";
        }
    }
}