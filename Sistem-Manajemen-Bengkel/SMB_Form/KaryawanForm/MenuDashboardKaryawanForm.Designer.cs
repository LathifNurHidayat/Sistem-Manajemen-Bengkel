namespace Sistem_Manajemen_Bengkel.SMB_Form.KaryawanForm
{
    partial class MenuDashboardKaryawanForm
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
            Label = new Label();
            PanelBackground = new Panel();
            PanelService = new Panel();
            LabelTotalService = new Label();
            label6 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            PanelAntrean = new Panel();
            LabelTotalBooking = new Label();
            label5 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            PanelPelanggan = new Panel();
            label4 = new Label();
            label1 = new Label();
            LabelTotalPelanggan = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            PanelData = new SMB_CustomTolbox.LathifPanel();
            PanelBackground.SuspendLayout();
            PanelService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelAntrean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelPelanggan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Label.Location = new Point(11, 29);
            Label.Name = "Label";
            Label.Size = new Size(27, 42);
            Label.TabIndex = 6;
            Label.Text = " ";
            // 
            // PanelBackground
            // 
            PanelBackground.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelBackground.BackColor = Color.White;
            PanelBackground.Controls.Add(PanelService);
            PanelBackground.Controls.Add(label7);
            PanelBackground.Controls.Add(PanelAntrean);
            PanelBackground.Controls.Add(PanelPelanggan);
            PanelBackground.Location = new Point(12, 12);
            PanelBackground.Name = "PanelBackground";
            PanelBackground.Size = new Size(1056, 354);
            PanelBackground.TabIndex = 10;
            // 
            // PanelService
            // 
            PanelService.Anchor = AnchorStyles.Top;
            PanelService.BackColor = Color.LightSlateGray;
            PanelService.Controls.Add(LabelTotalService);
            PanelService.Controls.Add(label6);
            PanelService.Controls.Add(label3);
            PanelService.Controls.Add(pictureBox1);
            PanelService.Location = new Point(709, 100);
            PanelService.Name = "PanelService";
            PanelService.Size = new Size(335, 237);
            PanelService.TabIndex = 9;
            // 
            // LabelTotalService
            // 
            LabelTotalService.Anchor = AnchorStyles.None;
            LabelTotalService.AutoSize = true;
            LabelTotalService.Font = new Font("Microsoft New Tai Lue", 40.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotalService.ForeColor = Color.White;
            LabelTotalService.Location = new Point(108, 107);
            LabelTotalService.Name = "LabelTotalService";
            LabelTotalService.Size = new Size(115, 88);
            LabelTotalService.TabIndex = 16;
            LabelTotalService.Text = "56";
            LabelTotalService.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(102, 196);
            label6.Name = "label6";
            label6.Size = new Size(134, 28);
            label6.TabIndex = 14;
            label6.Text = "Total Service";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(113, 25);
            label3.Name = "label3";
            label3.Size = new Size(134, 46);
            label3.TabIndex = 13;
            label3.Text = "Service";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Service;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(7, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelAntrean
            // 
            PanelAntrean.Anchor = AnchorStyles.Top;
            PanelAntrean.BackColor = Color.CadetBlue;
            PanelAntrean.Controls.Add(LabelTotalBooking);
            PanelAntrean.Controls.Add(label5);
            PanelAntrean.Controls.Add(label2);
            PanelAntrean.Controls.Add(pictureBox2);
            PanelAntrean.Location = new Point(362, 100);
            PanelAntrean.Name = "PanelAntrean";
            PanelAntrean.Size = new Size(334, 237);
            PanelAntrean.TabIndex = 8;
            // 
            // LabelTotalBooking
            // 
            LabelTotalBooking.Anchor = AnchorStyles.None;
            LabelTotalBooking.AutoSize = true;
            LabelTotalBooking.Font = new Font("Microsoft New Tai Lue", 40.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotalBooking.ForeColor = Color.White;
            LabelTotalBooking.Location = new Point(110, 107);
            LabelTotalBooking.Name = "LabelTotalBooking";
            LabelTotalBooking.Size = new Size(115, 88);
            LabelTotalBooking.TabIndex = 15;
            LabelTotalBooking.Text = "89";
            LabelTotalBooking.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(99, 196);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 13;
            label5.Text = "Total Booking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(113, 25);
            label2.Name = "label2";
            label2.Size = new Size(155, 46);
            label2.TabIndex = 12;
            label2.Text = "Booking";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Booking;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(7, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 75);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // PanelPelanggan
            // 
            PanelPelanggan.Anchor = AnchorStyles.Top;
            PanelPelanggan.BackColor = Color.DarkKhaki;
            PanelPelanggan.Controls.Add(label4);
            PanelPelanggan.Controls.Add(label1);
            PanelPelanggan.Controls.Add(LabelTotalPelanggan);
            PanelPelanggan.Controls.Add(pictureBox3);
            PanelPelanggan.Location = new Point(12, 100);
            PanelPelanggan.Name = "PanelPelanggan";
            PanelPelanggan.Size = new Size(334, 237);
            PanelPelanggan.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(86, 196);
            label4.Name = "label4";
            label4.Size = new Size(163, 28);
            label4.TabIndex = 12;
            label4.Text = "Total Pelanggan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(113, 25);
            label1.Name = "label1";
            label1.Size = new Size(188, 46);
            label1.TabIndex = 11;
            label1.Text = "Pelanggan";
            // 
            // LabelTotalPelanggan
            // 
            LabelTotalPelanggan.Anchor = AnchorStyles.None;
            LabelTotalPelanggan.AutoSize = true;
            LabelTotalPelanggan.Font = new Font("Microsoft New Tai Lue", 40.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTotalPelanggan.ForeColor = Color.White;
            LabelTotalPelanggan.Location = new Point(106, 107);
            LabelTotalPelanggan.Name = "LabelTotalPelanggan";
            LabelTotalPelanggan.Size = new Size(115, 88);
            LabelTotalPelanggan.TabIndex = 14;
            LabelTotalPelanggan.Text = "34";
            LabelTotalPelanggan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Pelanggan;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(7, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 75);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 15);
            label7.Name = "label7";
            label7.Size = new Size(226, 42);
            label7.TabIndex = 11;
            label7.Text = "🖥  Dashboard";
            // 
            // PanelData
            // 
            PanelData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelData.BackColor = Color.White;
            PanelData.BorderColor = Color.PaleVioletRed;
            PanelData.BorderRadius = 10;
            PanelData.BorderSize = 0;
            PanelData.ForeColor = Color.White;
            PanelData.Location = new Point(11, 379);
            PanelData.Name = "PanelData";
            PanelData.Size = new Size(1057, 310);
            PanelData.TabIndex = 12;
            // 
            // MenuDashboardKaryawanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(PanelData);
            Controls.Add(PanelBackground);
            Controls.Add(Label);
            Name = "MenuDashboardKaryawanForm";
            Text = " ";
            PanelBackground.ResumeLayout(false);
            PanelBackground.PerformLayout();
            PanelService.ResumeLayout(false);
            PanelService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelAntrean.ResumeLayout(false);
            PanelAntrean.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelPelanggan.ResumeLayout(false);
            PanelPelanggan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Label;
        private Panel PanelBackground;
        private Panel PanelService;
        private Label label6;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel PanelAntrean;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel PanelPelanggan;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label7;
        private Label LabelTotalBooking;
        private Label LabelTotalPelanggan;
        private Label LabelTotalService;
        private SMB_CustomTolbox.LathifPanel PanelData;
    }
}