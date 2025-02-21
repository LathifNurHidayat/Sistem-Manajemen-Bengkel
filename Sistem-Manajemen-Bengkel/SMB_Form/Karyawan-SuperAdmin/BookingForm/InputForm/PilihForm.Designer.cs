namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    partial class PilihForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonTamu = new SMB_CustomTolbox.LathifButton();
            label1 = new Label();
            ButtonPelanggan = new SMB_CustomTolbox.LathifButton();
            SuspendLayout();
            // 
            // ButtonTamu
            // 
            ButtonTamu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonTamu.BackColor = Color.FromArgb(157, 178, 191);
            ButtonTamu.BackgroundColor = Color.FromArgb(157, 178, 191);
            ButtonTamu.BorderColor = Color.DarkGray;
            ButtonTamu.BorderRadius = 5;
            ButtonTamu.BorderSize = 0;
            ButtonTamu.FlatAppearance.BorderSize = 0;
            ButtonTamu.FlatStyle = FlatStyle.Flat;
            ButtonTamu.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonTamu.ForeColor = Color.White;
            ButtonTamu.Location = new Point(289, 131);
            ButtonTamu.Name = "ButtonTamu";
            ButtonTamu.Size = new Size(229, 73);
            ButtonTamu.TabIndex = 5;
            ButtonTamu.Text = "Tamu (Guest)";
            ButtonTamu.TextColor = Color.White;
            ButtonTamu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 44);
            label1.Name = "label1";
            label1.Size = new Size(481, 36);
            label1.TabIndex = 6;
            label1.Text = "Untuk siapa Anda akan membuat data booking?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonPelanggan
            // 
            ButtonPelanggan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonPelanggan.BackColor = Color.FromArgb(82, 109, 130);
            ButtonPelanggan.BackgroundColor = Color.FromArgb(82, 109, 130);
            ButtonPelanggan.BorderColor = Color.DarkGray;
            ButtonPelanggan.BorderRadius = 5;
            ButtonPelanggan.BorderSize = 0;
            ButtonPelanggan.FlatAppearance.BorderSize = 0;
            ButtonPelanggan.FlatStyle = FlatStyle.Flat;
            ButtonPelanggan.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonPelanggan.ForeColor = Color.White;
            ButtonPelanggan.Location = new Point(37, 131);
            ButtonPelanggan.Name = "ButtonPelanggan";
            ButtonPelanggan.Size = new Size(229, 73);
            ButtonPelanggan.TabIndex = 7;
            ButtonPelanggan.Text = "Pelanggan";
            ButtonPelanggan.TextColor = Color.White;
            ButtonPelanggan.UseVisualStyleBackColor = false;
            // 
            // MainInputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 229);
            Controls.Add(ButtonPelanggan);
            Controls.Add(label1);
            Controls.Add(ButtonTamu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainInputForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        #endregion
        private ToolStripMenuItem jurusanToolStripMenuItem;
        private ToolStripMenuItem mataPelajaranToolStripMenuItem;
        private ToolStripMenuItem kelasToolStripMenuItem;
        private ToolStripMenuItem guruToolStripMenuItem;
        private ToolStripMenuItem jadwalPelajaranToolStripMenuItem;
        private ToolStripMenuItem dataIndukSiswaToolStripMenuItem;
        private ToolStripMenuItem kelasSiswaToolStripMenuItem;
        private ToolStripMenuItem absensiToolStripMenuItem;
        private SMB_CustomTolbox.LathifButton ButtonTamu;
        private Label label1;
        private SMB_CustomTolbox.LathifButton ButtonPelanggan;
    }
}