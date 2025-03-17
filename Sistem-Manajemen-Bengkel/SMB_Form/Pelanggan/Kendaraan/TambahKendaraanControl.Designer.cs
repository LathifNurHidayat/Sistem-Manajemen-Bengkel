using Sistem_Manajemen_Bengkel.SMB_CustomTolbox;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan
{
    partial class TambahKendaraanControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTambah = new LathifButton();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.Anchor = AnchorStyles.None;
            btnTambah.BackColor = Color.FromArgb(241, 147, 16);
            btnTambah.BackgroundColor = Color.FromArgb(241, 147, 16);
            btnTambah.BorderColor = Color.PaleVioletRed;
            btnTambah.BorderRadius = 10;
            btnTambah.BorderSize = 0;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambah.ForeColor = Color.White;
            btnTambah.ImageAlign = ContentAlignment.MiddleRight;
            btnTambah.Location = new Point(223, 17);
            btnTambah.Margin = new Padding(3, 4, 3, 4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(1183, 100);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "   Tambah Kendaraan";
            btnTambah.TextColor = Color.White;
            btnTambah.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // TambahKendaraanControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnTambah);
            Margin = new Padding(0);
            Name = "TambahKendaraanControl";
            Size = new Size(1634, 140);
            ResumeLayout(false);
        }

        #endregion
        private LathifButton btnTambah;
    }
}
