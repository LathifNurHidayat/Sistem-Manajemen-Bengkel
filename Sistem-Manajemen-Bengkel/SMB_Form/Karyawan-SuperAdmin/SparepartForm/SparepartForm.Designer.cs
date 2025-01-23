namespace Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm
{
    partial class SparepartForm
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
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanelExt1
            // 
            gradientPanelExt1.BackColor = Color.DimGray;
            gradientPanelExt1.Border = new Padding(5);
            gradientPanelExt1.BorderColor = Color.Transparent;
            gradientPanelExt1.BorderGap = 5;
            gradientPanelExt1.BorderStyle = BorderStyle.None;
            gradientPanelExt1.CornerRadius = 10;
            gradientPanelExt1.Location = new Point(125, 106);
            gradientPanelExt1.Name = "gradientPanelExt1";
            gradientPanelExt1.Size = new Size(760, 138);
            gradientPanelExt1.TabIndex = 0;
            // 
            // SparepartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(gradientPanelExt1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "SparepartForm";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
    }
}