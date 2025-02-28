using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.Input.Events;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class BookingModel
    {
        public int id_booking { get; set; } //aa
        public string no_ktp_pelanggan { get; set; } //bb
        public string? no_ktp_mekanik { get; set; }  //cc
        public int id_kendaraan { get; set; } //dd
        public int? id_jasa_servis { get; set; } //ee
        public int? id_penggunaan_sparepart { get; set; } //ff
        public List<string> nama_sparepart { get; set; } //gg

        public string nama_pelanggan { get; set; }
        public string no_hp { get; set; }
        public string no_polisi { get; set; }
        public string merek {  get; set; }
        public int transmisi { get; set; }
        public int kapasitas_mesin { get;set; }

        public string nama_kendaraan { get; set; }

        public DateTime tanggal { get; set; }
        public int antrean { get; set; }
        public string keluhan { get; set; } 
        public int status { get; set; } //menunggu=1, dikerjakan=2, selesai=3, dibatalkan=4
        public DateTime created_at { get; set; }
    }
}
 