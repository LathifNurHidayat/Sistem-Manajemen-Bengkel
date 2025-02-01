using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Database;
using System.Data;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class PelangganDal
    {
        public IEnumerable<PelangganModel> ListData()
        {
            const string sql = @"SELECT * FROM tb_pelanggan";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<PelangganModel>(sql);
        }

        public PelangganModel? GetData(int no_ktp)
        {
            const string sql = @"SELECT * FROM tb_pelanggan WHERE no_ktp = @no_ktp";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<PelangganModel>(sql, new { no_ktp });
        }

        public void InsertData(PelangganModel peanggan)
        {
            const string sql = @"INSERT INTO tb_pelanggan 
                                    (no_ktp, nama_pelanggan, no_hp, alamat, email, password)
                                VALUES
                                    (@no_ktp, @nama_pelanggan, @no_hp, @alamat, @email, @password)";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, peanggan);
        }

        public void UpdateData(int no_ktp)
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
                                    no_ktp = @no_ktp";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, no_ktp);
        }

        public void DeleteData(int no_ktp)
        {
            const string sql = @"DELETE FROM tb_pelanggan WHERE no_ktp = @no_ktp";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { no_ktp });
        }

        public int ValidasiDaftar(long no_ktp, string no_hp, string email)
        {
            const string cek_NIK = "SELECT COUNT(*) FROM tb_pelanggan WHERE no_ktp = @no_ktp";
            const string cek_NoTelp = "SELECT COUNT(*) FROM tb_pelanggan WHERE no_hp = @no_hp";
            const string cek_Email = "SELECT COUNT(*) FROM tb_pelanggan WHERE email = @email";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            var cekNIK = Conn.QueryFirstOrDefault<bool>(cek_NIK, new { no_ktp });
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

        public int ValidasiLoginPelanggan(string email, string password)
        {
            const string sql = "SELECT id_pelanggan FROM tb_pelanggan WHERE email = @email AND password = @password";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<int>(sql, new { email, password });
        }
    }
}