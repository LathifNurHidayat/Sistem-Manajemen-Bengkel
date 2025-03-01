namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.KandaraanForm
{
    partial class DataPelangganFormHelper
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
            GridListData = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ComboEntries = new ComboBox();
            ButtonSearch = new SMB_CustomTolbox.LathifButton();
            TextSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ButtonPilih = new SMB_CustomTolbox.LathifButton();
            ((System.ComponentModel.ISupportInitialize)GridListData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TextSearch).BeginInit();
            SuspendLayout();
            // 
            // GridListData
            // 
            GridListData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListData.BackgroundColor = Color.Gainsboro;
            GridListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListData.Location = new Point(17, 94);
            GridListData.Name = "GridListData";
            GridListData.RowHeadersWidth = 51;
            GridListData.RowTemplate.Height = 29;
            GridListData.Size = new Size(572, 271);
            GridListData.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(157, 390);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 59;
            label2.Text = "entries";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 390);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 58;
            label1.Text = "Show";
            // 
            // ComboEntries
            // 
            ComboEntries.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ComboEntries.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboEntries.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboEntries.ForeColor = Color.Black;
            ComboEntries.FormattingEnabled = true;
            ComboEntries.Location = new Point(74, 387);
            ComboEntries.Name = "ComboEntries";
            ComboEntries.Size = new Size(69, 31);
            ComboEntries.TabIndex = 57;
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
            ButtonSearch.Location = new Point(268, 34);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(53, 31);
            ButtonSearch.TabIndex = 56;
            ButtonSearch.Text = "🔍";
            ButtonSearch.TextColor = Color.White;
            ButtonSearch.UseVisualStyleBackColor = false;
            // 
            // TextSearch
            // 
            TextSearch.BeforeTouchSize = new Size(245, 30);
            TextSearch.Border3DStyle = Border3DStyle.Bump;
            TextSearch.BorderColor = Color.DimGray;
            TextSearch.BorderStyle = BorderStyle.FixedSingle;
            TextSearch.FocusBorderColor = Color.Black;
            TextSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextSearch.ForeColor = Color.Black;
            TextSearch.Location = new Point(17, 35);
            TextSearch.MinimumSize = new Size(34, 30);
            TextSearch.Name = "TextSearch";
            TextSearch.PlaceholderText = "🔍   Cari";
            TextSearch.Size = new Size(245, 30);
            TextSearch.TabIndex = 55;
            // 
            // ButtonPilih
            // 
            ButtonPilih.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonPilih.BackColor = Color.Goldenrod;
            ButtonPilih.BackgroundColor = Color.Goldenrod;
            ButtonPilih.BorderColor = Color.DarkGray;
            ButtonPilih.BorderRadius = 3;
            ButtonPilih.BorderSize = 0;
            ButtonPilih.FlatAppearance.BorderSize = 0;
            ButtonPilih.FlatStyle = FlatStyle.Flat;
            ButtonPilih.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonPilih.ForeColor = Color.White;
            ButtonPilih.Location = new Point(469, 381);
            ButtonPilih.Name = "ButtonPilih";
            ButtonPilih.Size = new Size(120, 40);
            ButtonPilih.TabIndex = 60;
            ButtonPilih.Text = "➕ Pilih";
            ButtonPilih.TextColor = Color.White;
            ButtonPilih.UseVisualStyleBackColor = false;
            // 
            // DataPelangganFormHelper
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(621, 442);
            Controls.Add(ButtonPilih);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ComboEntries);
            Controls.Add(ButtonSearch);
            Controls.Add(TextSearch);
            Controls.Add(GridListData);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DataPelangganFormHelper";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)GridListData).EndInit();
            ((System.ComponentModel.ISupportInitialize)TextSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridListData;
        private Label label2;
        private Label label1;
        private ComboBox ComboEntries;
        private SMB_CustomTolbox.LathifButton ButtonSearch;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearch;
        private SMB_CustomTolbox.LathifButton ButtonPilih;
    }
}