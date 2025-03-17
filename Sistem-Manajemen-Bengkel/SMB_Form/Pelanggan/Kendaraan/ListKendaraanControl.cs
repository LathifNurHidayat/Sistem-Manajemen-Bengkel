using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan
{
    public partial class ListKendaraanControl : UserControl
    {
        private KendaraanModel _kendaraan;
        private int borderRadius = 18; 
        private int shadowSize = 6;

        public ListKendaraanControl(KendaraanModel kendaraan)
        {
            InitializeComponent();

            _kendaraan = kendaraan;
            this.BackColor = Color.Transparent; // Supaya shadow bisa terlihat
            this.Paint += UC_KendaraanItem_Paint;
            TampilkanData();
        }

        private void TampilkanData()
        {
          

        }

        // Membuat sudut melengkung + shadow
        private void UC_KendaraanItem_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Gambar shadow (warna hitam transparan)
            using (GraphicsPath shadowPath = GetRoundedRectanglePath(shadowSize))
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(60, Color.Black)))
            {
                g.FillPath(shadowBrush, shadowPath);
            }

            // Gambar UserControl dengan warna putih
            using (GraphicsPath controlPath = GetRoundedRectanglePath(0))
            using (SolidBrush controlBrush = new SolidBrush(Color.White))
            {
                g.FillPath(controlBrush, controlPath);
            }

            this.Region = new Region(GetRoundedRectanglePath(0)); 
        }

        // Membuat bentuk sudut melengkung
        private GraphicsPath GetRoundedRectanglePath(int offset)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(offset, offset, borderRadius * 2, borderRadius * 2, 180, 90);
            path.AddArc(this.Width - (borderRadius * 2) - offset, offset, borderRadius * 2, borderRadius * 2, 270, 90);
            path.AddArc(this.Width - (borderRadius * 2) - offset, this.Height - (borderRadius * 2) - offset, borderRadius * 2, borderRadius * 2, 0, 90);
            path.AddArc(offset, this.Height - (borderRadius * 2) - offset, borderRadius * 2, borderRadius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
