using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class InvoiceDal
    {
        public InvoiceModel? GetInvoice(int idBooking)
        {   
            const string sql = @"SELECT 
                                    b.id_booking, 
                                    p.nama_pelanggan, 
                                    k.merek AS nama_kendaraan, 
                                    k.no_polisi, 
                                    b.antrean, 
                                    js.jenis_servis AS jasa_servis,
                                    js.biaya AS biaya_jasa,

                                    STRING_AGG(sp.nama_sparepart, ',') AS sparepart, 
                                    STRING_AGG(CAST(ps.jumlah AS VARCHAR), ',') AS quantity,
                                    STRING_AGG(CAST(CAST(ps.harga AS INT) AS VARCHAR), ',') AS harga_sparepart,

                                    (js.biaya + ISNULL(SUM(sp.harga * ps.jumlah), 0)) AS total_biaya_servis,

                                    b.catatan,
                                    ib.nama_bengkel,
                                    ib.alamat AS alamat_bengkel,
                                    ib.email AS email_bengkel,
                                    ib.no_telp AS no_telp_bengkel,
                                    b.tanggal
                                FROM tb_booking b
                                JOIN tb_pelanggan p ON b.no_ktp_pelanggan = p.no_ktp_pelanggan
                                JOIN tb_kendaraan k ON b.id_kendaraan = k.id_kendaraan
                                JOIN tb_jasa_servis js ON b.id_jasa_servis = js.id_jasa_servis
                                LEFT JOIN tb_penggunaan_sparepart ps ON b.id_booking = ps.id_penggunaan_sparepart
                                LEFT JOIN tb_sparepart sp ON ps.id_sparepart = sp.id_sparepart
                                CROSS JOIN tb_informasi_bengkel ib
                                WHERE b.id_booking = @idBooking AND b.status = 3
                                GROUP BY 
                                    b.id_booking, p.nama_pelanggan, k.merek, k.no_polisi, b.antrean, 
                                    js.jenis_servis, js.biaya, 
                                    b.catatan, ib.nama_bengkel, 
                                    ib.alamat, ib.email, ib.no_telp, b.tanggal ";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<InvoiceModel>(sql, new { idBooking });
        }
    }
}