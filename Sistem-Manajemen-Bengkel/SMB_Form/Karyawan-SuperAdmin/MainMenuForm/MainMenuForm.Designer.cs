namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.MainMenuForm
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
            PictureProfiles = new SMB_CustomTolbox.RJCircularPictureBox();
            LabelUsername = new Label();
            LabelRole = new Label();
            PanelMain = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ButtonLaporan = new Button();
            ButtonSparepart = new Button();
            ButtonKaryawan = new Button();
            ButtonKendaraan = new Button();
            ButtonPelanggan = new Button();
            ButtonRiwayat = new Button();
            ButtonServis = new Button();
            ButtonBooking = new Button();
            ButtonDashboard = new Button();
            ButtonLogout = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProfiles).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
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
            // PictureProfiles
            // 
            PictureProfiles.Anchor = AnchorStyles.Top;
            PictureProfiles.BackgroundImage = Properties.Resources.User_Hitam;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(ButtonDashboard);
            flowLayoutPanel1.Controls.Add(ButtonBooking);
            flowLayoutPanel1.Controls.Add(ButtonPelanggan);
            flowLayoutPanel1.Controls.Add(ButtonKendaraan);
            flowLayoutPanel1.Controls.Add(ButtonSparepart);
            flowLayoutPanel1.Controls.Add(ButtonKaryawan);
            flowLayoutPanel1.Controls.Add(ButtonServis);
            flowLayoutPanel1.Controls.Add(ButtonRiwayat);
            flowLayoutPanel1.Controls.Add(ButtonLaporan);
            flowLayoutPanel1.Controls.Add(ButtonLogout);
            flowLayoutPanel1.Location = new Point(0, 256);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(319, 796);
            flowLayoutPanel1.TabIndex = 37;
            // 
            // ButtonLaporan
            // 
            ButtonLaporan.BackColor = SystemColors.Window;
            ButtonLaporan.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonLaporan.FlatAppearance.BorderSize = 0;
            ButtonLaporan.FlatStyle = FlatStyle.Flat;
            ButtonLaporan.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonLaporan.ForeColor = Color.Gray;
            ButtonLaporan.Location = new Point(3, 475);
            ButtonLaporan.Name = "ButtonLaporan";
            ButtonLaporan.Size = new Size(319, 53);
            ButtonLaporan.TabIndex = 36;
            ButtonLaporan.Text = "          📊     Laporan";
            ButtonLaporan.TextAlign = ContentAlignment.MiddleLeft;
            ButtonLaporan.UseVisualStyleBackColor = false;
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
            // ButtonKaryawan
            // 
            ButtonKaryawan.BackColor = SystemColors.Window;
            ButtonKaryawan.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonKaryawan.FlatAppearance.BorderSize = 0;
            ButtonKaryawan.FlatStyle = FlatStyle.Flat;
            ButtonKaryawan.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonKaryawan.ForeColor = Color.Gray;
            ButtonKaryawan.Location = new Point(3, 298);
            ButtonKaryawan.Name = "ButtonKaryawan";
            ButtonKaryawan.Size = new Size(319, 53);
            ButtonKaryawan.TabIndex = 34;
            ButtonKaryawan.Text = "          \U0001f9d1‍🔧     Karyawan";
            ButtonKaryawan.TextAlign = ContentAlignment.MiddleLeft;
            ButtonKaryawan.UseVisualStyleBackColor = false;
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
            // ButtonRiwayat
            // 
            ButtonRiwayat.BackColor = SystemColors.Window;
            ButtonRiwayat.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonRiwayat.FlatAppearance.BorderSize = 0;
            ButtonRiwayat.FlatStyle = FlatStyle.Flat;
            ButtonRiwayat.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonRiwayat.ForeColor = Color.Gray;
            ButtonRiwayat.Location = new Point(3, 416);
            ButtonRiwayat.Name = "ButtonRiwayat";
            ButtonRiwayat.Size = new Size(319, 53);
            ButtonRiwayat.TabIndex = 31;
            ButtonRiwayat.Text = "          🗒️     Riwayat";
            ButtonRiwayat.TextAlign = ContentAlignment.MiddleLeft;
            ButtonRiwayat.UseVisualStyleBackColor = false;
            // 
            // ButtonServis
            // 
            ButtonServis.BackColor = SystemColors.Window;
            ButtonServis.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonServis.FlatAppearance.BorderSize = 0;
            ButtonServis.FlatStyle = FlatStyle.Flat;
            ButtonServis.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonServis.ForeColor = Color.Gray;
            ButtonServis.Location = new Point(3, 357);
            ButtonServis.Name = "ButtonServis";
            ButtonServis.Size = new Size(319, 53);
            ButtonServis.TabIndex = 30;
            ButtonServis.Text = "          🛠️     Jasa Servis";
            ButtonServis.TextAlign = ContentAlignment.MiddleLeft;
            ButtonServis.UseVisualStyleBackColor = false;
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
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1239, 1055);
            Controls.Add(PanelMain);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureProfiles).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
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
        private Button ButtonKaryawan;
        private Button ButtonServis;
        private Button ButtonRiwayat;
        private Button ButtonLaporan;
        private Button ButtonLogout;
    }
}