namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    partial class InputPelangganForm
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
            LinkReset = new LinkLabel();
            LabelResetPass = new Label();
            LabelPassword = new Label();
            LabelConfirmPass = new Label();
            label9 = new Label();
            panel8 = new Panel();
            ButtonShowHideConfrmPassword = new Button();
            TextConfirmPassword = new TextBox();
            LabelEmail = new Label();
            label6 = new Label();
            label5 = new Label();
            panel9 = new Panel();
            TextPassword = new TextBox();
            ButtonShowHidePassword = new Button();
            panel10 = new Panel();
            TextEmail = new TextBox();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            panel3 = new Panel();
            LabelNoHP = new Label();
            LabelNIK = new Label();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            TextNoKTP = new TextBox();
            panel2 = new Panel();
            TextNomorHP = new TextBox();
            panel6 = new Panel();
            TextAlamat = new TextBox();
            panel7 = new Panel();
            TextNamaLengkap = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
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
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 729);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.target;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(36, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJudul.ForeColor = Color.Black;
            LabelJudul.Location = new Point(132, 63);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(183, 31);
            LabelJudul.TabIndex = 46;
            LabelJudul.Text = "Input Pelanggan";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(LinkReset);
            panel4.Controls.Add(LabelResetPass);
            panel4.Controls.Add(LabelPassword);
            panel4.Controls.Add(LabelConfirmPass);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(LabelEmail);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel10);
            panel4.Location = new Point(538, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(471, 495);
            panel4.TabIndex = 2;
            // 
            // LinkReset
            // 
            LinkReset.AutoSize = true;
            LinkReset.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LinkReset.Location = new Point(293, 350);
            LinkReset.Name = "LinkReset";
            LinkReset.Size = new Size(45, 20);
            LinkReset.TabIndex = 4;
            LinkReset.TabStop = true;
            LinkReset.Text = "Reset";
            LinkReset.Visible = false;
            // 
            // LabelResetPass
            // 
            LabelResetPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelResetPass.ForeColor = Color.Black;
            LabelResetPass.Location = new Point(31, 350);
            LabelResetPass.Name = "LabelResetPass";
            LabelResetPass.Size = new Size(266, 23);
            LabelResetPass.TabIndex = 50;
            LabelResetPass.Tag = "ConfirmPassword";
            LabelResetPass.Text = "Apakah anda ingin mereset password?";
            LabelResetPass.TextAlign = ContentAlignment.MiddleLeft;
            LabelResetPass.Visible = false;
            // 
            // LabelPassword
            // 
            LabelPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.ForeColor = Color.Red;
            LabelPassword.Location = new Point(106, 141);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(333, 23);
            LabelPassword.TabIndex = 39;
            LabelPassword.Tag = "Password";
            LabelPassword.Text = "⚠ Harus kombinasi huruf besar/kecil/angka";
            LabelPassword.TextAlign = ContentAlignment.MiddleRight;
            LabelPassword.Visible = false;
            // 
            // LabelConfirmPass
            // 
            LabelConfirmPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelConfirmPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelConfirmPass.ForeColor = Color.Red;
            LabelConfirmPass.Location = new Point(177, 280);
            LabelConfirmPass.Name = "LabelConfirmPass";
            LabelConfirmPass.Size = new Size(262, 23);
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
            label9.Location = new Point(31, 281);
            label9.Name = "label9";
            label9.Size = new Size(149, 23);
            label9.TabIndex = 37;
            label9.Text = "Confirm Password";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(ButtonShowHideConfrmPassword);
            panel8.Controls.Add(TextConfirmPassword);
            panel8.Location = new Point(31, 306);
            panel8.Name = "panel8";
            panel8.Size = new Size(408, 41);
            panel8.TabIndex = 3;
            // 
            // ButtonShowHideConfrmPassword
            // 
            ButtonShowHideConfrmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonShowHideConfrmPassword.BackColor = Color.Transparent;
            ButtonShowHideConfrmPassword.BackgroundImage = Properties.Resources.HidePassword;
            ButtonShowHideConfrmPassword.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonShowHideConfrmPassword.FlatAppearance.BorderSize = 0;
            ButtonShowHideConfrmPassword.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonShowHideConfrmPassword.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtonShowHideConfrmPassword.FlatStyle = FlatStyle.Flat;
            ButtonShowHideConfrmPassword.Location = new Point(367, 5);
            ButtonShowHideConfrmPassword.Name = "ButtonShowHideConfrmPassword";
            ButtonShowHideConfrmPassword.Size = new Size(30, 29);
            ButtonShowHideConfrmPassword.TabIndex = 9;
            ButtonShowHideConfrmPassword.UseVisualStyleBackColor = false;
            // 
            // TextConfirmPassword
            // 
            TextConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextConfirmPassword.BorderStyle = BorderStyle.None;
            TextConfirmPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextConfirmPassword.Location = new Point(6, 7);
            TextConfirmPassword.Name = "TextConfirmPassword";
            TextConfirmPassword.PasswordChar = '•';
            TextConfirmPassword.Size = new Size(350, 24);
            TextConfirmPassword.TabIndex = 6;
            TextConfirmPassword.Tag = "ConfirmPassword";
            // 
            // LabelEmail
            // 
            LabelEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEmail.ForeColor = Color.Red;
            LabelEmail.Location = new Point(106, 25);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(333, 23);
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
            label6.Location = new Point(31, 25);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 35;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 140);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 34;
            label5.Text = "Password";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.White;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(TextPassword);
            panel9.Controls.Add(ButtonShowHidePassword);
            panel9.Location = new Point(31, 166);
            panel9.Name = "panel9";
            panel9.Size = new Size(408, 41);
            panel9.TabIndex = 2;
            // 
            // TextPassword
            // 
            TextPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextPassword.BorderStyle = BorderStyle.None;
            TextPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPassword.Location = new Point(6, 7);
            TextPassword.Name = "TextPassword";
            TextPassword.PasswordChar = '•';
            TextPassword.Size = new Size(350, 24);
            TextPassword.TabIndex = 5;
            TextPassword.Tag = "Password";
            // 
            // ButtonShowHidePassword
            // 
            ButtonShowHidePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonShowHidePassword.BackColor = Color.Transparent;
            ButtonShowHidePassword.BackgroundImage = Properties.Resources.HidePassword;
            ButtonShowHidePassword.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonShowHidePassword.FlatAppearance.BorderSize = 0;
            ButtonShowHidePassword.FlatAppearance.MouseDownBackColor = Color.Transparent;
            ButtonShowHidePassword.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ButtonShowHidePassword.FlatStyle = FlatStyle.Flat;
            ButtonShowHidePassword.Location = new Point(367, 5);
            ButtonShowHidePassword.Name = "ButtonShowHidePassword";
            ButtonShowHidePassword.Size = new Size(30, 29);
            ButtonShowHidePassword.TabIndex = 8;
            ButtonShowHidePassword.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(TextEmail);
            panel10.Location = new Point(31, 51);
            panel10.Name = "panel10";
            panel10.Size = new Size(408, 41);
            panel10.TabIndex = 1;
            // 
            // TextEmail
            // 
            TextEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextEmail.BorderStyle = BorderStyle.None;
            TextEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextEmail.Location = new Point(6, 7);
            TextEmail.MaxLength = 50;
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(397, 24);
            TextEmail.TabIndex = 4;
            TextEmail.Tag = "Email";
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSimpan.BackColor = Color.ForestGreen;
            ButtonSimpan.BackgroundColor = Color.ForestGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(871, 652);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(135, 45);
            ButtonSimpan.TabIndex = 4;
            ButtonSimpan.Text = "✅ Simpan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
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
            ButtonBatal.Location = new Point(724, 652);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(135, 45);
            ButtonBatal.TabIndex = 3;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(LabelNoHP);
            panel3.Controls.Add(LabelNIK);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel7);
            panel3.Location = new Point(36, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 495);
            panel3.TabIndex = 1;
            // 
            // LabelNoHP
            // 
            LabelNoHP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoHP.ForeColor = Color.Red;
            LabelNoHP.Location = new Point(171, 141);
            LabelNoHP.Name = "LabelNoHP";
            LabelNoHP.Size = new Size(267, 23);
            LabelNoHP.TabIndex = 35;
            LabelNoHP.Tag = "NoHP";
            LabelNoHP.Text = "⚠ Nomor HP sudah terdaftar";
            LabelNoHP.TextAlign = ContentAlignment.MiddleRight;
            LabelNoHP.Visible = false;
            // 
            // LabelNIK
            // 
            LabelNIK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNIK.ForeColor = Color.Red;
            LabelNIK.Location = new Point(177, 26);
            LabelNIK.Name = "LabelNIK";
            LabelNIK.Size = new Size(261, 23);
            LabelNIK.TabIndex = 34;
            LabelNIK.Tag = "NIK";
            LabelNIK.Text = "⚠ No. KTP sudah terdaftar";
            LabelNIK.TextAlign = ContentAlignment.MiddleRight;
            LabelNIK.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 255);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 33;
            label1.Text = "Nama Lengkap";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 370);
            label7.Name = "label7";
            label7.Size = new Size(64, 23);
            label7.TabIndex = 32;
            label7.Text = "Alamat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 140);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 31;
            label2.Text = "No. HP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 25);
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
            panel5.Location = new Point(28, 51);
            panel5.Name = "panel5";
            panel5.Size = new Size(410, 41);
            panel5.TabIndex = 1;
            // 
            // TextNoKTP
            // 
            TextNoKTP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextNoKTP.BorderStyle = BorderStyle.None;
            TextNoKTP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNoKTP.Location = new Point(6, 7);
            TextNoKTP.MaxLength = 16;
            TextNoKTP.Name = "TextNoKTP";
            TextNoKTP.Size = new Size(399, 24);
            TextNoKTP.TabIndex = 1;
            TextNoKTP.Tag = "NIK";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextNomorHP);
            panel2.Location = new Point(28, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 41);
            panel2.TabIndex = 2;
            // 
            // TextNomorHP
            // 
            TextNomorHP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextNomorHP.BorderStyle = BorderStyle.None;
            TextNomorHP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNomorHP.Location = new Point(6, 7);
            TextNomorHP.MaxLength = 13;
            TextNomorHP.Name = "TextNomorHP";
            TextNomorHP.Size = new Size(399, 24);
            TextNomorHP.TabIndex = 1;
            TextNomorHP.Tag = "NoHP";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TextAlamat);
            panel6.Location = new Point(28, 396);
            panel6.Name = "panel6";
            panel6.Size = new Size(410, 41);
            panel6.TabIndex = 4;
            // 
            // TextAlamat
            // 
            TextAlamat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextAlamat.BorderStyle = BorderStyle.None;
            TextAlamat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextAlamat.Location = new Point(6, 7);
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(399, 24);
            TextAlamat.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextNamaLengkap);
            panel7.Location = new Point(28, 281);
            panel7.Name = "panel7";
            panel7.Size = new Size(410, 41);
            panel7.TabIndex = 3;
            // 
            // TextNamaLengkap
            // 
            TextNamaLengkap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextNamaLengkap.BorderStyle = BorderStyle.None;
            TextNamaLengkap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNamaLengkap.Location = new Point(6, 8);
            TextNamaLengkap.MaxLength = 50;
            TextNamaLengkap.Name = "TextNamaLengkap";
            TextNamaLengkap.Size = new Size(399, 24);
            TextNamaLengkap.TabIndex = 2;
            // 
            // InputPelangganForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1064, 753);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InputPelangganForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Label LabelNoHP;
        private Label LabelNIK;
        private Label label1;
        private Label label7;
        private Label label2;
        private Label label10;
        private Panel panel5;
        private TextBox TextNoKTP;
        private Panel panel2;
        private TextBox TextNomorHP;
        private Panel panel6;
        private TextBox TextAlamat;
        private Panel panel7;
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
        private Label LabelJudul;
        private PictureBox pictureBox1;
        private LinkLabel LinkReset;
        private Label LabelResetPass;
        private Button ButtonShowHideConfrmPassword;
        private Button ButtonShowHidePassword;
    }
}