using System;
using System.Collections.Generic;
using System.Data;
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
                                aa.tanggal ASC,  aa.antrean ASC
                            OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return Conn.Query<BookingModel>(sql, Dp);
        }
        
        
        public IEnumerable<BookingModel> ListDataByNoKtp(string no_ktp_pelanggan)
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

                            WHERE aa.no_ktp_pelanggan = @no_ktp_pelanggan";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return Conn.Query<BookingModel>(sql, new { no_ktp_pelanggan });
        }

        public BookingModel? GetData(int id_booking)
        {
            const string sql = @"SELECT 
                                    aa.id_booking,
                                    ISNULL (aa.no_ktp_mekanik, '') AS no_ktp_mekanik,
                                    ISNULL (aa.id_jasa_servis, 0) AS id_jasa_servis,
                                    ISNULL (aa.no_ktp_pelanggan, '') AS no_ktp_pelanggan,
                                    COALESCE (bb.nama_pelanggan, aa.nama_pelanggan) AS nama_pelanggan,
                                    COALESCE (dd.no_polisi, aa.no_polisi) AS no_polisi,

                                CASE
                                    WHEN (aa.merek IS NULL  OR aa.merek = '') AND (aa.kapasitas_mesin IS NULL OR aa.kapasitas_mesin = '')
                                    THEN CONCAT (dd.merek , ' ' , dd.kapasitas_mesin, 'cc')
                                    ELSE CONCAT (aa.merek , ' ' , aa.kapasitas_mesin, 'cc')
                                END AS nama_kendaraan,
                                    COALESCE (dd.merek, aa.merek) AS merek,
                                    COALESCE (dd.kapasitas_mesin, aa.kapasitas_mesin) AS kapasitas_mesin,


                                    COALESCE (dd.transmisi, aa.transmisi) AS transmisi,
                                    ISNULL (ee.jenis_servis, '') AS jenis_servis,
                                    
                                    STRING_AGG(gg.nama_sparepart, ', ') AS nama_sparepart,

                                    aa.id_kendaraan, aa.catatan, aa.tanggal, aa.antrean, aa.keluhan, aa.status
                                FROM 
                                    tb_booking aa

                                LEFT JOIN tb_penggunaan_sparepart ff
                                    ON aa.id_booking = ff.id_penggunaan_sparepart
                                LEFT JOIN tb_sparepart gg
                                    ON ff.id_sparepart = gg.id_sparepart

                                LEFT JOIN tb_pelanggan bb  
                                    ON aa.no_ktp_pelanggan = bb.no_ktp_pelanggan
                                LEFT JOIN tb_kendaraan dd 
                                    ON aa.id_kendaraan = dd.id_kendaraan
                                LEFT JOIN tb_jasa_servis ee 
                                    ON aa.id_jasa_servis = ee.id_jasa_servis
                                WHERE aa.id_booking = @id_booking
                                GROUP BY
                                    aa.id_booking,
                                    ISNULL (aa.no_ktp_mekanik, ''),
                                    ISNULL (aa.id_jasa_servis, 0) ,
                                    ISNULL (aa.no_ktp_pelanggan, '') ,
                                    COALESCE(bb.nama_pelanggan, aa.nama_pelanggan),
                                    COALESCE(dd.no_polisi, aa.no_polisi),
                                    aa.merek, aa.kapasitas_mesin, dd.merek, dd.kapasitas_mesin, -- Tambahkan kolom ini
                                    COALESCE(dd.transmisi, aa.transmisi),
                                    ISNULL(ee.jenis_servis, ''),
                                    aa.id_kendaraan,
                                    aa.catatan,
                                    aa.tanggal,
                                    aa.antrean,
                                    aa.keluhan,
                                    aa.status";
            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID()); 
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
                            CAST(@tanggal AS DATE), @antrean, @keluhan, @status)";

            using var conn = new SqlConnection(ConnStringHelper.GetConnByUserID());

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

        public void UpdateData(BookingModel booking)
        {
            const string sql = @"UPDATE tb_booking 
                            SET 
                                no_ktp_mekanik = @no_ktp_mekanik,
                                id_jasa_servis = @id_jasa_servis,
                                catatan = @catatan,
                                status = @status
                            WHERE id_booking = @id_booking";

            using var conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            var Dp = new DynamicParameters();
            if (string.IsNullOrEmpty(booking.no_ktp_mekanik))
                Dp.Add("@no_ktp_mekanik", DBNull.Value, DbType.String);
            else
                Dp.Add("@no_ktp_mekanik", booking.no_ktp_mekanik); 
            
            if (booking.id_jasa_servis == 0)
                Dp.Add("@id_jasa_servis", DBNull.Value, DbType.Int32);
            else
                Dp.Add("@id_jasa_servis", booking.id_jasa_servis);

            Dp.Add("@catatan", booking.catatan);
            Dp.Add("@status", booking.status);
            Dp.Add("@id_booking", booking.id_booking);
            conn.Execute(sql, Dp);
        }


        public void DeleteAfterDateChange()
        {
            const string sql = "DELETE FROM tb_booking WHERE CAST(tanggal AS DATE) < CAST(GETDATE() AS DATE)";
            using var conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            conn.Execute(sql);
        }

        public int CountData(string filter,object dp)
        {
            string sql = @$"SELECT COUNT(*)
                            FROM tb_booking aa
                            LEFT JOIN tb_pelanggan bb ON aa.no_ktp_pelanggan = bb.no_ktp_pelanggan
                            LEFT JOIN tb_kendaraan dd ON aa.id_kendaraan = dd.id_kendaraan
                            {filter} ";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return Conn.ExecuteScalar<int>(sql, dp);
        }

        public (int AntreanBaru, int AntreanDikerjakan) CekKuotaBooking(DateTime tanggal)
        {
            const string sql = "SELECT * FROM dbo.fnc_ValidasiKuotaBooking(@tanggal)";

            using var conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            var result = conn.QueryFirstOrDefault(sql, new { tanggal });

            return (AntreanBaru: result.AntreanBaru, AntreanDikerjakan: result.AntreanDikerjakan);
        }


        public string CekOperasionalBengkel(DateTime tanggal)
        {
            const string sql = "SELECT dbo.fnc_CekOperasionalBengkel(@tanggal, @jamBooking)";

            using var conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            var result = conn.QueryFirstOrDefault<string>(sql, new { tanggal , jamBooking = DateTime.Now.TimeOfDay});
            return result?? "";
        }


        public List<DateTime> GetDataTanggal()
        {
            const string sql = @"SELECT DISTINCT tanggal 
                                FROM tb_booking 
                                WHERE CAST(tanggal AS DATE) <> CAST(GETDATE() AS DATE) 
                                ORDER BY tanggal ASC";
            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());

            return Conn.Query<DateTime>(sql).AsList();   
        }

    }
} 