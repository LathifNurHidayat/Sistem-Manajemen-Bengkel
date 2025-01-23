using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class UserModel
    {
        public int id_user { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public int role { get; set; }
    }
}
