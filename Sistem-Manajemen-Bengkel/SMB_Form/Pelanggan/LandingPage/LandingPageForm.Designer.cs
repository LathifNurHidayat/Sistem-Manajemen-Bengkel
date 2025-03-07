namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.LandingPage
{
    partial class LandingPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPageForm));
            PanelLandingPage = new Panel();
            pictureBox1 = new PictureBox();
            PanelLandingPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelLandingPage
            // 
            PanelLandingPage.AutoScroll = true;
            PanelLandingPage.Controls.Add(pictureBox1);
            PanelLandingPage.Dock = DockStyle.Fill;
            PanelLandingPage.Location = new Point(0, 0);
            PanelLandingPage.Name = "PanelLandingPage";
            PanelLandingPage.Size = new Size(1285, 1102);
            PanelLandingPage.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1251, 4500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LandingPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1285, 1102);
            Controls.Add(PanelLandingPage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LandingPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LandingPageForm";
            PanelLandingPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLandingPage;
        private PictureBox pictureBox1;
    }
}