using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class BatasBookingDal
    {
        public int LoadBatasBooking()
        {
            const string sql = "SELECT batas_booking FROM tb_batas_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<int>(sql);
        }

        public void UpdateBatasBooking(int batas_booking)
        {
            const string sql = "UPDATE tb_batas_booking SET batas_booking = @batas_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { batas_booking});
        }
    }
}
