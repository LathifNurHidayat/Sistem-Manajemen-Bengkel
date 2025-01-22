namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    partial class PelangganForm
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
            GridListBooking = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            PanelBooking = new SMB_CustomTolbox.LathifPanel();
            lathifButton1 = new SMB_CustomTolbox.LathifButton();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridListBooking).BeginInit();
            PanelBooking.SuspendLayout();
            SuspendLayout();
            // 
            // GridListBooking
            // 
            GridListBooking.AccessibleName = "Table";
            GridListBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListBooking.Location = new Point(12, 170);
            GridListBooking.Name = "GridListBooking";
            GridListBooking.PreviewRowHeight = 35;
            GridListBooking.Size = new Size(1035, 496);
            GridListBooking.Style.BorderColor = Color.FromArgb(100, 100, 100);
            GridListBooking.Style.CheckBoxStyle.CheckedBackColor = Color.FromArgb(0, 120, 215);
            GridListBooking.Style.CheckBoxStyle.CheckedBorderColor = Color.FromArgb(0, 120, 215);
            GridListBooking.Style.CheckBoxStyle.IndeterminateBorderColor = Color.FromArgb(0, 120, 215);
            GridListBooking.Style.HyperlinkStyle.DefaultLinkColor = Color.FromArgb(0, 120, 215);
            GridListBooking.TabIndex = 13;
            GridListBooking.Text = "sfDataGrid1";
            // 
            // PanelBooking
            // 
            PanelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelBooking.BackColor = Color.White;
            PanelBooking.BorderColor = Color.PaleVioletRed;
            PanelBooking.BorderRadius = 15;
            PanelBooking.BorderSize = 0;
            PanelBooking.Controls.Add(label7);
            PanelBooking.Controls.Add(lathifButton1);
            PanelBooking.Controls.Add(GridListBooking);
            PanelBooking.ForeColor = Color.White;
            PanelBooking.Location = new Point(11, 12);
            PanelBooking.Name = "PanelBooking";
            PanelBooking.Size = new Size(1059, 679);
            PanelBooking.TabIndex = 14;
            // 
            // lathifButton1
            // 
            lathifButton1.BackColor = Color.MediumSlateBlue;
            lathifButton1.BackgroundColor = Color.MediumSlateBlue;
            lathifButton1.BorderColor = Color.DarkGray;
            lathifButton1.BorderRadius = 5;
            lathifButton1.BorderSize = 0;
            lathifButton1.FlatAppearance.BorderSize = 0;
            lathifButton1.FlatStyle = FlatStyle.Flat;
            lathifButton1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lathifButton1.ForeColor = Color.White;
            lathifButton1.Location = new Point(12, 119);
            lathifButton1.Name = "lathifButton1";
            lathifButton1.Size = new Size(135, 45);
            lathifButton1.TabIndex = 15;
            lathifButton1.Text = "➕ Tambah ";
            lathifButton1.TextColor = Color.White;
            lathifButton1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(5, 15);
            label7.Name = "label7";
            label7.Size = new Size(183, 42);
            label7.TabIndex = 16;
            label7.Text = "📆  Booking";
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(PanelBooking);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)GridListBooking).EndInit();
            PanelBooking.ResumeLayout(false);
            PanelBooking.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridListBooking;
        private SMB_CustomTolbox.LathifPanel PanelBooking;
        private SMB_CustomTolbox.LathifButton lathifButton1;
        private Label label7;
    }
}