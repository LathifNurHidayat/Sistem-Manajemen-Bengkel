namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    partial class EditBatasBookingForm
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
            contextMenuStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            ButtonBaru = new SMB_CustomTolbox.LathifButton();
            PickerBookingTanggal = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            GridListData = new DataGridView();
            TextBatas = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonClose = new SMB_CustomTolbox.LathifButton();
            contextMenuStrip.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TextBatas).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ButtonBaru);
            panel1.Controls.Add(PickerBookingTanggal);
            panel1.Controls.Add(GridListData);
            panel1.Controls.Add(TextBatas);
            panel1.Controls.Add(ButtonSimpan);
            panel1.Controls.Add(ButtonClose);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 561);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(288, 26);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 94;
            label2.Text = "Batas Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 93;
            label1.Text = "Tanggal";
            // 
            // ButtonBaru
            // 
            ButtonBaru.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonBaru.BackColor = Color.SandyBrown;
            ButtonBaru.BackgroundColor = Color.SandyBrown;
            ButtonBaru.BorderColor = Color.DarkGray;
            ButtonBaru.BorderRadius = 3;
            ButtonBaru.BorderSize = 0;
            ButtonBaru.FlatAppearance.BorderSize = 0;
            ButtonBaru.FlatStyle = FlatStyle.Flat;
            ButtonBaru.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBaru.ForeColor = Color.White;
            ButtonBaru.Location = new Point(198, 112);
            ButtonBaru.Name = "ButtonBaru";
            ButtonBaru.Size = new Size(110, 35);
            ButtonBaru.TabIndex = 89;
            ButtonBaru.Text = "➕ Baru";
            ButtonBaru.TextColor = Color.White;
            ButtonBaru.UseVisualStyleBackColor = false;
            // 
            // PickerBookingTanggal
            // 
            PickerBookingTanggal.AllowNull = true;
            PickerBookingTanggal.BackColor = Color.White;
            PickerBookingTanggal.DateTimeIcon = null;
            PickerBookingTanggal.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerBookingTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PickerBookingTanggal.Format = "dddd,  dd MMMM yyyy";
            PickerBookingTanggal.Location = new Point(24, 52);
            PickerBookingTanggal.Name = "PickerBookingTanggal";
            PickerBookingTanggal.Size = new Size(258, 37);
            PickerBookingTanggal.TabIndex = 90;
            PickerBookingTanggal.ToolTipText = "";
            PickerBookingTanggal.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // GridListData
            // 
            GridListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListData.Location = new Point(24, 166);
            GridListData.Name = "GridListData";
            GridListData.RowHeadersWidth = 51;
            GridListData.RowTemplate.Height = 29;
            GridListData.Size = new Size(416, 309);
            GridListData.TabIndex = 87;
            // 
            // TextBatas
            // 
            TextBatas.AccessibilityEnabled = true;
            TextBatas.BackGroundColor = Color.White;
            TextBatas.BeforeTouchSize = new Size(152, 37);
            TextBatas.BorderStyle = BorderStyle.FixedSingle;
            TextBatas.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBatas.ForeColor = SystemColors.WindowText;
            TextBatas.IntegerValue = 0L;
            TextBatas.Location = new Point(288, 52);
            TextBatas.Metrocolor = Color.White;
            TextBatas.Multiline = true;
            TextBatas.Name = "TextBatas";
            TextBatas.ReadOnlyBackColor = Color.WhiteSmoke;
            TextBatas.Size = new Size(152, 37);
            TextBatas.TabIndex = 92;
            TextBatas.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.BackColor = Color.LimeGreen;
            ButtonSimpan.BackgroundColor = Color.LimeGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 3;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(330, 112);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(110, 35);
            ButtonSimpan.TabIndex = 91;
            ButtonSimpan.Text = "✅ Simpan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonClose.BackColor = Color.FromArgb(83, 92, 145);
            ButtonClose.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonClose.BorderColor = Color.DarkGray;
            ButtonClose.BorderRadius = 5;
            ButtonClose.BorderSize = 0;
            ButtonClose.FlatAppearance.BorderSize = 0;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonClose.ForeColor = Color.White;
            ButtonClose.Location = new Point(320, 497);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(120, 40);
            ButtonClose.TabIndex = 88;
            ButtonClose.Text = "❌ Close";
            ButtonClose.TextColor = Color.White;
            ButtonClose.UseVisualStyleBackColor = false;
            // 
            // EditBatasBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 561);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditBatasBookingForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            contextMenuStrip.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridListData).EndInit();
            ((System.ComponentModel.ISupportInitialize)TextBatas).EndInit();
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
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private SMB_CustomTolbox.LathifButton ButtonBaru;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerBookingTanggal;
        private DataGridView GridListData;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox TextBatas;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private SMB_CustomTolbox.LathifButton ButtonClose;
    }
}