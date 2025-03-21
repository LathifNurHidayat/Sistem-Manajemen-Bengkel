﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Helper
{
    public class CustomComponentHelper
    {
        public static void CustomPanel(Panel panel)
        {
            panel.SizeChanged += (s, e) =>
            {
                int cornerRadius = 20;
                GraphicsPath path = new GraphicsPath();

                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // kiri atas
                path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // kanan atas
                path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // kanan bawah
                path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // kiri bawah
                path.CloseAllFigures();

                panel.Region = new Region(path);
            };
        }

        public static void CustomDataGrid(DataGridView grid) 
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
              BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
              null, grid, new object[] { true });

            grid.BackgroundColor = Color.White;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.Gainsboro;
            grid.BorderStyle = BorderStyle.FixedSingle;

            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // mengatur warna header kolom
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(83, 92, 145);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(83, 92, 145);
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.ForeColor = Color.DimGray;

            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(221, 230, 237);
            grid.DefaultCellStyle.SelectionForeColor = grid.DefaultCellStyle.ForeColor;

            grid.ColumnHeadersHeight = 40;
            grid.RowTemplate.Height = 55;
            grid.RowHeadersVisible = false;
            grid.AllowUserToOrderColumns = false;
            grid.AllowUserToResizeColumns = true;
            grid.AllowUserToResizeRows = false;
            grid.AllowUserToAddRows = false;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            grid.ReadOnly = true;
            grid.MultiSelect = false;

            grid.RowPrePaint += (s, e) =>
            {
                if (e.RowIndex % 2 == 0) // Baris genap (putih)
                {
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
                else // Baris ganjil (abu-abu)
                {
                    grid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(251, 251, 251);
                }
            };
        }
         
        public static void CustomComboBox(ComboBox comboBox)
        {
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = Color.White;
            comboBox.ForeColor = Color.Black;
            comboBox.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox.ItemHeight = 25;

            // Menggambar ulang item
            comboBox.DrawItem += (s, e) =>
            {
                if (e.Index < 0) return;

                e.DrawBackground();
                bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                Color bgColor = isSelected ? Color.LightBlue : Color.White;
                Color textColor = isSelected ? Color.White : Color.Black;

                using (SolidBrush bgBrush = new SolidBrush(bgColor))
                    e.Graphics.FillRectangle(bgBrush, e.Bounds);

                using (SolidBrush textBrush = new SolidBrush(textColor))
                    e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds);

                e.DrawFocusRectangle();
            };

            comboBox.MouseEnter += (s, e) => comboBox.BackColor = Color.LightGray;
            comboBox.MouseLeave += (s, e) => comboBox.BackColor = Color.White;
        }
    }
}
