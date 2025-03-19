namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Riwayat
{
    partial class RiwayatControl
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
            FlowPanelMain = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // FlowPanelMain
            // 
            FlowPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FlowPanelMain.Location = new Point(0, 0);
            FlowPanelMain.Name = "FlowPanelMain";
            FlowPanelMain.Size = new Size(1856, 549);
            FlowPanelMain.TabIndex = 0;
            // 
            // RiwayatControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlowPanelMain);
            Name = "RiwayatControl";
            Size = new Size(1856, 549);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlowPanelMain;
    }
}
