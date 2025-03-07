using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;
using Syncfusion.Windows.Forms.Tools.MultiColumnTreeView;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class DashboardDal
    {

        public IEnumerable<(string nama_sparepart, int jumlah_terjual)> PeringkatSparepartTerjual()
        {
            const string sql = "SELECT * FROM dbo.fnc_ListPeringkatSparepartTerjual()";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<(string nama_sparepart, int jumlah_terjual)>(sql);
        }

        public IEnumerable<(string nama_pelanggan, int total_Servis)> PeringkatServisPelanggan()
        {
            const string sql = "SELECT * FROM dbo.fnc_TotalServisPelanggan()";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<(string nama_pelanggan, int total_Servis)>(sql);
        }

        public decimal TotalPendapatanHariIni(DateTime tanggal)
        {
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<decimal>("SELECT dbo.fnc_TotalPendapatanHariIni(@tanggal)", new { tanggal = tanggal });
        }

        public int TotalBookingHariIni(DateTime tanggal)
        {
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<int>("SELECT dbo.fnc_TotalBookingHariIni(@tanggal)", new { tanggal = tanggal });
        }

        public int TotalSelesaiServisHariIni(DateTime tanggal)
        {
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<int>("SELECT dbo.fnc_TotalSelesaiServisHariIni(@tanggal)", new { tanggal = tanggal });
        }

        public int TotalDataPelanggan()
        {
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<int>("SELECT dbo.fnc_TotalDataPelanggan()");
        }
    }
}
