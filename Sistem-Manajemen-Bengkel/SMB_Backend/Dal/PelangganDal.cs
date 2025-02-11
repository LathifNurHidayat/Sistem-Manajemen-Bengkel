using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using System.Data;
using Sistem_Manajemen_Bengkel.Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class PelangganDal
    {
        public IEnumerable<PelangganModel> ListData()
        {
            const string sql = @"SELECT * FROM tb_pelanggan 
                                ORDER BY created_at ASC";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<PelangganModel>(sql);
        }

        public PelangganModel? GetData(string no_ktp_pelanggan)
        {
            const string sql = @"SELECT * FROM tb_pelanggan WHERE no_ktp_pelanggan = @no_ktp_pelanggan";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<PelangganModel>(sql, new { no_ktp_pelanggan });
        }

        public void InsertData(PelangganModel peanggan)
        {
            const string sql = @"INSERT INTO tb_pelanggan 
                                    (no_ktp_pelanggan, nama_pelanggan, no_hp, alamat, email, password)
                                VALUES
                                    (@no_ktp_pelanggan, @nama_pelanggan, @no_hp, @alamat, @email, @password)";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, peanggan);
        }

        public void UpdateData(string no_ktp_pelanggan)
        {
            const string sql = @"UPDATE tb_pelanggan
                                SET
                                    nama_pelanggan = @nama_pelanggan,
                                    no_hp = @no_hp,
                                    alamat = @alamat,
                                    email = @email,
                                    password = @password,
                                    updated_at = GETDATE()
                                WHERE
                                    no_ktp_pelanggan = @no_ktp_pelanggan";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, no_ktp_pelanggan);
        }

        public void DeleteData(string no_ktp_pelanggan)
        {
            const string sql = @"DELETE FROM tb_pelanggan WHERE no_ktp_pelanggan = @no_ktp_pelanggan";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { no_ktp_pelanggan });
        }

        public int ValidasiDaftar(string no_ktp_pelanggan, string no_hp, string email)
        {
            const string cek_NIK = "SELECT COUNT(*) FROM tb_pelanggan WHERE no_ktp_pelanggan = @no_ktp_pelanggan";
            const string cek_NoTelp = "SELECT COUNT(*) FROM tb_pelanggan WHERE no_hp = @no_hp";
            const string cek_Email = "SELECT COUNT(*) FROM tb_pelanggan WHERE email = @email";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            var cekNIK = Conn.QueryFirstOrDefault<bool>(cek_NIK, new { no_ktp_pelanggan });
            var cekNoTelp = Conn.QueryFirstOrDefault<bool>(cek_NoTelp, new { no_hp });
            var cekEmail = Conn.QueryFirstOrDefault<bool>(cek_Email, new { email });

            if (cekNIK)
                return 1;
            else if (cekNoTelp)
                return 2;
            else if (cekEmail)
                return 3;
            else
                return 0;
        }

        public PelangganModel? ValidasiLoginPelanggan(string email, string password)
        {
            const string sql = "SELECT no_ktp_pelanggan, nama_pelanggan FROM tb_pelanggan WHERE email = @email AND password = @password";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<PelangganModel>(sql, new { email, password });
        }
    }
}