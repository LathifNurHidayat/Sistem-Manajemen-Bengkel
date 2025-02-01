using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.Input.Events;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class BookingModel
    {
        public int id_booking { get; set; }
        public int no_ktp { get; set; }
        public string username { get; set; }
        public DateTime tanggal { get; set; }
        public int antrean { get; set; }
        public string keluhan { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}