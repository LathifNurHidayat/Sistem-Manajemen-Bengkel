namespace Sistem_Manajemen_Bengkel.SMB_Helper
{
    partial class NontifikasiFormHelper
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
            gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).BeginInit();
            gradientPanelExt1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanelExt1
            // 
            gradientPanelExt1.BackColor = Color.WhiteSmoke;
            gradientPanelExt1.Border = new Padding(2);
            gradientPanelExt1.BorderGap = 2;
            gradientPanelExt1.BorderStyle = BorderStyle.None;
            gradientPanelExt1.Controls.Add(label1);
            gradientPanelExt1.Controls.Add(pictureBox1);
            gradientPanelExt1.CornerRadius = 10;
            gradientPanelExt1.Dock = DockStyle.Fill;
            gradientPanelExt1.Location = new Point(0, 0);
            gradientPanelExt1.Name = "gradientPanelExt1";
            gradientPanelExt1.Size = new Size(388, 102);
            gradientPanelExt1.TabIndex = 0;
            gradientPanelExt1.ThemeStyle.BackColor = Color.FromArgb(192, 64, 0);
            gradientPanelExt1.ThemeStyle.BorderThickness = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(116, 39);
            label1.Name = "label1";
            label1.Size = new Size(203, 25);
            label1.TabIndex = 3;
            label1.Text = "Data Berhasil Disimpan";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Centang;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // NontifikasiFormHelper
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(388, 102);
            Controls.Add(gradientPanelExt1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NontifikasiFormHelper";
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).EndInit();
            gradientPanelExt1.ResumeLayout(false);
            gradientPanelExt1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}