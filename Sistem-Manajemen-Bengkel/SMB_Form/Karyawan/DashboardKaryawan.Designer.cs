namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan
{
    partial class DashboardKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardKaryawan));
            panel2 = new Panel();
            ButtonLogout = new Button();
            LabelUsername = new Label();
            LabelRole = new Label();
            PictureProfile = new PictureBox();
            PanelMain = new Panel();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProfile).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(ButtonLogout);
            panel2.Controls.Add(LabelUsername);
            panel2.Controls.Add(LabelRole);
            panel2.Controls.Add(PictureProfile);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 699);
            panel2.TabIndex = 1;
            // 
            // ButtonLogout
            // 
            ButtonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonLogout.BackgroundImage = Properties.Resources.log_out;
            ButtonLogout.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonLogout.FlatAppearance.BorderSize = 0;
            ButtonLogout.FlatStyle = FlatStyle.Flat;
            ButtonLogout.Location = new Point(12, 637);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(50, 50);
            ButtonLogout.TabIndex = 10;
            ButtonLogout.UseVisualStyleBackColor = true;
            // 
            // LabelUsername
            // 
            LabelUsername.Anchor = AnchorStyles.Top;
            LabelUsername.AutoSize = true;
            LabelUsername.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUsername.Location = new Point(77, 197);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(165, 24);
            LabelUsername.TabIndex = 5;
            LabelUsername.Text = "Lathif Nur Hidayat";
            // 
            // LabelRole
            // 
            LabelRole.Anchor = AnchorStyles.Top;
            LabelRole.AutoSize = true;
            LabelRole.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelRole.ForeColor = Color.Gray;
            LabelRole.Location = new Point(105, 221);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(97, 20);
            LabelRole.TabIndex = 4;
            LabelRole.Text = "Super Admin";
            // 
            // PictureProfile
            // 
            PictureProfile.Anchor = AnchorStyles.Top;
            PictureProfile.BackgroundImage = Properties.Resources.Profile_Default;
            PictureProfile.BackgroundImageLayout = ImageLayout.Zoom;
            PictureProfile.Location = new Point(107, 94);
            PictureProfile.Name = "PictureProfile";
            PictureProfile.Size = new Size(100, 100);
            PictureProfile.TabIndex = 0;
            PictureProfile.TabStop = false;
            // 
            // PanelMain
            // 
            PanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelMain.BackColor = Color.FromArgb(221, 230, 237);
            PanelMain.Location = new Point(336, 20);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(885, 660);
            PanelMain.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Window;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Gray;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(0, 447);
            button3.Name = "button3";
            button3.Size = new Size(319, 53);
            button3.TabIndex = 14;
            button3.Text = "   Karyawan";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Window;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Gray;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 388);
            button4.Name = "button4";
            button4.Size = new Size(319, 53);
            button4.TabIndex = 13;
            button4.Text = "   Karyawan";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Window;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Gray;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(0, 329);
            button2.Name = "button2";
            button2.Size = new Size(319, 53);
            button2.TabIndex = 12;
            button2.Text = "   Karyawan";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Window;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Gray;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 270);
            button1.Name = "button1";
            button1.Size = new Size(319, 53);
            button1.TabIndex = 11;
            button1.Text = "   Karyawan";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // DashboardKaryawan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1239, 699);
            Controls.Add(PanelMain);
            Controls.Add(panel2);
            Name = "DashboardKaryawan";
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox PictureProfile;
        private Label LabelUsername;
        private Label LabelRole;
        private Panel PanelMain;
        private Button ButtonLogout;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button1;
    }
}