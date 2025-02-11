using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.Helper
{
    public class ConnStringHelper
    {
        public static string GetConn()
        {
            return "Server=(local); Database=DB_Bengkel; Integrated Security=True; TrustServerCertificate=True;";
        }
    }
}
