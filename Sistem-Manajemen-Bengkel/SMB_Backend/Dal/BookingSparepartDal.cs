using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Dapper;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class BookingSparepartDal
    {
        public IEnumerable<BookingSparepartModel> GetData(int id_booking_sparepart)
        {
            const string sql = @"SELECT aa.id_booking_sparepart, aa.id_sparepart, bb.nama_sparepart, bb.stok, aa.jumlah, aa.harga AS total_harga, bb.harga 
                                FROM tb_booking_sparepart aa
                                LEFT JOIN tb_sparepart bb ON aa.id_sparepart = bb.id_sparepart
                                WHERE aa.id_booking_sparepart = @id_booking_sparepart";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<BookingSparepartModel>(sql, new { id_booking_sparepart });
        }

        public void DeleteData(int id_booking_sparepart)
        {
            const string sql = "DELETE FROM tb_booking_sparepart WHERE id_booking_sparepart = @id_booking_sparepart";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());

            Conn.Execute(sql, new { id_booking_sparepart });
        }

        public void InsertData(BookingSparepartModel sparepartModel)
        {
            const string sql = @"
                                INSERT INTO tb_booking_sparepart 
                                    (id_booking_sparepart, id_sparepart, jumlah, harga)
                                VALUES 
                                    (@id_booking_sparepart, @id_sparepart, @jumlah, @harga)";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@id_booking_sparepart", sparepartModel.id_booking_sparepart);
            Dp.Add("@id_sparepart", sparepartModel.id_sparepart);
            Dp.Add("@jumlah", sparepartModel.jumlah);
            Dp.Add("@harga", sparepartModel.total_harga);

            conn.Execute(sql, Dp);
        }

    }
}
