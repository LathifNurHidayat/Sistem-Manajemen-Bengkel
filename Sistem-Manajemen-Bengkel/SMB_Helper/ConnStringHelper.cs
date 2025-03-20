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

        public static string GetConnBySA()
        {
            return "Server=(local); Database=DB_Bengkel; Integrated Security=True; TrustServerCertificate=True; Connect Timeout=120;";
        }
        


        public static string GetConnByUserID()
        {
            string koneksi =  @"Server=(local); 
                                Database=DB_Bengkel; 
                                User ID =Lathif98;
                                Password=Lathif_123;
                                Encrypt=True;
                                Integrated Security=True; 
                                TrustServerCertificate=True; 
                                Connect Timeout=30";
            return koneksi;
        }

        public static string? GetConnByOnlineServer()
        {
            string koneksi =  @"Server=103.100.27.44; 
                                Database=DB_Bengkel; 
                                User ID=sa; 
                                Password=jfe2025!; 
                                Encrypt=True; 
                                TrustServerCertificate=True;";

            try
            {
                using var Conn = new SqlConnection(koneksi);
                Conn.Open();
                return koneksi;
            }
            catch
            {
                return null;
            }
        }

    }
}