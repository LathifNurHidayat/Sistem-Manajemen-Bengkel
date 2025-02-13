using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class PegawaiDal
    {
        public IEnumerable<PegawaiModel> ListData(string filter, object Dp)
        {
            string sql = @$"SELECT * FROM tb_pegawai 
                                WHERE
                                    deleted_at IS NULL 
                                    {filter}
                                ORDER BY
                                    created_at ASC
                                OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<PegawaiModel>(sql, Dp);
        }

        public PegawaiModel? GetData(string no_ktp_pegawai)
        {
            const string sql = @"SELECT * FROM tb_pegawai WHERE no_ktp_pegawai = @no_ktp_pegawai";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<PegawaiModel>(sql, new { no_ktp_pegawai });
        }

        public void InsertData(PegawaiModel pegawaiModel)
        {
            const string sql = @"INSERT INTO tb_pegawai 
                                    (no_ktp_pegawai, nama_pegawai, email, password, no_hp, alamat, role, image_name, image_data)
                                 VALUES 
                                    (@no_ktp_pegawai, @nama_pegawai, @email, @password, @no_hp, @alamat, @role, @image_name, @image_data)";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, pegawaiModel);
        }

        public void UpdateData(PegawaiModel pegawaiModel)
        {
            const string sql = @"UPDATE tb_pegawai SET
                                    nama_pegawai = @nama_pegawai,
                                    email = @email,
                                    password = @password,
                                    no_hp = @no_hp,
                                    alamat = @alamat,
                                    role = @role,
                                    image_name = @image_name,
                                    image_data = @image_data,
                                    updated_at = GETDATE()
                                WHERE no_ktp_pegawai = @no_ktp_pegawai";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, pegawaiModel);
        }

        public void SoftDeleteData(string no_ktp_pegawai)
        {
            const string sql = @"UPDATE tb_pegawai SET
                                    deleted_at = GETDATE()
                                WHERE no_ktp_pegawai = @no_ktp_pegawai";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, no_ktp_pegawai);
        }

        public void RestoreData(string no_ktp_pegawai)
        {
            const string sql = @"UPDATE tb_pegawai SET
                                    deleted_at = NULL
                                WHERE no_ktp_pegawai = @no_ktp_pegawai";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, no_ktp_pegawai);
        }

        public void DeletePermanent(string no_ktp_pegawai)
        {
            const string sql = "DELETE FROM tb_pegawai WHERE no_ktp_pegawai = @no_ktp_pegawai";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { no_ktp_pegawai });
        }

        public int CountData(string filter)
        {
            string sql = @$"
                SELECT COUNT(*) 
                FROM tb_pegawai 
                WHERE deleted_at IS NULL 
                {filter}";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.ExecuteScalar<int>(sql);
        }

        public PegawaiModel? ValidasiLoginPetugas(string email, string password)
        {
            const string sql = @"SELECT
                                    no_ktp_pegawai, nama_pegawai, role 
                                FROM 
                                    tb_pegawai 
                                WHERE 
                                    email = @email AND password = @password";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            return conn.QueryFirstOrDefault<PegawaiModel>(sql, new { email, password });
        }

        public int ValidasiDaftar(string no_ktp_pegawai, string no_hp, string email)
        {
            const string cek_RestoreData = "SELECT COUNT(*) FROM tb_pegawai WHERE no_ktp_pegawai = @no_ktp_pegawai AND deleted_at IS NOT NULL";
            const string cek_NIK = "SELECT COUNT(*) FROM tb_pegawai WHERE no_ktp_pegawai = @no_ktp_pegawai";
            const string cek_NoTelp = "SELECT COUNT(*) FROM tb_pegawai WHERE no_hp = @no_hp";
            const string cek_Email = "SELECT COUNT(*) FROM tb_pegawai WHERE email = @email";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            var cekRestoreData = Conn.QueryFirstOrDefault<bool>(cek_RestoreData, new { no_ktp_pegawai });
            var cekNIK = Conn.QueryFirstOrDefault<bool>(cek_NIK, new { no_ktp_pegawai });
            var cekNoTelp = Conn.QueryFirstOrDefault<bool>(cek_NoTelp, new { no_hp });
            var cekEmail = Conn.QueryFirstOrDefault<bool>(cek_Email, new { email });

            if (cekRestoreData)
                return 1;
            if (cekNIK)
                return 2;
            else if (cekNoTelp)
                return 3;
            else if (cekEmail)
                return 4;
            else
                return 0;
        }

    }
}