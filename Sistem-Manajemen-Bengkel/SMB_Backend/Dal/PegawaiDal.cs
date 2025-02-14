using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.Helper;
using System.Data;

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
            return Conn.QueryFirstOrDefault<PegawaiModel>(sql, new { no_ktp_pegawai = no_ktp_pegawai });
        }

        public void InsertData(PegawaiModel pegawaiModel)
        {
            const string sql = @"INSERT INTO tb_pegawai 
                            (no_ktp_pegawai, nama_pegawai, email, password, no_hp, alamat, role, image_name, image_data)
                         VALUES 
                            (@no_ktp_pegawai, @nama_pegawai, @email, @password, @no_hp, @alamat, @role, @image_name, @image_data)";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@no_ktp_pegawai", pegawaiModel.no_ktp_pegawai);
            Dp.Add("@nama_pegawai", pegawaiModel.nama_pegawai);
            Dp.Add("@email", pegawaiModel.email);
            Dp.Add("@password", pegawaiModel.password);
            Dp.Add("@no_hp", pegawaiModel.no_hp);
            Dp.Add("@alamat", pegawaiModel.alamat);
            Dp.Add("@role", pegawaiModel.role);
            Dp.Add("@image_data", pegawaiModel.image_data);

            conn.Execute(sql, Dp);
        }

        public void UpdateData(PegawaiModel pegawaiModel, bool isPasswordReset)
        {
            string sql = @$"UPDATE tb_pegawai SET
                                nama_pegawai = @nama_pegawai,
                                email = @email,
                                no_hp = @no_hp,
                                alamat = @alamat,
                                role = @role,
                                image_data = @image_data,
                                updated_at = GETDATE()
                                {( isPasswordReset ? ", password = @password" : "")}
                            WHERE no_ktp_pegawai = @no_ktp_pegawai";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@no_ktp_pegawai", pegawaiModel.no_ktp_pegawai);
            Dp.Add("@nama_pegawai", pegawaiModel.nama_pegawai);
            Dp.Add("@email", pegawaiModel.email);
            Dp.Add("@no_hp", pegawaiModel.no_hp);
            Dp.Add("@alamat", pegawaiModel.alamat);
            Dp.Add("@role", pegawaiModel.role);
            Dp.Add("@image_data", pegawaiModel.image_data);

            if (isPasswordReset)
                Dp.Add("@password", pegawaiModel.password);

            conn.Execute(sql, Dp);
        }

        public void UpdateDataNoKTP(PegawaiModel pegawai, string no_ktp, bool isPasswordReset)
        {
            string sql = @$"UPDATE tb_pegawai SET
                                no_ktp_pegawai = @no_ktp_pegawai,
                                nama_pegawai = @nama_pegawai,
                                email = @email,
                                no_hp = @no_hp,
                                alamat = @alamat,
                                role = @role,
                                image_data = @image_data,
                                updated_at = GETDATE()
                                {(isPasswordReset ? ", password = @password" : "")} 
                            WHERE no_ktp_pegawai = @no_ktp";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@no_ktp_pegawai", pegawai.no_ktp_pegawai);
            Dp.Add("@nama_pegawai", pegawai.nama_pegawai);
            Dp.Add("@email", pegawai.email);
            Dp.Add("@no_hp", pegawai.no_hp);
            Dp.Add("@alamat", pegawai.alamat);
            Dp.Add("@role", pegawai.role);
            Dp.Add("@image_data", pegawai.image_data);
            Dp.Add("@no_ktp", no_ktp);

            if (isPasswordReset)
                Dp.Add("@password", pegawai.password);

            Conn.Execute(sql, Dp);
        }



        public void SoftDeleteData(string no_ktp)
        {
            const string sql = @"UPDATE tb_pegawai SET
                             deleted_at = GETDATE()
                         WHERE no_ktp_pegawai = @no_ktp_pegawai";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { no_ktp_pegawai = no_ktp });
        }


        public void RestoreData(string no_ktp_pegawai)
        {
            const string sql = @"UPDATE tb_pegawai SET
                                    deleted_at = NULL
                                WHERE no_ktp_pegawai = @no_ktp_pegawai";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { no_ktp_pegawai = no_ktp_pegawai});
        }

        public void DeletePermanent(string no_ktp_pegawai)
        {
            const string sql = "DELETE FROM tb_pegawai WHERE no_ktp_pegawai = @no_ktp_pegawai";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { no_ktp_pegawai = no_ktp_pegawai });
        }

        public int CountData(string filter, DynamicParameters dp)
        {
            string sql = @$"
                SELECT COUNT(no_ktp_pegawai) 
                FROM tb_pegawai 
                WHERE deleted_at IS NULL 
                {filter}";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.ExecuteScalar<int>(sql, dp);
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
            const string sql = @"SELECT CASE 
                                        WHEN EXISTS (SELECT 1 FRON tb_pegawai WHERE no_ktp_pegawai = @no_ktp_pegawai AND deleted_at IS NULL) THEN 1
                                        WHEN EXISTS (SELECT 1 FROM tb_pegawai WHERE no_ktp_pegawai = @no_ktp_pegawai) THEN 2
                                        WHEN EXISTS (SELECT 1 FROM tb_pegawai WHERE no_hp = @no_hp) THEN 3
                                        WHEN EXISTS (SELECT 1 FROM tb_pegawai WHERE email = @email) THEN 4
                                        ELSE 0
                                END AS Result";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<int>(sql, new { no_ktp_pegawai, no_hp, email });
        }

    }
}