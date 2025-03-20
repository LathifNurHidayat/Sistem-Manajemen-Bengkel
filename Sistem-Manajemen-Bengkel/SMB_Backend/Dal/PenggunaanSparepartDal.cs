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
    public class PenggunaanSparepartDal
    {
        public IEnumerable<PenggunaanSparepartModel> GetData(int id_penggunaan_sparepart)
        {
            const string sql = @"SELECT aa.id_penggunaan_sparepart, aa.id_sparepart, bb.nama_sparepart, bb.stok, aa.jumlah, aa.harga AS total_harga, bb.harga 
                                FROM tb_penggunaan_sparepart aa
                                LEFT JOIN tb_sparepart bb ON aa.id_sparepart = bb.id_sparepart
                                WHERE aa.id_penggunaan_sparepart = @id_penggunaan_sparepart";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return Conn.Query<PenggunaanSparepartModel>(sql, new { id_penggunaan_sparepart });
        }

        public PenggunaanSparepartModel? GetSparepart(int id_penggunaan_sparepart)
        {
            const string sql = @"SELECT 
                                    aa.id_penggunaan_sparepart, 
                                    STRING_AGG(bb.nama_sparepart, ', ') AS nama_sparepart
                                FROM 
                                    tb_penggunaan_sparepart aa
                                LEFT JOIN tb_sparepart bb
                                    ON aa.id_sparepart = bb.id_sparepart
                                WHERE aa.id_penggunaan_sparepart = @id_penggunaan_sparepart
                                GROUP BY aa.id_penggunaan_sparepart;";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return Conn.QueryFirstOrDefault<PenggunaanSparepartModel>(sql, new { id_penggunaan_sparepart});
        }

        public void DeleteData(int id_penggunaan_sparepart)
        {
            const string sql = "DELETE FROM tb_penggunaan_sparepart WHERE id_penggunaan_sparepart = @id_penggunaan_sparepart";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());

            Conn.Execute(sql, new { id_penggunaan_sparepart });
        }

        public void InsertData(PenggunaanSparepartModel sparepartModel)
        {
            const string sql = @"
                                INSERT INTO tb_penggunaan_sparepart 
                                    (id_penggunaan_sparepart, id_sparepart, jumlah, harga)
                                VALUES 
                                    (@id_penggunaan_sparepart, @id_sparepart, @jumlah, @harga)";

            using var conn = new SqlConnection(ConnStringHelper.GetConnByUserID());

            var Dp = new DynamicParameters();
            Dp.Add("@id_penggunaan_sparepart", sparepartModel.id_penggunaan_sparepart);
            Dp.Add("@id_sparepart", sparepartModel.id_sparepart);
            Dp.Add("@jumlah", sparepartModel.jumlah);
            Dp.Add("@harga", sparepartModel.total_harga);

            conn.Execute(sql, Dp);
        }

    }
}
