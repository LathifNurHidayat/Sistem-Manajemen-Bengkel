namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PelangganForm
{
    partial class InputEditPelanggan
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
            LabelJudul = new Label();
            panel4 = new Panel();
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
            LabelNoHP = new Label();
            LabelNIK = new Label();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            TextNIK = new TextBox();
            panel2 = new Panel();
            TextNomorHP = new TextBox();
            panel6 = new Panel();
            TextAlamat = new TextBox();
            panel7 = new Panel();
            TextNamaLengkap = new TextBox();
            panel1.SuspendLayout();
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
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJudul.ForeColor = Color.Black;
            LabelJudul.Location = new Point(36, 24);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(225, 38);
            LabelJudul.TabIndex = 46;
            LabelJudul.Text = "Input Pelanggan";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(LabelPassword);
            panel4.Controls.Add(LabelConfirmPass);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(LabelEmail);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel10);
            panel4.Location = new Point(544, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 561);
            panel4.TabIndex = 2;
            // 
            // LabelPassword
            // 
            LabelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.ForeColor = Color.Red;
            LabelPassword.Location = new Point(166, 166);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(268, 23);
            LabelPassword.TabIndex = 39;
            LabelPassword.Tag = "Password";
            LabelPassword.Text = "Harus berupa kombinasi huruf besar/kecil, dan angka";
            LabelPassword.TextAlign = ContentAlignment.MiddleRight;
            LabelPassword.Visible = false;
            // 
            // LabelConfirmPass
            // 
            LabelConfirmPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelConfirmPass.ForeColor = Color.Red;
            LabelConfirmPass.Location = new Point(197, 281);
            LabelConfirmPass.Name = "LabelConfirmPass";
            LabelConfirmPass.Size = new Size(237, 23);
            LabelConfirmPass.TabIndex = 38;
            LabelConfirmPass.Tag = "ConfirmPassword";
            LabelConfirmPass.Text = "Password tidak valid";
            LabelConfirmPass.TextAlign = ContentAlignment.MiddleRight;
            LabelConfirmPass.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(42, 280);
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
            panel8.Location = new Point(42, 306);
            panel8.Name = "panel8";
            panel8.Size = new Size(392, 41);
            panel8.TabIndex = 33;
            // 
            // TextConfirmPassword
            // 
            TextConfirmPassword.BorderStyle = BorderStyle.None;
            TextConfirmPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextConfirmPassword.Location = new Point(6, 7);
            TextConfirmPassword.Name = "TextConfirmPassword";
            TextConfirmPassword.PasswordChar = '*';
            TextConfirmPassword.Size = new Size(381, 24);
            TextConfirmPassword.TabIndex = 6;
            TextConfirmPassword.Tag = "ConfirmPassword";
            // 
            // LabelEmail
            // 
            LabelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEmail.ForeColor = Color.Red;
            LabelEmail.Location = new Point(126, 50);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(308, 23);
            LabelEmail.TabIndex = 36;
            LabelEmail.Tag = "Email";
            LabelEmail.Text = "Email sudah terdaftar";
            LabelEmail.TextAlign = ContentAlignment.MiddleRight;
            LabelEmail.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(42, 50);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 35;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(42, 165);
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
            panel9.Location = new Point(42, 191);
            panel9.Name = "panel9";
            panel9.Size = new Size(392, 41);
            panel9.TabIndex = 32;
            // 
            // TextPassword
            // 
            TextPassword.BorderStyle = BorderStyle.None;
            TextPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPassword.Location = new Point(6, 7);
            TextPassword.Name = "TextPassword";
            TextPassword.PasswordChar = '*';
            TextPassword.Size = new Size(381, 24);
            TextPassword.TabIndex = 5;
            TextPassword.Tag = "Password";
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(TextEmail);
            panel10.Location = new Point(42, 76);
            panel10.Name = "panel10";
            panel10.Size = new Size(392, 41);
            panel10.TabIndex = 31;
            // 
            // TextEmail
            // 
            TextEmail.BorderStyle = BorderStyle.None;
            TextEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextEmail.Location = new Point(6, 7);
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
            ButtonSimpan.Location = new Point(889, 652);
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
            ButtonBatal.Location = new Point(742, 652);
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
            panel3.Location = new Point(36, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 561);
            panel3.TabIndex = 1;
            // 
            // LabelNoHP
            // 
            LabelNoHP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoHP.ForeColor = Color.Red;
            LabelNoHP.Location = new Point(107, 166);
            LabelNoHP.Name = "LabelNoHP";
            LabelNoHP.Size = new Size(323, 23);
            LabelNoHP.TabIndex = 35;
            LabelNoHP.Tag = "NoHP";
            LabelNoHP.Text = "Nomor HP sudah terdaftar";
            LabelNoHP.TextAlign = ContentAlignment.MiddleRight;
            LabelNoHP.Visible = false;
            // 
            // LabelNIK
            // 
            LabelNIK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNIK.ForeColor = Color.Red;
            LabelNIK.Location = new Point(113, 50);
            LabelNIK.Name = "LabelNIK";
            LabelNIK.Size = new Size(317, 23);
            LabelNIK.TabIndex = 34;
            LabelNIK.Tag = "NIK";
            LabelNIK.Text = "No. KTP sudah terdaftar";
            LabelNIK.TextAlign = ContentAlignment.MiddleRight;
            LabelNIK.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 280);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 33;
            label1.Text = "Nama Lengkap";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(44, 395);
            label7.Name = "label7";
            label7.Size = new Size(64, 23);
            label7.TabIndex = 32;
            label7.Text = "Alamat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 165);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 31;
            label2.Text = "No. HP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(44, 50);
            label10.Name = "label10";
            label10.Size = new Size(71, 23);
            label10.TabIndex = 30;
            label10.Text = "No. KTP";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TextNIK);
            panel5.Location = new Point(44, 76);
            panel5.Name = "panel5";
            panel5.Size = new Size(386, 41);
            panel5.TabIndex = 26;
            // 
            // TextNIK
            // 
            TextNIK.BorderStyle = BorderStyle.None;
            TextNIK.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNIK.Location = new Point(6, 7);
            TextNIK.MaxLength = 16;
            TextNIK.Name = "TextNIK";
            TextNIK.Size = new Size(375, 24);
            TextNIK.TabIndex = 1;
            TextNIK.Tag = "NIK";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextNomorHP);
            panel2.Location = new Point(44, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 41);
            panel2.TabIndex = 27;
            // 
            // TextNomorHP
            // 
            TextNomorHP.BorderStyle = BorderStyle.None;
            TextNomorHP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNomorHP.Location = new Point(6, 7);
            TextNomorHP.MaxLength = 13;
            TextNomorHP.Name = "TextNomorHP";
            TextNomorHP.Size = new Size(375, 24);
            TextNomorHP.TabIndex = 1;
            TextNomorHP.Tag = "NoHP";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TextAlamat);
            panel6.Location = new Point(44, 421);
            panel6.Name = "panel6";
            panel6.Size = new Size(386, 41);
            panel6.TabIndex = 29;
            // 
            // TextAlamat
            // 
            TextAlamat.BorderStyle = BorderStyle.None;
            TextAlamat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextAlamat.Location = new Point(6, 7);
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(375, 24);
            TextAlamat.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextNamaLengkap);
            panel7.Location = new Point(44, 306);
            panel7.Name = "panel7";
            panel7.Size = new Size(386, 41);
            panel7.TabIndex = 28;
            // 
            // TextNamaLengkap
            // 
            TextNamaLengkap.BorderStyle = BorderStyle.None;
            TextNamaLengkap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNamaLengkap.Location = new Point(6, 8);
            TextNamaLengkap.Name = "TextNamaLengkap";
            TextNamaLengkap.Size = new Size(375, 24);
            TextNamaLengkap.TabIndex = 2;
            // 
            // InputEditPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 753);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InputEditPelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox TextNIK;
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
    }
}