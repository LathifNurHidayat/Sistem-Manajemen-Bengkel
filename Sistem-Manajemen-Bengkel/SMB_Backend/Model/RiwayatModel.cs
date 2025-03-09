using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class RiwayatModel
    {
        public int id_riwayat { get; set; }//aa
        public int id_jasa_servis { get; set; }//bb
        public string no_ktp_pelanggan { get; set; }//cc
        public string no_ktp_pegawai { get; set; }//dd
        public string no_ktp_mekanik { get; set; }//ee
        public int id_kendaraan { get; set; }//ff
        public int id_penggunaan_sparepart { get; set; }//gg

        public string jenis_servis { get; set; }
        public string nama_pegawai { get; set; }
        public string nama_mekanik { get; set; }
        public string nama_sparepart { get; set; }

        public string nama_pelanggan { get; set; }
        public string no_polisi { get; set; }
        public string merek { get; set; }
        public int transmisi { get; set; }
        public int kapasitas_mesin { get; set; }
        public string nama_kendaraan { get; set; }

        public DateTime tanggal { get; set; }
        public string keluhan { get; set; }
        public string catatan { get; set; }
        public decimal total_biaya { get; set; }
        public int status { get; set; } //1 = Selesai, 2 = Dibatalkan
    }
}
