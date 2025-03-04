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
        /*  public IEnumerable<RiwayatModel> ListData(string filter, object Dp)
          {
              string sql = @$"SELECT 
                          aa.id_riwayat, 
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
                      LEFT JOIN tb_jasa_servis bb ON aa.id_jasa_servis = bb.id_jasa_servis
                      LEFT JOIN tb_pelanggan cc ON aa.no_ktp_pelanggan = cc.no_ktp_pelanggan
                      LEFT JOIN tb_pegawai dd ON aa.no_ktp_pegawai = dd.no_ktp_pegawai
                      LEFT JOIN tb_mekanik ee ON aa.no_ktp_mekanik = ee.no_ktp_mekanik
                      LEFT JOIN tb_kendaraan ff ON aa.id_kendaraan = ff.id_kendaraan
                      LEFT JOIN tb_penggunaan_sparepart gg ON aa.id_penggunaan_sparepart = gg.id_penggunaan_sparepart
                      LEFT JOIN tb_sparepart hh ON gg.id_sparepart = hh.id_sparepart
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
                      ORDER BY aa.tanggal DESC
                      OFFSET @offset ROWS FETCH NEXT @fetch ROWS ONLY"; // Pastikan tidak ada spasi atau karakter tambahan

              using var Conn = new SqlConnection(ConnStringHelper.GetConn());
              return Conn.Query<RiwayatModel>(sql, Dp);
          }*/

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
    }
}
