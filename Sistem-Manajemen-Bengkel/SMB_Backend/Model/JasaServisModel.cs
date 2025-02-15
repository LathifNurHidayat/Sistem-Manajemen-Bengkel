using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class JasaServisModel
    {
        public int id_jasa_servis { get; set; }
        public string jenis_servis { get; set; }
        public string keterangan { get; set; }
        public decimal biaya { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}