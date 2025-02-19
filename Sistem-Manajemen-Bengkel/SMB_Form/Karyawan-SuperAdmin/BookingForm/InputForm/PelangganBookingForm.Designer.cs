namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm.InputForm
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
            panel3 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            TextAlamat = new TextBox();
            ButtonShowPelanggan = new SMB_CustomTolbox.LathifButton();
            LabelNoKTP = new Label();
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
            panel4 = new Panel();
            ButtonTambahKendaraan = new SMB_CustomTolbox.LathifButton();
            comboBox1 = new ComboBox();
            panel5 = new Panel();
            label4 = new Label();
            lathifButton1 = new SMB_CustomTolbox.LathifButton();
            label13 = new Label();
            panel10 = new Panel();
            TextTahun = new TextBox();
            panel11 = new Panel();
            TextKapasitasMesin = new TextBox();
            label5 = new Label();
            panel12 = new Panel();
            TextMerek = new TextBox();
            label6 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel13 = new Panel();
            TextTransmisi = new TextBox();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(ButtonShowPelanggan);
            panel3.Controls.Add(LabelNoKTP);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 549);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(156, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 3);
            panel1.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(5, 5);
            label3.Name = "label3";
            label3.Size = new Size(161, 28);
            label3.TabIndex = 58;
            label3.Text = "A. Data Pribadi ";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TextAlamat);
            panel6.Location = new Point(28, 358);
            panel6.Name = "panel6";
            panel6.Size = new Size(409, 44);
            panel6.TabIndex = 5;
            // 
            // TextAlamat
            // 
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
            ButtonShowPelanggan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonShowPelanggan.BackColor = Color.Gray;
            ButtonShowPelanggan.BackgroundColor = Color.Gray;
            ButtonShowPelanggan.BorderColor = Color.Black;
            ButtonShowPelanggan.BorderRadius = 3;
            ButtonShowPelanggan.BorderSize = 0;
            ButtonShowPelanggan.FlatAppearance.BorderSize = 0;
            ButtonShowPelanggan.FlatStyle = FlatStyle.Flat;
            ButtonShowPelanggan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonShowPelanggan.ForeColor = Color.White;
            ButtonShowPelanggan.Location = new Point(384, 95);
            ButtonShowPelanggan.Name = "ButtonShowPelanggan";
            ButtonShowPelanggan.Size = new Size(53, 44);
            ButtonShowPelanggan.TabIndex = 2;
            ButtonShowPelanggan.Text = "...";
            ButtonShowPelanggan.TextColor = Color.White;
            ButtonShowPelanggan.UseVisualStyleBackColor = false;
            // 
            // LabelNoKTP
            // 
            LabelNoKTP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoKTP.ForeColor = Color.Red;
            LabelNoKTP.Location = new Point(148, 71);
            LabelNoKTP.Name = "LabelNoKTP";
            LabelNoKTP.Size = new Size(230, 23);
            LabelNoKTP.TabIndex = 56;
            LabelNoKTP.Text = "⚠ Nomor KTP tidak ditemukan";
            LabelNoKTP.TextAlign = ContentAlignment.MiddleRight;
            LabelNoKTP.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 330);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 56;
            label1.Text = "Alamat";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextTelepon);
            panel7.Location = new Point(28, 271);
            panel7.Name = "panel7";
            panel7.Size = new Size(409, 44);
            panel7.TabIndex = 4;
            // 
            // TextTelepon
            // 
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
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(TextNama);
            panel8.Location = new Point(28, 184);
            panel8.Name = "panel8";
            panel8.Size = new Size(409, 44);
            panel8.TabIndex = 3;
            // 
            // TextNama
            // 
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
            label2.Location = new Point(28, 243);
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
            label7.Location = new Point(28, 156);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 51;
            label7.Text = "Nama";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(TextNomorKTP);
            panel9.Location = new Point(28, 97);
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
            TextNomorKTP.PlaceholderText = "🔍 Cari berdasarkan nomor KTP ";
            TextNomorKTP.Size = new Size(341, 23);
            TextNomorKTP.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(28, 69);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 43;
            label8.Text = "No. KTP";
            // 
            // ButtonCekKetersediaan
            // 
            ButtonCekKetersediaan.BackColor = Color.FromArgb(83, 92, 145);
            ButtonCekKetersediaan.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonCekKetersediaan.BorderColor = Color.DarkGray;
            ButtonCekKetersediaan.BorderRadius = 5;
            ButtonCekKetersediaan.BorderSize = 0;
            ButtonCekKetersediaan.FlatAppearance.BorderSize = 0;
            ButtonCekKetersediaan.FlatStyle = FlatStyle.Flat;
            ButtonCekKetersediaan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCekKetersediaan.ForeColor = Color.White;
            ButtonCekKetersediaan.Location = new Point(650, 578);
            ButtonCekKetersediaan.Name = "ButtonCekKetersediaan";
            ButtonCekKetersediaan.Size = new Size(201, 45);
            ButtonCekKetersediaan.TabIndex = 52;
            ButtonCekKetersediaan.Text = "✅ Cek Antrean";
            ButtonCekKetersediaan.TextColor = Color.White;
            ButtonCekKetersediaan.UseVisualStyleBackColor = false;
            // 
            // ButtonBatal
            // 
            ButtonBatal.BackColor = Color.Red;
            ButtonBatal.BackgroundColor = Color.Red;
            ButtonBatal.BorderColor = Color.DarkGray;
            ButtonBatal.BorderRadius = 5;
            ButtonBatal.BorderSize = 0;
            ButtonBatal.FlatAppearance.BorderSize = 0;
            ButtonBatal.FlatStyle = FlatStyle.Flat;
            ButtonBatal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBatal.ForeColor = Color.White;
            ButtonBatal.Location = new Point(494, 578);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(135, 45);
            ButtonBatal.TabIndex = 51;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(ButtonTambahKendaraan);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(lathifButton1);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(494, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(470, 549);
            panel4.TabIndex = 60;
            panel4.Paint += panel4_Paint;
            // 
            // ButtonTambahKendaraan
            // 
            ButtonTambahKendaraan.BackColor = Color.FromArgb(83, 92, 145);
            ButtonTambahKendaraan.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonTambahKendaraan.BorderColor = Color.DarkGray;
            ButtonTambahKendaraan.BorderRadius = 3;
            ButtonTambahKendaraan.BorderSize = 0;
            ButtonTambahKendaraan.FlatAppearance.BorderSize = 0;
            ButtonTambahKendaraan.FlatStyle = FlatStyle.Flat;
            ButtonTambahKendaraan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonTambahKendaraan.ForeColor = Color.White;
            ButtonTambahKendaraan.Location = new Point(321, 95);
            ButtonTambahKendaraan.Name = "ButtonTambahKendaraan";
            ButtonTambahKendaraan.Size = new Size(116, 39);
            ButtonTambahKendaraan.TabIndex = 61;
            ButtonTambahKendaraan.Text = "➕ Tambah ";
            ButtonTambahKendaraan.TextColor = Color.White;
            ButtonTambahKendaraan.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(287, 33);
            comboBox1.TabIndex = 60;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.LightGray;
            panel5.Location = new Point(188, 24);
            panel5.Name = "panel5";
            panel5.Size = new Size(273, 3);
            panel5.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(5, 5);
            label4.Name = "label4";
            label4.Size = new Size(188, 28);
            label4.TabIndex = 58;
            label4.Text = "B. Data Kendaraan";
            // 
            // lathifButton1
            // 
            lathifButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lathifButton1.BackColor = Color.Gray;
            lathifButton1.BackgroundColor = Color.Gray;
            lathifButton1.BorderColor = Color.Black;
            lathifButton1.BorderRadius = 3;
            lathifButton1.BorderSize = 0;
            lathifButton1.FlatAppearance.BorderSize = 0;
            lathifButton1.FlatStyle = FlatStyle.Flat;
            lathifButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lathifButton1.ForeColor = Color.White;
            lathifButton1.Location = new Point(652, 95);
            lathifButton1.Name = "lathifButton1";
            lathifButton1.Size = new Size(53, 44);
            lathifButton1.TabIndex = 2;
            lathifButton1.Text = "...";
            lathifButton1.TextColor = Color.White;
            lathifButton1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(28, 69);
            label13.Name = "label13";
            label13.Size = new Size(232, 25);
            label13.TabIndex = 43;
            label13.Text = "Pilih Kendaraan (No Polisi)";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(TextTahun);
            panel10.Location = new Point(28, 474);
            panel10.Name = "panel10";
            panel10.Size = new Size(409, 44);
            panel10.TabIndex = 69;
            // 
            // TextTahun
            // 
            TextTahun.BackColor = Color.White;
            TextTahun.BorderStyle = BorderStyle.None;
            TextTahun.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextTahun.Location = new Point(4, 10);
            TextTahun.MaxLength = 100;
            TextTahun.Name = "TextTahun";
            TextTahun.Size = new Size(392, 23);
            TextTahun.TabIndex = 49;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(TextKapasitasMesin);
            panel11.Location = new Point(28, 381);
            panel11.Name = "panel11";
            panel11.Size = new Size(409, 44);
            panel11.TabIndex = 68;
            // 
            // TextKapasitasMesin
            // 
            TextKapasitasMesin.BackColor = Color.White;
            TextKapasitasMesin.BorderStyle = BorderStyle.None;
            TextKapasitasMesin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextKapasitasMesin.Location = new Point(4, 10);
            TextKapasitasMesin.MaxLength = 100;
            TextKapasitasMesin.Name = "TextKapasitasMesin";
            TextKapasitasMesin.Size = new Size(392, 23);
            TextKapasitasMesin.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(28, 446);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 73;
            label5.Text = "Tahun";
            // 
            // panel12
            // 
            panel12.BackColor = Color.White;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(TextMerek);
            panel12.Location = new Point(28, 190);
            panel12.Name = "panel12";
            panel12.Size = new Size(409, 44);
            panel12.TabIndex = 67;
            // 
            // TextMerek
            // 
            TextMerek.BackColor = Color.White;
            TextMerek.BorderStyle = BorderStyle.None;
            TextMerek.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextMerek.Location = new Point(4, 10);
            TextMerek.MaxLength = 100;
            TextMerek.Name = "TextMerek";
            TextMerek.Size = new Size(392, 23);
            TextMerek.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(28, 353);
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
            label10.Location = new Point(28, 255);
            label10.Name = "label10";
            label10.Size = new Size(90, 25);
            label10.TabIndex = 71;
            label10.Text = "Transmisi";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(28, 162);
            label11.Name = "label11";
            label11.Size = new Size(65, 25);
            label11.TabIndex = 70;
            label11.Text = "Merek";
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(TextTransmisi);
            panel13.Location = new Point(28, 294);
            panel13.Name = "panel13";
            panel13.Size = new Size(409, 44);
            panel13.TabIndex = 68;
            // 
            // TextTransmisi
            // 
            TextTransmisi.BackColor = Color.White;
            TextTransmisi.BorderStyle = BorderStyle.None;
            TextTransmisi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextTransmisi.Location = new Point(4, 10);
            TextTransmisi.MaxLength = 100;
            TextTransmisi.Name = "TextTransmisi";
            TextTransmisi.Size = new Size(392, 23);
            TextTransmisi.TabIndex = 49;
            // 
            // PelangganBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(981, 652);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(ButtonCekKetersediaan);
            Controls.Add(ButtonBatal);
            Name = "PelangganBookingForm";
            Text = "PelangganBookingForm";
            Load += PelangganBookingForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel2;
        private TextBox TextEmail;
        private Panel panel6;
        private TextBox TextAlamat;
        private SMB_CustomTolbox.LathifButton ButtonShowPelanggan;
        private Label label9;
        private Label LabelNoKTP;
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
        private Label label3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Panel panel10;
        private TextBox textBox1;
        private Panel panel11;
        private TextBox textBox2;
        private SMB_CustomTolbox.LathifButton lathifButton1;
        private Label label5;
        private Label label10;
        private Panel panel12;
        private TextBox textBox3;
        private Panel panel13;
        private TextBox textBox4;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox comboBox1;
        private SMB_CustomTolbox.LathifButton ButtonTambahKendaraan;
        private TextBox TextTransmisi;
        private TextBox TextTahun;
        private TextBox TextKapasitasMesin;
        private TextBox TextMerek;
        private Label label6;
    }
}