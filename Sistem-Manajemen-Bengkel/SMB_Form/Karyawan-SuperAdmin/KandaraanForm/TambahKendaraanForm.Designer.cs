namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.KandaraanForm
{
    partial class TambahKendaraanForm
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
            pictureBox1 = new PictureBox();
            LabelJudul = new Label();
            panel4 = new Panel();
            ComboTransmisi = new ComboBox();
            panel10 = new Panel();
            TextTahun = new TextBox();
            panel11 = new Panel();
            TextKapasitasMesin = new TextBox();
            label3 = new Label();
            panel8 = new Panel();
            TextMerek = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel9 = new Panel();
            TextNoPolisi = new TextBox();
            label6 = new Label();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LabelJudul);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(ButtonSimpan);
            panel1.Controls.Add(ButtonBatal);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 709);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Motor;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(25, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJudul.ForeColor = Color.Black;
            LabelJudul.Location = new Point(121, 43);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(213, 31);
            LabelJudul.TabIndex = 45;
            LabelJudul.Text = "Tambah Kendaraan";
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(ComboTransmisi);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(25, 113);
            panel4.Name = "panel4";
            panel4.Size = new Size(444, 514);
            panel4.TabIndex = 2;
            // 
            // ComboTransmisi
            // 
            ComboTransmisi.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboTransmisi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboTransmisi.FormattingEnabled = true;
            ComboTransmisi.IntegralHeight = false;
            ComboTransmisi.Location = new Point(29, 241);
            ComboTransmisi.Name = "ComboTransmisi";
            ComboTransmisi.Size = new Size(383, 33);
            ComboTransmisi.TabIndex = 66;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(TextTahun);
            panel10.Location = new Point(29, 432);
            panel10.Name = "panel10";
            panel10.Size = new Size(383, 44);
            panel10.TabIndex = 5;
            // 
            // TextTahun
            // 
            TextTahun.BackColor = Color.White;
            TextTahun.BorderStyle = BorderStyle.None;
            TextTahun.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextTahun.Location = new Point(4, 10);
            TextTahun.MaxLength = 4;
            TextTahun.Name = "TextTahun";
            TextTahun.Size = new Size(373, 23);
            TextTahun.TabIndex = 49;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(TextKapasitasMesin);
            panel11.Location = new Point(29, 339);
            panel11.Name = "panel11";
            panel11.Size = new Size(383, 44);
            panel11.TabIndex = 4;
            // 
            // TextKapasitasMesin
            // 
            TextKapasitasMesin.BackColor = Color.White;
            TextKapasitasMesin.BorderStyle = BorderStyle.None;
            TextKapasitasMesin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextKapasitasMesin.Location = new Point(4, 10);
            TextKapasitasMesin.MaxLength = 6;
            TextKapasitasMesin.Name = "TextKapasitasMesin";
            TextKapasitasMesin.Size = new Size(373, 23);
            TextKapasitasMesin.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(29, 404);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 65;
            label3.Text = "Tahun";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(TextMerek);
            panel8.Location = new Point(29, 148);
            panel8.Name = "panel8";
            panel8.Size = new Size(383, 44);
            panel8.TabIndex = 2;
            // 
            // TextMerek
            // 
            TextMerek.BackColor = Color.White;
            TextMerek.BorderStyle = BorderStyle.None;
            TextMerek.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextMerek.Location = new Point(4, 10);
            TextMerek.MaxLength = 50;
            TextMerek.Name = "TextMerek";
            TextMerek.Size = new Size(373, 23);
            TextMerek.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(29, 311);
            label8.Name = "label8";
            label8.Size = new Size(178, 25);
            label8.TabIndex = 64;
            label8.Text = "Kapasitas Mesin (cc)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(29, 213);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 61;
            label4.Text = "Transmisi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(29, 120);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 60;
            label5.Text = "Merek";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(TextNoPolisi);
            panel9.Location = new Point(29, 58);
            panel9.Name = "panel9";
            panel9.Size = new Size(383, 44);
            panel9.TabIndex = 1;
            // 
            // TextNoPolisi
            // 
            TextNoPolisi.BackColor = Color.White;
            TextNoPolisi.BorderStyle = BorderStyle.None;
            TextNoPolisi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextNoPolisi.Location = new Point(4, 10);
            TextNoPolisi.MaxLength = 10;
            TextNoPolisi.Name = "TextNoPolisi";
            TextNoPolisi.Size = new Size(373, 23);
            TextNoPolisi.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(29, 30);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 57;
            label6.Text = "No. Polisi";
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.BackColor = Color.ForestGreen;
            ButtonSimpan.BackgroundColor = Color.ForestGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(334, 645);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(135, 45);
            ButtonSimpan.TabIndex = 3;
            ButtonSimpan.Text = "✅ Simpan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
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
            ButtonBatal.Location = new Point(181, 645);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(135, 45);
            ButtonBatal.TabIndex = 4;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // TambahKendaraanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(515, 733);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TambahKendaraanForm";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
        private Panel panel10;
        private TextBox TextTahun;
        private Panel panel11;
        private TextBox TextKapasitasMesin;
        private Label label3;
        private Panel panel8;
        private TextBox TextMerek;
        private Label label8;
        private Label label4;
        private Label label5;
        private Panel panel9;
        private TextBox TextNoPolisi;
        private Label label6;
        private Label LabelJudul;
        private PictureBox pictureBox1;
        private ComboBox ComboTransmisi;
    }
}