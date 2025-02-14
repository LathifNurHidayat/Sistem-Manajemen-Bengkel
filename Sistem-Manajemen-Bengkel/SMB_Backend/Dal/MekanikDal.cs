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
    public class MekanikDal
    {
        public IEnumerable<MekanikModel> ListData(string filter, object Dp)
        {
            string sql = @$"SELECT * FROM tb_mekanik 
                                WHERE
                                    deleted_at IS NULL 
                                    {filter}
                                ORDER BY
                                    created_at ASC
                                OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<MekanikModel>(sql, Dp);
        }

        public MekanikModel? GetData(string no_ktp_mekanik)
        {
            const string sql = @"SELECT * FROM tb_mekanik WHERE no_ktp_mekanik = @no_ktp_mekanik";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<MekanikModel>(sql, new { no_ktp_mekanik });
        }

        public void InsertData(MekanikModel mekanik)
        {
            const string sql = @"INSERT INTO tb_mekanik 
                            (no_ktp_mekanik, nama_mekanik, no_hp, alamat, spesialis, image_data)
                         VALUES 
                            (@no_ktp_mekanik, @nama_mekanik, @no_hp, @alamat, @spesialis, @image_data)";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@no_ktp_mekanik", mekanik.no_ktp_mekanik);
            Dp.Add("@nama_mekanik", mekanik.nama_mekanik);
            Dp.Add("@no_hp", mekanik.no_hp);
            Dp.Add("@alamat", mekanik.alamat);
            Dp.Add("@spesialis", mekanik.spesialis);
            Dp.Add("@image_data", mekanik.image_data);

            conn.Execute(sql, Dp);
        }

        public void UpdateData(MekanikModel pegawai, string no_ktp)
        {
            string sql = @$"UPDATE tb_mekanik SET
                                no_ktp_mekanik = @no_ktp_mekanik,
                                nama_mekanik = @nama_mekanik,
                                no_hp = @no_hp,
                                alamat = @alamat,
                                spesialis = @spesialis,
                                image_data = @image_data,
                                updated_at = GETDATE()
                            WHERE no_ktp_pegawai = @no_ktp";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@no_ktp_mekanik", pegawai.no_ktp_mekanik);
            Dp.Add("@nama_mekanik", pegawai.nama_mekanik);
            Dp.Add("@no_hp", pegawai.no_hp);
            Dp.Add("@alamat", pegawai.alamat);
            Dp.Add("@spesialis", pegawai.spesialis);
            Dp.Add("@image_data", pegawai.image_data);
            Dp.Add("@no_ktp", no_ktp);

            Conn.Execute(sql, Dp);
        }



        public void SoftDeleteData(string no_ktp_mekanik)
        {
            const string sql = @"UPDATE tb_mekanik SET
                             deleted_at = GETDATE()
                         WHERE no_ktp_mekanik = @no_ktp_mekanik";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { no_ktp_mekanik});
        }


        public void RestoreData(string no_ktp_mekanik)
        {
            const string sql = @"UPDATE tb_mekanik SET
                                    deleted_at = NULL
                                WHERE no_ktp_mekanik = @no_ktp_mekanik";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { no_ktp_mekanik });
        }

        public void DeletePermanent(string no_ktp_mekanik)
        {
            const string sql = "DELETE FROM tb_mekanik WHERE no_ktp_mekanik = @no_ktp_mekanik";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { no_ktp_mekanik });
        }

        public int CountData(string filter, DynamicParameters dp)
        {
            string sql = @$"
                SELECT COUNT(no_ktp_mekanik) 
                FROM tb_mekanik
                WHERE deleted_at IS NULL 
                {filter}";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.ExecuteScalar<int>(sql, dp);
        }
    }
}
