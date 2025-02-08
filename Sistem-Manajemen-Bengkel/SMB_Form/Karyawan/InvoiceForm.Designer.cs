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
            lathifPanel1 = new SMB_CustomTolbox.LathifPanel();
            lathifPanel2 = new SMB_CustomTolbox.LathifPanel();
            label1 = new Label();
            label2 = new Label();
            lathifPanel1.SuspendLayout();
            lathifPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lathifPanel1
            // 
            lathifPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lathifPanel1.AutoScroll = true;
            lathifPanel1.BackColor = Color.White;
            lathifPanel1.BorderColor = Color.PaleVioletRed;
            lathifPanel1.BorderRadius = 15;
            lathifPanel1.BorderSize = 0;
            lathifPanel1.Controls.Add(lathifPanel2);
            lathifPanel1.ForeColor = Color.White;
            lathifPanel1.Location = new Point(12, 12);
            lathifPanel1.Name = "lathifPanel1";
            lathifPanel1.Size = new Size(1058, 679);
            lathifPanel1.TabIndex = 2;
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
            lathifPanel2.Location = new Point(359, 31);
            lathifPanel2.Name = "lathifPanel2";
            lathifPanel2.Size = new Size(235, 635);
            lathifPanel2.TabIndex = 0;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(78, 595);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(lathifPanel1);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            lathifPanel1.ResumeLayout(false);
            lathifPanel2.ResumeLayout(false);
            lathifPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SMB_CustomTolbox.LathifPanel lathifPanel1;
        private SMB_CustomTolbox.LathifPanel lathifPanel2;
        private Label label2;
        private Label label1;
    }
}