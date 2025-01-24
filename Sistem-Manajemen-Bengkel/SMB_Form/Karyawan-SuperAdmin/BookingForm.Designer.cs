namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    partial class BookingForm
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
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label7 = new Label();
            lathifButton1 = new SMB_CustomTolbox.LathifButton();
            ((System.ComponentModel.ISupportInitialize)GridListBooking).BeginInit();
            PanelBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            SuspendLayout();
            // 
            // GridListBooking
            // 
            GridListBooking.AccessibleName = "Table";
            GridListBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListBooking.Location = new Point(18, 185);
            GridListBooking.Name = "GridListBooking";
            GridListBooking.PreviewRowHeight = 35;
            GridListBooking.Size = new Size(1023, 439);
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
            PanelBooking.Controls.Add(textBoxExt1);
            PanelBooking.Controls.Add(label7);
            PanelBooking.Controls.Add(lathifButton1);
            PanelBooking.Controls.Add(GridListBooking);
            PanelBooking.ForeColor = Color.White;
            PanelBooking.Location = new Point(11, 12);
            PanelBooking.Name = "PanelBooking";
            PanelBooking.Size = new Size(1059, 679);
            PanelBooking.TabIndex = 14;
            // 
            // textBoxExt1
            // 
            textBoxExt1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxExt1.BeforeTouchSize = new Size(362, 34);
            textBoxExt1.Border3DStyle = Border3DStyle.Bump;
            textBoxExt1.BorderColor = Color.DimGray;
            textBoxExt1.BorderStyle = BorderStyle.FixedSingle;
            textBoxExt1.FocusBorderColor = Color.Black;
            textBoxExt1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxExt1.Location = new Point(677, 131);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.PlaceholderText = "🔍   Search";
            textBoxExt1.Size = new Size(362, 34);
            textBoxExt1.TabIndex = 21;
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
            lathifButton1.Location = new Point(25, 120);
            lathifButton1.Name = "lathifButton1";
            lathifButton1.Size = new Size(135, 45);
            lathifButton1.TabIndex = 15;
            lathifButton1.Text = "➕ Tambah ";
            lathifButton1.TextColor = Color.White;
            lathifButton1.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridListBooking;
        private SMB_CustomTolbox.LathifPanel PanelBooking;
        private SMB_CustomTolbox.LathifButton lathifButton1;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
    }
}