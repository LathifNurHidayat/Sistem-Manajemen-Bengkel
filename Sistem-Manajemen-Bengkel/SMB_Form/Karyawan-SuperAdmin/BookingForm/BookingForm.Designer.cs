namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            PanelBooking = new Panel();
            panel1 = new Panel();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            TextPage = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ButtonNext = new SMB_CustomTolbox.LathifButton();
            ButtonPreviuos = new SMB_CustomTolbox.LathifButton();
            ButtonTambah = new SMB_CustomTolbox.LathifButton();
            TextBatasBooking = new TextBox();
            label3 = new Label();
            LabelJam = new Label();
            LabelHariTanggal = new Label();
            label2 = new Label();
            label1 = new Label();
            LabelShowEntries = new Label();
            ComboEntries = new ComboBox();
            ComboFilter = new ComboBox();
            TextSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            GridListData = new DataGridView();
            label7 = new Label();
            contextMenuStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            editToolStripMenuItem = new ToolStripMenuItem();
            ButtonUbahBatasBooking = new SMB_CustomTolbox.LathifButton();
            PanelBooking.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
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
            PanelBooking.Controls.Add(ButtonUbahBatasBooking);
            PanelBooking.Controls.Add(panel1);
            PanelBooking.Controls.Add(ButtonNext);
            PanelBooking.Controls.Add(ButtonPreviuos);
            PanelBooking.Controls.Add(ButtonTambah);
            PanelBooking.Controls.Add(TextBatasBooking);
            PanelBooking.Controls.Add(label3);
            PanelBooking.Controls.Add(LabelJam);
            PanelBooking.Controls.Add(LabelHariTanggal);
            PanelBooking.Controls.Add(label2);
            PanelBooking.Controls.Add(label1);
            PanelBooking.Controls.Add(LabelShowEntries);
            PanelBooking.Controls.Add(ComboEntries);
            PanelBooking.Controls.Add(ComboFilter);
            PanelBooking.Controls.Add(TextSearch);
            PanelBooking.Controls.Add(GridListData);
            PanelBooking.Controls.Add(label7);
            PanelBooking.Location = new Point(12, 12);
            PanelBooking.Name = "PanelBooking";
            PanelBooking.Size = new Size(1058, 679);
            PanelBooking.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(83, 92, 145);
            panel1.Controls.Add(textBoxExt1);
            panel1.Controls.Add(TextPage);
            panel1.Location = new Point(861, 623);
            panel1.Name = "panel1";
            panel1.Size = new Size(66, 35);
            panel1.TabIndex = 65;
            // 
            // textBoxExt1
            // 
            textBoxExt1.Anchor = AnchorStyles.None;
            textBoxExt1.BackColor = Color.FromArgb(83, 92, 145);
            textBoxExt1.BeforeTouchSize = new Size(152, 37);
            textBoxExt1.Border3DStyle = Border3DStyle.Bump;
            textBoxExt1.BorderColor = Color.SlateGray;
            textBoxExt1.BorderStyle = BorderStyle.None;
            textBoxExt1.FocusBorderColor = Color.Black;
            textBoxExt1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxExt1.ForeColor = Color.White;
            textBoxExt1.Location = new Point(3, 5);
            textBoxExt1.MinimumSize = new Size(24, 20);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.ReadOnly = true;
            textBoxExt1.Size = new Size(60, 24);
            textBoxExt1.TabIndex = 33;
            textBoxExt1.Text = "1";
            textBoxExt1.TextAlign = HorizontalAlignment.Center;
            // 
            // TextPage
            // 
            TextPage.Anchor = AnchorStyles.None;
            TextPage.BackColor = Color.FromArgb(83, 92, 145);
            TextPage.BeforeTouchSize = new Size(152, 37);
            TextPage.Border3DStyle = Border3DStyle.Bump;
            TextPage.BorderColor = Color.SlateGray;
            TextPage.BorderStyle = BorderStyle.None;
            TextPage.FocusBorderColor = Color.Black;
            TextPage.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            TextPage.ForeColor = Color.White;
            TextPage.Location = new Point(-64, -28);
            TextPage.MinimumSize = new Size(24, 20);
            TextPage.Name = "TextPage";
            TextPage.ReadOnly = true;
            TextPage.Size = new Size(60, 24);
            TextPage.TabIndex = 32;
            TextPage.Text = "1";
            TextPage.TextAlign = HorizontalAlignment.Center;
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
            ButtonNext.Location = new Point(927, 623);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(108, 35);
            ButtonNext.TabIndex = 64;
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
            ButtonPreviuos.Location = new Point(753, 623);
            ButtonPreviuos.Name = "ButtonPreviuos";
            ButtonPreviuos.Size = new Size(108, 35);
            ButtonPreviuos.TabIndex = 63;
            ButtonPreviuos.Text = "Previous";
            ButtonPreviuos.TextColor = Color.DimGray;
            ButtonPreviuos.UseVisualStyleBackColor = false;
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
            ButtonTambah.Location = new Point(28, 110);
            ButtonTambah.Name = "ButtonTambah";
            ButtonTambah.Size = new Size(124, 39);
            ButtonTambah.TabIndex = 62;
            ButtonTambah.Text = "➕ Tambah ";
            ButtonTambah.TextColor = Color.White;
            ButtonTambah.UseVisualStyleBackColor = false;
            // 
            // TextBatasBooking
            // 
            TextBatasBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TextBatasBooking.BorderStyle = BorderStyle.FixedSingle;
            TextBatasBooking.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBatasBooking.Location = new Point(871, 125);
            TextBatasBooking.Name = "TextBatasBooking";
            TextBatasBooking.ReadOnly = true;
            TextBatasBooking.Size = new Size(40, 31);
            TextBatasBooking.TabIndex = 61;
            TextBatasBooking.Text = "1";
            TextBatasBooking.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(634, 133);
            label3.Name = "label3";
            label3.Size = new Size(184, 23);
            label3.TabIndex = 60;
            label3.Text = "Batas booking hari ini :";
            // 
            // LabelJam
            // 
            LabelJam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelJam.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LabelJam.ForeColor = Color.DimGray;
            LabelJam.Location = new Point(847, 43);
            LabelJam.Name = "LabelJam";
            LabelJam.Size = new Size(188, 24);
            LabelJam.TabIndex = 57;
            LabelJam.Text = "00:00:00";
            LabelJam.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelHariTanggal
            // 
            LabelHariTanggal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelHariTanggal.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelHariTanggal.ForeColor = Color.DimGray;
            LabelHariTanggal.Location = new Point(769, 15);
            LabelHariTanggal.Name = "LabelHariTanggal";
            LabelHariTanggal.Size = new Size(266, 28);
            LabelHariTanggal.TabIndex = 56;
            LabelHariTanggal.Text = "Selasa, 8 - 8 - 2025";
            LabelHariTanggal.TextAlign = ContentAlignment.MiddleRight;
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
            // ComboFilter
            // 
            ComboFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ComboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboFilter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboFilter.ForeColor = Color.Black;
            ComboFilter.FormattingEnabled = true;
            ComboFilter.Location = new Point(864, 171);
            ComboFilter.Name = "ComboFilter";
            ComboFilter.Size = new Size(171, 31);
            ComboFilter.TabIndex = 46;
            // 
            // TextSearch
            // 
            TextSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TextSearch.BeforeTouchSize = new Size(152, 37);
            TextSearch.Border3DStyle = Border3DStyle.Bump;
            TextSearch.BorderColor = Color.DimGray;
            TextSearch.BorderStyle = BorderStyle.FixedSingle;
            TextSearch.FocusBorderColor = Color.Black;
            TextSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TextSearch.ForeColor = Color.Black;
            TextSearch.Location = new Point(542, 172);
            TextSearch.MinimumSize = new Size(34, 30);
            TextSearch.Name = "TextSearch";
            TextSearch.PlaceholderText = "🔍   Cari";
            TextSearch.Size = new Size(236, 30);
            TextSearch.TabIndex = 45;
            // 
            // GridListData
            // 
            GridListData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            label7.Size = new Size(171, 39);
            label7.TabIndex = 43;
            label7.Text = "📆  Booking";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStrip.MetroColor = Color.FromArgb(204, 236, 249);
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(238, 36);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            editToolStripMenuItem.Image = (Image)resources.GetObject("editToolStripMenuItem.Image");
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(237, 32);
            editToolStripMenuItem.Text = "Lihat lebih detail";
            // 
            // ButtonUbahBatasBooking
            // 
            ButtonUbahBatasBooking.BackColor = Color.Salmon;
            ButtonUbahBatasBooking.BackgroundColor = Color.Salmon;
            ButtonUbahBatasBooking.BorderColor = Color.DarkGray;
            ButtonUbahBatasBooking.BorderRadius = 3;
            ButtonUbahBatasBooking.BorderSize = 0;
            ButtonUbahBatasBooking.FlatAppearance.BorderSize = 0;
            ButtonUbahBatasBooking.FlatStyle = FlatStyle.Flat;
            ButtonUbahBatasBooking.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonUbahBatasBooking.ForeColor = Color.White;
            ButtonUbahBatasBooking.Location = new Point(917, 121);
            ButtonUbahBatasBooking.Name = "ButtonUbahBatasBooking";
            ButtonUbahBatasBooking.Size = new Size(118, 39);
            ButtonUbahBatasBooking.TabIndex = 66;
            ButtonUbahBatasBooking.Text = "Ubah";
            ButtonUbahBatasBooking.TextColor = Color.White;
            ButtonUbahBatasBooking.UseVisualStyleBackColor = false;
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
            PanelBooking.ResumeLayout(false);
            PanelBooking.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
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
        private ComboBox ComboFilter;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearch;
        private DataGridView GridListData;
        private Label label7;
        private SMB_CustomTolbox.LathifButton ButtonTambah;
        private Label LabelJam;
        private Label LabelHariTanggal;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox integerTextBox1;
        private Label label3;
        private SMB_CustomTolbox.LathifButton ButtonUbahBatasBooking;
        private TextBox TextBatasBooking;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStrip;
        private ToolStripMenuItem editToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private SMB_CustomTolbox.LathifButton ButtonUbahBatasBooking;
    }
}