namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking
{
    partial class BookingControl
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
            FlowPanelMain.AutoScroll = true;
            FlowPanelMain.BackColor = Color.White;
            FlowPanelMain.Dock = DockStyle.Fill;
            FlowPanelMain.Location = new Point(0, 0);
            FlowPanelMain.Name = "FlowPanelMain";
            FlowPanelMain.Size = new Size(1836, 492);
            FlowPanelMain.TabIndex = 0;
            // 
            // BookingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FlowPanelMain);
            Name = "BookingControl";
            Size = new Size(1836, 492);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel FlowPanelMain;
    }
}
