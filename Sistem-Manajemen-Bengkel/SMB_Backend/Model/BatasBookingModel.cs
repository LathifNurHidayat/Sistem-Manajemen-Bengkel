using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class BatasBookingModel
    {
        public int id_batas_booking { get; set; }
        public DateTime? tanggal { get; set; }
        public int batas_booking { get; set; }
    }
}
