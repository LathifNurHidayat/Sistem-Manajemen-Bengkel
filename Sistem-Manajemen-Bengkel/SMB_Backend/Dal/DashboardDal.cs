using System;
using System.Collections.Generic;
using System.Data;
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
        public DashboardMetrics GetDashboardMetrics(DateTime tanggal)
        {
            const string sql = "sp_GetDashboardMetrics";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            using var multi = conn.QueryMultiple(sql, new { tanggal }, commandType: CommandType.StoredProcedure);

            var metrics = new DashboardMetrics
            {
                TotalPendapatanHariIni = multi.ReadFirstOrDefault<decimal>(),
                TotalBookingHariIni = multi.ReadFirstOrDefault<int>(),
                TotalSelesaiServisHariIni = multi.ReadFirstOrDefault<int>(),
                TotalDataPelanggan = multi.ReadFirstOrDefault<int>(),
                TopPelanggan = multi.Read<(string NamaPelanggan, int TotalServis)>(),
                TopSpareparts = multi.Read<(string NamaSparepart, int JumlahTerjual)>()
            };

            return metrics;
        }
    }


    public class DashboardMetrics
    {
        public decimal TotalPendapatanHariIni { get; set; }
        public int TotalBookingHariIni { get; set; }
        public int TotalSelesaiServisHariIni { get; set; }
        public int TotalDataPelanggan { get; set; }
        public IEnumerable<(string NamaPelanggan, int TotalServis)> TopPelanggan { get; set; }
        public IEnumerable<(string NamaSparepart, int JumlahTerjual)> TopSpareparts { get; set; }
    }
}
