using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class JamKerjaModel
    {
        public int id_jam_kerja { get; set; }
        public string hari { get; set; }
        public TimeSpan? jam_buka { get; set; }
        public TimeSpan? jam_tutup { get; set; }
    }
}
