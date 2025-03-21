﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class KendaraanModel
    {
        public int id_kendaraan { get; set; }
        public string no_ktp_pelanggan { get; set; }
        
        public string nama_pelanggan { get; set; }  

        public string no_polisi { get; set; }
        public string merek { get; set; }
        public int transmisi { get; set; } //1 = Otomatis, 2=Manual
        public int kapasitas_mesin { get; set; }
        public int tahun { get; set; }
        public DateTime? terakhir_servis { get; set; }   
    }
}