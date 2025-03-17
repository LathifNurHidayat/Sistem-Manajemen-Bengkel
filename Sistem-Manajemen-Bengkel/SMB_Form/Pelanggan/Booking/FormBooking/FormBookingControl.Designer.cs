namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking.FormBooking
{
    partial class FormBookingControl
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
            contextMenuStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            panel3 = new Panel();
            gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            label11 = new Label();
            label13 = new Label();
            label10 = new Label();
            label6 = new Label();
            panel12 = new Panel();
            TextMerekBooking = new TextBox();
            label5 = new Label();
            panel11 = new Panel();
            TextKapasitasMesinBooking = new TextBox();
            ComboKendaraan = new ComboBox();
            panel10 = new Panel();
            TextTahunBooking = new TextBox();
            ButtonTambahKendaraan = new SMB_CustomTolbox.LathifButton();
            panel13 = new Panel();
            TextTransmisiBooking = new TextBox();
            gradientPanelExt2 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            label17 = new Label();
            label16 = new Label();
            panel18 = new Panel();
            TextKeluhanBooking = new TextBox();
            ButtonCekKetersediaan = new SMB_CustomTolbox.LathifButton();
            PickerBookingTanggal = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            label2 = new Label();
            panel1 = new Panel();
            contextMenuStrip.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).BeginInit();
            gradientPanelExt1.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt2).BeginInit();
            gradientPanelExt2.SuspendLayout();
            panel18.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip.MetroColor = Color.FromArgb(204, 236, 249);
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(146, 36);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteToolStripMenuItem.Image = Properties.Resources.delete__1_;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(145, 32);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(gradientPanelExt2);
            panel3.Controls.Add(gradientPanelExt1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1458, 765);
            panel3.TabIndex = 49;
            // 
            // gradientPanelExt1
            // 
            gradientPanelExt1.Anchor = AnchorStyles.Top;
            gradientPanelExt1.BackColor = Color.WhiteSmoke;
            gradientPanelExt1.Border = new Padding(2);
            gradientPanelExt1.BorderGap = 2;
            gradientPanelExt1.BorderStyle = BorderStyle.None;
            gradientPanelExt1.Controls.Add(panel13);
            gradientPanelExt1.Controls.Add(ButtonTambahKendaraan);
            gradientPanelExt1.Controls.Add(panel10);
            gradientPanelExt1.Controls.Add(ComboKendaraan);
            gradientPanelExt1.Controls.Add(panel11);
            gradientPanelExt1.Controls.Add(label5);
            gradientPanelExt1.Controls.Add(panel12);
            gradientPanelExt1.Controls.Add(label6);
            gradientPanelExt1.Controls.Add(label10);
            gradientPanelExt1.Controls.Add(label13);
            gradientPanelExt1.Controls.Add(label11);
            gradientPanelExt1.CornerRadius = 10;
            gradientPanelExt1.Location = new Point(174, 140);
            gradientPanelExt1.Name = "gradientPanelExt1";
            gradientPanelExt1.Size = new Size(539, 570);
            gradientPanelExt1.TabIndex = 50;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(43, 157);
            label11.Name = "label11";
            label11.Size = new Size(65, 25);
            label11.TabIndex = 92;
            label11.Text = "Merek";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(43, 64);
            label13.Name = "label13";
            label13.Size = new Size(232, 25);
            label13.TabIndex = 91;
            label13.Text = "Pilih Kendaraan (No Polisi)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(43, 250);
            label10.Name = "label10";
            label10.Size = new Size(90, 25);
            label10.TabIndex = 93;
            label10.Text = "Transmisi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(41, 343);
            label6.Name = "label6";
            label6.Size = new Size(178, 25);
            label6.TabIndex = 94;
            label6.Text = "Kapasitas Mesin (cc)";
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel12.BackColor = Color.WhiteSmoke;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(TextMerekBooking);
            panel12.Location = new Point(43, 182);
            panel12.Name = "panel12";
            panel12.Size = new Size(455, 44);
            panel12.TabIndex = 87;
            // 
            // TextMerekBooking
            // 
            TextMerekBooking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextMerekBooking.BackColor = Color.WhiteSmoke;
            TextMerekBooking.BorderStyle = BorderStyle.None;
            TextMerekBooking.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextMerekBooking.Location = new Point(4, 10);
            TextMerekBooking.MaxLength = 100;
            TextMerekBooking.Name = "TextMerekBooking";
            TextMerekBooking.ReadOnly = true;
            TextMerekBooking.Size = new Size(437, 23);
            TextMerekBooking.TabIndex = 49;
            TextMerekBooking.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(43, 436);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 95;
            label5.Text = "Tahun";
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel11.BackColor = Color.WhiteSmoke;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(TextKapasitasMesinBooking);
            panel11.Location = new Point(43, 372);
            panel11.Name = "panel11";
            panel11.Size = new Size(455, 44);
            panel11.TabIndex = 89;
            // 
            // TextKapasitasMesinBooking
            // 
            TextKapasitasMesinBooking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextKapasitasMesinBooking.BackColor = Color.WhiteSmoke;
            TextKapasitasMesinBooking.BorderStyle = BorderStyle.None;
            TextKapasitasMesinBooking.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextKapasitasMesinBooking.Location = new Point(4, 10);
            TextKapasitasMesinBooking.MaxLength = 100;
            TextKapasitasMesinBooking.Name = "TextKapasitasMesinBooking";
            TextKapasitasMesinBooking.ReadOnly = true;
            TextKapasitasMesinBooking.Size = new Size(437, 23);
            TextKapasitasMesinBooking.TabIndex = 49;
            TextKapasitasMesinBooking.TabStop = false;
            // 
            // ComboKendaraan
            // 
            ComboKendaraan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboKendaraan.BackColor = Color.White;
            ComboKendaraan.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboKendaraan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKendaraan.FormattingEnabled = true;
            ComboKendaraan.Location = new Point(43, 98);
            ComboKendaraan.Name = "ComboKendaraan";
            ComboKendaraan.Size = new Size(323, 33);
            ComboKendaraan.TabIndex = 85;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = Color.WhiteSmoke;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(TextTahunBooking);
            panel10.Location = new Point(43, 467);
            panel10.Name = "panel10";
            panel10.Size = new Size(455, 44);
            panel10.TabIndex = 90;
            // 
            // TextTahunBooking
            // 
            TextTahunBooking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextTahunBooking.BackColor = Color.WhiteSmoke;
            TextTahunBooking.BorderStyle = BorderStyle.None;
            TextTahunBooking.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextTahunBooking.Location = new Point(4, 10);
            TextTahunBooking.MaxLength = 100;
            TextTahunBooking.Name = "TextTahunBooking";
            TextTahunBooking.ReadOnly = true;
            TextTahunBooking.Size = new Size(437, 23);
            TextTahunBooking.TabIndex = 49;
            TextTahunBooking.TabStop = false;
            // 
            // ButtonTambahKendaraan
            // 
            ButtonTambahKendaraan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonTambahKendaraan.BackColor = Color.FromArgb(82, 109, 130);
            ButtonTambahKendaraan.BackgroundColor = Color.FromArgb(82, 109, 130);
            ButtonTambahKendaraan.BorderColor = Color.DarkGray;
            ButtonTambahKendaraan.BorderRadius = 3;
            ButtonTambahKendaraan.BorderSize = 0;
            ButtonTambahKendaraan.FlatAppearance.BorderSize = 0;
            ButtonTambahKendaraan.FlatStyle = FlatStyle.Flat;
            ButtonTambahKendaraan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonTambahKendaraan.ForeColor = Color.White;
            ButtonTambahKendaraan.Location = new Point(382, 98);
            ButtonTambahKendaraan.Name = "ButtonTambahKendaraan";
            ButtonTambahKendaraan.Size = new Size(116, 33);
            ButtonTambahKendaraan.TabIndex = 86;
            ButtonTambahKendaraan.Text = "➕ Tambah ";
            ButtonTambahKendaraan.TextColor = Color.White;
            ButtonTambahKendaraan.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel13.BackColor = Color.WhiteSmoke;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(TextTransmisiBooking);
            panel13.Location = new Point(43, 277);
            panel13.Name = "panel13";
            panel13.Size = new Size(455, 44);
            panel13.TabIndex = 88;
            // 
            // TextTransmisiBooking
            // 
            TextTransmisiBooking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextTransmisiBooking.BackColor = Color.WhiteSmoke;
            TextTransmisiBooking.BorderStyle = BorderStyle.None;
            TextTransmisiBooking.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextTransmisiBooking.Location = new Point(4, 10);
            TextTransmisiBooking.MaxLength = 100;
            TextTransmisiBooking.Name = "TextTransmisiBooking";
            TextTransmisiBooking.ReadOnly = true;
            TextTransmisiBooking.Size = new Size(437, 23);
            TextTransmisiBooking.TabIndex = 49;
            TextTransmisiBooking.TabStop = false;
            // 
            // gradientPanelExt2
            // 
            gradientPanelExt2.Anchor = AnchorStyles.Top;
            gradientPanelExt2.BackColor = Color.WhiteSmoke;
            gradientPanelExt2.Border = new Padding(2);
            gradientPanelExt2.BorderGap = 2;
            gradientPanelExt2.BorderStyle = BorderStyle.None;
            gradientPanelExt2.Controls.Add(PickerBookingTanggal);
            gradientPanelExt2.Controls.Add(ButtonCekKetersediaan);
            gradientPanelExt2.Controls.Add(panel18);
            gradientPanelExt2.Controls.Add(label16);
            gradientPanelExt2.Controls.Add(label17);
            gradientPanelExt2.CornerRadius = 10;
            gradientPanelExt2.Location = new Point(759, 140);
            gradientPanelExt2.Name = "gradientPanelExt2";
            gradientPanelExt2.Size = new Size(539, 570);
            gradientPanelExt2.TabIndex = 51;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(41, 154);
            label17.Name = "label17";
            label17.Size = new Size(79, 25);
            label17.TabIndex = 75;
            label17.Text = "Keluhan";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(41, 64);
            label16.Name = "label16";
            label16.Size = new Size(150, 25);
            label16.TabIndex = 73;
            label16.Text = "Booking Tanggal";
            label16.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel18.BackColor = Color.White;
            panel18.BorderStyle = BorderStyle.FixedSingle;
            panel18.Controls.Add(TextKeluhanBooking);
            panel18.Location = new Point(41, 182);
            panel18.Name = "panel18";
            panel18.Size = new Size(457, 262);
            panel18.TabIndex = 72;
            // 
            // TextKeluhanBooking
            // 
            TextKeluhanBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextKeluhanBooking.BackColor = Color.White;
            TextKeluhanBooking.BorderStyle = BorderStyle.None;
            TextKeluhanBooking.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextKeluhanBooking.Location = new Point(6, 8);
            TextKeluhanBooking.MaxLength = 100;
            TextKeluhanBooking.Multiline = true;
            TextKeluhanBooking.Name = "TextKeluhanBooking";
            TextKeluhanBooking.Size = new Size(442, 245);
            TextKeluhanBooking.TabIndex = 49;
            // 
            // ButtonCekKetersediaan
            // 
            ButtonCekKetersediaan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonCekKetersediaan.BackColor = Color.FromArgb(82, 109, 130);
            ButtonCekKetersediaan.BackgroundColor = Color.FromArgb(82, 109, 130);
            ButtonCekKetersediaan.BorderColor = Color.DarkGray;
            ButtonCekKetersediaan.BorderRadius = 5;
            ButtonCekKetersediaan.BorderSize = 0;
            ButtonCekKetersediaan.FlatAppearance.BorderSize = 0;
            ButtonCekKetersediaan.FlatStyle = FlatStyle.Flat;
            ButtonCekKetersediaan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCekKetersediaan.ForeColor = Color.White;
            ButtonCekKetersediaan.Location = new Point(291, 478);
            ButtonCekKetersediaan.Name = "ButtonCekKetersediaan";
            ButtonCekKetersediaan.Size = new Size(207, 45);
            ButtonCekKetersediaan.TabIndex = 74;
            ButtonCekKetersediaan.Text = "✅ Cek Ketersediaan";
            ButtonCekKetersediaan.TextColor = Color.White;
            ButtonCekKetersediaan.UseVisualStyleBackColor = false;
            // 
            // PickerBookingTanggal
            // 
            PickerBookingTanggal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PickerBookingTanggal.DateTimeIcon = null;
            PickerBookingTanggal.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerBookingTanggal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PickerBookingTanggal.Format = "dddd, dd-MM-yyyy";
            PickerBookingTanggal.Location = new Point(41, 93);
            PickerBookingTanggal.MinDateTime = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            PickerBookingTanggal.Name = "PickerBookingTanggal";
            PickerBookingTanggal.Size = new Size(457, 44);
            PickerBookingTanggal.TabIndex = 71;
            PickerBookingTanggal.ToolTipText = "";
            PickerBookingTanggal.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(556, 40);
            label2.Name = "label2";
            label2.Size = new Size(352, 46);
            label2.TabIndex = 56;
            label2.Text = "Form Booking Servis";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1458, 765);
            panel1.TabIndex = 0;
            // 
            // FormBookingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            Controls.Add(panel1);
            Name = "FormBookingControl";
            Size = new Size(1458, 765);
            contextMenuStrip.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).EndInit();
            gradientPanelExt1.ResumeLayout(false);
            gradientPanelExt1.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt2).EndInit();
            gradientPanelExt2.ResumeLayout(false);
            gradientPanelExt2.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox TextEmail;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel panel3;
        private Label label2;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerBookingTanggal;
        private SMB_CustomTolbox.LathifButton ButtonCekKetersediaan;
        private Panel panel18;
        private TextBox TextKeluhanBooking;
        private Label label16;
        private Label label17;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private Panel panel13;
        private TextBox TextTransmisiBooking;
        private SMB_CustomTolbox.LathifButton ButtonTambahKendaraan;
        private Panel panel10;
        private TextBox TextTahunBooking;
        private ComboBox ComboKendaraan;
        private Panel panel11;
        private TextBox TextKapasitasMesinBooking;
        private Label label5;
        private Panel panel12;
        private TextBox TextMerekBooking;
        private Label label6;
        private Label label10;
        private Label label13;
        private Label label11;
        private Panel panel1;
    }
}
