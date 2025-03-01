using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class BookingSparepartModel
    {
        public int id_booking_sparepart { get; set; }
        public int id_sparepart { get; set; }
        public string nama_sparepart { get; set; }
        public int stok {  get; set; }
        public int jumlah { get; set; }
        public decimal harga { get; set; }
        public decimal total_harga { get; set; }//harga as total_harga
    }
}
