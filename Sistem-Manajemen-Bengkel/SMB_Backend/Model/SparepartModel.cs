using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class SparepartModel
    {
        public int id_sparepart { get; set; }
        public string nama_sparepart { get; set; }
        public decimal harga { get; set; }
        public int stok { get; set; }
        public int stok_minimal { get; set; }
        public int status_stok { get; set; } // 0=habis, 1=menipis , 2=tersedia
        public byte[] image_data { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}