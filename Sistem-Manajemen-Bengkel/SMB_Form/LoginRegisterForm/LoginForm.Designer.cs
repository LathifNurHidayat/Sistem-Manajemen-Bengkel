namespace Sistem_Manajemen_Bengkel.SMB_Form.LoginRegisterForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            ButtonShowHidePassword = new Button();
            TextPassword = new TextBox();
            panel3 = new Panel();
            TextEmail = new TextBox();
            LinkDaftar = new LinkLabel();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            ButtonMasuk = new Button();
            panel2 = new Panel();
            ButtonBack = new SMB_CustomTolbox.LathifButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(LinkDaftar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(ButtonMasuk);
            panel1.Location = new Point(354, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 526);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(175, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(51, 192);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 23;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(51, 291);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 22;
            label5.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(82, 109, 130);
            label2.Location = new Point(171, 116);
            label2.Name = "label2";
            label2.Size = new Size(110, 35);
            label2.TabIndex = 9;
            label2.Text = "MASUK";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(ButtonShowHidePassword);
            panel4.Controls.Add(TextPassword);
            panel4.Location = new Point(20, 320);
            panel4.Name = "panel4";
            panel4.Size = new Size(399, 41);
            panel4.TabIndex = 1;
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
            ButtonShowHidePassword.Location = new Point(361, 6);
            ButtonShowHidePassword.Name = "ButtonShowHidePassword";
            ButtonShowHidePassword.Size = new Size(30, 29);
            ButtonShowHidePassword.TabIndex = 1;
            ButtonShowHidePassword.UseVisualStyleBackColor = false;
            // 
            // TextPassword
            // 
            TextPassword.BorderStyle = BorderStyle.None;
            TextPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPassword.Location = new Point(8, 7);
            TextPassword.Name = "TextPassword";
            TextPassword.PasswordChar = '•';
            TextPassword.Size = new Size(350, 24);
            TextPassword.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TextEmail);
            panel3.Location = new Point(20, 221);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 41);
            panel3.TabIndex = 0;
            // 
            // TextEmail
            // 
            TextEmail.BorderStyle = BorderStyle.None;
            TextEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextEmail.Location = new Point(8, 8);
            TextEmail.Name = "TextEmail";
            TextEmail.Size = new Size(386, 24);
            TextEmail.TabIndex = 8;
            // 
            // LinkDaftar
            // 
            LinkDaftar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LinkDaftar.AutoSize = true;
            LinkDaftar.Location = new Point(251, 467);
            LinkDaftar.Name = "LinkDaftar";
            LinkDaftar.Size = new Size(51, 20);
            LinkDaftar.TabIndex = 3;
            LinkDaftar.TabStop = true;
            LinkDaftar.Text = "Daftar";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(111, 467);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 8;
            label1.Text = "Belum punya akun ?";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.BackgroundImage = Properties.Resources.Gembok;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(20, 289);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.BackgroundImage = Properties.Resources.User_Hitam;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(20, 190);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // ButtonMasuk
            // 
            ButtonMasuk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonMasuk.BackColor = Color.FromArgb(82, 109, 130);
            ButtonMasuk.FlatAppearance.BorderSize = 0;
            ButtonMasuk.FlatStyle = FlatStyle.Flat;
            ButtonMasuk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonMasuk.ForeColor = Color.White;
            ButtonMasuk.Location = new Point(20, 419);
            ButtonMasuk.Name = "ButtonMasuk";
            ButtonMasuk.Size = new Size(399, 45);
            ButtonMasuk.TabIndex = 2;
            ButtonMasuk.Text = "Masuk";
            ButtonMasuk.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(221, 230, 237);
            panel2.Controls.Add(ButtonBack);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1155, 981);
            panel2.TabIndex = 2;
            // 
            // ButtonBack
            // 
            ButtonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonBack.BackColor = Color.FromArgb(82, 109, 130);
            ButtonBack.BackgroundColor = Color.FromArgb(82, 109, 130);
            ButtonBack.BorderColor = Color.DarkGray;
            ButtonBack.BorderRadius = 5;
            ButtonBack.BorderSize = 0;
            ButtonBack.FlatAppearance.BorderSize = 0;
            ButtonBack.FlatStyle = FlatStyle.Flat;
            ButtonBack.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBack.ForeColor = Color.White;
            ButtonBack.Location = new Point(32, 906);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(109, 45);
            ButtonBack.TabIndex = 8;
            ButtonBack.Text = "Kembali";
            ButtonBack.TextColor = Color.White;
            ButtonBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonBack.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 981);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button ButtonMasuk;
        private TextBox TextPassword;
        private TextBox TextEmail;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
        private LinkLabel LinkDaftar;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Button ButtonShowHidePassword;
        private SMB_CustomTolbox.LathifButton ButtonBack;
        private PictureBox pictureBox1;
    }
}