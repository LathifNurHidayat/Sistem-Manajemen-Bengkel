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

        public IEnumerable<BatasBookingModel> LoadBatasBooking()
        {
            const string sql = "SELECT id_batas_booking, tanggal, batas_booking FROM tb_batas_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<BatasBookingModel>(sql);
        }

        public void InsertBatasBooking(DateTime tanggal, int batas_booking)
        {
            const string sql = @"INSERT INTO tb_batas_booking 
                                    (tanggal, batas_booking)
                                VALUES 
                                    (tanggal, batas_booking)";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { tanggal, batas_booking });
        }

        public void UpdateBatasBooking(DateTime tanggal, int batas_booking, int id_batas_booking)
        {
            const string sql = @"UPDATE tb_batas_booking SET 
                                    tanggal = @tanggal, 
                                    batas_booking = @batas_booking
                                WHERE 
                                    id_batas_booking = @id_batas_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { tanggal, batas_booking, id_batas_booking });
        }

        public void DeleteBatasBooking(int id_batas_booking)
        {
            const string sql = @"DELETE FROM tb_batas_booking WHERE id_batas_booking = @id_batas_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { id_batas_booking });
        }

        public BatasBookingModel? GetDataBatasBooking (int id_batas_booking)
        {
            const string sql = @"SELECT id_batas_booking , tanggal, batas_booking FROM tb_batas_booking WHERE id_batas_booking = @id_batas_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<BatasBookingModel>(sql, new { id_batas_booking });
        }

    }

    public class BatasBookingModel
    {
        public int id_batas_booking { get; set; }
        public DateTime tanggal { get; set; }
        public int batas_booking { get; set; }
    }
}
