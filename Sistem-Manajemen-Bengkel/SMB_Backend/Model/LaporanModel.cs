using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class LaporanModel
    {
        public DateTime tanggal { get; set; }
        public string no_ktp_pelanggan { get; set; } 
        public string nama_pelanggan { get; set; } 
        public string nama_kendaraan { get; set; }


        public string nama_petugas { get; set; }
        public string nama_mekanik { get; set; }
        public string jasa_servis { get; set; }
        public string nama_sparepart { get; set; }


        public string keluhan { get; set; }
        public string catatan { get; set; }
        public decimal total_biaya { get; set; }
        public int status { get; set; } //1 = Selesai, 2 = Dibatalkan
    }
}
