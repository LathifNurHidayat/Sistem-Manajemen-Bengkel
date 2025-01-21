using Sistem_Manajemen_Bengkel.SMB_Form.KaryawanForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm
{
    partial class MenuDashboardAdminForm
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
            TextTotalService = new TextBox();
            label6 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            PanelAntrean = new Panel();
            TextTotalBooking = new TextBox();
            label5 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            PanelPelanggan = new Panel();
            TextTotalPelanggan = new TextBox();
            label4 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
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
            Label.Location = new Point(10, 22);
            Label.Name = "Label";
            Label.Size = new Size(22, 33);
            Label.TabIndex = 6;
            Label.Text = " ";
            // 
            // PanelBackground
            // 
            PanelBackground.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelBackground.Controls.Add(PanelService);
            PanelBackground.Controls.Add(PanelAntrean);
            PanelBackground.Controls.Add(PanelPelanggan);
            PanelBackground.Location = new Point(0, 64);
            PanelBackground.Margin = new Padding(3, 2, 3, 2);
            PanelBackground.Name = "PanelBackground";
            PanelBackground.Size = new Size(948, 218);
            PanelBackground.TabIndex = 10;
            // 
            // PanelService
            // 
            PanelService.Anchor = AnchorStyles.None;
            PanelService.BackColor = Color.LightSlateGray;
            PanelService.Controls.Add(TextTotalService);
            PanelService.Controls.Add(label6);
            PanelService.Controls.Add(label3);
            PanelService.Controls.Add(pictureBox1);
            PanelService.Location = new Point(642, 8);
            PanelService.Margin = new Padding(3, 2, 3, 2);
            PanelService.Name = "PanelService";
            PanelService.Size = new Size(293, 178);
            PanelService.TabIndex = 9;
            // 
            // TextTotalService
            // 
            TextTotalService.Anchor = AnchorStyles.None;
            TextTotalService.BackColor = Color.LightSlateGray;
            TextTotalService.BorderStyle = BorderStyle.None;
            TextTotalService.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            TextTotalService.ForeColor = Color.White;
            TextTotalService.Location = new Point(92, 70);
            TextTotalService.Margin = new Padding(3, 2, 3, 2);
            TextTotalService.Name = "TextTotalService";
            TextTotalService.Size = new Size(109, 64);
            TextTotalService.TabIndex = 15;
            TextTotalService.Text = "67";
            TextTotalService.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(89, 147);
            label6.Name = "label6";
            label6.Size = new Size(103, 21);
            label6.TabIndex = 14;
            label6.Text = "Total Service";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(99, 19);
            label3.Name = "label3";
            label3.Size = new Size(119, 41);
            label3.TabIndex = 13;
            label3.Text = "Service";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Service;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(6, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelAntrean
            // 
            PanelAntrean.Anchor = AnchorStyles.None;
            PanelAntrean.BackColor = Color.CadetBlue;
            PanelAntrean.Controls.Add(TextTotalBooking);
            PanelAntrean.Controls.Add(label5);
            PanelAntrean.Controls.Add(label2);
            PanelAntrean.Controls.Add(pictureBox2);
            PanelAntrean.Location = new Point(328, 8);
            PanelAntrean.Margin = new Padding(3, 2, 3, 2);
            PanelAntrean.Name = "PanelAntrean";
            PanelAntrean.Size = new Size(292, 178);
            PanelAntrean.TabIndex = 8;
            // 
            // TextTotalBooking
            // 
            TextTotalBooking.Anchor = AnchorStyles.None;
            TextTotalBooking.BackColor = Color.CadetBlue;
            TextTotalBooking.BorderStyle = BorderStyle.None;
            TextTotalBooking.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            TextTotalBooking.ForeColor = Color.White;
            TextTotalBooking.Location = new Point(90, 70);
            TextTotalBooking.Margin = new Padding(3, 2, 3, 2);
            TextTotalBooking.Name = "TextTotalBooking";
            TextTotalBooking.Size = new Size(109, 64);
            TextTotalBooking.TabIndex = 14;
            TextTotalBooking.Text = "5";
            TextTotalBooking.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(87, 147);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 13;
            label5.Text = "Total Booking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(99, 19);
            label2.Name = "label2";
            label2.Size = new Size(136, 41);
            label2.TabIndex = 12;
            label2.Text = "Booking";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Booking;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(6, 10);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 56);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // PanelPelanggan
            // 
            PanelPelanggan.Anchor = AnchorStyles.None;
            PanelPelanggan.BackColor = Color.DarkKhaki;
            PanelPelanggan.Controls.Add(TextTotalPelanggan);
            PanelPelanggan.Controls.Add(label4);
            PanelPelanggan.Controls.Add(label1);
            PanelPelanggan.Controls.Add(pictureBox3);
            PanelPelanggan.Location = new Point(10, 8);
            PanelPelanggan.Margin = new Padding(3, 2, 3, 2);
            PanelPelanggan.Name = "PanelPelanggan";
            PanelPelanggan.Size = new Size(292, 178);
            PanelPelanggan.TabIndex = 7;
            // 
            // TextTotalPelanggan
            // 
            TextTotalPelanggan.Anchor = AnchorStyles.None;
            TextTotalPelanggan.BackColor = Color.DarkKhaki;
            TextTotalPelanggan.BorderStyle = BorderStyle.None;
            TextTotalPelanggan.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            TextTotalPelanggan.ForeColor = Color.White;
            TextTotalPelanggan.Location = new Point(85, 70);
            TextTotalPelanggan.Margin = new Padding(3, 2, 3, 2);
            TextTotalPelanggan.Name = "TextTotalPelanggan";
            TextTotalPelanggan.Size = new Size(109, 64);
            TextTotalPelanggan.TabIndex = 15;
            TextTotalPelanggan.Text = "50";
            TextTotalPelanggan.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(76, 147);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 12;
            label4.Text = "Total Pelanggan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 19);
            label1.Name = "label1";
            label1.Size = new Size(166, 41);
            label1.TabIndex = 11;
            label1.Text = "Pelanggan";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Pelanggan;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(6, 10);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 56);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 22);
            label7.Name = "label7";
            label7.Size = new Size(181, 33);
            label7.TabIndex = 11;
            label7.Text = "🖥  Dashboard";
            // 
            // MenuDashboardAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(947, 527);
            Controls.Add(label7);
            Controls.Add(PanelBackground);
            Controls.Add(Label);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuDashboardAdminForm";
            Text = " ";
            PanelBackground.ResumeLayout(false);
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
        private TextBox TextTotalService;
        private Label label6;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel PanelAntrean;
        private TextBox TextTotalBooking;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel PanelPelanggan;
        private TextBox TextTotalPelanggan;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label7;
    }
}