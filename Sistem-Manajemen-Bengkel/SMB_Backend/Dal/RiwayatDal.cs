using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Dapper;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public   class RiwayatDal
    {
        public IEnumerable<BookingModel> ListData(string filter, object Dp)
        {
            string sql = @$"SELECT 
                                aa.id_booking,
                                COALESCE (bb.nama_pelanggan, aa.nama_pelanggan) AS nama_pelanggan,
                                COALESCE (dd.no_polisi, aa.no_polisi) AS no_polisi,

                            CASE 
                                WHEN (aa.merek IS NULL  OR aa.merek = '') AND (aa.kapasitas_mesin IS NULL OR aa.kapasitas_mesin = '')
                                THEN CONCAT (dd.merek , ' ' , dd.kapasitas_mesin, 'cc')
                                ELSE CONCAT (aa.merek , ' ' , aa.kapasitas_mesin, 'cc')
                            END AS nama_kendaraan,

                                COALESCE (dd.transmisi, aa.transmisi) AS transmisi,
                                ISNULL (ee.jenis_servis, '') AS jenis_servis,
                                aa.tanggal, aa.antrean, aa.keluhan, aa.status
                            FROM 
                                tb_booking aa

                            LEFT JOIN tb_pelanggan bb 
                                ON aa.no_ktp_pelanggan = bb.no_ktp_pelanggan
                            LEFT JOIN tb_kendaraan dd 
                                ON aa.id_kendaraan = dd.id_kendaraan
                            LEFT JOIN tb_jasa_servis ee 
                                ON aa.id_jasa_servis = ee.id_jasa_servis

                            WHERE
                                {filter}
                            ORDER BY 
                                aa.antrean ASC
                            OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<BookingModel>(sql, Dp);
        }

    }
}
