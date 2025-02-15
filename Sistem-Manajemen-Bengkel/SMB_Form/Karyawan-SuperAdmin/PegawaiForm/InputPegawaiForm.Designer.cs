namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    partial class InputPegawaiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputPegawaiForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            LabelJudul = new Label();
            panel4 = new Panel();
            LinkReset = new LinkLabel();
            LabelResetPass = new Label();
            LabelNoHP = new Label();
            label1 = new Label();
            panel6 = new Panel();
            TextNoHP = new TextBox();
            label3 = new Label();
            RadioKaryawan = new MaterialSkin.Controls.MaterialRadioButton();
            RadioSuperAdmin = new MaterialSkin.Controls.MaterialRadioButton();
            LabelPassword = new Label();
            LabelConfirmPass = new Label();
            label9 = new Label();
            panel8 = new Panel();
            TextConfirmPassword = new TextBox();
            LabelEmail = new Label();
            label6 = new Label();
            label5 = new Label();
            panel9 = new Panel();
            TextPassword = new TextBox();
            panel10 = new Panel();
            TextEmail = new TextBox();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            panel3 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            TextAlamat = new TextBox();
            ButtonEditProfiles = new SMB_CustomTolbox.LathifButton();
            PictureProfiles = new SMB_CustomTolbox.RJCircularPictureBox();
            LabelNIK = new Label();
            label2 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            TextNoKTP = new TextBox();
            panel2 = new Panel();
            TextNamaLengkap = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProfiles).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LabelJudul);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(ButtonSimpan);
            panel1.Controls.Add(ButtonBatal);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 787);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.technical_support;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(24, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJudul.ForeColor = Color.Black;
            LabelJudul.Location = new Point(120, 39);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(197, 38);
            LabelJudul.TabIndex = 45;
            LabelJudul.Text = "Input Pegawai";
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(LinkReset);
            panel4.Controls.Add(LabelResetPass);
            panel4.Controls.Add(LabelNoHP);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(RadioKaryawan);
            panel4.Controls.Add(RadioSuperAdmin);
            panel4.Controls.Add(LabelPassword);
            panel4.Controls.Add(LabelConfirmPass);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(LabelEmail);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel10);
            panel4.Location = new Point(484, 106);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 590);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // LinkReset
            // 
            LinkReset.AutoSize = true;
            LinkReset.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LinkReset.Location = new Point(285, 421);
            LinkReset.Name = "LinkReset";
            LinkReset.Size = new Size(45, 20);
            LinkReset.TabIndex = 5;
            LinkReset.TabStop = true;
            LinkReset.Text = "Reset";
            LinkReset.Visible = false;
            // 
            // LabelResetPass
            // 
            LabelResetPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelResetPass.ForeColor = Color.Black;
            LabelResetPass.Location = new Point(23, 420);
            LabelResetPass.Name = "LabelResetPass";
            LabelResetPass.Size = new Size(266, 23);
            LabelResetPass.TabIndex = 52;
            LabelResetPass.Tag = "ConfirmPassword";
            LabelResetPass.Text = "Apakah anda ingin mereset password?";
            LabelResetPass.TextAlign = ContentAlignment.MiddleLeft;
            LabelResetPass.Visible = false;
            // 
            // LabelNoHP
            // 
            LabelNoHP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoHP.ForeColor = Color.Red;
            LabelNoHP.Location = new Point(169, 26);
            LabelNoHP.Name = "LabelNoHP";
            LabelNoHP.Size = new Size(242, 23);
            LabelNoHP.TabIndex = 46;
            LabelNoHP.Tag = "Email";
            LabelNoHP.Text = "⚠ No HP sudah terdaftar";
            LabelNoHP.TextAlign = ContentAlignment.MiddleRight;
            LabelNoHP.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 26);
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
            panel6.Location = new Point(23, 52);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 41);
            panel6.TabIndex = 1;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 465);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 43;
            label3.Text = "Role";
            // 
            // RadioKaryawan
            // 
            RadioKaryawan.AutoSize = true;
            RadioKaryawan.Depth = 0;
            RadioKaryawan.Location = new Point(322, 495);
            RadioKaryawan.Margin = new Padding(0);
            RadioKaryawan.MouseLocation = new Point(-1, -1);
            RadioKaryawan.MouseState = MaterialSkin.MouseState.HOVER;
            RadioKaryawan.Name = "RadioKaryawan";
            RadioKaryawan.Ripple = true;
            RadioKaryawan.Size = new Size(93, 37);
            RadioKaryawan.TabIndex = 7;
            RadioKaryawan.TabStop = true;
            RadioKaryawan.Text = "Petugas";
            RadioKaryawan.UseVisualStyleBackColor = true;
            // 
            // RadioSuperAdmin
            // 
            RadioSuperAdmin.AutoSize = true;
            RadioSuperAdmin.Depth = 0;
            RadioSuperAdmin.Location = new Point(23, 495);
            RadioSuperAdmin.Margin = new Padding(0);
            RadioSuperAdmin.MouseLocation = new Point(-1, -1);
            RadioSuperAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            RadioSuperAdmin.Name = "RadioSuperAdmin";
            RadioSuperAdmin.Ripple = true;
            RadioSuperAdmin.Size = new Size(126, 37);
            RadioSuperAdmin.TabIndex = 6;
            RadioSuperAdmin.TabStop = true;
            RadioSuperAdmin.Text = "Super Admin";
            RadioSuperAdmin.UseVisualStyleBackColor = true;
            // 
            // LabelPassword
            // 
            LabelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.ForeColor = Color.Red;
            LabelPassword.Location = new Point(102, 243);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(313, 23);
            LabelPassword.TabIndex = 39;
            LabelPassword.Tag = "Password";
            LabelPassword.Text = "⚠ Harus kombinasi huruf besar/kecil/angka";
            LabelPassword.TextAlign = ContentAlignment.MiddleRight;
            LabelPassword.Visible = false;
            // 
            // LabelConfirmPass
            // 
            LabelConfirmPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelConfirmPass.ForeColor = Color.Red;
            LabelConfirmPass.Location = new Point(178, 352);
            LabelConfirmPass.Name = "LabelConfirmPass";
            LabelConfirmPass.Size = new Size(237, 23);
            LabelConfirmPass.TabIndex = 38;
            LabelConfirmPass.Tag = "ConfirmPassword";
            LabelConfirmPass.Text = "⚠ Password tidak valid";
            LabelConfirmPass.TextAlign = ContentAlignment.MiddleRight;
            LabelConfirmPass.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(23, 350);
            label9.Name = "label9";
            label9.Size = new Size(149, 23);
            label9.TabIndex = 37;
            label9.Text = "Confirm Password";
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(TextConfirmPassword);
            panel8.Location = new Point(23, 376);
            panel8.Name = "panel8";
            panel8.Size = new Size(392, 41);
            panel8.TabIndex = 4;
            panel8.Paint += panel8_Paint;
            // 
            // TextConfirmPassword
            // 
            TextConfirmPassword.BorderStyle = BorderStyle.None;
            TextConfirmPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextConfirmPassword.Location = new Point(6, 7);
            TextConfirmPassword.Name = "TextConfirmPassword";
            TextConfirmPassword.PasswordChar = '•';
            TextConfirmPassword.Size = new Size(381, 24);
            TextConfirmPassword.TabIndex = 6;
            TextConfirmPassword.Tag = "ConfirmPassword";
            // 
            // LabelEmail
            // 
            LabelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEmail.ForeColor = Color.Red;
            LabelEmail.Location = new Point(107, 134);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(308, 23);
            LabelEmail.TabIndex = 36;
            LabelEmail.Tag = "Email";
            LabelEmail.Text = "⚠ Email sudah terdaftar";
            LabelEmail.TextAlign = ContentAlignment.MiddleRight;
            LabelEmail.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(23, 134);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 35;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(23, 242);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 34;
            label5.Text = "Password";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(TextPassword);
            panel9.Location = new Point(23, 268);
            panel9.Name = "panel9";
            panel9.Size = new Size(392, 41);
            panel9.TabIndex = 3;
            // 
            // TextPassword
            // 
            TextPassword.BorderStyle = BorderStyle.None;
            TextPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPassword.Location = new Point(6, 7);
            TextPassword.Name = "TextPassword";
            TextPassword.PasswordChar = '•';
            TextPassword.Size = new Size(381, 24);
            TextPassword.TabIndex = 5;
            TextPassword.Tag = "Password";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(TextEmail);
            panel10.Location = new Point(23, 160);
            panel10.Name = "panel10";
            panel10.Size = new Size(392, 41);
            panel10.TabIndex = 2;
            // 
            // TextEmail
            // 
            TextEmail.BorderStyle = BorderStyle.None;
            TextEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextEmail.Location = new Point(6, 7);
            TextEmail.MaxLength = 50;
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(381, 24);
            TextEmail.TabIndex = 4;
            TextEmail.Tag = "Email";
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.Anchor = AnchorStyles.None;
            ButtonSimpan.BackColor = Color.ForestGreen;
            ButtonSimpan.BackgroundColor = Color.ForestGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(790, 716);
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
            ButtonBatal.Location = new Point(634, 716);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(135, 45);
            ButtonBatal.TabIndex = 3;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(ButtonEditProfiles);
            panel3.Controls.Add(PictureProfiles);
            panel3.Controls.Add(LabelNIK);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(24, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 590);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 471);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 37;
            label4.Text = "Alamat";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextAlamat);
            panel7.Location = new Point(21, 498);
            panel7.Name = "panel7";
            panel7.Size = new Size(386, 41);
            panel7.TabIndex = 36;
            // 
            // TextAlamat
            // 
            TextAlamat.BorderStyle = BorderStyle.None;
            TextAlamat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextAlamat.Location = new Point(6, 7);
            TextAlamat.MaxLength = 100;
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(375, 24);
            TextAlamat.TabIndex = 1;
            TextAlamat.Tag = "NamaLengkap";
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
            ButtonEditProfiles.Font = new Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEditProfiles.ForeColor = Color.White;
            ButtonEditProfiles.Location = new Point(162, 183);
            ButtonEditProfiles.Name = "ButtonEditProfiles";
            ButtonEditProfiles.Size = new Size(104, 37);
            ButtonEditProfiles.TabIndex = 1;
            ButtonEditProfiles.Text = "♻ Ganti";
            ButtonEditProfiles.TextColor = Color.White;
            ButtonEditProfiles.UseVisualStyleBackColor = false;
            // 
            // PictureProfiles
            // 
            PictureProfiles.BackgroundImageLayout = ImageLayout.Stretch;
            PictureProfiles.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            PictureProfiles.BorderColor = Color.FromArgb(83, 92, 145);
            PictureProfiles.BorderColor2 = Color.FromArgb(83, 92, 145);
            PictureProfiles.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            PictureProfiles.BorderSize = 2;
            PictureProfiles.GradientAngle = 50F;
            PictureProfiles.Image = (Image)resources.GetObject("PictureProfiles.Image");
            PictureProfiles.Location = new Point(152, 44);
            PictureProfiles.Name = "PictureProfiles";
            PictureProfiles.Size = new Size(125, 125);
            PictureProfiles.SizeMode = PictureBoxSizeMode.Zoom;
            PictureProfiles.TabIndex = 35;
            PictureProfiles.TabStop = false;
            // 
            // LabelNIK
            // 
            LabelNIK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNIK.ForeColor = Color.Red;
            LabelNIK.Location = new Point(109, 272);
            LabelNIK.Name = "LabelNIK";
            LabelNIK.Size = new Size(298, 23);
            LabelNIK.TabIndex = 34;
            LabelNIK.Tag = "NIK";
            LabelNIK.Text = "⚠ No. KTP sudah terdaftar";
            LabelNIK.TextAlign = ContentAlignment.MiddleRight;
            LabelNIK.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 371);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 31;
            label2.Text = "Nama Lengkap";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 271);
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
            panel5.Location = new Point(21, 298);
            panel5.Name = "panel5";
            panel5.Size = new Size(386, 41);
            panel5.TabIndex = 2;
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
            panel2.Location = new Point(21, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 41);
            panel2.TabIndex = 3;
            // 
            // TextNamaLengkap
            // 
            TextNamaLengkap.BorderStyle = BorderStyle.None;
            TextNamaLengkap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNamaLengkap.Location = new Point(6, 7);
            TextNamaLengkap.MaxLength = 50;
            TextNamaLengkap.Name = "TextNamaLengkap";
            TextNamaLengkap.Size = new Size(375, 24);
            TextNamaLengkap.TabIndex = 1;
            TextNamaLengkap.Tag = "NamaLengkap";
            // 
            // InputPegawaiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(976, 811);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InputPegawaiForm";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProfiles).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label LabelPassword;
        private Label LabelConfirmPass;
        private Label label9;
        private Panel panel8;
        private TextBox TextConfirmPassword;
        private Label LabelEmail;
        private Label label6;
        private Label label5;
        private Panel panel9;
        private TextBox TextPassword;
        private Panel panel10;
        private TextBox TextEmail;
        private Label label3;
        private MaterialSkin.Controls.MaterialRadioButton RadioKaryawan;
        private MaterialSkin.Controls.MaterialRadioButton RadioSuperAdmin;
        private Label label1;
        private Panel panel6;
        private TextBox TextNoHP;
        private SMB_CustomTolbox.RJCircularPictureBox PictureProfiles;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private SMB_CustomTolbox.LathifButton ButtonEditProfiles;
        private Label LabelJudul;
        private PictureBox pictureBox1;
        private Label LabelNoHP;
        private Label label4;
        private Panel panel7;
        private TextBox TextAlamat;
        private LinkLabel LinkReset;
        private Label LabelResetPass;
    }
}