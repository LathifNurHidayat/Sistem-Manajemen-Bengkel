using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class BookingDal
    {


        public IEnumerable<BookingModel> ListData(string filter,object Dp)
        {
            string sql = @$"SELECT 
                                aa.id_booking,
                                COALESCE (bb.nama_pelanggan, aa.nama_pelanggan) AS nama_pelanggan,

                            CASE 
                                WHEN (aa.merek IS NULL  OR aa.merek = '') AND (aa.kapasitas_mesin IS NULL OR aa.kapasitas_mesin = '')
                                THEN CONCAT(COALESCE(dd.merek, ''), ' ', COALESCE(dd.kapasitas_mesin, ''), 'cc')
                                ELSE CONCAT(COALESCE(aa.merek, ''), ' ', COALESCE(aa.kapasitas_mesin, ''), 'cc')
                            END AS nama_kendaraan,

                                bb.no_hp,
                                CONVERT(DATETIME, aa.tanggal, 105) AS tanggal, aa.antrean, aa.keluhan, aa.status
                            FROM 
                                tb_booking aa

                            LEFT JOIN tb_pelanggan bb 
                                ON aa.no_ktp_pelanggan = bb.no_ktp_pelanggan
                            LEFT JOIN tb_kendaraan dd 
                                ON aa.id_kendaraan = dd.id_kendaraan

                            {filter}

                            ORDER BY 
                                antrean ASC
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
                                    
                                    ff.id_sparepart 
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

        public void InsertData(BookingModel booking)
        {
            const string sql = @"INSERT INTO tb_booking 
                            (no_ktp_pelanggan, no_ktp_mekanik, id_kendaraan, id_jasa_servis, 
                            nama_pelanggan, no_polisi, merek, transmisi, kapasitas_mesin, 
                            tanggal, antrean, keluhan, status)
                         VALUES 
                             (@no_ktp_pelanggan, @no_ktp_mekanik, @id_kendaraan, @id_jasa_servis, 
                            @nama_pelanggan, @no_polisi, @merek, @transmisi, @kapasitas_mesin, 
                            @tanggal, @antrean, @keluhan, @status)";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());

            var Dp = new DynamicParameters();
            Dp.Add("@no_ktp_pelanggan", booking.no_ktp_pelanggan);
            Dp.Add("@no_ktp_mekanik", booking.no_ktp_mekanik);
            Dp.Add("@id_kendaraan", booking.id_kendaraan);
            Dp.Add("@id_jasa_servis", booking.id_jasa_servis);
            Dp.Add("@nama_pelanggan", booking.nama_pelanggan);
            Dp.Add("@no_polisi", booking.no_polisi);
            Dp.Add("@merek", booking.merek);
            Dp.Add("@transmisi", booking.transmisi);
            Dp.Add("@kapasitas_mesin", booking.kapasitas_mesin);
            Dp.Add("@tanggal", booking.tanggal);
            Dp.Add("@antrean", booking.antrean);
            Dp.Add("@keluhan", booking.keluhan);
            Dp.Add("@status", booking.status);

            conn.Execute(sql, Dp);
        }

        public void DeletePermanent(int id_booking)
        {
            const string sql = "DELETE FROM tb_booking WHERE id_booking = @id_booking";
            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            conn.Execute(sql, new { id_booking });
        }

        public int CountData(string filter,object dp)
        {
            string sql = @$"SELECT COUNT(*)
                            FROM tb_booking aa
                            LEFT JOIN tb_pelanggan bb ON aa.no_ktp_pelanggan = bb.no_ktp_pelanggan
                            LEFT JOIN tb_kendaraan dd ON aa.id_kendaraan = dd.id_kendaraan
                            {filter} ";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.ExecuteScalar<int>(sql, dp);
        }

        public (int AntreanBaru, int AntreanDikerjakan) CekKuotaBooking(DateTime tanggal)
        {
            const string sql = "SELECT * FROM dbo.CekKuotaBooking(@tanggal)";

            using var conn = new SqlConnection(ConnStringHelper.GetConn());
            var result = conn.QueryFirstOrDefault(sql, new { tanggal });

            return (AntreanBaru: result.AntreanBaru, AntreanDikerjakan: result.AntreanDikerjakan);
        }


    }
}