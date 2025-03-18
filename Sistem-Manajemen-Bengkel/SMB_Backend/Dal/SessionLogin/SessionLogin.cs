using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal.SessionLogin
{
    public static class SessionLogin
    {
        public static SessionLoginPegawaiModel _sessionLoginPegawai { get; private set; }
        public static SessionLoginPelangganModel _sessionLoginPelanggan { get; private set; }

        public static void GetSessionLoginPegawai(string no_ktp_pegawai, string nama_pegawai, string role)
        {
            _sessionLoginPegawai = new SessionLoginPegawaiModel
            {
                no_ktp_pegawai = no_ktp_pegawai,
                nama_pegawai = nama_pegawai,
                role = role
            };
        }


        public static void GetSessionLoginPelanggan(string no_ktp_pelanggan, string nama_pelanggan)
        {
            _sessionLoginPelanggan = new SessionLoginPelangganModel
            {
                no_ktp_pelanggan = no_ktp_pelanggan,
                nama_pelanggan = nama_pelanggan
            };
        }
        
        
        public static void ClearSessionLoginPelanggan()
        {
            _sessionLoginPelanggan = new SessionLoginPelangganModel
            {
                no_ktp_pelanggan = null,
                nama_pelanggan = null
            };
        }

        public static void ClearSessionLoginPegawai()
        {
            _sessionLoginPegawai = new SessionLoginPegawaiModel
            {
                no_ktp_pegawai = null,
                nama_pegawai = null,
                role = null
            };
        }
    }



    public class SessionLoginPegawaiModel
    {
        public string? no_ktp_pegawai { get; set; }
        public string? nama_pegawai { get; set; }
        public string? role { get; set; }
    }

    public class SessionLoginPelangganModel
    {
        public string? no_ktp_pelanggan { get; set; }
        public string? nama_pelanggan { get; set; }
    }
}
