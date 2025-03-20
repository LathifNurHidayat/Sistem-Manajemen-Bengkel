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
    public class LaporanDal
    {
        public IEnumerable<LaporanModel?> ListLaporan(DateTime tanggal_1, DateTime tanggal_2)
        {
            const string sql = @"SELECT
                                    CAST(rw.tanggal AS DATE) AS tanggal,
                                    pl.no_ktp_pelanggan,
                                    COALESCE(pl.nama_pelanggan, rw.nama_pelanggan) AS nama_pelanggan,
                                    CASE 
                                        WHEN (rw.no_polisi IS NULL OR rw.no_polisi = '') AND (rw.merek IS NULL OR rw.merek = '')
                                            THEN CONCAT(kd.no_polisi, ', ', kd.merek)
                                        ELSE CONCAT(rw.no_polisi, ', ', rw.merek)
                                    END AS nama_kendaraan,
                                    pg.nama_pegawai AS nama_petugas,
                                    mk.nama_mekanik,
                                    js.jenis_servis AS jasa_servis,
                                    COALESCE(STRING_AGG(sp.nama_sparepart, ', '), ' ') AS nama_sparepart,
                                    rw.keluhan,
                                    rw.catatan,
                                    rw.total_biaya,
                                    rw.status
                                FROM tb_riwayat rw 
                                LEFT JOIN tb_pelanggan pl ON rw.no_ktp_pelanggan = pl.no_ktp_pelanggan 
                                LEFT JOIN tb_kendaraan kd ON rw.id_kendaraan = kd.id_kendaraan
                                LEFT JOIN tb_pegawai pg ON rw.no_ktp_pegawai = pg.no_ktp_pegawai
                                LEFT JOIN tb_mekanik mk ON rw.no_ktp_mekanik = mk.no_ktp_mekanik
                                LEFT JOIN tb_jasa_servis js ON rw.id_jasa_servis = js.id_jasa_servis
                                LEFT JOIN tb_penggunaan_sparepart ps ON rw.id_penggunaan_sparepart = ps.id_penggunaan_sparepart
                                LEFT JOIN tb_sparepart sp ON ps.id_sparepart = sp.id_sparepart
                                WHERE rw.tanggal BETWEEN CAST(@tanggal_1 AS DATE) AND CAST(@tanggal_2 AS DATE)
                                GROUP BY
                                    rw.tanggal,
                                    pl.no_ktp_pelanggan,
                                    COALESCE(pl.nama_pelanggan, rw.nama_pelanggan),
                                    CASE  
                                        WHEN (rw.no_polisi IS NULL OR rw.no_polisi = '') AND (rw.merek IS NULL OR rw.merek = '')
                                            THEN CONCAT(kd.no_polisi, ', ', kd.merek)
                                        ELSE CONCAT(rw.no_polisi, ', ', rw.merek)
                                    END,
                                    pg.nama_pegawai,
                                    mk.nama_mekanik,
                                    js.jenis_servis,
                                    rw.keluhan,
                                    rw.catatan,
                                    rw.total_biaya,
                                    rw.status";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return Conn.Query<LaporanModel>(sql , new { tanggal_1 , tanggal_2  });
        }
    }
}
