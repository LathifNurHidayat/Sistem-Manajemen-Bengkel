using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class KendaraanDal
    {
        public IEnumerable<KendaraanModel> ListData(string filter, object Dp)
        {
            string sql = @$"SELECT 
                                aa.id_kendaraan, aa.no_ktp_pelanggan, bb.nama_pelanggan, aa.no_polisi, 
                                aa.merek, aa.transmisi, aa.kapasitas_mesin, aa.tahun
                            FROM 
                                tb_kendaraan aa
                            LEFT JOIN tb_pelanggan bb ON aa.no_ktp_pelanggan = bb.no_ktp_pelanggan
                            WHERE
                                aa.deleted_at IS NULL 
                                {filter}
                            ORDER BY
                                aa.created_at ASC
                            OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<KendaraanModel>(sql, Dp);
        }

        public IEnumerable<KendaraanModel> LoadNamaKendaraan(string no_ktp_pelanggan)
        {
            string sql = "SELECT id_kendaraan, merek, kapasitas_mesin FROM tb_kendaraan WHERE no_ktp_pelanggan = @no_ktp_pelanggan";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<KendaraanModel>(sql, new { no_ktp_pelanggan });
        }

        public List<int> ListTahun()
        {
            const string sql = @"SELECT DISTINCT tahun FROM tb_kendaraan ORDER BY tahun DESC";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<int>(sql).AsList();
        }

        public KendaraanModel? GetData(int id_kendaraan)
        {
            const string sql = @"SELECT 
                                    aa.id_kendaraan, aa.no_ktp_pelanggan, bb.nama_pelanggan, aa.no_polisi, 
                                    aa.merek, aa.transmisi, aa.kapasitas_mesin, aa.tahun                                
                                FROM 
                                    tb_kendaraan aa
                                LEFT JOIN tb_pelanggan bb ON aa.no_ktp_pelanggan = bb.no_ktp_pelanggan
                                WHERE 
                                    aa.id_kendaraan = @id_kendaraan";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<KendaraanModel>(sql, new { id_kendaraan});
        }

        public void InsertData(KendaraanModel kendaraan)
        {
            const string sql = @"INSERT INTO tb_kendaraan 
                                    (no_ktp_pelanggan, no_polisi, merek, transmisi, kapasitas_mesin, tahun)
                                 VALUES 
                                    (@no_ktp_pelanggan, @no_polisi, @merek, @transmisi, @kapasitas_mesin, @tahun)";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@no_ktp_pelanggan", kendaraan.no_ktp_pelanggan);
            Dp.Add("@no_polisi", kendaraan.no_polisi);
            Dp.Add("@merek", kendaraan.merek);
            Dp.Add("@transmisi", kendaraan.transmisi);
            Dp.Add("@kapasitas_mesin", kendaraan.kapasitas_mesin);
            Dp.Add("@tahun", kendaraan.tahun);

            conn.Execute(sql, Dp);
        }

        public void UpdateData(KendaraanModel kendaraan)
        {
            string sql = @$"UPDATE tb_kendaraan SET
                                no_ktp_pelanggan = @no_ktp_pelanggan,
                                no_polisi = @no_polisi,
                                merek = @merek,
                                transmisi = @transmisi,
                                kapasitas_mesin = @kapasitas_mesin,
                                tahun = @tahun,
                                updated_at = GETDATE()
                            WHERE id_kendaraan = @id_kendaraan";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@no_ktp_pelanggan", kendaraan.no_ktp_pelanggan);
            Dp.Add("@no_polisi", kendaraan.no_polisi);
            Dp.Add("@merek", kendaraan.merek);
            Dp.Add("@transmisi", kendaraan.transmisi);
            Dp.Add("@kapasitas_mesin", kendaraan.kapasitas_mesin);
            Dp.Add("@tahun", kendaraan.tahun);
            Dp.Add("@id_kendaraan", kendaraan.id_kendaraan);

            Conn.Execute(sql, Dp);
        }

        public void SoftDeleteData(int id_kendaraan)
        {
            const string sql = @"UPDATE tb_kendaraan SET
                                    deleted_at = GETDATE()
                                WHERE id_kendaraan = @id_kendaraan";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { id_kendaraan });
        }

/*        public void RestoreData(string no_ktp_pegawai)
        {
            const string sql = @"UPDATE tb_pegawai SET
                                    deleted_at = NULL
                                WHERE no_ktp_pegawai = @no_ktp_pegawai";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { no_ktp_pegawai = no_ktp_pegawai });
        }*/

        public void DeletePermanent(int id_kendaraan)
        {
            const string sql = "DELETE FROM tb_kendaraan WHERE id_kendaraan = @id_kendaraan";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { id_kendaraan });
        }

        public int CountData(string filter, DynamicParameters dp)
        {
            string sql = @$"SELECT COUNT(*) 
                                FROM tb_kendaraan 
                            WHERE deleted_at IS NULL 
                                {filter}";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.ExecuteScalar<int>(sql, dp);
        }

    }
}
