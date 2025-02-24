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
            components = new System.ComponentModel.Container();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonClose = new SMB_CustomTolbox.LathifButton();
            TextBatas = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            GridListData = new DataGridView();
            PickerBookingTanggal = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            ButtonBaru = new SMB_CustomTolbox.LathifButton();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)TextBatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridListData).BeginInit();
            SuspendLayout();
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonSimpan.BackColor = Color.LimeGreen;
            ButtonSimpan.BackgroundColor = Color.LimeGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 3;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(306, 116);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(110, 35);
            ButtonSimpan.TabIndex = 5;
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
            ButtonClose.Location = new Point(296, 396);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(120, 40);
            ButtonClose.TabIndex = 1;
            ButtonClose.Text = "❌ Close";
            ButtonClose.TextColor = Color.White;
            ButtonClose.UseVisualStyleBackColor = false;
            // 
            // TextBatas
            // 
            TextBatas.AccessibilityEnabled = true;
            TextBatas.BeforeTouchSize = new Size(175, 37);
            TextBatas.BorderStyle = BorderStyle.FixedSingle;
            TextBatas.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBatas.IntegerValue = 0L;
            TextBatas.Location = new Point(241, 54);
            TextBatas.Multiline = true;
            TextBatas.Name = "TextBatas";
            TextBatas.Size = new Size(175, 37);
            TextBatas.TabIndex = 81;
            TextBatas.Text = "0";
            TextBatas.TextAlign = HorizontalAlignment.Center;
            // 
            // GridListData
            // 
            GridListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListData.Location = new Point(12, 174);
            GridListData.Name = "GridListData";
            GridListData.RowHeadersWidth = 51;
            GridListData.RowTemplate.Height = 29;
            GridListData.Size = new Size(404, 212);
            GridListData.TabIndex = 0;
            // 
            // PickerBookingTanggal
            // 
            PickerBookingTanggal.DateTimeIcon = null;
            PickerBookingTanggal.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerBookingTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PickerBookingTanggal.Format = "dddd, dd MMMM yyyy";
            PickerBookingTanggal.Location = new Point(12, 54);
            PickerBookingTanggal.Name = "PickerBookingTanggal";
            PickerBookingTanggal.Size = new Size(223, 37);
            PickerBookingTanggal.TabIndex = 3;
            PickerBookingTanggal.ToolTipText = "";
            PickerBookingTanggal.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
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
            ButtonBaru.Location = new Point(190, 116);
            ButtonBaru.Name = "ButtonBaru";
            ButtonBaru.Size = new Size(110, 35);
            ButtonBaru.TabIndex = 2;
            ButtonBaru.Text = "➕ Baru";
            ButtonBaru.TextColor = Color.White;
            ButtonBaru.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 85;
            label1.Text = "Tanggal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(241, 28);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 86;
            label2.Text = "Batas Booking";
            // 
            // EditBatasBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 448);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonBaru);
            Controls.Add(PickerBookingTanggal);
            Controls.Add(GridListData);
            Controls.Add(TextBatas);
            Controls.Add(ButtonSimpan);
            Controls.Add(ButtonClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "EditBatasBookingForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)TextBatas).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridListData).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private SMB_CustomTolbox.LathifButton ButtonClose;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox TextBatas;
        private DataGridView GridListData;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerBookingTanggal;
        private SMB_CustomTolbox.LathifButton ButtonBaru;
        private Label label1;
        private Label label2;
    }
}