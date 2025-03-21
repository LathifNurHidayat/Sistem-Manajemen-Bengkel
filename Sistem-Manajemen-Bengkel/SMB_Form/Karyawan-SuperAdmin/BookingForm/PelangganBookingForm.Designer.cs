﻿namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    partial class PelangganBookingForm
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
            PanelMain = new Panel();
            label9 = new Label();
            PanelBookingServis = new Panel();
            PickerBookingTanggal = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            label12 = new Label();
            panel18 = new Panel();
            TextKeluhan = new TextBox();
            label16 = new Label();
            label17 = new Label();
            PanelDataKendaraan = new Panel();
            panel13 = new Panel();
            TextTransmisi = new TextBox();
            ButtonTambahKendaraan = new SMB_CustomTolbox.LathifButton();
            panel10 = new Panel();
            TextTahun = new TextBox();
            ComboKendaraan = new ComboBox();
            panel11 = new Panel();
            TextKapasitasMesin = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel12 = new Panel();
            TextMerek = new TextBox();
            label6 = new Label();
            label10 = new Label();
            label13 = new Label();
            label11 = new Label();
            PanelDataPribadi = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            TextAlamat = new TextBox();
            ButtonShowPelanggan = new SMB_CustomTolbox.LathifButton();
            label1 = new Label();
            panel7 = new Panel();
            TextTelepon = new TextBox();
            panel8 = new Panel();
            TextNama = new TextBox();
            label2 = new Label();
            label7 = new Label();
            panel9 = new Panel();
            TextNomorKTP = new TextBox();
            label8 = new Label();
            ButtonCekKetersediaan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            PanelMain.SuspendLayout();
            PanelBookingServis.SuspendLayout();
            panel18.SuspendLayout();
            PanelDataKendaraan.SuspendLayout();
            panel13.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            PanelDataPribadi.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMain
            // 
            PanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelMain.BackColor = Color.White;
            PanelMain.Controls.Add(label9);
            PanelMain.Controls.Add(PanelBookingServis);
            PanelMain.Controls.Add(PanelDataKendaraan);
            PanelMain.Controls.Add(PanelDataPribadi);
            PanelMain.Controls.Add(ButtonCekKetersediaan);
            PanelMain.Controls.Add(ButtonBatal);
            PanelMain.Location = new Point(12, 12);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1458, 882);
            PanelMain.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(26, 20);
            label9.Name = "label9";
            label9.Size = new Size(208, 31);
            label9.TabIndex = 50;
            label9.Text = "📆  Input Booking";
            // 
            // PanelBookingServis
            // 
            PanelBookingServis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PanelBookingServis.BackColor = Color.WhiteSmoke;
            PanelBookingServis.BorderStyle = BorderStyle.FixedSingle;
            PanelBookingServis.Controls.Add(PickerBookingTanggal);
            PanelBookingServis.Controls.Add(label12);
            PanelBookingServis.Controls.Add(panel18);
            PanelBookingServis.Controls.Add(label16);
            PanelBookingServis.Controls.Add(label17);
            PanelBookingServis.Location = new Point(963, 140);
            PanelBookingServis.Name = "PanelBookingServis";
            PanelBookingServis.Size = new Size(470, 640);
            PanelBookingServis.TabIndex = 47;
            // 
            // PickerBookingTanggal
            // 
            PickerBookingTanggal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PickerBookingTanggal.DateTimeIcon = null;
            PickerBookingTanggal.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerBookingTanggal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PickerBookingTanggal.Format = "dddd, dd-MM-yyyy";
            PickerBookingTanggal.Location = new Point(28, 109);
            PickerBookingTanggal.MinDateTime = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            PickerBookingTanggal.Name = "PickerBookingTanggal";
            PickerBookingTanggal.Size = new Size(409, 44);
            PickerBookingTanggal.TabIndex = 1;
            PickerBookingTanggal.ToolTipText = "";
            PickerBookingTanggal.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(16, 16);
            label12.Name = "label12";
            label12.Size = new Size(176, 28);
            label12.TabIndex = 58;
            label12.Text = "C. Booking Servis";
            // 
            // panel18
            // 
            panel18.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel18.BackColor = Color.White;
            panel18.BorderStyle = BorderStyle.FixedSingle;
            panel18.Controls.Add(TextKeluhan);
            panel18.Location = new Point(28, 215);
            panel18.Name = "panel18";
            panel18.Size = new Size(409, 262);
            panel18.TabIndex = 2;
            // 
            // TextKeluhan
            // 
            TextKeluhan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextKeluhan.BackColor = Color.White;
            TextKeluhan.BorderStyle = BorderStyle.None;
            TextKeluhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextKeluhan.Location = new Point(6, 8);
            TextKeluhan.MaxLength = 100;
            TextKeluhan.Multiline = true;
            TextKeluhan.Name = "TextKeluhan";
            TextKeluhan.Size = new Size(397, 241);
            TextKeluhan.TabIndex = 49;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(28, 83);
            label16.Name = "label16";
            label16.Size = new Size(150, 25);
            label16.TabIndex = 43;
            label16.Text = "Booking Tanggal";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(28, 187);
            label17.Name = "label17";
            label17.Size = new Size(79, 25);
            label17.TabIndex = 70;
            label17.Text = "Keluhan";
            // 
            // PanelDataKendaraan
            // 
            PanelDataKendaraan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelDataKendaraan.BackColor = Color.WhiteSmoke;
            PanelDataKendaraan.BorderStyle = BorderStyle.FixedSingle;
            PanelDataKendaraan.Controls.Add(panel13);
            PanelDataKendaraan.Controls.Add(ButtonTambahKendaraan);
            PanelDataKendaraan.Controls.Add(panel10);
            PanelDataKendaraan.Controls.Add(ComboKendaraan);
            PanelDataKendaraan.Controls.Add(panel11);
            PanelDataKendaraan.Controls.Add(label5);
            PanelDataKendaraan.Controls.Add(label4);
            PanelDataKendaraan.Controls.Add(panel12);
            PanelDataKendaraan.Controls.Add(label6);
            PanelDataKendaraan.Controls.Add(label10);
            PanelDataKendaraan.Controls.Add(label13);
            PanelDataKendaraan.Controls.Add(label11);
            PanelDataKendaraan.Location = new Point(526, 140);
            PanelDataKendaraan.Name = "PanelDataKendaraan";
            PanelDataKendaraan.Size = new Size(405, 640);
            PanelDataKendaraan.TabIndex = 46;
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel13.BackColor = Color.White;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(TextTransmisi);
            panel13.Location = new Point(28, 326);
            panel13.Name = "panel13";
            panel13.Size = new Size(346, 44);
            panel13.TabIndex = 4;
            // 
            // TextTransmisi
            // 
            TextTransmisi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextTransmisi.BackColor = Color.White;
            TextTransmisi.BorderStyle = BorderStyle.None;
            TextTransmisi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextTransmisi.Location = new Point(4, 10);
            TextTransmisi.MaxLength = 100;
            TextTransmisi.Name = "TextTransmisi";
            TextTransmisi.ReadOnly = true;
            TextTransmisi.Size = new Size(337, 23);
            TextTransmisi.TabIndex = 49;
            TextTransmisi.TabStop = false;
            // 
            // ButtonTambahKendaraan
            // 
            ButtonTambahKendaraan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonTambahKendaraan.BackColor = Color.FromArgb(83, 92, 145);
            ButtonTambahKendaraan.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonTambahKendaraan.BorderColor = Color.DarkGray;
            ButtonTambahKendaraan.BorderRadius = 3;
            ButtonTambahKendaraan.BorderSize = 0;
            ButtonTambahKendaraan.FlatAppearance.BorderSize = 0;
            ButtonTambahKendaraan.FlatStyle = FlatStyle.Flat;
            ButtonTambahKendaraan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonTambahKendaraan.ForeColor = Color.White;
            ButtonTambahKendaraan.Location = new Point(258, 114);
            ButtonTambahKendaraan.Name = "ButtonTambahKendaraan";
            ButtonTambahKendaraan.Size = new Size(116, 39);
            ButtonTambahKendaraan.TabIndex = 2;
            ButtonTambahKendaraan.Text = "➕ Tambah ";
            ButtonTambahKendaraan.TextColor = Color.White;
            ButtonTambahKendaraan.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(TextTahun);
            panel10.Location = new Point(28, 548);
            panel10.Name = "panel10";
            panel10.Size = new Size(346, 44);
            panel10.TabIndex = 6;
            // 
            // TextTahun
            // 
            TextTahun.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextTahun.BackColor = Color.White;
            TextTahun.BorderStyle = BorderStyle.None;
            TextTahun.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextTahun.Location = new Point(4, 10);
            TextTahun.MaxLength = 100;
            TextTahun.Name = "TextTahun";
            TextTahun.ReadOnly = true;
            TextTahun.Size = new Size(337, 23);
            TextTahun.TabIndex = 49;
            TextTahun.TabStop = false;
            // 
            // ComboKendaraan
            // 
            ComboKendaraan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboKendaraan.BackColor = Color.White;
            ComboKendaraan.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboKendaraan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboKendaraan.FormattingEnabled = true;
            ComboKendaraan.Location = new Point(28, 117);
            ComboKendaraan.Name = "ComboKendaraan";
            ComboKendaraan.Size = new Size(224, 33);
            ComboKendaraan.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(TextKapasitasMesin);
            panel11.Location = new Point(28, 437);
            panel11.Name = "panel11";
            panel11.Size = new Size(346, 44);
            panel11.TabIndex = 5;
            // 
            // TextKapasitasMesin
            // 
            TextKapasitasMesin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextKapasitasMesin.BackColor = Color.White;
            TextKapasitasMesin.BorderStyle = BorderStyle.None;
            TextKapasitasMesin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextKapasitasMesin.Location = new Point(4, 10);
            TextKapasitasMesin.MaxLength = 100;
            TextKapasitasMesin.Name = "TextKapasitasMesin";
            TextKapasitasMesin.ReadOnly = true;
            TextKapasitasMesin.Size = new Size(337, 23);
            TextKapasitasMesin.TabIndex = 49;
            TextKapasitasMesin.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 519);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 73;
            label5.Text = "Tahun";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 16);
            label4.Name = "label4";
            label4.Size = new Size(188, 28);
            label4.TabIndex = 58;
            label4.Text = "B. Data Kendaraan";
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel12.BackColor = Color.White;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(TextMerek);
            panel12.Location = new Point(28, 215);
            panel12.Name = "panel12";
            panel12.Size = new Size(346, 44);
            panel12.TabIndex = 3;
            // 
            // TextMerek
            // 
            TextMerek.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextMerek.BackColor = Color.White;
            TextMerek.BorderStyle = BorderStyle.None;
            TextMerek.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextMerek.Location = new Point(4, 10);
            TextMerek.MaxLength = 100;
            TextMerek.Name = "TextMerek";
            TextMerek.ReadOnly = true;
            TextMerek.Size = new Size(337, 23);
            TextMerek.TabIndex = 49;
            TextMerek.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(26, 409);
            label6.Name = "label6";
            label6.Size = new Size(178, 25);
            label6.TabIndex = 72;
            label6.Text = "Kapasitas Mesin (cc)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(28, 299);
            label10.Name = "label10";
            label10.Size = new Size(90, 25);
            label10.TabIndex = 71;
            label10.Text = "Transmisi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(28, 83);
            label13.Name = "label13";
            label13.Size = new Size(232, 25);
            label13.TabIndex = 43;
            label13.Text = "Pilih Kendaraan (No Polisi)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(28, 189);
            label11.Name = "label11";
            label11.Size = new Size(65, 25);
            label11.TabIndex = 70;
            label11.Text = "Merek";
            // 
            // PanelDataPribadi
            // 
            PanelDataPribadi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PanelDataPribadi.BackColor = Color.WhiteSmoke;
            PanelDataPribadi.BorderStyle = BorderStyle.FixedSingle;
            PanelDataPribadi.Controls.Add(label3);
            PanelDataPribadi.Controls.Add(panel6);
            PanelDataPribadi.Controls.Add(ButtonShowPelanggan);
            PanelDataPribadi.Controls.Add(label1);
            PanelDataPribadi.Controls.Add(panel7);
            PanelDataPribadi.Controls.Add(panel8);
            PanelDataPribadi.Controls.Add(label2);
            PanelDataPribadi.Controls.Add(label7);
            PanelDataPribadi.Controls.Add(panel9);
            PanelDataPribadi.Controls.Add(label8);
            PanelDataPribadi.Location = new Point(26, 140);
            PanelDataPribadi.Name = "PanelDataPribadi";
            PanelDataPribadi.Size = new Size(470, 640);
            PanelDataPribadi.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 16);
            label3.Name = "label3";
            label3.Size = new Size(161, 28);
            label3.TabIndex = 58;
            label3.Text = "A. Data Pribadi ";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TextAlamat);
            panel6.Location = new Point(28, 433);
            panel6.Name = "panel6";
            panel6.Size = new Size(409, 44);
            panel6.TabIndex = 5;
            // 
            // TextAlamat
            // 
            TextAlamat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextAlamat.BackColor = Color.White;
            TextAlamat.BorderStyle = BorderStyle.None;
            TextAlamat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextAlamat.Location = new Point(4, 10);
            TextAlamat.MaxLength = 100;
            TextAlamat.Name = "TextAlamat";
            TextAlamat.ReadOnly = true;
            TextAlamat.Size = new Size(400, 23);
            TextAlamat.TabIndex = 49;
            TextAlamat.TabStop = false;
            // 
            // ButtonShowPelanggan
            // 
            ButtonShowPelanggan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonShowPelanggan.BackColor = Color.Gray;
            ButtonShowPelanggan.BackgroundColor = Color.Gray;
            ButtonShowPelanggan.BorderColor = Color.Black;
            ButtonShowPelanggan.BorderRadius = 3;
            ButtonShowPelanggan.BorderSize = 0;
            ButtonShowPelanggan.FlatAppearance.BorderSize = 0;
            ButtonShowPelanggan.FlatStyle = FlatStyle.Flat;
            ButtonShowPelanggan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonShowPelanggan.ForeColor = Color.White;
            ButtonShowPelanggan.Location = new Point(384, 109);
            ButtonShowPelanggan.Name = "ButtonShowPelanggan";
            ButtonShowPelanggan.Size = new Size(53, 44);
            ButtonShowPelanggan.TabIndex = 2;
            ButtonShowPelanggan.Text = "...";
            ButtonShowPelanggan.TextColor = Color.White;
            ButtonShowPelanggan.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 405);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 56;
            label1.Text = "Alamat";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextTelepon);
            panel7.Location = new Point(28, 325);
            panel7.Name = "panel7";
            panel7.Size = new Size(409, 44);
            panel7.TabIndex = 4;
            // 
            // TextTelepon
            // 
            TextTelepon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextTelepon.BackColor = Color.White;
            TextTelepon.BorderStyle = BorderStyle.None;
            TextTelepon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextTelepon.Location = new Point(4, 10);
            TextTelepon.MaxLength = 100;
            TextTelepon.Name = "TextTelepon";
            TextTelepon.ReadOnly = true;
            TextTelepon.Size = new Size(400, 23);
            TextTelepon.TabIndex = 49;
            TextTelepon.TabStop = false;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(TextNama);
            panel8.Location = new Point(28, 217);
            panel8.Name = "panel8";
            panel8.Size = new Size(409, 44);
            panel8.TabIndex = 3;
            // 
            // TextNama
            // 
            TextNama.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextNama.BackColor = Color.White;
            TextNama.BorderStyle = BorderStyle.None;
            TextNama.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextNama.Location = new Point(4, 10);
            TextNama.MaxLength = 100;
            TextNama.Name = "TextNama";
            TextNama.ReadOnly = true;
            TextNama.Size = new Size(400, 23);
            TextNama.TabIndex = 49;
            TextNama.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(28, 297);
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
            label7.Location = new Point(28, 189);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 51;
            label7.Text = "Nama";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(TextNomorKTP);
            panel9.Location = new Point(28, 109);
            panel9.Name = "panel9";
            panel9.Size = new Size(350, 44);
            panel9.TabIndex = 1;
            // 
            // TextNomorKTP
            // 
            TextNomorKTP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextNomorKTP.BackColor = Color.White;
            TextNomorKTP.BorderStyle = BorderStyle.None;
            TextNomorKTP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextNomorKTP.Location = new Point(4, 10);
            TextNomorKTP.MaxLength = 16;
            TextNomorKTP.Name = "TextNomorKTP";
            TextNomorKTP.ReadOnly = true;
            TextNomorKTP.Size = new Size(341, 23);
            TextNomorKTP.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(28, 81);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 43;
            label8.Text = "No. KTP";
            // 
            // ButtonCekKetersediaan
            // 
            ButtonCekKetersediaan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonCekKetersediaan.BackColor = Color.FromArgb(83, 92, 145);
            ButtonCekKetersediaan.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonCekKetersediaan.BorderColor = Color.DarkGray;
            ButtonCekKetersediaan.BorderRadius = 5;
            ButtonCekKetersediaan.BorderSize = 0;
            ButtonCekKetersediaan.FlatAppearance.BorderSize = 0;
            ButtonCekKetersediaan.FlatStyle = FlatStyle.Flat;
            ButtonCekKetersediaan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCekKetersediaan.ForeColor = Color.White;
            ButtonCekKetersediaan.Location = new Point(1215, 817);
            ButtonCekKetersediaan.Name = "ButtonCekKetersediaan";
            ButtonCekKetersediaan.Size = new Size(218, 45);
            ButtonCekKetersediaan.TabIndex = 48;
            ButtonCekKetersediaan.Text = "✅ Cek Ketersediaan";
            ButtonCekKetersediaan.TextColor = Color.White;
            ButtonCekKetersediaan.UseVisualStyleBackColor = false;
            // 
            // ButtonBatal
            // 
            ButtonBatal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonBatal.BackColor = Color.Red;
            ButtonBatal.BackgroundColor = Color.Red;
            ButtonBatal.BorderColor = Color.DarkGray;
            ButtonBatal.BorderRadius = 5;
            ButtonBatal.BorderSize = 0;
            ButtonBatal.FlatAppearance.BorderSize = 0;
            ButtonBatal.FlatStyle = FlatStyle.Flat;
            ButtonBatal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBatal.ForeColor = Color.White;
            ButtonBatal.Location = new Point(1053, 817);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(135, 45);
            ButtonBatal.TabIndex = 49;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // PelangganBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1482, 906);
            Controls.Add(PanelMain);
            Name = "PelangganBookingForm";
            Text = "PelangganBookingForm";
            PanelMain.ResumeLayout(false);
            PanelMain.PerformLayout();
            PanelBookingServis.ResumeLayout(false);
            PanelBookingServis.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            PanelDataKendaraan.ResumeLayout(false);
            PanelDataKendaraan.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            PanelDataPribadi.ResumeLayout(false);
            PanelDataPribadi.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox TextEmail;
        private Panel PanelMain;
        private Label label9;
        private Panel PanelBookingServis;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerBookingTanggal;
        private Label label12;
        private Panel panel18;
        private TextBox TextKeluhan;
        private Label label16;
        private Label label17;
        private Panel PanelDataKendaraan;
        private Panel panel13;
        private TextBox TextTransmisi;
        private SMB_CustomTolbox.LathifButton ButtonTambahKendaraan;
        private Panel panel10;
        private TextBox TextTahun;
        private ComboBox ComboKendaraan;
        private Panel panel11;
        private TextBox TextKapasitasMesin;
        private Label label5;
        private Label label4;
        private Panel panel12;
        private TextBox TextMerek;
        private Label label6;
        private Label label10;
        private Label label13;
        private Label label11;
        private Panel PanelDataPribadi;
        private Label label3;
        private Panel panel6;
        private TextBox TextAlamat;
        private SMB_CustomTolbox.LathifButton ButtonShowPelanggan;
        private Label label1;
        private Panel panel7;
        private TextBox TextTelepon;
        private Panel panel8;
        private TextBox TextNama;
        private Label label2;
        private Label label7;
        private Panel panel9;
        private TextBox TextNomorKTP;
        private Label label8;
        private SMB_CustomTolbox.LathifButton ButtonCekKetersediaan;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
    }
}