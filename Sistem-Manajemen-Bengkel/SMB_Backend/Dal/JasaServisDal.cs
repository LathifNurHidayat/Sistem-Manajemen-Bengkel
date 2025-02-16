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
    public class JasaServisDal
    {
        public IEnumerable<JasaServisModel> ListData(string filter, string order, object Dp)
        {
            string sql = @$"SELECT 
                                id_jasa_servis, jenis_servis, keterangan, biaya
                            FROM 
                                tb_jasa_servis
                            WHERE
                                deleted_at IS NULL 
                                {filter}
                            ORDER BY 
                                {order}
                            OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<JasaServisModel>(sql, Dp);
        }

        public JasaServisModel? GetData(int id_jasa_servis)
        {
            const string sql = @"SELECT 
                                    id_jasa_servis, jenis_servis, keterangan, biaya
                                FROM 
                                    tb_jasa_servis 
                                WHERE 
                                    id_jasa_servis = @id_jasa_servis";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<JasaServisModel>(sql, new { id_jasa_servis });
        }

        public void InsertData(JasaServisModel jasaServis)
        {
            const string sql = @"INSERT INTO tb_jasa_servis 
                            (jenis_servis, keterangan, biaya)
                         VALUES 
                            (@jenis_servis, @keterangan, @biaya)";
            
            using var conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@jenis_servis", jasaServis.jenis_servis);
            Dp.Add("@keterangan", jasaServis.keterangan);
            Dp.Add("@biaya", jasaServis.biaya);

            conn.Execute(sql, Dp);
        }

        public void UpdateData(JasaServisModel jasaServis)
        {
            string sql = @$"UPDATE tb_jasa_servis SET
                                jenis_servis = @jenis_servis,
                                keterangan = @keterangan,
                                biaya = @biaya,
                                updated_at = GETDATE()
                            WHERE 
                                id_jasa_servis = @id_jasa_servis";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@id_jasa_servis", jasaServis.id_jasa_servis);
            Dp.Add("@jenis_servis", jasaServis.jenis_servis);
            Dp.Add("@keterangan", jasaServis.keterangan);
            Dp.Add("@biaya", jasaServis.biaya);

            Conn.Execute(sql, Dp);
        }

        public void SoftDeleteData(int id_jasa_servis)
        {
            const string sql = @"UPDATE tb_jasa_servis SET
                                    deleted_at = GETDATE()
                                WHERE 
                                    id_jasa_servis = @id_jasa_servis";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { id_jasa_servis });
        }


        public void RestoreData(int id_jasa_servis)
        {
            const string sql = @"UPDATE tb_jasa_servis SET
                                    deleted_at = NULL
                                WHERE id_jasa_servis = @id_jasa_servis";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { id_jasa_servis });
        }

        public void DeletePermanent(int id_jasa_servis)
        {
            const string sql = "DELETE FROM tb_jasa_servis WHERE id_jasa_servis = @id_jasa_servis";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { id_jasa_servis });
        }

        public int CountData(string filter, DynamicParameters dp)
        {
            string sql = @$"
                SELECT COUNT(id_jasa_servis) 
                FROM tb_jasa_servis
                WHERE deleted_at IS NULL 
                {filter}";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.ExecuteScalar<int>(sql, dp);
        }
    }
}
