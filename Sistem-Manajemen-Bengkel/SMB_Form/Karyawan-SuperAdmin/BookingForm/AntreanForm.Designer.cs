namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    partial class AntreanForm
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
            PanelAntrean = new Panel();
            gradientPanelExt2 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            label2 = new Label();
            LabelAntreanAnda = new Label();
            pictureBox3 = new PictureBox();
            gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            label3 = new Label();
            LabelAntreanDikerjakan = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ButtonBooking = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            Label = new Label();
            panel1 = new Panel();
            PanelAntrean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt2).BeginInit();
            gradientPanelExt2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).BeginInit();
            gradientPanelExt1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelAntrean
            // 
            PanelAntrean.BackColor = Color.White;
            PanelAntrean.Controls.Add(gradientPanelExt2);
            PanelAntrean.Controls.Add(gradientPanelExt1);
            PanelAntrean.Controls.Add(label1);
            PanelAntrean.Controls.Add(ButtonBooking);
            PanelAntrean.Controls.Add(ButtonBatal);
            PanelAntrean.Controls.Add(Label);
            PanelAntrean.Controls.Add(panel1);
            PanelAntrean.Dock = DockStyle.Fill;
            PanelAntrean.Location = new Point(0, 0);
            PanelAntrean.Name = "PanelAntrean";
            PanelAntrean.Size = new Size(445, 510);
            PanelAntrean.TabIndex = 52;
            PanelAntrean.Paint += PanelAntrean_Paint;
            // 
            // gradientPanelExt2
            // 
            gradientPanelExt2.BackColor = Color.Transparent;
            gradientPanelExt2.Border = new Padding(3);
            gradientPanelExt2.BorderGap = 3;
            gradientPanelExt2.BorderStyle = BorderStyle.None;
            gradientPanelExt2.Controls.Add(label2);
            gradientPanelExt2.Controls.Add(LabelAntreanAnda);
            gradientPanelExt2.Controls.Add(pictureBox3);
            gradientPanelExt2.Location = new Point(19, 93);
            gradientPanelExt2.Name = "gradientPanelExt2";
            gradientPanelExt2.Size = new Size(190, 248);
            gradientPanelExt2.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(31, 203);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 27;
            label2.Text = "Antrean anda";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAntreanAnda
            // 
            LabelAntreanAnda.Anchor = AnchorStyles.None;
            LabelAntreanAnda.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAntreanAnda.ForeColor = Color.Black;
            LabelAntreanAnda.Location = new Point(9, 73);
            LabelAntreanAnda.Name = "LabelAntreanAnda";
            LabelAntreanAnda.Size = new Size(171, 98);
            LabelAntreanAnda.TabIndex = 17;
            LabelAntreanAnda.Text = "00";
            LabelAntreanAnda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Pelanggan;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(15, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 37);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // gradientPanelExt1
            // 
            gradientPanelExt1.BackColor = Color.Transparent;
            gradientPanelExt1.Border = new Padding(3);
            gradientPanelExt1.BorderGap = 3;
            gradientPanelExt1.BorderStyle = BorderStyle.None;
            gradientPanelExt1.Controls.Add(label3);
            gradientPanelExt1.Controls.Add(LabelAntreanDikerjakan);
            gradientPanelExt1.Controls.Add(pictureBox1);
            gradientPanelExt1.Location = new Point(236, 93);
            gradientPanelExt1.Name = "gradientPanelExt1";
            gradientPanelExt1.Size = new Size(190, 248);
            gradientPanelExt1.TabIndex = 25;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(23, 203);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 28;
            label3.Text = "Sedang dilayani";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAntreanDikerjakan
            // 
            LabelAntreanDikerjakan.Anchor = AnchorStyles.None;
            LabelAntreanDikerjakan.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAntreanDikerjakan.ForeColor = Color.FromArgb(217, 131, 36);
            LabelAntreanDikerjakan.Location = new Point(9, 73);
            LabelAntreanDikerjakan.Name = "LabelAntreanDikerjakan";
            LabelAntreanDikerjakan.Size = new Size(171, 98);
            LabelAntreanDikerjakan.TabIndex = 20;
            LabelAntreanDikerjakan.Text = "00";
            LabelAntreanDikerjakan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.mechanic;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 37);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(110, 15);
            label1.Name = "label1";
            label1.Size = new Size(224, 38);
            label1.TabIndex = 17;
            label1.Text = "Nomor Antrean";
            // 
            // ButtonBooking
            // 
            ButtonBooking.Anchor = AnchorStyles.None;
            ButtonBooking.BackColor = Color.FromArgb(83, 92, 145);
            ButtonBooking.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonBooking.BorderColor = Color.DarkGray;
            ButtonBooking.BorderRadius = 5;
            ButtonBooking.BorderSize = 0;
            ButtonBooking.FlatAppearance.BorderSize = 0;
            ButtonBooking.FlatStyle = FlatStyle.Flat;
            ButtonBooking.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBooking.ForeColor = Color.White;
            ButtonBooking.Location = new Point(260, 443);
            ButtonBooking.Name = "ButtonBooking";
            ButtonBooking.Size = new Size(138, 45);
            ButtonBooking.TabIndex = 24;
            ButtonBooking.Text = "✅ Booking";
            ButtonBooking.TextColor = Color.White;
            ButtonBooking.UseVisualStyleBackColor = false;
            // 
            // ButtonBatal
            // 
            ButtonBatal.Anchor = AnchorStyles.None;
            ButtonBatal.BackColor = Color.Red;
            ButtonBatal.BackgroundColor = Color.Red;
            ButtonBatal.BorderColor = Color.DarkGray;
            ButtonBatal.BorderRadius = 5;
            ButtonBatal.BorderSize = 0;
            ButtonBatal.FlatAppearance.BorderSize = 0;
            ButtonBatal.FlatStyle = FlatStyle.Flat;
            ButtonBatal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBatal.ForeColor = Color.White;
            ButtonBatal.Location = new Point(46, 443);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(138, 45);
            ButtonBatal.TabIndex = 23;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // Label
            // 
            Label.Anchor = AnchorStyles.None;
            Label.AutoSize = true;
            Label.BackColor = Color.Transparent;
            Label.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label.ForeColor = Color.DimGray;
            Label.Location = new Point(86, 357);
            Label.Name = "Label";
            Label.Size = new Size(273, 50);
            Label.TabIndex = 22;
            Label.Text = "Apakah anda ingin melanjutkan\r\nuntuk booking?";
            Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(14, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 2);
            panel1.TabIndex = 20;
            // 
            // AntreanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 510);
            Controls.Add(PanelAntrean);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AntreanForm";
            StartPosition = FormStartPosition.CenterParent;
            PanelAntrean.ResumeLayout(false);
            PanelAntrean.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt2).EndInit();
            gradientPanelExt2.ResumeLayout(false);
            gradientPanelExt2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).EndInit();
            gradientPanelExt1.ResumeLayout(false);
            gradientPanelExt1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAntrean;
        private Label LabelAntreanAnda;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label1;
        private Label Label;
        private SMB_CustomTolbox.LathifButton ButtonBooking;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt2;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label LabelAntreanDikerjakan;
    }
}