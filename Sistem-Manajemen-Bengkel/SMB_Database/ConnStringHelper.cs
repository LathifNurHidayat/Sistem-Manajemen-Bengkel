using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Database
{
    public class ConnStringHelper
    {
        public static string GetConn()
        {
            return "Server=(local); Database=db_bengkel; Integrated Security=True; TrustServerCertificate=True;";
        }
    }
}
