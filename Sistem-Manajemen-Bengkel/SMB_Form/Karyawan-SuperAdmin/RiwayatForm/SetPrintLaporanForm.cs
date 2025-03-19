using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.RiwayatForm
{
    public partial class SetPrintLaporanForm : Form
    {
        private readonly LaporanDal _laporanDal;
        public SetPrintLaporanForm()
        {
            InitializeComponent();
            _laporanDal = new LaporanDal();
            this.MinimizeBox = false;
            this.MaximizeBox = false;   

            PickerRentan_1.Culture = new System.Globalization.CultureInfo("id-ID");
            PickerRentan_2.Culture = new System.Globalization.CultureInfo("id-ID");

            PickerRentan_1.Value = DateTime.Today;
            PickerRentan_2.Value = DateTime.Today;

            ButtonSimpan.Click += ButtonSimpan_Click;
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            DateTime tanggal_1 = PickerRentan_1.Value ?? DateTime.Today;
            DateTime tanggal_2 = PickerRentan_2.Value ?? DateTime.Today;

            InvoiceLaporanHelper.GenerateLaporan(tanggal_1, tanggal_2);
        }
    }
}
