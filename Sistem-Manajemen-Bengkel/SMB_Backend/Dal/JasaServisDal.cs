using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Database;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class JasaServisDal
    {
        public IEnumerable<JasaServisModel> ListData()
        {
            const string sql = @"SELECT * FROM jasa_servis";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<JasaServisModel>(sql);
        }

        public JasaServisModel? GetData(int id_jasa_servis)
        {
            const string sql = @"SELECT * FROM jasa_servis WHERE id_jasa_servis = @id_jasa_servis";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<JasaServisModel>(sql, new { id_jasa_servis });
        }

        public void InsertData(JasaServisModel jasaServis)
        {
            const string sql = @"INSERT INTO jasa_servis 
                                    (jenis_servis, keterangan, biaya) 
                                VALUES 
                                    (@jenis_servis, @keterangan, @biaya)";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, jasaServis);
        }

        public void UpdateData(JasaServisModel jasaServis)
        {
            const string sql = @"UPDATE jasa_servis 
                                SET 
                                    jenis_servis = @jenis_servis, 
                                    keterangan = @keterangan, 
                                    biaya = @biaya,
                                    updated_at = GETDATE()      
                                WHERE 
                                    id_jasa_servis = @id_jasa_servis";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, jasaServis);
        }

        public void DeleteData(int id_jasa_servis)
        {
            const string sql = @"DELETE FROM jasa_servis WHERE id_jasa_servis = @id_jasa_servis";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { id_jasa_servis });
        }

    }
}
