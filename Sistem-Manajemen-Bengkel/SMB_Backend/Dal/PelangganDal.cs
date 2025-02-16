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
using System.Runtime.Intrinsics.Arm;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class PelangganDal
    {
        public IEnumerable<PelangganModel> ListData(string filter , string orderBy, object Dp)
        {
            string sql = @$"SELECT 
                                no_ktp_pelanggan, nama_pelanggan, no_hp, alamat, email, total_servis 
                            FROM 
                                tb_pelanggan 
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
            const string sql = @"SELECT 
                                    no_ktp_pelanggan, nama_pelanggan, no_hp, alamat, email, password, total_servis   
                                FROM tb_pelanggan WHERE no_ktp_pelanggan = @no_ktp_pelanggan";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<PelangganModel>(sql, new { no_ktp_pelanggan });
        }

        public void InsertData(PelangganModel pelanggan)
        {
            const string sql = @"INSERT INTO tb_pelanggan 
                            (no_ktp_pelanggan, nama_pelanggan, no_hp, alamat, email, password, total_servis)
                        VALUES
                            (@no_ktp_pelanggan, @nama_pelanggan, @no_hp, @alamat, @email, @password, 0)";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            var Dp = new DynamicParameters();

            Dp.Add("@no_ktp_pelanggan", pelanggan.no_ktp_pelanggan);
            Dp.Add("@nama_pelanggan", pelanggan.nama_pelanggan);
            Dp.Add("@no_hp", pelanggan.no_hp);
            Dp.Add("@alamat", pelanggan.alamat);
            Dp.Add("@email", pelanggan.email);
            Dp.Add("@password", pelanggan.password);

            Conn.Execute(sql, Dp);
        }


        public void UpdateData(PelangganModel pelanggan, string no_ktp, bool isPasswordReset)
        {
            string sql = @$"UPDATE tb_pelanggan
                           SET
                               no_ktp_pelanggan = @no_ktp_pelanggan,
                               nama_pelanggan = @nama_pelanggan,
                               no_hp = @no_hp,
                               alamat = @alamat,
                               email = @email,
                               total_servis = @total_servis,
                               updated_at = GETDATE()
                               { (isPasswordReset ? ", password = @password" : "")}
                            WHERE no_ktp_pelanggan = @no_ktp_pelanggan";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@no_ktp_pelanggan", pelanggan.no_ktp_pelanggan);
            Dp.Add("@nama_pelanggan", pelanggan.nama_pelanggan);
            Dp.Add("@no_hp", pelanggan.no_hp);
            Dp.Add("@alamat", pelanggan.alamat);
            Dp.Add("@email", pelanggan.email);
            Dp.Add("@total_servis", pelanggan.total_servis);
            Dp.Add("@no_ktp", no_ktp);

            if (isPasswordReset)
                Dp.Add("@password", pelanggan.password);

            Conn.Execute(sql, Dp);
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

        public int CountData(string filter, DynamicParameters dp)
        {
            string sql = @$"
                SELECT COUNT(no_ktp_pelanggan) 
                FROM tb_pelanggan 
                WHERE deleted_at IS NULL 
                {filter}";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.ExecuteScalar<int>(sql, dp);
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
            const string sql = @"SELECT CASE 
                                    WHEN EXISTS (SELECT 1 FROM tb_pelanggan WHERE no_ktp_pelanggan = @no_ktp_pelanggan AND deleted_at IS NOT NULL) THEN 1
                                    WHEN EXISTS (SELECT 1 FROM tb_pelanggan WHERE no_ktp_pelanggan = @no_ktp_pelanggan) THEN 2
                                    WHEN EXISTS (SELECT 1 FROM tb_pelanggan WHERE no_hp = @no_hp) THEN 3
                                    WHEN EXISTS (SELECT 1 FROM tb_pelanggan WHERE email = @email) THEN 4
                                    ELSE 0
                                END AS Result";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<int>(sql, new { no_ktp_pelanggan, no_hp, email });
        }


        public PelangganModel? ValidasiLoginPelanggan(string email, string password)
        {
            const string sql = "SELECT no_ktp_pelanggan, nama_pelanggan FROM tb_pelanggan WHERE email = @email AND password = @password";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<PelangganModel>(sql, new { email, password });
        }
    }
}