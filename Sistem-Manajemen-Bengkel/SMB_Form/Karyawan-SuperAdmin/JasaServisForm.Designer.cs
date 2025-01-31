namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    partial class JasaServisForm
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
            label7 = new Label();
            ButtonTambah = new SMB_CustomTolbox.LathifButton();
            ((System.ComponentModel.ISupportInitialize)GridListBooking).BeginInit();
            PanelBooking.SuspendLayout();
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
            PanelBooking.Controls.Add(label7);
            PanelBooking.Controls.Add(ButtonTambah);
            PanelBooking.Controls.Add(GridListBooking);
            PanelBooking.ForeColor = Color.White;
            PanelBooking.Location = new Point(11, 12);
            PanelBooking.Name = "PanelBooking";
            PanelBooking.Size = new Size(1059, 679);
            PanelBooking.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(5, 15);
            label7.Name = "label7";
            label7.Size = new Size(239, 42);
            label7.TabIndex = 16;
            label7.Text = "🛠️  Jasa Servis";
            // 
            // ButtonTambah
            // 
            ButtonTambah.BackColor = Color.MediumSlateBlue;
            ButtonTambah.BackgroundColor = Color.MediumSlateBlue;
            ButtonTambah.BorderColor = Color.DarkGray;
            ButtonTambah.BorderRadius = 5;
            ButtonTambah.BorderSize = 0;
            ButtonTambah.FlatAppearance.BorderSize = 0;
            ButtonTambah.FlatStyle = FlatStyle.Flat;
            ButtonTambah.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonTambah.ForeColor = Color.White;
            ButtonTambah.Location = new Point(25, 120);
            ButtonTambah.Name = "ButtonTambah";
            ButtonTambah.Size = new Size(135, 45);
            ButtonTambah.TabIndex = 15;
            ButtonTambah.Text = "➕ Tambah ";
            ButtonTambah.TextColor = Color.White;
            ButtonTambah.UseVisualStyleBackColor = false;
            // 
            // JasaServisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(PanelBooking);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "JasaServisForm";
            ((System.ComponentModel.ISupportInitialize)GridListBooking).EndInit();
            PanelBooking.ResumeLayout(false);
            PanelBooking.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridListBooking;
        private SMB_CustomTolbox.LathifPanel PanelBooking;
        private SMB_CustomTolbox.LathifButton ButtonTambah;
        private Label label7;
    }
}