using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class BookingDal
    {
        public IEnumerable<BookingModel> ListData()
        {
            const string sql = @"SELECT * FROM tb_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<BookingModel>(sql);
        }

        public BookingModel? GetData(int id_booking)
        {
            const string sql = @"SELECT * FROM tb_booking WHERE id_booking = @id_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<BookingModel>(sql, new { id_booking });
        }

        public int InsertData(BookingModel model)
        {
            const string sql = @"INSERT INTO tb_booking 
                                    (no_ktp, username, tanggal, antrean, keluhan, status) 
                                VALUES 
                                    (@no_ktp, @username, @tanggal, @antrean, @keluhan, @status)";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Execute(sql, model);
        }

        public int UpdateData(BookingModel model)
        {
            const string sql = @"UPDATE tb_booking 
                                SET 
                                    no_ktp = @no_ktp, 
                                    username = @username, 
                                    tanggal = @tanggal, 
                                    antrean = @antrean, 
                                    keluhan = @keluhan, 
                                    status = @status 
                                WHERE 
                                    id_booking = @id_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Execute(sql, model);
        }

        public void DeleteData(int id_booking)
        {
            const string sql = @"DELETE FROM tb_booking WHERE id_booking = @id_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { id_booking });
        }
    }
}