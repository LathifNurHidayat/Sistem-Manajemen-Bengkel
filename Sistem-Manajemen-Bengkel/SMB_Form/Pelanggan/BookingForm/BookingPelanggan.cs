using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.BookingForm
{
    public partial class BookingPelanggan : Form
    {
        public BookingPelanggan()
        {
            InitializeComponent();
            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            panel3.Resize += Panel3_Resize;
        }

        private void Panel3_Resize(object? sender, EventArgs e)
        {
            int panelWidth = panel3.Width;
            int padding = 45;

            int calculatedWidth = (panelWidth - (3 * padding)) / 2;
            panel4.Width = Math.Max(calculatedWidth, 50); 
            panel2.Width = panel4.Width;

            panel4.Location = new Point(padding, 150);
            panel2.Location = new Point(panel4.Right + padding, 150);

            if (panel2.Right > panel3.Width)
            {
                panel2.Width = panel3.Width - panel2.Left - padding;
            }
        }

    }
}
