namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.RiwayatForm
{
    partial class SetPrintLaporanForm
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
            panel1 = new Panel();
            label2 = new Label();
            PickerRentan_2 = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            PickerRentan_1 = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PickerRentan_2);
            panel1.Controls.Add(PickerRentan_1);
            panel1.Controls.Add(ButtonSimpan);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 314);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 116);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 98;
            label2.Text = "Dari tanggal         :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PickerRentan_2
            // 
            PickerRentan_2.AllowNull = true;
            PickerRentan_2.BackColor = Color.White;
            PickerRentan_2.DateTimeIcon = null;
            PickerRentan_2.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerRentan_2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PickerRentan_2.Format = "dddd,  dd MMMM yyyy";
            PickerRentan_2.Location = new Point(192, 170);
            PickerRentan_2.Name = "PickerRentan_2";
            PickerRentan_2.Size = new Size(290, 38);
            PickerRentan_2.TabIndex = 96;
            PickerRentan_2.ToolTipText = "";
            PickerRentan_2.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // PickerRentan_1
            // 
            PickerRentan_1.AllowNull = true;
            PickerRentan_1.BackColor = Color.White;
            PickerRentan_1.DateTimeIcon = null;
            PickerRentan_1.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerRentan_1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PickerRentan_1.Format = "dddd,  dd MMMM yyyy";
            PickerRentan_1.Location = new Point(192, 112);
            PickerRentan_1.Name = "PickerRentan_1";
            PickerRentan_1.Size = new Size(290, 38);
            PickerRentan_1.TabIndex = 95;
            PickerRentan_1.ToolTipText = "";
            PickerRentan_1.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSimpan.BackColor = Color.SlateBlue;
            ButtonSimpan.BackgroundColor = Color.SlateBlue;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(289, 240);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(193, 45);
            ButtonSimpan.TabIndex = 94;
            ButtonSimpan.Text = "📥 Simpan Laporan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(460, 36);
            label1.TabIndex = 93;
            label1.Text = "Silakan Pilih Rentang Tanggal\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 174);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 99;
            label3.Text = "Hingga tanggal    :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SetPrintLaporanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(540, 338);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SetPrintLaporanForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerRentan_2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerRentan_1;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}