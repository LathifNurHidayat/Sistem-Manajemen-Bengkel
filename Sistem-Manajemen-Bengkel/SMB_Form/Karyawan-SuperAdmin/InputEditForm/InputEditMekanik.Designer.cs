namespace Sistem_Manajemen_Bengkel.SMB_Form.SuperAdmin.DataKaryawanForm
{
    partial class InputEditKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputEditKaryawan));
            panel1 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            TextNoHP = new TextBox();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            panel3 = new Panel();
            ButtonEditProfiles = new SMB_CustomTolbox.LathifButton();
            LabelNIK = new Label();
            label2 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            TextNoKTP = new TextBox();
            panel2 = new Panel();
            TextNamaLengkap = new TextBox();
            PictureProfiles = new SMB_CustomTolbox.RJCircularPictureBox();
            LabelJudul = new Label();
            label4 = new Label();
            panel7 = new Panel();
            TextAlamat = new TextBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProfiles).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(LabelJudul);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(ButtonSimpan);
            panel1.Controls.Add(ButtonBatal);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 729);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(LabelNIK);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(544, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 561);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 329);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 45;
            label1.Text = "No. HP";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TextNoHP);
            panel6.Location = new Point(46, 354);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 41);
            panel6.TabIndex = 44;
            // 
            // TextNoHP
            // 
            TextNoHP.BorderStyle = BorderStyle.None;
            TextNoHP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNoHP.Location = new Point(6, 7);
            TextNoHP.MaxLength = 13;
            TextNoHP.Name = "TextNoHP";
            TextNoHP.Size = new Size(375, 24);
            TextNoHP.TabIndex = 1;
            TextNoHP.Tag = "NoHP";
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.Anchor = AnchorStyles.None;
            ButtonSimpan.BackColor = Color.LimeGreen;
            ButtonSimpan.BackgroundColor = Color.LimeGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(889, 654);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(135, 45);
            ButtonSimpan.TabIndex = 4;
            ButtonSimpan.Text = "✅ Simpan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
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
            ButtonBatal.Location = new Point(729, 654);
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
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(PictureProfiles);
            panel3.Controls.Add(ButtonEditProfiles);
            panel3.Location = new Point(36, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 561);
            panel3.TabIndex = 1;
            // 
            // ButtonEditProfiles
            // 
            ButtonEditProfiles.Anchor = AnchorStyles.None;
            ButtonEditProfiles.BackColor = Color.FromArgb(83, 92, 145);
            ButtonEditProfiles.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonEditProfiles.BorderColor = Color.DarkGray;
            ButtonEditProfiles.BorderRadius = 5;
            ButtonEditProfiles.BorderSize = 0;
            ButtonEditProfiles.FlatAppearance.BorderSize = 0;
            ButtonEditProfiles.FlatStyle = FlatStyle.Flat;
            ButtonEditProfiles.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonEditProfiles.ForeColor = Color.White;
            ButtonEditProfiles.Location = new Point(164, 354);
            ButtonEditProfiles.Name = "ButtonEditProfiles";
            ButtonEditProfiles.Size = new Size(137, 48);
            ButtonEditProfiles.TabIndex = 36;
            ButtonEditProfiles.Text = "🖍 Edit";
            ButtonEditProfiles.TextColor = Color.White;
            ButtonEditProfiles.UseVisualStyleBackColor = false;
            // 
            // LabelNIK
            // 
            LabelNIK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNIK.ForeColor = Color.Red;
            LabelNIK.Location = new Point(115, 56);
            LabelNIK.Name = "LabelNIK";
            LabelNIK.Size = new Size(317, 23);
            LabelNIK.TabIndex = 34;
            LabelNIK.Tag = "NIK";
            LabelNIK.Text = "No. KTP sudah terdaftar";
            LabelNIK.TextAlign = ContentAlignment.MiddleRight;
            LabelNIK.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 187);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 31;
            label2.Text = "Nama Lengkap";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(46, 56);
            label10.Name = "label10";
            label10.Size = new Size(71, 23);
            label10.TabIndex = 30;
            label10.Text = "No. KTP";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TextNoKTP);
            panel5.Location = new Point(46, 82);
            panel5.Name = "panel5";
            panel5.Size = new Size(386, 41);
            panel5.TabIndex = 26;
            // 
            // TextNoKTP
            // 
            TextNoKTP.BorderStyle = BorderStyle.None;
            TextNoKTP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNoKTP.Location = new Point(6, 7);
            TextNoKTP.MaxLength = 16;
            TextNoKTP.Name = "TextNoKTP";
            TextNoKTP.Size = new Size(375, 24);
            TextNoKTP.TabIndex = 1;
            TextNoKTP.Tag = "NIK";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextNamaLengkap);
            panel2.Location = new Point(46, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 41);
            panel2.TabIndex = 27;
            // 
            // TextNamaLengkap
            // 
            TextNamaLengkap.BorderStyle = BorderStyle.None;
            TextNamaLengkap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNamaLengkap.Location = new Point(6, 7);
            TextNamaLengkap.MaxLength = 13;
            TextNamaLengkap.Name = "TextNamaLengkap";
            TextNamaLengkap.Size = new Size(375, 24);
            TextNamaLengkap.TabIndex = 1;
            TextNamaLengkap.Tag = "NoHP";
            // 
            // PictureProfiles
            // 
            PictureProfiles.BackgroundImage = Properties.Resources.User_Hitam;
            PictureProfiles.BackgroundImageLayout = ImageLayout.Stretch;
            PictureProfiles.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            PictureProfiles.BorderColor = Color.FromArgb(83, 92, 145);
            PictureProfiles.BorderColor2 = Color.FromArgb(83, 92, 145);
            PictureProfiles.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            PictureProfiles.BorderSize = 2;
            PictureProfiles.GradientAngle = 50F;
            PictureProfiles.Image = (Image)resources.GetObject("PictureProfiles.Image");
            PictureProfiles.Location = new Point(138, 107);
            PictureProfiles.Name = "PictureProfiles";
            PictureProfiles.Size = new Size(193, 193);
            PictureProfiles.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureProfiles.TabIndex = 38;
            PictureProfiles.TabStop = false;
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJudul.ForeColor = Color.Black;
            LabelJudul.Location = new Point(36, 19);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(201, 38);
            LabelJudul.TabIndex = 44;
            LabelJudul.Text = "Input Mekanik";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(591, 525);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 47;
            label4.Text = "Alamat";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextAlamat);
            panel7.Location = new Point(591, 551);
            panel7.Name = "panel7";
            panel7.Size = new Size(386, 41);
            panel7.TabIndex = 46;
            // 
            // TextAlamat
            // 
            TextAlamat.BorderStyle = BorderStyle.None;
            TextAlamat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextAlamat.Location = new Point(6, 7);
            TextAlamat.MaxLength = 13;
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(375, 24);
            TextAlamat.TabIndex = 1;
            TextAlamat.Tag = "NoHP";
            // 
            // InputEditKaryawan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 753);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InputEditKaryawan";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProfiles).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
        private Label LabelNIK;
        private Label label2;
        private Label label10;
        private Panel panel5;
        private TextBox TextNoKTP;
        private Panel panel2;
        private TextBox TextNamaLengkap;
        private Label label1;
        private Panel panel6;
        private TextBox TextNoHP;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private SMB_CustomTolbox.LathifButton ButtonEditProfiles;
        private SMB_CustomTolbox.RJCircularPictureBox PictureProfiles;
        private Label LabelJudul;
        private Label label4;
        private Panel panel7;
        private TextBox TextAlamat;
    }
}