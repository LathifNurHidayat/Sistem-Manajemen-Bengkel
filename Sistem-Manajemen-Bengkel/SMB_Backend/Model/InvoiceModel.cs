using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class InvoiceModel
    {
        public string nama_bengkel { get; set; }
        public string alamat_bengkel { get; set; }
        public string email_bengkel { get; set; }
        public string no_telp_bengkel { get; set; }
        public DateTime tanggal { get; set; }


        public string nama_pelanggan { get; set; }
        public string nama_kendaraan { get; set; }
        public string no_polisi { get; set; }
        public int antrean { get; set; }


        public string barang_jasa { get; set; } // Untuk menyimpan data apa saja jasa / sparepart yang dipilih
        public string quantity { get; set; }
        public decimal harga { get; set; }


        public decimal total_biaya_servis { get; set; }
        public string catatan { get; set; }

    }
}
