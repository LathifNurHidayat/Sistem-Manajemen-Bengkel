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
    public class PetugasDal
    {
        public IEnumerable<PegawaiModel> ListData()
        {
            const string sql = @"SELECT * FROM tb_petugas";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<PegawaiModel>(sql);
        }

        public PegawaiModel? GetData(int id_petugas)
        {
            const string sql = @"SELECT * FROM tb_petugas WHERE id_petugas = @id_petugas";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<PegawaiModel>(sql, new { id_petugas });
        }

        public void InsertData(PegawaiModel petugasModel)
        {
            const string sql = @"INSERT INTO tb_petugas 
                                    (nama_petugas, email, password, no_hp, alamat, role) 
                                VALUES 
                                    (@nama_petugas, @email, @password, @no_hp, @alamat, @role)";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, petugasModel);
        }

        public void UpdateData (PegawaiModel petugasModel)
        {
            const string sql = @"UPDATE tb_petugas SET
                                    nama_petugas = @nama_petugas,
                                    email = @email,
                                    password = @password
                                    no_hp = @no_hp,
                                    alamat = @alamat,
                                    role = @role
                                WHERE id_petugas = @id_petugas";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, petugasModel);
        }

        public void Delete(int id_petugas)
        {
            const string sql = "DELETE FROM tb_petugas WHERE id_petugas = @id_petugas";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { id_petugas });
        }

        public PegawaiModel? ValidasiLoginPetugas(string email, string password)
        {
            const string sql = "SELECT id_petugas, nama_petugas, role FROM tb_petugas WHERE email = @email AND password = @password";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<PegawaiModel>(sql, new { email, password });
        }
    }
 }