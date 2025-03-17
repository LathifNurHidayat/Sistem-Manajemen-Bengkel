using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan
{
    public partial class TambahKendaraanControl : UserControl
    {
        public TambahKendaraanControl()
        {
            InitializeComponent();

            btnTambah.Click += ButtonTambahKendaraan_Click;
        }


        private void ButtonTambahKendaraan_Click(object sender, EventArgs e)
        {
            using var editInputForm = new EditInputKendaraanForm(0);
            if (editInputForm.ShowDialog() == DialogResult.OK)
            {
                KendaraanControl.LoadData();
            }
        }
    }
}
