﻿namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.MainMenuForm
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            panel2 = new Panel();
            ButtonEditProfiles = new SMB_CustomTolbox.LathifButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ButtonDashboard = new Button();
            ButtonBooking = new Button();
            ButtonPelanggan = new Button();
            ButtonKendaraan = new Button();
            ButtonSparepart = new Button();
            ButtonPegawai = new Button();
            ButtonMekanik = new Button();
            ButtonServis = new Button();
            ButtonRiwayat = new Button();
            ButtonLogout = new Button();
            PictureProfiles = new SMB_CustomTolbox.RJCircularPictureBox();
            LabelUsername = new Label();
            LabelRole = new Label();
            PanelMain = new Panel();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProfiles).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ButtonEditProfiles);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(PictureProfiles);
            panel2.Controls.Add(LabelUsername);
            panel2.Controls.Add(LabelRole);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 1055);
            panel2.TabIndex = 1;
            // 
            // ButtonEditProfiles
            // 
            ButtonEditProfiles.Anchor = AnchorStyles.Top;
            ButtonEditProfiles.BackColor = Color.FromArgb(83, 92, 145);
            ButtonEditProfiles.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonEditProfiles.BorderColor = Color.DarkGray;
            ButtonEditProfiles.BorderRadius = 5;
            ButtonEditProfiles.BorderSize = 0;
            ButtonEditProfiles.FlatAppearance.BorderSize = 0;
            ButtonEditProfiles.FlatStyle = FlatStyle.Flat;
            ButtonEditProfiles.Font = new Font("Segoe UI Variable Small", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonEditProfiles.ForeColor = Color.White;
            ButtonEditProfiles.Location = new Point(113, 213);
            ButtonEditProfiles.Name = "ButtonEditProfiles";
            ButtonEditProfiles.Size = new Size(95, 37);
            ButtonEditProfiles.TabIndex = 39;
            ButtonEditProfiles.Text = "🖍 Edit";
            ButtonEditProfiles.TextColor = Color.White;
            ButtonEditProfiles.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(ButtonDashboard);
            flowLayoutPanel1.Controls.Add(ButtonBooking);
            flowLayoutPanel1.Controls.Add(ButtonPelanggan);
            flowLayoutPanel1.Controls.Add(ButtonKendaraan);
            flowLayoutPanel1.Controls.Add(ButtonSparepart);
            flowLayoutPanel1.Controls.Add(ButtonPegawai);
            flowLayoutPanel1.Controls.Add(ButtonMekanik);
            flowLayoutPanel1.Controls.Add(ButtonServis);
            flowLayoutPanel1.Controls.Add(ButtonRiwayat);
            flowLayoutPanel1.Controls.Add(ButtonLogout);
            flowLayoutPanel1.Location = new Point(0, 277);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(319, 775);
            flowLayoutPanel1.TabIndex = 37;
            // 
            // ButtonDashboard
            // 
            ButtonDashboard.BackColor = SystemColors.Window;
            ButtonDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonDashboard.FlatAppearance.BorderSize = 0;
            ButtonDashboard.FlatStyle = FlatStyle.Flat;
            ButtonDashboard.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonDashboard.ForeColor = Color.Gray;
            ButtonDashboard.Location = new Point(3, 3);
            ButtonDashboard.Name = "ButtonDashboard";
            ButtonDashboard.Size = new Size(319, 53);
            ButtonDashboard.TabIndex = 28;
            ButtonDashboard.Text = "          🖥     Dashboard";
            ButtonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            ButtonDashboard.UseVisualStyleBackColor = false;
            // 
            // ButtonBooking
            // 
            ButtonBooking.BackColor = SystemColors.Window;
            ButtonBooking.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonBooking.FlatAppearance.BorderSize = 0;
            ButtonBooking.FlatStyle = FlatStyle.Flat;
            ButtonBooking.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonBooking.ForeColor = Color.Gray;
            ButtonBooking.Location = new Point(3, 62);
            ButtonBooking.Name = "ButtonBooking";
            ButtonBooking.Size = new Size(319, 53);
            ButtonBooking.TabIndex = 29;
            ButtonBooking.Text = "          📆     Booking";
            ButtonBooking.TextAlign = ContentAlignment.MiddleLeft;
            ButtonBooking.UseVisualStyleBackColor = false;
            // 
            // ButtonPelanggan
            // 
            ButtonPelanggan.BackColor = SystemColors.Window;
            ButtonPelanggan.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonPelanggan.FlatAppearance.BorderSize = 0;
            ButtonPelanggan.FlatStyle = FlatStyle.Flat;
            ButtonPelanggan.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPelanggan.ForeColor = Color.Gray;
            ButtonPelanggan.Location = new Point(3, 121);
            ButtonPelanggan.Name = "ButtonPelanggan";
            ButtonPelanggan.Size = new Size(319, 53);
            ButtonPelanggan.TabIndex = 32;
            ButtonPelanggan.Text = "          👥     Pelanggan";
            ButtonPelanggan.TextAlign = ContentAlignment.MiddleLeft;
            ButtonPelanggan.UseVisualStyleBackColor = false;
            // 
            // ButtonKendaraan
            // 
            ButtonKendaraan.BackColor = SystemColors.Window;
            ButtonKendaraan.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonKendaraan.FlatAppearance.BorderSize = 0;
            ButtonKendaraan.FlatStyle = FlatStyle.Flat;
            ButtonKendaraan.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonKendaraan.ForeColor = Color.Gray;
            ButtonKendaraan.Location = new Point(3, 180);
            ButtonKendaraan.Name = "ButtonKendaraan";
            ButtonKendaraan.Size = new Size(319, 53);
            ButtonKendaraan.TabIndex = 33;
            ButtonKendaraan.Text = "          🏍     Kendaraan";
            ButtonKendaraan.TextAlign = ContentAlignment.MiddleLeft;
            ButtonKendaraan.UseVisualStyleBackColor = false;
            // 
            // ButtonSparepart
            // 
            ButtonSparepart.BackColor = SystemColors.Window;
            ButtonSparepart.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonSparepart.FlatAppearance.BorderSize = 0;
            ButtonSparepart.FlatStyle = FlatStyle.Flat;
            ButtonSparepart.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSparepart.ForeColor = Color.Gray;
            ButtonSparepart.Location = new Point(3, 239);
            ButtonSparepart.Name = "ButtonSparepart";
            ButtonSparepart.Size = new Size(319, 53);
            ButtonSparepart.TabIndex = 35;
            ButtonSparepart.Text = "          🔩     Sparepart";
            ButtonSparepart.TextAlign = ContentAlignment.MiddleLeft;
            ButtonSparepart.UseVisualStyleBackColor = false;
            // 
            // ButtonPegawai
            // 
            ButtonPegawai.BackColor = SystemColors.Window;
            ButtonPegawai.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonPegawai.FlatAppearance.BorderSize = 0;
            ButtonPegawai.FlatStyle = FlatStyle.Flat;
            ButtonPegawai.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonPegawai.ForeColor = Color.Gray;
            ButtonPegawai.Location = new Point(3, 298);
            ButtonPegawai.Name = "ButtonPegawai";
            ButtonPegawai.Size = new Size(319, 53);
            ButtonPegawai.TabIndex = 34;
            ButtonPegawai.Text = "          \U0001f9d1‍🔧     Pegawai";
            ButtonPegawai.TextAlign = ContentAlignment.MiddleLeft;
            ButtonPegawai.UseVisualStyleBackColor = false;
            // 
            // ButtonMekanik
            // 
            ButtonMekanik.BackColor = SystemColors.Window;
            ButtonMekanik.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonMekanik.FlatAppearance.BorderSize = 0;
            ButtonMekanik.FlatStyle = FlatStyle.Flat;
            ButtonMekanik.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMekanik.ForeColor = Color.Gray;
            ButtonMekanik.Location = new Point(3, 357);
            ButtonMekanik.Name = "ButtonMekanik";
            ButtonMekanik.Size = new Size(319, 53);
            ButtonMekanik.TabIndex = 38;
            ButtonMekanik.Text = "          👩‍🔧     Mekanik";
            ButtonMekanik.TextAlign = ContentAlignment.MiddleLeft;
            ButtonMekanik.UseVisualStyleBackColor = false;
            // 
            // ButtonServis
            // 
            ButtonServis.BackColor = SystemColors.Window;
            ButtonServis.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonServis.FlatAppearance.BorderSize = 0;
            ButtonServis.FlatStyle = FlatStyle.Flat;
            ButtonServis.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonServis.ForeColor = Color.Gray;
            ButtonServis.Location = new Point(3, 416);
            ButtonServis.Name = "ButtonServis";
            ButtonServis.Size = new Size(319, 53);
            ButtonServis.TabIndex = 30;
            ButtonServis.Text = "          🛠️     Jasa Servis";
            ButtonServis.TextAlign = ContentAlignment.MiddleLeft;
            ButtonServis.UseVisualStyleBackColor = false;
            // 
            // ButtonRiwayat
            // 
            ButtonRiwayat.BackColor = SystemColors.Window;
            ButtonRiwayat.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonRiwayat.FlatAppearance.BorderSize = 0;
            ButtonRiwayat.FlatStyle = FlatStyle.Flat;
            ButtonRiwayat.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRiwayat.ForeColor = Color.Gray;
            ButtonRiwayat.Location = new Point(3, 475);
            ButtonRiwayat.Name = "ButtonRiwayat";
            ButtonRiwayat.Size = new Size(319, 53);
            ButtonRiwayat.TabIndex = 31;
            ButtonRiwayat.Text = "          🗒️     Riwayat";
            ButtonRiwayat.TextAlign = ContentAlignment.MiddleLeft;
            ButtonRiwayat.UseVisualStyleBackColor = false;
            // 
            // ButtonLogout
            // 
            ButtonLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonLogout.BackColor = SystemColors.Window;
            ButtonLogout.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonLogout.FlatAppearance.BorderSize = 0;
            ButtonLogout.FlatStyle = FlatStyle.Flat;
            ButtonLogout.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLogout.ForeColor = Color.Gray;
            ButtonLogout.Location = new Point(3, 534);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(319, 53);
            ButtonLogout.TabIndex = 37;
            ButtonLogout.Text = "          🔚     Logout";
            ButtonLogout.TextAlign = ContentAlignment.MiddleLeft;
            ButtonLogout.UseVisualStyleBackColor = false;
            // 
            // PictureProfiles
            // 
            PictureProfiles.Anchor = AnchorStyles.Top;
            PictureProfiles.BackgroundImageLayout = ImageLayout.Stretch;
            PictureProfiles.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            PictureProfiles.BorderColor = Color.FromArgb(83, 92, 145);
            PictureProfiles.BorderColor2 = Color.FromArgb(83, 92, 145);
            PictureProfiles.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            PictureProfiles.BorderSize = 2;
            PictureProfiles.GradientAngle = 50F;
            PictureProfiles.Image = (Image)resources.GetObject("PictureProfiles.Image");
            PictureProfiles.Location = new Point(109, 48);
            PictureProfiles.Name = "PictureProfiles";
            PictureProfiles.Size = new Size(101, 101);
            PictureProfiles.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureProfiles.TabIndex = 36;
            PictureProfiles.TabStop = false;
            // 
            // LabelUsername
            // 
            LabelUsername.Anchor = AnchorStyles.Top;
            LabelUsername.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            LabelUsername.Location = new Point(3, 151);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(313, 24);
            LabelUsername.TabIndex = 5;
            LabelUsername.Text = "Lathif Nur Hidayat";
            LabelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelRole
            // 
            LabelRole.Anchor = AnchorStyles.Top;
            LabelRole.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelRole.ForeColor = Color.Gray;
            LabelRole.Location = new Point(3, 175);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(313, 20);
            LabelRole.TabIndex = 4;
            LabelRole.Text = "Super Admin";
            LabelRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            PanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelMain.AutoScroll = true;
            PanelMain.BackColor = Color.Transparent;
            PanelMain.ForeColor = Color.Black;
            PanelMain.Location = new Point(329, 16);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(901, 1029);
            PanelMain.TabIndex = 4;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1239, 1055);
            Controls.Add(PanelMain);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureProfiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label LabelUsername;
        private Label LabelRole;
        private Panel PanelMain;
        private SMB_CustomTolbox.RJCircularPictureBox PictureProfiles;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ButtonDashboard;
        private Button ButtonBooking;
        private Button ButtonPelanggan;
        private Button ButtonKendaraan;
        private Button ButtonSparepart;
        private Button ButtonPegawai;
        private Button ButtonServis;
        private Button ButtonRiwayat;
        private Button ButtonLogout;
        private Button ButtonMekanik;
        private SMB_CustomTolbox.LathifButton ButtonEditProfiles;
    }
}