namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    partial class MainInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInputForm));
            PanelMain = new Panel();
            TamuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            PelangganToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelMain
            // 
            PanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelMain.BackColor = Color.LightGray;
            PanelMain.Location = new Point(0, 43);
            PanelMain.Name = "PanelMain";
            PanelMain.Size = new Size(872, 568);
            PanelMain.TabIndex = 1;
            // 
            // TamuToolStripMenuItem
            // 
            TamuToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TamuToolStripMenuItem.Image = Properties.Resources.profile_picture;
            TamuToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            TamuToolStripMenuItem.Name = "TamuToolStripMenuItem";
            TamuToolStripMenuItem.Size = new Size(102, 36);
            TamuToolStripMenuItem.Text = "Tamu";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { PelangganToolStripMenuItem, TamuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(872, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // PelangganToolStripMenuItem
            // 
            PelangganToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            PelangganToolStripMenuItem.Image = (Image)resources.GetObject("PelangganToolStripMenuItem.Image");
            PelangganToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem";
            PelangganToolStripMenuItem.Size = new Size(145, 36);
            PelangganToolStripMenuItem.Text = "Pelanggan";
            // 
            // MainInputForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 612);
            Controls.Add(PanelMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainInputForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PanelMain;
        private ToolStripMenuItem TamuToolStripMenuItem;
        private ToolStripMenuItem jurusanToolStripMenuItem;
        private ToolStripMenuItem mataPelajaranToolStripMenuItem;
        private ToolStripMenuItem kelasToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem guruToolStripMenuItem;
        private ToolStripMenuItem jadwalPelajaranToolStripMenuItem;
        private ToolStripMenuItem PelangganToolStripMenuItem;
        private ToolStripMenuItem dataIndukSiswaToolStripMenuItem;
        private ToolStripMenuItem kelasSiswaToolStripMenuItem;
        private ToolStripMenuItem absensiToolStripMenuItem;
    }
}