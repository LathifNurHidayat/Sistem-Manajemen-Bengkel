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
using System.Windows.Media.Animation;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class PelangganDal
    {
        public IEnumerable<PelangganModel> ListData(string filter , string orderBy, object Dp)
        {
            string sql = @$"SELECT * FROM tb_pelanggan 
                                WHERE
                                    deleted_at IS NULL 
                                    {filter}
                                ORDER BY 
                                    {orderBy} 
                                OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<PelangganModel>(sql, Dp);
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
                                    (no_ktp_pelanggan, nama_pelanggan, no_hp, alamat, email, password, total_servis)
                                VALUES
                                    (@no_ktp_pelanggan, @nama_pelanggan, @no_hp, @alamat, @email, @password, 0)";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, peanggan);
        }
        
        public void UpdateDataNoKTP(PelangganModel pelanggan, string no_ktp)
        {
            const string sql = @"UPDATE tb_pelanggan
                                SET
                                    no_ktp_pelanggan = @no_ktp_pelanggan,
                                    nama_pelanggan = @nama_pelanggan,
                                    no_hp = @no_hp,
                                    alamat = @alamat,
                                    email = @email,
                                    password = @password,
                                    total_servis = @total_servis,
                                    updated_at = GETDATE()
                                WHERE
                                    no_ktp_pelanggan = @no_ktp";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { pelanggan, no_ktp });
        }

        public void UpdateData(PelangganModel pelanggan)
        {

            const string sql = @"UPDATE tb_pelanggan
                                SET
                                    nama_pelanggan = @nama_pelanggan,
                                    no_hp = @no_hp,
                                    alamat = @alamat,
                                    email = @email,
                                    password = @password,
                                    total_servis = @total_servis,
                                    updated_at = GETDATE()
                                WHERE
                                    no_ktp_pelanggan = @no_ktp_pelanggan";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, pelanggan);
        }

        public void SoftDeleteData(string no_ktp_pelanggan)
        {
            const string sql = @"UPDATE tb_pelanggan SET deleted_at = GETDATE() WHERE no_ktp_pelanggan = @no_ktp_pelanggan";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { no_ktp_pelanggan });
        }
        
        public void DeleteDataPermanent(string no_ktp_pelanggan)
        {
            const string sql = @"DELETE FROM tb_pelanggan WHERE no_ktp_pelanggan = @no_ktp_pelanggan";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { no_ktp_pelanggan });
        }

        public int CountData(string filter)
        {
            string sql = @$"
                SELECT COUNT(*) 
                FROM tb_pelanggan 
                WHERE deleted_at IS NULL 
                {filter}";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.ExecuteScalar<int>(sql);
        }

        public void RestoreData(string no_ktp_pelanggan)
        {
            const string sql = @"UPDATE tb_pelanggan SET deleted_at = NULL WHERE no_ktp_pelanggan = @no_ktp_pelanggan";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { no_ktp_pelanggan });
        }

        //PERBAIKI VALIDASINYA NANTI

        public int ValidasiDaftar(string no_ktp_pelanggan, string no_hp, string email)
        {
            const string cek_RestoreData = "SELECT COUNT(*) FROM tb_pelanggan WHERE no_ktp_pelanggan = @no_ktp_pelanggan AND deleted_at IS NOT NULL";
            const string cek_NIK = "SELECT COUNT(*) FROM tb_pelanggan WHERE no_ktp_pelanggan = @no_ktp_pelanggan";
            const string cek_NoTelp = "SELECT COUNT(*) FROM tb_pelanggan WHERE no_hp = @no_hp";
            const string cek_Email = "SELECT COUNT(*) FROM tb_pelanggan WHERE email = @email";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            var cekRestoreData = Conn.QueryFirstOrDefault<bool>(cek_RestoreData, new { no_ktp_pelanggan });
            var cekNIK = Conn.QueryFirstOrDefault<bool>(cek_NIK, new { no_ktp_pelanggan });
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

        public PelangganModel? ValidasiLoginPelanggan(string email, string password)
        {
            const string sql = "SELECT no_ktp_pelanggan, nama_pelanggan FROM tb_pelanggan WHERE email = @email AND password = @password";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<PelangganModel>(sql, new { email, password });
        }
    }
}