namespace Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm
{
    partial class LaporanForm
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
            label7 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 22);
            label7.Name = "label7";
            label7.Size = new Size(149, 33);
            label7.TabIndex = 12;
            label7.Text = "📊  Laporan";
            // 
            // LaporanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 527);
            Controls.Add(label7);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LaporanForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
    }
}