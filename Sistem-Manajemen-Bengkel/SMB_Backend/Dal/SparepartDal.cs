using System.Data.SqlClient;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class SparepartDal
    {
        public IEnumerable<SparepartModel> ListData(string filter, object Dp)
        {
            string sql = @$"SELECT 
                                id_sparepart, nama_sparepart, harga, stok, stok_minimal, status_stok, image_data
,                            FROM 
                                tb_sparepart 
                            WHERE
                                deleted_at IS NULL 
                                {filter}
                            ORDER BY
                                created_at ASC
                            OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<SparepartModel>(sql, Dp);
        }

        public SparepartModel? GetData(int id_sparepart)
        {
            const string sql = @"SELECT 
                                    id_sparepart, nama_sparepart, harga, stok, stok_minimal, status_stok, image_data
                                FROM 
                                    tb_sparepart
                                WHERE 
                                    id_sparepart = @id_sparepart";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<SparepartModel>(sql, new { id_sparepart });
        }

        public void InsertData(SparepartModel sparepart)
        {
            const string sql = @"INSERT INTO tb_sparepart
                                    (nama_sparepart, harga, stok, stok_minimal, image_data, status_stok )
                                VALUES 
                                    (@nama_sparepart, @harga, @stok, @stok_minimal, @image_data,
                                CASE 
                                    WHEN @stok = 0 THEN 0
                                    WHEN @stok > 0 AND <= @stok_minimal THEN 1
                                    ELSE 2
                                END)";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@nama_sparepart", sparepart.nama_sparepart);
            Dp.Add("@harga", sparepart.harga);
            Dp.Add("@stok", sparepart.stok);
            Dp.Add("@stok_minimal", sparepart.stok_minimal);
            Dp.Add("@image_data", sparepart.image_data);

            conn.Execute(sql, Dp);
        }

        public void UpdateData(SparepartModel sparepart)
        {
            string sql = @$"UPDATE tb_sparepart SET
                                nama_sparepart = @nama_sparepart,
                                harga = @harga,
                                stok = @stok,
                                stok_minimal = @stok_minimal,
                                image_data = @image_data,
                                status_stok =   CASE 
                                                    WHEN @stok = 0 THEN 0
                                                    WHEN @stok > 0 AND <= @stok_minimal THEN 1
                                                    ELSE 2
                                                END,
                                updated_at = GETDATE()
                            WHERE 
                                id_sparepart = @id_sparepart
";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@id_sparepart", sparepart.id_sparepart);
            Dp.Add("@nama_sparepart", sparepart.nama_sparepart);
            Dp.Add("@harga", sparepart.harga);
            Dp.Add("@stok", sparepart.stok);
            Dp.Add("@stok_minimal", sparepart.stok_minimal);
            Dp.Add("@image_data", sparepart.image_data);

            Conn.Execute(sql, Dp);
        }

        public void SoftDeleteData(int id_sparepart)
        {
            const string sql = @"UPDATE tb_sparepart SET
                                     deleted_at = GETDATE()
                                 WHERE id_sparepart = @id_sparepart";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { id_sparepart });
        }


        public void RestoreData(int id_sparepart)
        {
            const string sql = @"UPDATE tb_sparepart SET
                                     deleted_at = NULL
                                 WHERE id_sparepart = @id_sparepart";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { id_sparepart });
        }

        public void DeletePermanent(string id_sparepart)
        {
            const string sql = "DELETE FROM tb_sparepart WHERE id_sparepart = @id_sparepart";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { id_sparepart });
        }

        public int CountData(string filter, DynamicParameters dp)
        {
            string sql = @$"SELECT COUNT(*) 
                            FROM tb_sparepart
                            WHERE deleted_at IS NULL 
                            {filter}";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.ExecuteScalar<int>(sql, dp);
        }
    }
}
