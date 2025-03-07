using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Model
{
    public class InvoiceModel
    {
        public string nama_bengkel { get; set; }
        public string alamat_bengkel { get; set; }
        public string email_bengkel { get; set; }
        public string no_telp_bengkel { get; set; }
        public DateTime tanggal { get; set; }


        public string nama_pelanggan { get; set; }
        public string nama_kendaraan { get; set; }
        public string no_polisi { get; set; }
        public int antrean { get; set; }


        public string jasa_servis { get; set; } 
        public decimal biaya_jasa { get; set; }


        public string? sparepart { get; set; }  
        public string? quantity { get; set; }   
        public string? harga_sparepart { get; set; }

        public List<string> List_sparepart => !string.IsNullOrEmpty(sparepart)
                                            ? sparepart.Contains(",") ? sparepart.Split(",").ToList() : new List<string> { sparepart }
                                            : new List<string>();

        public List<string> List_quantity => !string.IsNullOrEmpty(quantity)
                                            ? quantity.Contains(",") ? quantity.Split(",").ToList() : new List<string> { quantity }
                                            : new List<string>();
        public List<decimal> List_harga_sparepart => !string.IsNullOrEmpty(harga_sparepart)
                                                    ? harga_sparepart.Contains(",") ? harga_sparepart.Split(",").Select(s => decimal.Parse(s)).ToList() 
                                                    : new List<decimal> {decimal.Parse(harga_sparepart)}
                                                    : new List<decimal>();


        public decimal total_biaya_servis { get; set; }
        public string catatan { get; set; }

    }
}
