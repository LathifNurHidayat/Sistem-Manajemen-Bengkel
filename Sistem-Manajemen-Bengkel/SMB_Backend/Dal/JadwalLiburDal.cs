using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class JadwalLiburDal
    {
        public void UpdateDataDefault(string hari, int is_libur)
        {
            const string sql = @"
                UPDATE tb_jadwal_libur 
                    SET is_libur = @is_libur
                    WHERE hari = @hari";

                using var conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
                conn.Execute(sql, new { hari, is_libur });
        }

        public IEnumerable<JadwalLiburModel> ListData()
        {
            const string sql = @"SELECT id_jadwal_libur, tanggal_libur, hari, is_libur FROM tb_jadwal_libur";

            using var conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return conn.Query<JadwalLiburModel>(sql);
        }

        public void DeleteData(int id_jadwal_libur)
        {
            const string sql = @"
                DELETE FROM tb_jadwal_libur 
                WHERE id_jadwal_libur = @id_jadwal_libur";

            using var conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            conn.Execute(sql, new { id_jadwal_libur });
        }

        public void InsertData(JadwalLiburModel jadwal)
        {
            const string sql = @"
                INSERT INTO tb_jadwal_libur 
                    (tanggal_libur, is_libur)
                VALUES 
                    (@tanggal_libur, @is_libur)";

            using var conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            var dp = new DynamicParameters();
            dp.Add("@tanggal_libur", jadwal.tanggal_libur, DbType.Date);
            dp.Add("@is_libur", jadwal.is_libur, DbType.Int32);

            conn.Execute(sql, dp);
        }
    }
}
