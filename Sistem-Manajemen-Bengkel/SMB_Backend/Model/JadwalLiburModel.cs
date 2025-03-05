using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class JadwalLiburModel
    {
        public int id_jadwal_libur { get; set; }
        public DateTime? tanggal_libur { get; set; }
        public string? hari { get; set; }
        public int is_libur { get; set; }

    }
}
