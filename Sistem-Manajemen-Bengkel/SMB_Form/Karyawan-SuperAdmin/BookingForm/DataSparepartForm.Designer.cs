namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    partial class DataSparepartForm
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
            ButtonSearch = new SMB_CustomTolbox.LathifButton();
            TextSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            GridListSparepart = new DataGridView();
            GridListSparepartUse = new DataGridView();
            label1 = new Label();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            ((System.ComponentModel.ISupportInitialize)TextSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridListSparepart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridListSparepartUse).BeginInit();
            SuspendLayout();
            // 
            // ButtonSearch
            // 
            ButtonSearch.BackColor = Color.FromArgb(83, 92, 145);
            ButtonSearch.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonSearch.BorderColor = Color.Black;
            ButtonSearch.BorderRadius = 3;
            ButtonSearch.BorderSize = 0;
            ButtonSearch.FlatAppearance.BorderSize = 0;
            ButtonSearch.FlatStyle = FlatStyle.Flat;
            ButtonSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Location = new Point(272, 25);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(53, 31);
            ButtonSearch.TabIndex = 63;
            ButtonSearch.Text = "🔍";
            ButtonSearch.TextColor = Color.White;
            ButtonSearch.UseVisualStyleBackColor = false;
            // 
            // TextSearch
            // 
            TextSearch.BeforeTouchSize = new Size(244, 30);
            TextSearch.Border3DStyle = Border3DStyle.Bump;
            TextSearch.BorderColor = Color.DimGray;
            TextSearch.BorderStyle = BorderStyle.FixedSingle;
            TextSearch.FocusBorderColor = Color.Black;
            TextSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextSearch.ForeColor = Color.Black;
            TextSearch.Location = new Point(22, 25);
            TextSearch.MinimumSize = new Size(34, 30);
            TextSearch.Name = "TextSearch";
            TextSearch.PlaceholderText = "🔍   Cari";
            TextSearch.Size = new Size(244, 30);
            TextSearch.TabIndex = 62;
            // 
            // GridListSparepart
            // 
            GridListSparepart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListSparepart.BackgroundColor = Color.Gainsboro;
            GridListSparepart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListSparepart.Location = new Point(22, 78);
            GridListSparepart.Name = "GridListSparepart";
            GridListSparepart.RowHeadersWidth = 51;
            GridListSparepart.RowTemplate.Height = 29;
            GridListSparepart.Size = new Size(505, 412);
            GridListSparepart.TabIndex = 61;
            // 
            // GridListSparepartUse
            // 
            GridListSparepartUse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListSparepartUse.BackgroundColor = Color.Gainsboro;
            GridListSparepartUse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListSparepartUse.Location = new Point(552, 78);
            GridListSparepartUse.Name = "GridListSparepartUse";
            GridListSparepartUse.RowHeadersWidth = 51;
            GridListSparepartUse.RowTemplate.Height = 29;
            GridListSparepartUse.Size = new Size(505, 412);
            GridListSparepartUse.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(543, 30);
            label1.Name = "label1";
            label1.Size = new Size(231, 25);
            label1.TabIndex = 65;
            label1.Text = "Sparepart yang digunakan";
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.BackColor = Color.ForestGreen;
            ButtonSimpan.BackgroundColor = Color.ForestGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(922, 503);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(135, 45);
            ButtonSimpan.TabIndex = 66;
            ButtonSimpan.Text = "✅ Simpan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
            // 
            // ButtonBatal
            // 
            ButtonBatal.BackColor = Color.Red;
            ButtonBatal.BackgroundColor = Color.Red;
            ButtonBatal.BorderColor = Color.DarkGray;
            ButtonBatal.BorderRadius = 5;
            ButtonBatal.BorderSize = 0;
            ButtonBatal.FlatAppearance.BorderSize = 0;
            ButtonBatal.FlatStyle = FlatStyle.Flat;
            ButtonBatal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBatal.ForeColor = Color.White;
            ButtonBatal.Location = new Point(769, 503);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(135, 45);
            ButtonBatal.TabIndex = 67;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // DataSparepartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 572);
            Controls.Add(ButtonSimpan);
            Controls.Add(ButtonBatal);
            Controls.Add(label1);
            Controls.Add(GridListSparepartUse);
            Controls.Add(ButtonSearch);
            Controls.Add(TextSearch);
            Controls.Add(GridListSparepart);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DataSparepartForm";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)TextSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridListSparepart).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridListSparepartUse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SMB_CustomTolbox.LathifButton ButtonSearch;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearch;
        private DataGridView GridListSparepart;
        private DataGridView GridListSparepartUse;
        private Label label1;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
    }
}