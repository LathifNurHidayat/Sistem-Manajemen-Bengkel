using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class BookingDal
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

        public BookingModel? GetData(int id_booking)
        {
            const string sql = @"SELECT 
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
";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn()); 
            return Conn.QueryFirstOrDefault<BookingModel>(sql, new { id_booking });
        }

        public int InsertData(BookingModel model)
        {
            const string sql = @"INSERT INTO tb_booking 
                                    (no_ktp, username, tanggal, antrean, keluhan, status) 
                                VALUES 
                                    (@no_ktp, @username, @tanggal, @antrean, @keluhan, @status)";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Execute(sql, model);
        }

        public int UpdateData(BookingModel model)
        {
            const string sql = @"UPDATE tb_booking 
                                SET 
                                    no_ktp = @no_ktp, 
                                    username = @username, 
                                    tanggal = @tanggal, 
                                    antrean = @antrean, 
                                    keluhan = @keluhan, 
                                    status = @status 
                                WHERE 
                                    id_booking = @id_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Execute(sql, model);
        }

        public void DeleteData(int id_booking)
        {
            const string sql = @"DELETE FROM tb_booking WHERE id_booking = @id_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            Conn.Execute(sql, new { id_booking });
        }
    }
}