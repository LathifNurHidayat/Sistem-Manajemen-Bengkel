using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class MekanikModel
    {
        public string no_ktp_mekanik { get; set; }  
        public string nama_mekanik { get; set; }
        public string no_hp { get; set; }
        public string alamat { get; set; }
        public string spesialis { get; set; }
        public byte[] image_data { get; set; }
        public DateTime created_at { get; set; } 
        public DateTime updated_at { get; set; } 
        public DateTime deleted_at { get; set; }
    }
}
