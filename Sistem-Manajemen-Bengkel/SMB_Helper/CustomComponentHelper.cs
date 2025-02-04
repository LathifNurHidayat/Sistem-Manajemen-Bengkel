using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Helper
{
    public class CustomComponentHelper
    {
        public static void CustomPanel(Panel panel)
        {
            int cornerRadius = 10;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // kiri atas
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // kanan atas
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // kanan bawah
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // kiri bawah
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }


        public static void CustomDataGrid(DataGridView grid)
        {
            DataGridView grid = grid;
            grid.BackgroundColor = Color.White;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            // Mengatur ukuran font header kolom
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Mengatur warna header kolom
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.ForeColor = Color.DimGray;


            // Menonaktifkan warna seleksi untuk sel
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 240, 240);
            grid.DefaultCellStyle.SelectionForeColor = grid.DefaultCellStyle.ForeColor;

            grid.ColumnHeadersHeight = 40;
            grid.RowTemplate.Height = 55;

            grid.RowHeadersVisible = false;

            // Mencegah penggeseran kolom
            grid.AllowUserToOrderColumns = false;

            // Mencegah pengubahan ukuran kolom
            grid.AllowUserToResizeColumns = true;

            // Mencegah pengubahan ukuran baris
            grid.AllowUserToResizeRows = false;

            // Mencegah penambahan baris baru
            grid.AllowUserToAddRows = false;

            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
        }
    }
}
