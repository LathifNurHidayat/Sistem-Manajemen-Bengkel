using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class PelangganModel
    {
        public string no_ktp_pelanggan { get; set;}
        public string nama_pelanggan { get; set; }
        public string no_hp { get; set; }
        public string alamat { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int total_servis { get; set; }   
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}