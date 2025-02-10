namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    partial class InputEditBooking
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
            panel4 = new Panel();
            ComboStatus = new Syncfusion.WinForms.ListView.SfComboBox();
            label5 = new Label();
            panel5 = new Panel();
            PickerTanggal = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            label6 = new Label();
            ButtonCekKetersediaan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            panel3 = new Panel();
            ComboKendaraan = new Syncfusion.WinForms.ListView.SfComboBox();
            LabelNoKTP = new Label();
            panel7 = new Panel();
            TextTelepon = new TextBox();
            panel6 = new Panel();
            TextNama = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label3 = new Label();
            TextKeluhan = new TextBox();
            panel2 = new Panel();
            TextNomorKTP = new TextBox();
            label4 = new Label();
            label1 = new Label();
            LabelJudul = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ComboStatus).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ComboKendaraan).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(LabelJudul);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(ButtonCekKetersediaan);
            panel1.Controls.Add(ButtonBatal);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 729);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(ComboStatus);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(TextKeluhan);
            panel4.Location = new Point(544, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 561);
            panel4.TabIndex = 2;
            // 
            // ComboStatus
            // 
            ComboStatus.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            ComboStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboStatus.Location = new Point(54, 433);
            ComboStatus.Name = "ComboStatus";
            ComboStatus.Size = new Size(373, 44);
            ComboStatus.Style.EditorStyle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboStatus.Style.ReadOnlyEditorStyle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboStatus.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            ComboStatus.Style.TokenStyle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboStatus.TabIndex = 53;
            ComboStatus.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(54, 405);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 52;
            label5.Text = "Status";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(PickerTanggal);
            panel5.Location = new Point(54, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(373, 44);
            panel5.TabIndex = 50;
            // 
            // PickerTanggal
            // 
            PickerTanggal.BackColor = Color.White;
            PickerTanggal.DateTimeIcon = null;
            PickerTanggal.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerTanggal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            PickerTanggal.Format = "dddd  -  dd-MM-yyyy";
            PickerTanggal.Location = new Point(7, 5);
            PickerTanggal.Name = "PickerTanggal";
            PickerTanggal.Size = new Size(356, 33);
            PickerTanggal.Style.BorderColor = Color.Transparent;
            PickerTanggal.TabIndex = 42;
            PickerTanggal.ToolTipText = "";
            PickerTanggal.Value = new DateTime(2025, 2, 9, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(54, 40);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 43;
            label6.Text = "Tanggal";
            // 
            // ButtonCekKetersediaan
            // 
            ButtonCekKetersediaan.Anchor = AnchorStyles.None;
            ButtonCekKetersediaan.BackColor = Color.FromArgb(83, 92, 145);
            ButtonCekKetersediaan.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonCekKetersediaan.BorderColor = Color.DarkGray;
            ButtonCekKetersediaan.BorderRadius = 5;
            ButtonCekKetersediaan.BorderSize = 0;
            ButtonCekKetersediaan.FlatAppearance.BorderSize = 0;
            ButtonCekKetersediaan.FlatStyle = FlatStyle.Flat;
            ButtonCekKetersediaan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCekKetersediaan.ForeColor = Color.White;
            ButtonCekKetersediaan.Location = new Point(823, 659);
            ButtonCekKetersediaan.Name = "ButtonCekKetersediaan";
            ButtonCekKetersediaan.Size = new Size(201, 45);
            ButtonCekKetersediaan.TabIndex = 4;
            ButtonCekKetersediaan.Text = "✅ Cek Ketersediaan";
            ButtonCekKetersediaan.TextColor = Color.White;
            ButtonCekKetersediaan.UseVisualStyleBackColor = false;
            // 
            // ButtonBatal
            // 
            ButtonBatal.Anchor = AnchorStyles.None;
            ButtonBatal.BackColor = Color.Red;
            ButtonBatal.BackgroundColor = Color.Red;
            ButtonBatal.BorderColor = Color.DarkGray;
            ButtonBatal.BorderRadius = 5;
            ButtonBatal.BorderSize = 0;
            ButtonBatal.FlatAppearance.BorderSize = 0;
            ButtonBatal.FlatStyle = FlatStyle.Flat;
            ButtonBatal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBatal.ForeColor = Color.White;
            ButtonBatal.Location = new Point(667, 659);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(135, 45);
            ButtonBatal.TabIndex = 3;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(ComboKendaraan);
            panel3.Controls.Add(LabelNoKTP);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(36, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 561);
            panel3.TabIndex = 1;
            // 
            // ComboKendaraan
            // 
            ComboKendaraan.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            ComboKendaraan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKendaraan.Location = new Point(47, 433);
            ComboKendaraan.Name = "ComboKendaraan";
            ComboKendaraan.Size = new Size(383, 44);
            ComboKendaraan.Style.EditorStyle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKendaraan.Style.ReadOnlyEditorStyle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKendaraan.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            ComboKendaraan.Style.TokenStyle.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKendaraan.TabIndex = 4;
            ComboKendaraan.TabStop = false;
            ComboKendaraan.SelectedIndexChanged += sfComboBox1_SelectedIndexChanged;
            // 
            // LabelNoKTP
            // 
            LabelNoKTP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoKTP.ForeColor = Color.Red;
            LabelNoKTP.Location = new Point(225, 43);
            LabelNoKTP.Name = "LabelNoKTP";
            LabelNoKTP.Size = new Size(205, 23);
            LabelNoKTP.TabIndex = 56;
            LabelNoKTP.Text = "Nomor KTP tidak ditemukan";
            LabelNoKTP.TextAlign = ContentAlignment.MiddleRight;
            LabelNoKTP.Visible = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextTelepon);
            panel7.Location = new Point(47, 274);
            panel7.Name = "panel7";
            panel7.Size = new Size(383, 44);
            panel7.TabIndex = 3;
            // 
            // TextTelepon
            // 
            TextTelepon.BackColor = Color.White;
            TextTelepon.BorderStyle = BorderStyle.None;
            TextTelepon.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextTelepon.Location = new Point(4, 10);
            TextTelepon.Name = "TextTelepon";
            TextTelepon.Size = new Size(373, 24);
            TextTelepon.TabIndex = 49;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TextNama);
            panel6.Location = new Point(47, 171);
            panel6.Name = "panel6";
            panel6.Size = new Size(383, 44);
            panel6.TabIndex = 2;
            // 
            // TextNama
            // 
            TextNama.BackColor = Color.White;
            TextNama.BorderStyle = BorderStyle.None;
            TextNama.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNama.Location = new Point(4, 10);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(373, 24);
            TextNama.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(47, 246);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 53;
            label2.Text = "Telepon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(47, 143);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 51;
            label7.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(47, 405);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 48;
            label3.Text = "Kendaraan";
            // 
            // TextKeluhan
            // 
            TextKeluhan.BackColor = Color.White;
            TextKeluhan.BorderStyle = BorderStyle.FixedSingle;
            TextKeluhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextKeluhan.Location = new Point(54, 171);
            TextKeluhan.Multiline = true;
            TextKeluhan.Name = "TextKeluhan";
            TextKeluhan.Size = new Size(373, 147);
            TextKeluhan.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextNomorKTP);
            panel2.Location = new Point(47, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 44);
            panel2.TabIndex = 1;
            // 
            // TextNomorKTP
            // 
            TextNomorKTP.BackColor = Color.White;
            TextNomorKTP.BorderStyle = BorderStyle.None;
            TextNomorKTP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNomorKTP.Location = new Point(4, 10);
            TextNomorKTP.Name = "TextNomorKTP";
            TextNomorKTP.PlaceholderText = "🔍 Cari berdasarkan nomor KTP ";
            TextNomorKTP.Size = new Size(373, 24);
            TextNomorKTP.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(54, 143);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 44;
            label4.Text = "Keluhan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(47, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 43;
            label1.Text = "Nomor KTP";
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJudul.ForeColor = Color.Black;
            LabelJudul.Location = new Point(36, 27);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(198, 38);
            LabelJudul.TabIndex = 45;
            LabelJudul.Text = "Input Booking";
            // 
            // InputEditBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 753);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InputEditBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += InputEditBooking_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ComboStatus).EndInit();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ComboKendaraan).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private TextBox TextNomorKTP;
        private Panel panel4;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerTanggal;
        private Panel panel5;
        private Label label3;
        private SMB_CustomTolbox.LathifButton ButtonCekKetersediaan;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
        private TextBox TextKeluhan;
        private Label label4;
        private Label label6;
        private Label label2;
        private Label label7;
        private Panel panel7;
        private TextBox TextTelepon;
        private Panel panel6;
        private TextBox TextNama;
        private Syncfusion.WinForms.ListView.SfComboBox ComboKendaraan;
        private Label LabelNoKTP;
        private Syncfusion.WinForms.ListView.SfComboBox ComboStatus;
        private Label label5;
        private Label LabelJudul;
    }
}