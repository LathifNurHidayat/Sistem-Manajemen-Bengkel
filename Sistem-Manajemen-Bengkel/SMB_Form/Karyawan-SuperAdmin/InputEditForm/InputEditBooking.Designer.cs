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
            label2 = new Label();
            label1 = new Label();
            PickerTanggal = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            ButtonCancel = new SMB_CustomTolbox.LathifButton();
            ButtonSave = new SMB_CustomTolbox.LathifButton();
            TextKeluhan = new TextBox();
            PanelPelanggan = new Panel();
            label3 = new Label();
            LabelTotalPelanggan = new Label();
            pictureBox3 = new PictureBox();
            lathifButton2 = new SMB_CustomTolbox.LathifButton();
            ComboKendaraan = new Syncfusion.WinForms.ListView.SfComboBox();
            label5 = new Label();
            PanelPelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComboKendaraan).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 258);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 34;
            label2.Text = "Keluhan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 33;
            label1.Text = "Masukan tanggal booking";
            // 
            // PickerTanggal
            // 
            PickerTanggal.DateTimeIcon = null;
            PickerTanggal.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerTanggal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            PickerTanggal.Format = "dddd  -  dd-MM-yyyy";
            PickerTanggal.Location = new Point(30, 62);
            PickerTanggal.Name = "PickerTanggal";
            PickerTanggal.Size = new Size(297, 40);
            PickerTanggal.TabIndex = 31;
            PickerTanggal.ToolTipText = "";
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.Red;
            ButtonCancel.BackgroundColor = Color.Red;
            ButtonCancel.BorderColor = Color.DarkGray;
            ButtonCancel.BorderRadius = 5;
            ButtonCancel.BorderSize = 0;
            ButtonCancel.FlatAppearance.BorderSize = 0;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancel.ForeColor = Color.White;
            ButtonCancel.Location = new Point(417, 478);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(135, 45);
            ButtonCancel.TabIndex = 30;
            ButtonCancel.Text = "❌ Cancel";
            ButtonCancel.TextColor = Color.White;
            ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.LimeGreen;
            ButtonSave.BackgroundColor = Color.LimeGreen;
            ButtonSave.BorderColor = Color.DarkGray;
            ButtonSave.BorderRadius = 5;
            ButtonSave.BorderSize = 0;
            ButtonSave.FlatAppearance.BorderSize = 0;
            ButtonSave.FlatStyle = FlatStyle.Flat;
            ButtonSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Location = new Point(586, 478);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(135, 45);
            ButtonSave.TabIndex = 28;
            ButtonSave.Text = "✅ Save";
            ButtonSave.TextColor = Color.White;
            ButtonSave.UseVisualStyleBackColor = false;
            // 
            // TextKeluhan
            // 
            TextKeluhan.BorderStyle = BorderStyle.FixedSingle;
            TextKeluhan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextKeluhan.Location = new Point(30, 286);
            TextKeluhan.Multiline = true;
            TextKeluhan.Name = "TextKeluhan";
            TextKeluhan.Size = new Size(297, 165);
            TextKeluhan.TabIndex = 35;
            // 
            // PanelPelanggan
            // 
            PanelPelanggan.Anchor = AnchorStyles.Top;
            PanelPelanggan.BackColor = Color.DarkGray;
            PanelPelanggan.Controls.Add(label3);
            PanelPelanggan.Controls.Add(LabelTotalPelanggan);
            PanelPelanggan.Controls.Add(pictureBox3);
            PanelPelanggan.Location = new Point(418, 62);
            PanelPelanggan.Name = "PanelPelanggan";
            PanelPelanggan.Size = new Size(314, 320);
            PanelPelanggan.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 99);
            label3.Name = "label3";
            label3.Size = new Size(213, 46);
            label3.TabIndex = 11;
            label3.Text = "Antrean ke :";
            // 
            // LabelTotalPelanggan
            // 
            LabelTotalPelanggan.Anchor = AnchorStyles.None;
            LabelTotalPelanggan.AutoSize = true;
            LabelTotalPelanggan.Font = new Font("Microsoft New Tai Lue", 48F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotalPelanggan.ForeColor = Color.White;
            LabelTotalPelanggan.Location = new Point(91, 183);
            LabelTotalPelanggan.Name = "LabelTotalPelanggan";
            LabelTotalPelanggan.Size = new Size(137, 105);
            LabelTotalPelanggan.TabIndex = 14;
            LabelTotalPelanggan.Text = "34";
            LabelTotalPelanggan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Pelanggan;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(105, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 75);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // lathifButton2
            // 
            lathifButton2.BackColor = Color.Gray;
            lathifButton2.BackgroundColor = Color.Gray;
            lathifButton2.BorderColor = Color.DarkGray;
            lathifButton2.BorderRadius = 5;
            lathifButton2.BorderSize = 0;
            lathifButton2.FlatAppearance.BorderSize = 0;
            lathifButton2.FlatStyle = FlatStyle.Flat;
            lathifButton2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lathifButton2.ForeColor = Color.White;
            lathifButton2.Location = new Point(413, 406);
            lathifButton2.Name = "lathifButton2";
            lathifButton2.Size = new Size(314, 45);
            lathifButton2.TabIndex = 37;
            lathifButton2.Text = "Cek Antrean";
            lathifButton2.TextColor = Color.White;
            lathifButton2.UseVisualStyleBackColor = false;
            // 
            // ComboKendaraan
            // 
            ComboKendaraan.DropDownPosition = Syncfusion.WinForms.Core.Enums.PopupRelativeAlignment.Center;
            ComboKendaraan.Location = new Point(30, 174);
            ComboKendaraan.Name = "ComboKendaraan";
            ComboKendaraan.Size = new Size(297, 40);
            ComboKendaraan.Style.TokenStyle.CloseButtonBackColor = Color.FromArgb(255, 255, 255);
            ComboKendaraan.TabIndex = 38;
            ComboKendaraan.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(30, 146);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 39;
            label5.Text = "Kendaraan";
            // 
            // InputEditBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(762, 623);
            Controls.Add(label5);
            Controls.Add(ComboKendaraan);
            Controls.Add(lathifButton2);
            Controls.Add(PanelPelanggan);
            Controls.Add(TextKeluhan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PickerTanggal);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InputEditBooking";
            StartPosition = FormStartPosition.CenterScreen;
            PanelPelanggan.ResumeLayout(false);
            PanelPelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComboKendaraan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerTanggal;
        private SMB_CustomTolbox.LathifButton ButtonCancel;
        private SMB_CustomTolbox.LathifButton ButtonSave;
        private TextBox TextKeluhan;
        private Panel PanelPelanggan;
        private Label label3;
        private Label LabelTotalPelanggan;
        private PictureBox pictureBox3;
        private SMB_CustomTolbox.LathifButton lathifButton2;
        private Syncfusion.WinForms.ListView.SfComboBox ComboKendaraan;
        private Label label5;
    }
}