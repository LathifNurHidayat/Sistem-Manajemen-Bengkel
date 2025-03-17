using Sistem_Manajemen_Bengkel.SMB_CustomTolbox;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking
{
    partial class ListBookingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            LathifPanel1 = new LathifPanel();
            AntreanPanel = new LathifPanel();
            label10 = new Label();
            LabelAntrean = new Label();
            pictureBox3 = new PictureBox();
            lathifPanel2 = new LathifPanel();
            PictureStatus = new PictureBox();
            panel1 = new Panel();
            ButtonBatalkanBooking = new LathifButton();
            LabelTanggal = new Label();
            LabelKeluhan = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            LabelKapasitasMesin = new Label();
            LabelMerek = new Label();
            LabelNoPolisi = new Label();
            label5 = new Label();
            label1 = new Label();
            button1 = new Button();
            panelProfile = new Panel();
            label3 = new Label();
            sfToolTip1 = new Syncfusion.Windows.Forms.SfToolTip(components);
            LathifPanel1.SuspendLayout();
            AntreanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            lathifPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureStatus).BeginInit();
            SuspendLayout();
            // 
            // LathifPanel1
            // 
            LathifPanel1.Anchor = AnchorStyles.None;
            LathifPanel1.BackColor = Color.White;
            LathifPanel1.BorderColor = Color.Gainsboro;
            LathifPanel1.BorderRadius = 10;
            LathifPanel1.BorderSize = 2;
            LathifPanel1.Controls.Add(AntreanPanel);
            LathifPanel1.Controls.Add(lathifPanel2);
            LathifPanel1.Controls.Add(LabelKapasitasMesin);
            LathifPanel1.Controls.Add(LabelMerek);
            LathifPanel1.Controls.Add(LabelNoPolisi);
            LathifPanel1.Controls.Add(label5);
            LathifPanel1.Controls.Add(label1);
            LathifPanel1.Controls.Add(button1);
            LathifPanel1.Controls.Add(panelProfile);
            LathifPanel1.Controls.Add(label3);
            LathifPanel1.ForeColor = Color.White;
            LathifPanel1.Location = new Point(223, 31);
            LathifPanel1.Margin = new Padding(3, 4, 3, 4);
            LathifPanel1.Name = "LathifPanel1";
            LathifPanel1.Size = new Size(1183, 416);
            LathifPanel1.TabIndex = 0;
            // 
            // AntreanPanel
            // 
            AntreanPanel.BackColor = Color.White;
            AntreanPanel.BorderColor = Color.LightGray;
            AntreanPanel.BorderRadius = 10;
            AntreanPanel.BorderSize = 2;
            AntreanPanel.Controls.Add(label10);
            AntreanPanel.Controls.Add(LabelAntrean);
            AntreanPanel.Controls.Add(pictureBox3);
            AntreanPanel.ForeColor = Color.White;
            AntreanPanel.Location = new Point(966, 24);
            AntreanPanel.Name = "AntreanPanel";
            AntreanPanel.Size = new Size(183, 193);
            AntreanPanel.TabIndex = 88;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(26, 151);
            label10.Name = "label10";
            label10.Size = new Size(130, 23);
            label10.TabIndex = 30;
            label10.Text = "Nomor Antrean";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAntrean
            // 
            LabelAntrean.Anchor = AnchorStyles.None;
            LabelAntrean.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAntrean.ForeColor = Color.Black;
            LabelAntrean.Location = new Point(28, 67);
            LabelAntrean.Name = "LabelAntrean";
            LabelAntrean.Size = new Size(122, 48);
            LabelAntrean.TabIndex = 28;
            LabelAntrean.Text = "00";
            LabelAntrean.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Pelanggan;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(16, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 45);
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // lathifPanel2
            // 
            lathifPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lathifPanel2.BackColor = Color.WhiteSmoke;
            lathifPanel2.BorderColor = Color.WhiteSmoke;
            lathifPanel2.BorderRadius = 10;
            lathifPanel2.BorderSize = 2;
            lathifPanel2.Controls.Add(PictureStatus);
            lathifPanel2.Controls.Add(panel1);
            lathifPanel2.Controls.Add(ButtonBatalkanBooking);
            lathifPanel2.Controls.Add(LabelTanggal);
            lathifPanel2.Controls.Add(LabelKeluhan);
            lathifPanel2.Controls.Add(label9);
            lathifPanel2.Controls.Add(label8);
            lathifPanel2.Controls.Add(label7);
            lathifPanel2.Controls.Add(label2);
            lathifPanel2.ForeColor = Color.White;
            lathifPanel2.Location = new Point(35, 239);
            lathifPanel2.Name = "lathifPanel2";
            lathifPanel2.Size = new Size(1114, 140);
            lathifPanel2.TabIndex = 22;
            // 
            // PictureStatus
            // 
            PictureStatus.Image = Properties.Resources.Dikerjakan;
            PictureStatus.Location = new Point(188, 95);
            PictureStatus.Name = "PictureStatus";
            PictureStatus.Size = new Size(183, 36);
            PictureStatus.SizeMode = PictureBoxSizeMode.Zoom;
            PictureStatus.TabIndex = 33;
            PictureStatus.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(20, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 110);
            panel1.TabIndex = 32;
            // 
            // ButtonBatalkanBooking
            // 
            ButtonBatalkanBooking.BackColor = Color.Red;
            ButtonBatalkanBooking.BackgroundColor = Color.Red;
            ButtonBatalkanBooking.BorderColor = Color.DarkGray;
            ButtonBatalkanBooking.BorderRadius = 5;
            ButtonBatalkanBooking.BorderSize = 0;
            ButtonBatalkanBooking.FlatAppearance.BorderSize = 0;
            ButtonBatalkanBooking.FlatStyle = FlatStyle.Flat;
            ButtonBatalkanBooking.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBatalkanBooking.ForeColor = Color.White;
            ButtonBatalkanBooking.Location = new Point(895, 71);
            ButtonBatalkanBooking.Name = "ButtonBatalkanBooking";
            ButtonBatalkanBooking.Size = new Size(196, 45);
            ButtonBatalkanBooking.TabIndex = 23;
            ButtonBatalkanBooking.Text = "Batalkan Booking";
            ButtonBatalkanBooking.TextColor = Color.White;
            ButtonBatalkanBooking.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonBatalkanBooking.UseVisualStyleBackColor = false;
            // 
            // LabelTanggal
            // 
            LabelTanggal.AutoSize = true;
            LabelTanggal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTanggal.ForeColor = Color.DimGray;
            LabelTanggal.Location = new Point(178, 58);
            LabelTanggal.Name = "LabelTanggal";
            LabelTanggal.Size = new Size(141, 25);
            LabelTanggal.TabIndex = 31;
            LabelTanggal.Text = ": 22 Maret 2025";
            // 
            // LabelKeluhan
            // 
            LabelKeluhan.AutoSize = true;
            LabelKeluhan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelKeluhan.ForeColor = Color.DimGray;
            LabelKeluhan.Location = new Point(178, 18);
            LabelKeluhan.Name = "LabelKeluhan";
            LabelKeluhan.Size = new Size(292, 25);
            LabelKeluhan.TabIndex = 29;
            LabelKeluhan.Text = ": Mesin sering bocor olinya ehehe";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(36, 58);
            label9.Name = "label9";
            label9.Size = new Size(81, 25);
            label9.TabIndex = 28;
            label9.Text = "Tanggal ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(36, 98);
            label8.Name = "label8";
            label8.Size = new Size(137, 25);
            label8.TabIndex = 27;
            label8.Text = "Status Booking";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(36, 18);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 24;
            label7.Text = "Keluhan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(179, 98);
            label2.Name = "label2";
            label2.Size = new Size(16, 25);
            label2.TabIndex = 34;
            label2.Text = ":";
            // 
            // LabelKapasitasMesin
            // 
            LabelKapasitasMesin.AutoSize = true;
            LabelKapasitasMesin.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelKapasitasMesin.ForeColor = Color.DimGray;
            LabelKapasitasMesin.Location = new Point(430, 162);
            LabelKapasitasMesin.Name = "LabelKapasitasMesin";
            LabelKapasitasMesin.Size = new Size(69, 25);
            LabelKapasitasMesin.TabIndex = 18;
            LabelKapasitasMesin.Text = ": 123 cc";
            // 
            // LabelMerek
            // 
            LabelMerek.AutoSize = true;
            LabelMerek.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelMerek.ForeColor = Color.DimGray;
            LabelMerek.Location = new Point(430, 118);
            LabelMerek.Name = "LabelMerek";
            LabelMerek.Size = new Size(103, 25);
            LabelMerek.TabIndex = 17;
            LabelMerek.Text = ": Hondaaaa";
            // 
            // LabelNoPolisi
            // 
            LabelNoPolisi.AutoSize = true;
            LabelNoPolisi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNoPolisi.ForeColor = Color.DimGray;
            LabelNoPolisi.Location = new Point(430, 73);
            LabelNoPolisi.Name = "LabelNoPolisi";
            LabelNoPolisi.Size = new Size(110, 25);
            LabelNoPolisi.TabIndex = 16;
            LabelNoPolisi.Text = ": AB 1212 BC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(260, 162);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 14;
            label5.Text = "Kapasitas Mesin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(260, 118);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 13;
            label1.Text = "Merek";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1123, 24);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(40, 47);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // panelProfile
            // 
            panelProfile.BackColor = Color.FromArgb(251, 251, 251);
            panelProfile.BackgroundImage = Properties.Resources.Motor;
            panelProfile.BackgroundImageLayout = ImageLayout.Zoom;
            panelProfile.BorderStyle = BorderStyle.FixedSingle;
            panelProfile.Location = new Point(39, 37);
            panelProfile.Margin = new Padding(3, 4, 3, 4);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(180, 180);
            panelProfile.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(260, 73);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 3;
            label3.Text = "No. Polisi";
            // 
            // ListBookingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(LathifPanel1);
            DoubleBuffered = true;
            Margin = new Padding(0);
            Name = "ListBookingControl";
            Size = new Size(1634, 476);
            LathifPanel1.ResumeLayout(false);
            LathifPanel1.PerformLayout();
            AntreanPanel.ResumeLayout(false);
            AntreanPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            lathifPanel2.ResumeLayout(false);
            lathifPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LathifPanel LathifPanel1;
        private Label label3;
        private Panel panelProfile;
        private Button button1;
        private Syncfusion.Windows.Forms.SfToolTip sfToolTip1;
        private Label label5;
        private Label label1;
        private Label LabelKapasitasMesin;
        private Label LabelMerek;
        private Label LabelNoPolisi;
        private LathifPanel lathifPanel2;
        private Panel panel1;
        private LathifButton ButtonBatalkanBooking;
        private Label LabelTanggal;
        private Label label9;
        private Label label8;
        private LathifPanel AntreanPanel;
        private Label label10;
        private Label LabelAntrean;
        private PictureBox pictureBox3;
        private Label LabelKeluhan;
        private Label label7;
        private PictureBox PictureStatus;
        private Label label2;
    }
}
