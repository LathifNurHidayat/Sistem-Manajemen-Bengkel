﻿namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            PanelBooking = new Panel();
            label8 = new Label();
            panel5 = new Panel();
            TextIdJasaServis = new TextBox();
            label6 = new Label();
            TextSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label3 = new Label();
            TextKeterangan = new TextBox();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            label5 = new Label();
            panel4 = new Panel();
            TextBiaya = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            label4 = new Label();
            panel3 = new Panel();
            TextJenisServis = new TextBox();
            ButtonBaru = new SMB_CustomTolbox.LathifButton();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            TextPage = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ButtonNext = new SMB_CustomTolbox.LathifButton();
            ButtonPreviuos = new SMB_CustomTolbox.LathifButton();
            LabelShowEntries = new Label();
            ComboEntries = new ComboBox();
            ButtonSearch = new SMB_CustomTolbox.LathifButton();
            ComboFilter = new ComboBox();
            GridListData = new DataGridView();
            label7 = new Label();
            contextMenuStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            PanelBooking.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextSearch).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextBiaya).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridListData).BeginInit();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // PanelBooking
            // 
            PanelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelBooking.AutoScroll = true;
            PanelBooking.BackColor = Color.White;
            PanelBooking.Controls.Add(label8);
            PanelBooking.Controls.Add(panel5);
            PanelBooking.Controls.Add(label6);
            PanelBooking.Controls.Add(TextSearch);
            PanelBooking.Controls.Add(label3);
            PanelBooking.Controls.Add(TextKeterangan);
            PanelBooking.Controls.Add(ButtonSimpan);
            PanelBooking.Controls.Add(label5);
            PanelBooking.Controls.Add(panel4);
            PanelBooking.Controls.Add(label4);
            PanelBooking.Controls.Add(panel3);
            PanelBooking.Controls.Add(ButtonBaru);
            PanelBooking.Controls.Add(panel2);
            PanelBooking.Controls.Add(label2);
            PanelBooking.Controls.Add(label1);
            PanelBooking.Controls.Add(panel1);
            PanelBooking.Controls.Add(ButtonNext);
            PanelBooking.Controls.Add(ButtonPreviuos);
            PanelBooking.Controls.Add(LabelShowEntries);
            PanelBooking.Controls.Add(ComboEntries);
            PanelBooking.Controls.Add(ButtonSearch);
            PanelBooking.Controls.Add(ComboFilter);
            PanelBooking.Controls.Add(GridListData);
            PanelBooking.Controls.Add(label7);
            PanelBooking.Location = new Point(12, 12);
            PanelBooking.Name = "PanelBooking";
            PanelBooking.Size = new Size(1058, 778);
            PanelBooking.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(221, 95);
            label8.Name = "label8";
            label8.Size = new Size(100, 25);
            label8.TabIndex = 68;
            label8.Text = "Jenis Servis";
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TextIdJasaServis);
            panel5.Location = new Point(40, 123);
            panel5.Name = "panel5";
            panel5.Size = new Size(143, 40);
            panel5.TabIndex = 7;
            // 
            // TextIdJasaServis
            // 
            TextIdJasaServis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextIdJasaServis.BackColor = Color.WhiteSmoke;
            TextIdJasaServis.BorderStyle = BorderStyle.None;
            TextIdJasaServis.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextIdJasaServis.Location = new Point(8, 8);
            TextIdJasaServis.MaxLength = 15;
            TextIdJasaServis.Name = "TextIdJasaServis";
            TextIdJasaServis.ReadOnly = true;
            TextIdJasaServis.Size = new Size(130, 24);
            TextIdJasaServis.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(835, 347);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 67;
            label6.Text = "Sort by";
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
            TextSearch.Location = new Point(443, 344);
            TextSearch.MinimumSize = new Size(34, 30);
            TextSearch.Name = "TextSearch";
            TextSearch.PlaceholderText = "🔍   Cari";
            TextSearch.Size = new Size(316, 30);
            TextSearch.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(637, 95);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 66;
            label3.Text = "Keterangan";
            // 
            // TextKeterangan
            // 
            TextKeterangan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextKeterangan.BorderStyle = BorderStyle.FixedSingle;
            TextKeterangan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextKeterangan.Location = new Point(637, 123);
            TextKeterangan.MaxLength = 15;
            TextKeterangan.Multiline = true;
            TextKeterangan.Name = "TextKeterangan";
            TextKeterangan.Size = new Size(396, 117);
            TextKeterangan.TabIndex = 10;
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonSimpan.BackColor = Color.ForestGreen;
            ButtonSimpan.BackgroundColor = Color.ForestGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(904, 256);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(125, 38);
            ButtonSimpan.TabIndex = 11;
            ButtonSimpan.Text = "✅ Simpan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(40, 172);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 62;
            label5.Text = "Biaya";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(TextBiaya);
            panel4.Location = new Point(40, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(558, 40);
            panel4.TabIndex = 9;
            // 
            // TextBiaya
            // 
            TextBiaya.AccessibilityEnabled = true;
            TextBiaya.BeforeTouchSize = new Size(152, 37);
            TextBiaya.BorderStyle = BorderStyle.None;
            TextBiaya.DecimalValue = new decimal(new int[] { 0, 0, 0, 131072 });
            TextBiaya.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBiaya.Location = new Point(8, 6);
            TextBiaya.Name = "TextBiaya";
            TextBiaya.Size = new Size(545, 24);
            TextBiaya.TabIndex = 37;
            TextBiaya.Text = "Rp0,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 95);
            label4.Name = "label4";
            label4.Size = new Size(30, 25);
            label4.TabIndex = 60;
            label4.Text = "ID";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TextJenisServis);
            panel3.Location = new Point(221, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 40);
            panel3.TabIndex = 8;
            // 
            // TextJenisServis
            // 
            TextJenisServis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextJenisServis.BorderStyle = BorderStyle.None;
            TextJenisServis.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextJenisServis.Location = new Point(8, 8);
            TextJenisServis.MaxLength = 15;
            TextJenisServis.Name = "TextJenisServis";
            TextJenisServis.Size = new Size(364, 24);
            TextJenisServis.TabIndex = 0;
            // 
            // ButtonBaru
            // 
            ButtonBaru.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonBaru.BackColor = Color.SandyBrown;
            ButtonBaru.BackgroundColor = Color.SandyBrown;
            ButtonBaru.BorderColor = Color.DarkGray;
            ButtonBaru.BorderRadius = 3;
            ButtonBaru.BorderSize = 0;
            ButtonBaru.FlatAppearance.BorderSize = 0;
            ButtonBaru.FlatStyle = FlatStyle.Flat;
            ButtonBaru.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBaru.ForeColor = Color.White;
            ButtonBaru.Location = new Point(765, 257);
            ButtonBaru.Name = "ButtonBaru";
            ButtonBaru.Size = new Size(125, 38);
            ButtonBaru.TabIndex = 12;
            ButtonBaru.Text = "➕ Baru";
            ButtonBaru.TextColor = Color.White;
            ButtonBaru.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(26, 311);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 3);
            panel2.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(159, 351);
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
            label1.Location = new Point(27, 351);
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
            panel1.Location = new Point(861, 723);
            panel1.Name = "panel1";
            panel1.Size = new Size(66, 35);
            panel1.TabIndex = 52;
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
            TextPage.Location = new Point(3, 5);
            TextPage.MinimumSize = new Size(24, 20);
            TextPage.Name = "TextPage";
            TextPage.Size = new Size(60, 24);
            TextPage.TabIndex = 32;
            TextPage.TabStop = false;
            TextPage.Text = "12";
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
            ButtonNext.Location = new Point(927, 723);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(108, 35);
            ButtonNext.TabIndex = 6;
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
            ButtonPreviuos.Location = new Point(753, 723);
            ButtonPreviuos.Name = "ButtonPreviuos";
            ButtonPreviuos.Size = new Size(108, 35);
            ButtonPreviuos.TabIndex = 5;
            ButtonPreviuos.Text = "Previous";
            ButtonPreviuos.TextColor = Color.DimGray;
            ButtonPreviuos.UseVisualStyleBackColor = false;
            // 
            // LabelShowEntries
            // 
            LabelShowEntries.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelShowEntries.AutoSize = true;
            LabelShowEntries.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LabelShowEntries.ForeColor = Color.Black;
            LabelShowEntries.Location = new Point(27, 728);
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
            ComboEntries.Location = new Point(84, 345);
            ComboEntries.Name = "ComboEntries";
            ComboEntries.Size = new Size(69, 31);
            ComboEntries.TabIndex = 48;
            ComboEntries.TabStop = false;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonSearch.BackColor = Color.FromArgb(83, 92, 145);
            ButtonSearch.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonSearch.BorderColor = Color.Black;
            ButtonSearch.BorderRadius = 3;
            ButtonSearch.BorderSize = 0;
            ButtonSearch.FlatAppearance.BorderSize = 0;
            ButtonSearch.FlatStyle = FlatStyle.Flat;
            ButtonSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Location = new Point(765, 344);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(53, 31);
            ButtonSearch.TabIndex = 3;
            ButtonSearch.Text = "🔍";
            ButtonSearch.TextColor = Color.White;
            ButtonSearch.UseVisualStyleBackColor = false;
            // 
            // ComboFilter
            // 
            ComboFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ComboFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboFilter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ComboFilter.ForeColor = Color.Black;
            ComboFilter.FormattingEnabled = true;
            ComboFilter.Location = new Point(905, 344);
            ComboFilter.Name = "ComboFilter";
            ComboFilter.Size = new Size(129, 31);
            ComboFilter.TabIndex = 4;
            // 
            // GridListData
            // 
            GridListData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridListData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GridListData.DefaultCellStyle = dataGridViewCellStyle2;
            GridListData.Location = new Point(27, 386);
            GridListData.Name = "GridListData";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            GridListData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            GridListData.RowHeadersWidth = 51;
            GridListData.RowTemplate.Height = 29;
            GridListData.Size = new Size(1008, 324);
            GridListData.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 15);
            label7.Name = "label7";
            label7.Size = new Size(223, 39);
            label7.TabIndex = 43;
            label7.Text = "🛠️  Jasa Servis";
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip.MetroColor = Color.FromArgb(204, 236, 249);
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(146, 36);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deleteToolStripMenuItem.Image = Properties.Resources.delete__1_;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(145, 32);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // JasaServisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 802);
            Controls.Add(PanelBooking);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "JasaServisForm";
            PanelBooking.ResumeLayout(false);
            PanelBooking.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TextSearch).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TextBiaya).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TextPage).EndInit();
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
        private DataGridView GridListData;
        private Label label7;
        private SMB_CustomTolbox.LathifButton ButtonCancel;
        private TextBox TextKeterangan;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private Label label5;
        private Panel panel4;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextBiaya;
        private Label label4;
        private Panel panel3;
        private TextBox TextJenisServis;
        private SMB_CustomTolbox.LathifButton ButtonBaru;
        private Panel panel2;
        private Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearch;
        private Label label6;
        private Panel panel5;
        private TextBox TextIdJasaServis;
        private Label label8;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}