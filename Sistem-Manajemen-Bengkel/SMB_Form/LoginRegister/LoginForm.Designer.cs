namespace Sistem_Manajemen_Bengkel.SMB_Form
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
            panel1 = new Panel();
            panel4 = new Panel();
            TextPassword = new TextBox();
            panel3 = new Panel();
            TextUsername = new TextBox();
            LinkRegistrasi = new LinkLabel();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            ButtonLogin = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(LinkRegistrasi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(ButtonLogin);
            panel1.Location = new Point(338, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 385);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(TextPassword);
            panel4.Location = new Point(20, 234);
            panel4.Name = "panel4";
            panel4.Size = new Size(247, 41);
            panel4.TabIndex = 1;
            // 
            // TextPassword
            // 
            TextPassword.BorderStyle = BorderStyle.None;
            TextPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPassword.Location = new Point(8, 7);
            TextPassword.Name = "TextPassword";
            TextPassword.PlaceholderText = "Password";
            TextPassword.Size = new Size(230, 24);
            TextPassword.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TextUsername);
            panel3.Location = new Point(20, 142);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 41);
            panel3.TabIndex = 0;
            // 
            // TextUsername
            // 
            TextUsername.BorderStyle = BorderStyle.None;
            TextUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextUsername.Location = new Point(8, 8);
            TextUsername.Name = "TextUsername";
            TextUsername.PlaceholderText = "Username";
            TextUsername.Size = new Size(230, 24);
            TextUsername.TabIndex = 0;
            // 
            // LinkRegistrasi
            // 
            LinkRegistrasi.AutoSize = true;
            LinkRegistrasi.Location = new Point(191, 347);
            LinkRegistrasi.Name = "LinkRegistrasi";
            LinkRegistrasi.Size = new Size(63, 20);
            LinkRegistrasi.TabIndex = 4;
            LinkRegistrasi.TabStop = true;
            LinkRegistrasi.Text = "Register";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 347);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 8;
            label1.Text = "Don't have an account?";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.Gembok;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(20, 203);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.User_Hitam;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(20, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.FromArgb(82, 109, 130);
            ButtonLogin.FlatAppearance.BorderSize = 0;
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLogin.ForeColor = Color.White;
            ButtonLogin.Location = new Point(20, 296);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(247, 45);
            ButtonLogin.TabIndex = 3;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._3D_LoginNew;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(48, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 357);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(221, 230, 237);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 449);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(82, 109, 130);
            label2.Location = new Point(96, 38);
            label2.Name = "label2";
            label2.Size = new Size(97, 35);
            label2.TabIndex = 9;
            label2.Text = "LOGIN";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 449);
            Controls.Add(panel2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button ButtonLogin;
        private TextBox TextPassword;
        private TextBox TextUsername;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
        private LinkLabel LinkRegistrasi;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
    }
}