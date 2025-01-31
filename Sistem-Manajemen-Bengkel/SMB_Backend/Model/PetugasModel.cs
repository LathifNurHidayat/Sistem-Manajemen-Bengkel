using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class PetugasModel
    {
        public int id_petugas { get; set; }
        public string nama_petugas { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string no_hp { get; set; }
        public string alamat { get; set; }
        public string role { get; set; }
    }
}