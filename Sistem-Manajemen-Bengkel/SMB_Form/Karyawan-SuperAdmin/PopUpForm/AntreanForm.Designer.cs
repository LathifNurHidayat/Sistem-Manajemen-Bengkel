namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm
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
            LabelAntrean = new Label();
            label1 = new Label();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            Label = new Label();
            ButtonBooking = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            panel2 = new Panel();
            PanelAntrean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).BeginInit();
            gradientPanelExt1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAntrean
            // 
            PanelAntrean.BackColor = Color.White;
            PanelAntrean.Controls.Add(panel2);
            PanelAntrean.Controls.Add(ButtonBooking);
            PanelAntrean.Controls.Add(ButtonBatal);
            PanelAntrean.Controls.Add(Label);
            PanelAntrean.Controls.Add(gradientPanelExt1);
            PanelAntrean.Controls.Add(panel1);
            PanelAntrean.Controls.Add(label8);
            PanelAntrean.Controls.Add(pictureBox3);
            PanelAntrean.Controls.Add(LabelAntrean);
            PanelAntrean.Dock = DockStyle.Fill;
            PanelAntrean.Location = new Point(0, 0);
            PanelAntrean.Name = "PanelAntrean";
            PanelAntrean.Size = new Size(396, 510);
            PanelAntrean.TabIndex = 52;
            // 
            // LabelAntrean
            // 
            LabelAntrean.Anchor = AnchorStyles.None;
            LabelAntrean.Font = new Font("Microsoft New Tai Lue", 60F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAntrean.ForeColor = Color.Black;
            LabelAntrean.Location = new Point(14, 200);
            LabelAntrean.Name = "LabelAntrean";
            LabelAntrean.Size = new Size(372, 97);
            LabelAntrean.TabIndex = 17;
            LabelAntrean.Text = "05";
            LabelAntrean.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(48, 16);
            label1.Name = "label1";
            label1.Size = new Size(182, 31);
            label1.TabIndex = 17;
            label1.Text = "Nomor Antrean";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(74, 24);
            label8.Name = "label8";
            label8.Size = new Size(236, 28);
            label8.TabIndex = 18;
            label8.Text = "Kuota Booking Tersedia";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Pelanggan;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(14, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 42);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(13, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 3);
            panel1.TabIndex = 20;
            // 
            // gradientPanelExt1
            // 
            gradientPanelExt1.BackColor = Color.Transparent;
            gradientPanelExt1.Border = new Padding(3);
            gradientPanelExt1.BorderGap = 3;
            gradientPanelExt1.BorderStyle = BorderStyle.None;
            gradientPanelExt1.Controls.Add(label1);
            gradientPanelExt1.Location = new Point(63, 108);
            gradientPanelExt1.Name = "gradientPanelExt1";
            gradientPanelExt1.Size = new Size(280, 66);
            gradientPanelExt1.TabIndex = 21;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.BackColor = Color.Transparent;
            Label.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label.ForeColor = Color.DimGray;
            Label.Location = new Point(63, 363);
            Label.Name = "Label";
            Label.Size = new Size(273, 50);
            Label.TabIndex = 22;
            Label.Text = "Apakah anda ingin melanjutkan\r\nuntuk booking?";
            Label.TextAlign = ContentAlignment.MiddleCenter;
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
            ButtonBooking.Location = new Point(236, 443);
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
            ButtonBatal.Location = new Point(22, 443);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(138, 45);
            ButtonBatal.TabIndex = 23;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(129, 300);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 3);
            panel2.TabIndex = 25;
            // 
            // AntreanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 510);
            Controls.Add(PanelAntrean);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AntreanForm";
            PanelAntrean.ResumeLayout(false);
            PanelAntrean.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).EndInit();
            gradientPanelExt1.ResumeLayout(false);
            gradientPanelExt1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAntrean;
        private Label LabelAntrean;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label1;
        private Label Label;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private SMB_CustomTolbox.LathifButton ButtonBooking;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
        private Panel panel2;
    }
}