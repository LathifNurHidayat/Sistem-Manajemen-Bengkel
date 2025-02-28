using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class PenggunaanSparepartModel
    {
        public int id_penggunaan_sparepart { get; set; }
        public int id_sparepart { get; set; }
        public int jumlah { get; set; }
        public decimal harga { get; set; }
    }
}