using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Dapper;
using System.Runtime.Intrinsics.Arm;
using System.Data;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public   class RiwayatDal
    {
        public IEnumerable<RiwayatModel> ListData(string filter, object Dp)
        {
            string sql = @$"SELECT 
                        bb.jenis_servis,
                        COALESCE(cc.nama_pelanggan, aa.nama_pelanggan) AS nama_pelanggan,
                        COALESCE(cc.no_ktp_pelanggan, aa.no_ktp_pelanggan) AS no_ktp_pelanggan,  
                        COALESCE(ff.no_polisi, aa.no_polisi) AS no_polisi,       
                        ISNULL(dd.nama_pegawai, '') AS nama_pegawai, 
                        ISNULL(ee.nama_mekanik, '') AS nama_mekanik, 
                        CASE 
                            WHEN (aa.merek IS NULL OR aa.merek = '') AND (aa.kapasitas_mesin IS NULL OR aa.kapasitas_mesin = '')
                            THEN CONCAT(ff.merek, ' ', ff.kapasitas_mesin, 'cc') 
                            ELSE CONCAT(aa.merek, ' ', aa.kapasitas_mesin, 'cc') 
                        END AS nama_kendaraan,
                        aa.tanggal, 
                        aa.keluhan, 
                        aa.catatan, 
                        aa.total_biaya, 
                        aa.status
                    FROM tb_riwayat aa
                    LEFT JOIN tb_jasa_servis bb 
                        ON aa.id_jasa_servis = bb.id_jasa_servis
                    LEFT JOIN tb_pelanggan cc
                        ON aa.no_ktp_pelanggan = cc.no_ktp_pelanggan
                    LEFT JOIN tb_pegawai dd
                        ON aa.no_ktp_pegawai = dd.no_ktp_pegawai
                    LEFT JOIN tb_mekanik ee 
                        ON aa.no_ktp_mekanik = ee.no_ktp_mekanik
                    LEFT JOIN tb_kendaraan ff
                        ON aa.id_kendaraan = ff.id_kendaraan
                    {filter}
                    GROUP BY 
                        aa.id_riwayat, 
                        bb.jenis_servis, 
                        cc.nama_pelanggan, 
                        cc.no_ktp_pelanggan, 
                        ff.no_polisi,
                        dd.nama_pegawai, 
                        ee.nama_mekanik, 
                        aa.merek, 
                        aa.kapasitas_mesin, 
                        ff.merek, 
                        ff.kapasitas_mesin,
                        aa.tanggal, 
                        aa.keluhan, 
                        aa.catatan, 
                        aa.total_biaya, 
                        aa.status,
                        aa.nama_pelanggan, 
                        aa.no_ktp_pelanggan, 
                        aa.no_polisi
                    ORDER BY 
                        aa.tanggal DESC
                    OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<RiwayatModel>(sql, Dp);
        }


        public int CountData(string filter, object Dp)
        {
            string sql = @$"SELECT 
                                COUNT(aa.id_riwayat)
                            FROM tb_riwayat aa
                            LEFT JOIN tb_jasa_servis bb 
                                ON aa.id_jasa_servis = bb.id_jasa_servis
                            LEFT JOIN tb_pelanggan cc
                                ON aa.no_ktp_pelanggan = cc.no_ktp_pelanggan
                            LEFT JOIN tb_pegawai dd
                                ON aa.no_ktp_pegawai = dd.no_ktp_pegawai
                            LEFT JOIN tb_mekanik ee 
                                ON aa.no_ktp_mekanik = ee.no_ktp_mekanik
                            LEFT JOIN tb_kendaraan ff
                                ON aa.id_kendaraan = ff.id_kendaraan
                                {filter}";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.ExecuteScalar<int>(sql, Dp);
        }


        public void InsertData(RiwayatModel riwayat)
        {
            const string sql = @"DECLARE @biaya_servis DECIMAL(18,2) = 0;
                                DECLARE @biaya_sparepart DECIMAL(18,2) = 0;
                                DECLARE @total_biaya DECIMAL(18,2) = 0;

                                IF @status <> 4
                                BEGIN 
                                    SELECT @biaya_servis = COALESCE(biaya, 0) FROM tb_jasa_servis WHERE id_jasa_servis = @id_jasa_servis;
                                    SELECT @biaya_sparepart = COALESCE(SUM(harga), 0) FROM tb_penggunaan_sparepart WHERE id_penggunaan_sparepart = @id_penggunaan_sparepart;
        
                                    SET @total_biaya = @biaya_servis + @biaya_sparepart;
                                END

                                INSERT INTO tb_riwayat (
                                    id_jasa_servis,
                                    no_ktp_pelanggan,
                                    no_ktp_pegawai,
                                    no_ktp_mekanik,
                                    id_kendaraan,
                                    id_penggunaan_sparepart,
                                    nama_pelanggan,
                                    no_polisi,
                                    merek,
                                    transmisi,
                                    kapasitas_mesin,
                                    tanggal,
                                    keluhan,
                                    catatan,
                                    total_biaya,
                                    status
                                ) 
                                VALUES (
                                    @id_jasa_servis,
                                    @no_ktp_pelanggan,
                                    @no_ktp_pegawai,
                                    @no_ktp_mekanik,
                                    @id_kendaraan,
                                    @id_penggunaan_sparepart,
                                    @nama_pelanggan,
                                    @no_polisi,
                                    @merek,
                                    @transmisi,
                                    @kapasitas_mesin,
                                    @tanggal,
                                    @keluhan,
                                    @catatan,
                                    @total_biaya,
                                    @status)";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            var Dp = new DynamicParameters();

            Dp.Add("@no_ktp_pelanggan", riwayat.no_ktp_pelanggan);
            Dp.Add("@no_ktp_pegawai", riwayat.no_ktp_pegawai);
            Dp.Add("@no_ktp_mekanik", riwayat.no_ktp_mekanik);
            Dp.Add("@id_kendaraan", riwayat.id_kendaraan);
            Dp.Add("@id_jasa_servis", riwayat.status == 4 ? (object)DBNull.Value : riwayat.id_jasa_servis);
            Dp.Add("@id_penggunaan_sparepart", riwayat.status == 4 ? (object)DBNull.Value : riwayat.id_penggunaan_sparepart);
            Dp.Add("@nama_pelanggan", riwayat.nama_pelanggan); 
            Dp.Add("@no_polisi", riwayat.no_polisi);
            Dp.Add("@merek", riwayat.merek);
            Dp.Add("@transmisi", riwayat.transmisi);
            Dp.Add("@kapasitas_mesin", riwayat.kapasitas_mesin); 
            Dp.Add("@tanggal", DateTime.Today);
            Dp.Add("@keluhan", riwayat.keluhan);
            Dp.Add("@catatan", riwayat.catatan);
            Dp.Add("@status", riwayat.status);

            Conn.Execute(sql, Dp);
        }


        public IEnumerable<RiwayatModel> ListDataWhereNoKtp (string no_ktp_pelanggan)
        {
            const string sql = @"SELECT 
                                    rw.tanggal,
                                    CONCAT(kd.no_polisi, ' - ', kd.merek) AS kendaraan,
                                    rw.keluhan,
                                    pg.nama_pegawai,
                                    mk.nama_mekanik,
                                    COALESCE(STRING_AGG(sp.nama_sparepart, ', '), '-') AS nama_sparepart,
                                    rw.catatan,
                                    rw.total_biaya,
                                    rw.status
                                FROM tb_riwayat rw
                                LEFT JOIN tb_kendaraan kd ON rw.id_kendaraan = kd.id_kendaraan
                                LEFT JOIN tb_pegawai pg ON pg.no_ktp_pegawai = rw.no_ktp_pegawai
                                LEFT JOIN tb_mekanik mk ON mk.no_ktp_mekanik = rw.no_ktp_mekanik
                                LEFT JOIN tb_penggunaan_sparepart ps ON ps.id_penggunaan_sparepart = rw.id_penggunaan_sparepart
                                LEFT JOIN tb_sparepart sp ON sp.id_sparepart = ps.id_sparepart
                                WHERE rw.no_ktp_pelanggan = @no_ktp_pelanggan
                                GROUP BY 
                                    rw.tanggal, kd.no_polisi, kd.merek, rw.keluhan, pg.nama_pegawai, 
                                    mk.nama_mekanik, rw.catatan, rw.total_biaya, rw.status
                                ORDER BY 
                                    rw.tanggal DESC";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<RiwayatModel>(sql, new { no_ktp_pelanggan });
        }
    }
}
