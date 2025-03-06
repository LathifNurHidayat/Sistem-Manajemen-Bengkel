namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm
{
    partial class MainMenuPelanggan
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
            ButtonDashboard = new Button();
            LabelUsername = new Label();
            PanelMain = new Panel();
            panel1 = new Panel();
            ButtonLogout = new Button();
            ButtonRiwayat = new Button();
            ButtonKendaraan = new Button();
            ButtonBooking = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonDashboard
            // 
            ButtonDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonDashboard.BackColor = Color.Transparent;
            ButtonDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonDashboard.FlatAppearance.BorderSize = 0;
            ButtonDashboard.FlatStyle = FlatStyle.Flat;
            ButtonDashboard.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
            ButtonDashboard.ForeColor = Color.White;
            ButtonDashboard.Location = new Point(704, -1);
            ButtonDashboard.Name = "ButtonDashboard";
            ButtonDashboard.Size = new Size(128, 102);
            ButtonDashboard.TabIndex = 28;
            ButtonDashboard.Text = "Dashboard";
            ButtonDashboard.UseVisualStyleBackColor = false;
            // 
            // LabelUsername
            // 
            LabelUsername.AutoSize = true;
            LabelUsername.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LabelUsername.ForeColor = Color.White;
            LabelUsername.Location = new Point(19, 31);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(244, 37);
            LabelUsername.TabIndex = 5;
            LabelUsername.Text = "Lathif Nur Hidayat";
            LabelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelMain
            // 
            PanelMain.AutoScroll = true;
            PanelMain.BackColor = Color.White;
            PanelMain.Dock = DockStyle.Bottom;
            PanelMain.ForeColor = Color.Black;
            PanelMain.Location = new Point(0, 71);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(1239, 984);
            PanelMain.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 92, 145);
            panel1.Controls.Add(ButtonLogout);
            panel1.Controls.Add(ButtonRiwayat);
            panel1.Controls.Add(ButtonKendaraan);
            panel1.Controls.Add(ButtonBooking);
            panel1.Controls.Add(LabelUsername);
            panel1.Controls.Add(ButtonDashboard);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1239, 102);
            panel1.TabIndex = 5;
            // 
            // ButtonLogout
            // 
            ButtonLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonLogout.BackColor = Color.Transparent;
            ButtonLogout.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonLogout.FlatAppearance.BorderSize = 0;
            ButtonLogout.FlatStyle = FlatStyle.Flat;
            ButtonLogout.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
            ButtonLogout.ForeColor = Color.White;
            ButtonLogout.Location = new Point(1155, 0);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(84, 102);
            ButtonLogout.TabIndex = 32;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = false;
            // 
            // ButtonRiwayat
            // 
            ButtonRiwayat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonRiwayat.BackColor = Color.Transparent;
            ButtonRiwayat.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonRiwayat.FlatAppearance.BorderSize = 0;
            ButtonRiwayat.FlatStyle = FlatStyle.Flat;
            ButtonRiwayat.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
            ButtonRiwayat.ForeColor = Color.White;
            ButtonRiwayat.Location = new Point(1058, 0);
            ButtonRiwayat.Name = "ButtonRiwayat";
            ButtonRiwayat.Size = new Size(91, 102);
            ButtonRiwayat.TabIndex = 31;
            ButtonRiwayat.Text = "Riwayat";
            ButtonRiwayat.UseVisualStyleBackColor = false;
            // 
            // ButtonKendaraan
            // 
            ButtonKendaraan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonKendaraan.BackColor = Color.Transparent;
            ButtonKendaraan.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonKendaraan.FlatAppearance.BorderSize = 0;
            ButtonKendaraan.FlatStyle = FlatStyle.Flat;
            ButtonKendaraan.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
            ButtonKendaraan.ForeColor = Color.White;
            ButtonKendaraan.Location = new Point(937, -1);
            ButtonKendaraan.Name = "ButtonKendaraan";
            ButtonKendaraan.Size = new Size(115, 102);
            ButtonKendaraan.TabIndex = 30;
            ButtonKendaraan.Text = "Kendaraan";
            ButtonKendaraan.UseVisualStyleBackColor = false;
            // 
            // ButtonBooking
            // 
            ButtonBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonBooking.BackColor = Color.Transparent;
            ButtonBooking.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonBooking.FlatAppearance.BorderSize = 0;
            ButtonBooking.FlatStyle = FlatStyle.Flat;
            ButtonBooking.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point);
            ButtonBooking.ForeColor = Color.White;
            ButtonBooking.Location = new Point(838, 0);
            ButtonBooking.Name = "ButtonBooking";
            ButtonBooking.Size = new Size(93, 102);
            ButtonBooking.TabIndex = 29;
            ButtonBooking.Text = "Booking";
            ButtonBooking.UseVisualStyleBackColor = false;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1239, 1055);
            Controls.Add(panel1);
            Controls.Add(PanelMain);
            DoubleBuffered = true;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LabelUsername;
        private Panel PanelMain;
        private Button ButtonDashboard;
        private Panel panel1;
        private Button ButtonLogout;
        private Button ButtonRiwayat;
        private Button ButtonKendaraan;
        private Button ButtonBooking;
    }
}