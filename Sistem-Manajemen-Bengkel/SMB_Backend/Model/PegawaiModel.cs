﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class PegawaiModel
    {
        public string no_ktp_pegawai { get; set; }
        public string nama_pegawai { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string no_hp { get; set; }
        public string alamat { get; set; }
        public int role { get; set; } // 1=Super Admin , 2 = Petugas 
        public byte[]? image_data { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}