using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class RiwayatModel
    {
        public int id_riwayat { get; set; }
        public int id_jasa_servis { get; set; }
        public string no_ktp { get; set; }
        public int id_kendaraan { get; set; }
        public int id_riwayat_sparepart { get; set; }
        public int id_petugas { get; set; }
        public DateTime tanggal { get; set; }
        public string keluhan { get; set; }
        public string catatan { get; set; }
        public decimal total_biaya { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}