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

        public int ShowBatasBooking(DateTime tanggal)
        {
            const string sql = @"SELECT 
                                    batas_booking 
                                WHERE
                                    tanggal = COALESCE(
                                                (SELECT tanggal FROM tb_batas_booking WHERE tanggal = @tanggal),
                                                (SELECT tanggal FROM tb_batas_booking WHERE tanggal IS NULL)
                                )";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<int>(sql, new {tanggal});
        }

        public void InsertBatasBooking(BatasBookingModel batas)
        {
            const string sql = @"INSERT INTO tb_batas_booking 
                                    (tanggal, batas_booking)
                                VALUES 
                                    (@tanggal, @batas_booking)";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            
            var Dp = new DynamicParameters();
            Dp.Add("@tanggal", batas.tanggal);
            Dp.Add("@batas_booking", batas.batas_booking);

            Conn.Execute(sql, Dp);
        }

        public void UpdateBatasBooking(BatasBookingModel batas)
        {
            const string sql = @"UPDATE tb_batas_booking SET 
                                    tanggal = @tanggal, 
                                    batas_booking = @batas_booking
                                WHERE 
                                    id_batas_booking = @id_batas_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
          
            var Dp = new DynamicParameters();
            Dp.Add("@id_batas_booking", batas.id_batas_booking);
            Dp.Add("@tanggal", batas.tanggal);
            Dp.Add("@batas_booking", batas.batas_booking);

            Conn.Execute(sql, Dp);
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
        public DateTime? tanggal { get; set; }
        public int batas_booking { get; set; }
    }
}
