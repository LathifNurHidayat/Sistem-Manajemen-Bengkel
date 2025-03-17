namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.SparepartForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            PanelBooking = new Panel();
            label3 = new Label();
            ComboFilter = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            TextPage = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            LabelShowEntries = new Label();
            ComboEntries = new ComboBox();
            TextSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            GridListData = new DataGridView();
            label7 = new Label();
            contextMenuStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ButtonNext = new SMB_CustomTolbox.LathifButton();
            ButtonPreviuos = new SMB_CustomTolbox.LathifButton();
            ButtonSearch = new SMB_CustomTolbox.LathifButton();
            ButtonTambah = new SMB_CustomTolbox.LathifButton();
            PanelBooking.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TextSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridListData).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // PanelBooking
            // 
            PanelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelBooking.AutoScroll = true;
            PanelBooking.BackColor = Color.White;
            PanelBooking.Controls.Add(ButtonNext);
            PanelBooking.Controls.Add(ButtonPreviuos);
            PanelBooking.Controls.Add(ButtonSearch);
            PanelBooking.Controls.Add(ButtonTambah);
            PanelBooking.Controls.Add(label3);
            PanelBooking.Controls.Add(ComboFilter);
            PanelBooking.Controls.Add(label2);
            PanelBooking.Controls.Add(label1);
            PanelBooking.Controls.Add(panel1);
            PanelBooking.Controls.Add(LabelShowEntries);
            PanelBooking.Controls.Add(ComboEntries);
            PanelBooking.Controls.Add(TextSearch);
            PanelBooking.Controls.Add(GridListData);
            PanelBooking.Controls.Add(label7);
            PanelBooking.Location = new Point(12, 12);
            PanelBooking.Name = "PanelBooking";
            PanelBooking.Size = new Size(1058, 679);
            PanelBooking.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(816, 172);
            label3.Name = "label3";
            label3.Size = new Size(43, 23);
            label3.TabIndex = 56;
            label3.Text = "Role";
            // 
            // ComboFilter
            // 
            ComboFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ComboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboFilter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboFilter.ForeColor = Color.Black;
            ComboFilter.FormattingEnabled = true;
            ComboFilter.Location = new Point(861, 169);
            ComboFilter.Name = "ComboFilter";
            ComboFilter.Size = new Size(165, 31);
            ComboFilter.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(160, 178);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 54;
            label2.Text = "entries";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 178);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 53;
            label1.Text = "Show";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(83, 92, 145);
            panel1.Controls.Add(TextPage);
            panel1.Location = new Point(861, 624);
            panel1.Name = "panel1";
            panel1.Size = new Size(66, 35);
            panel1.TabIndex = 52;
            // 
            // TextPage
            // 
            TextPage.Anchor = AnchorStyles.None;
            TextPage.BackColor = Color.FromArgb(83, 92, 145);
            TextPage.BeforeTouchSize = new Size(245, 30);
            TextPage.Border3DStyle = Border3DStyle.Bump;
            TextPage.BorderColor = Color.SlateGray;
            TextPage.BorderStyle = BorderStyle.None;
            TextPage.FocusBorderColor = Color.Black;
            TextPage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TextPage.ForeColor = Color.White;
            TextPage.Location = new Point(3, 5);
            TextPage.MinimumSize = new Size(24, 20);
            TextPage.Name = "TextPage";
            TextPage.ReadOnly = true;
            TextPage.Size = new Size(60, 24);
            TextPage.TabIndex = 32;
            TextPage.Text = "1";
            TextPage.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelShowEntries
            // 
            LabelShowEntries.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelShowEntries.AutoSize = true;
            LabelShowEntries.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LabelShowEntries.ForeColor = Color.Black;
            LabelShowEntries.Location = new Point(27, 629);
            LabelShowEntries.Name = "LabelShowEntries";
            LabelShowEntries.Size = new Size(241, 23);
            LabelShowEntries.TabIndex = 49;
            LabelShowEntries.Text = "Showing 11 to 10 of 29 entries";
            // 
            // ComboEntries
            // 
            ComboEntries.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboEntries.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboEntries.ForeColor = Color.Black;
            ComboEntries.FormattingEnabled = true;
            ComboEntries.Location = new Point(85, 172);
            ComboEntries.Name = "ComboEntries";
            ComboEntries.Size = new Size(69, 31);
            ComboEntries.TabIndex = 48;
            // 
            // TextSearch
            // 
            TextSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TextSearch.BeforeTouchSize = new Size(245, 30);
            TextSearch.Border3DStyle = Border3DStyle.Bump;
            TextSearch.BorderColor = Color.DimGray;
            TextSearch.BorderStyle = BorderStyle.FixedSingle;
            TextSearch.FocusBorderColor = Color.Black;
            TextSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextSearch.ForeColor = Color.Black;
            TextSearch.Location = new Point(470, 169);
            TextSearch.MinimumSize = new Size(34, 30);
            TextSearch.Name = "TextSearch";
            TextSearch.PlaceholderText = "🔍   Cari";
            TextSearch.Size = new Size(245, 30);
            TextSearch.TabIndex = 45;
            // 
            // GridListData
            // 
            GridListData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListData.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            GridListData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            GridListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            GridListData.DefaultCellStyle = dataGridViewCellStyle5;
            GridListData.Location = new Point(27, 233);
            GridListData.Name = "GridListData";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            GridListData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            GridListData.RowHeadersWidth = 51;
            GridListData.RowTemplate.Height = 29;
            GridListData.Size = new Size(1008, 358);
            GridListData.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 15);
            label7.Name = "label7";
            label7.Size = new Size(204, 39);
            label7.TabIndex = 43;
            label7.Text = "🔩  Sparepart";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip.MetroColor = Color.FromArgb(204, 236, 249);
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(146, 68);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editToolStripMenuItem.Image = Properties.Resources.pencil;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(145, 32);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteToolStripMenuItem.Image = Properties.Resources.delete__1_;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(145, 32);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // ButtonNext
            // 
            ButtonNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonNext.BackColor = Color.Transparent;
            ButtonNext.BackgroundColor = Color.Transparent;
            ButtonNext.BorderColor = Color.DarkGray;
            ButtonNext.BorderRadius = 1;
            ButtonNext.BorderSize = 1;
            ButtonNext.FlatAppearance.BorderSize = 0;
            ButtonNext.FlatStyle = FlatStyle.Flat;
            ButtonNext.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonNext.ForeColor = Color.DimGray;
            ButtonNext.Location = new Point(927, 624);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(108, 35);
            ButtonNext.TabIndex = 60;
            ButtonNext.Text = "Next";
            ButtonNext.TextColor = Color.DimGray;
            ButtonNext.UseVisualStyleBackColor = false;
            // 
            // ButtonPreviuos
            // 
            ButtonPreviuos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonPreviuos.BackColor = Color.Transparent;
            ButtonPreviuos.BackgroundColor = Color.Transparent;
            ButtonPreviuos.BorderColor = Color.DarkGray;
            ButtonPreviuos.BorderRadius = 1;
            ButtonPreviuos.BorderSize = 1;
            ButtonPreviuos.FlatAppearance.BorderSize = 0;
            ButtonPreviuos.FlatStyle = FlatStyle.Flat;
            ButtonPreviuos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonPreviuos.ForeColor = Color.DimGray;
            ButtonPreviuos.Location = new Point(753, 624);
            ButtonPreviuos.Name = "ButtonPreviuos";
            ButtonPreviuos.Size = new Size(108, 35);
            ButtonPreviuos.TabIndex = 59;
            ButtonPreviuos.Text = "Previous";
            ButtonPreviuos.TextColor = Color.DimGray;
            ButtonPreviuos.UseVisualStyleBackColor = false;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonSearch.BackColor = Color.FromArgb(83, 92, 145);
            ButtonSearch.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonSearch.BackgroundImage = Properties.Resources.User_Hitam;
            ButtonSearch.BorderColor = Color.Black;
            ButtonSearch.BorderRadius = 3;
            ButtonSearch.BorderSize = 0;
            ButtonSearch.FlatAppearance.BorderSize = 0;
            ButtonSearch.FlatStyle = FlatStyle.Flat;
            ButtonSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Location = new Point(721, 168);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(53, 31);
            ButtonSearch.TabIndex = 58;
            ButtonSearch.Text = "🔍";
            ButtonSearch.TextColor = Color.White;
            ButtonSearch.UseVisualStyleBackColor = false;
            // 
            // ButtonTambah
            // 
            ButtonTambah.BackColor = Color.FromArgb(83, 92, 145);
            ButtonTambah.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonTambah.BorderColor = Color.DarkGray;
            ButtonTambah.BorderRadius = 3;
            ButtonTambah.BorderSize = 0;
            ButtonTambah.FlatAppearance.BorderSize = 0;
            ButtonTambah.FlatStyle = FlatStyle.Flat;
            ButtonTambah.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonTambah.ForeColor = Color.White;
            ButtonTambah.Location = new Point(28, 115);
            ButtonTambah.Name = "ButtonTambah";
            ButtonTambah.Size = new Size(124, 39);
            ButtonTambah.TabIndex = 57;
            ButtonTambah.Text = "➕ Tambah ";
            ButtonTambah.TextColor = Color.White;
            ButtonTambah.UseVisualStyleBackColor = false;
            // 
            // SparepartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(PanelBooking);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "SparepartForm";
            PanelBooking.ResumeLayout(false);
            PanelBooking.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TextPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)TextSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridListData).EndInit();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBooking;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextPage;
        private SMB_CustomTolbox.LathifButton ButtonNext;
        private SMB_CustomTolbox.LathifButton ButtonPreviuos;
        private Label LabelShowEntries;
        private ComboBox ComboEntries;
        private SMB_CustomTolbox.LathifButton ButtonSearch;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearch;
        private DataGridView GridListData;
        private Label label7;
        private SMB_CustomTolbox.LathifButton ButtonTambah;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStrip;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ComboBox ComboFilter;
        private Label label3;
    }
}