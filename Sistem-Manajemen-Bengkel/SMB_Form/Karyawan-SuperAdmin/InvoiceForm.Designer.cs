namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan
{
    partial class InvoiceForm
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
            panel1 = new Panel();
            lathifPanel2 = new SMB_CustomTolbox.LathifPanel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            lathifPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(lathifPanel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 679);
            panel1.TabIndex = 0;
            // 
            // lathifPanel2
            // 
            lathifPanel2.BackColor = Color.MediumSlateBlue;
            lathifPanel2.BorderColor = Color.PaleVioletRed;
            lathifPanel2.BorderRadius = 0;
            lathifPanel2.BorderSize = 0;
            lathifPanel2.Controls.Add(label2);
            lathifPanel2.Controls.Add(label1);
            lathifPanel2.ForeColor = Color.White;
            lathifPanel2.Location = new Point(412, 22);
            lathifPanel2.Name = "lathifPanel2";
            lathifPanel2.Size = new Size(235, 635);
            lathifPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(78, 1130);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 15);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(panel1);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            panel1.ResumeLayout(false);
            lathifPanel2.ResumeLayout(false);
            lathifPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SMB_CustomTolbox.LathifPanel lathifPanel2;
        private Label label2;
        private Label label1;
    }
}