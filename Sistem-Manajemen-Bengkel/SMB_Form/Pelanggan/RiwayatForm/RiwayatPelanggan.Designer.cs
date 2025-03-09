namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.RiwayatForm
{
    partial class RiwayatPelanggan
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            PanelBooking = new Panel();
            PickerFilter1 = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            PickerFilter2 = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            TextPage = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ButtonNext = new SMB_CustomTolbox.LathifButton();
            ButtonPreviuos = new SMB_CustomTolbox.LathifButton();
            ComboEntries = new ComboBox();
            GridListData = new DataGridView();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            PanelBooking.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridListData).BeginInit();
            SuspendLayout();
            // 
            // PanelBooking
            // 
            PanelBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelBooking.AutoScroll = true;
            PanelBooking.BackColor = Color.White;
            PanelBooking.Controls.Add(panel3);
            PanelBooking.Controls.Add(label3);
            PanelBooking.Controls.Add(panel2);
            PanelBooking.Controls.Add(PickerFilter1);
            PanelBooking.Controls.Add(PickerFilter2);
            PanelBooking.Controls.Add(label2);
            PanelBooking.Controls.Add(label1);
            PanelBooking.Controls.Add(panel1);
            PanelBooking.Controls.Add(ButtonNext);
            PanelBooking.Controls.Add(ButtonPreviuos);
            PanelBooking.Controls.Add(ComboEntries);
            PanelBooking.Controls.Add(GridListData);
            PanelBooking.Location = new Point(12, 12);
            PanelBooking.Name = "PanelBooking";
            PanelBooking.Size = new Size(1350, 679);
            PanelBooking.TabIndex = 0;
            PanelBooking.Paint += PanelBooking_Paint;
            // 
            // PickerFilter1
            // 
            PickerFilter1.AllowNull = true;
            PickerFilter1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PickerFilter1.BackColor = Color.White;
            PickerFilter1.DateTimeIcon = null;
            PickerFilter1.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerFilter1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            PickerFilter1.Format = "dd MMMM yyyy";
            PickerFilter1.Location = new Point(956, 178);
            PickerFilter1.Name = "PickerFilter1";
            PickerFilter1.Size = new Size(176, 33);
            PickerFilter1.TabIndex = 92;
            PickerFilter1.ToolTipText = "";
            PickerFilter1.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // PickerFilter2
            // 
            PickerFilter2.AllowNull = true;
            PickerFilter2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PickerFilter2.BackColor = Color.White;
            PickerFilter2.DateTimeIcon = null;
            PickerFilter2.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerFilter2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            PickerFilter2.Format = "dd MMMM yyyy";
            PickerFilter2.Location = new Point(1151, 178);
            PickerFilter2.Name = "PickerFilter2";
            PickerFilter2.Size = new Size(176, 33);
            PickerFilter2.TabIndex = 91;
            PickerFilter2.ToolTipText = "";
            PickerFilter2.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(160, 178);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 54;
            label2.Text = "entries";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 178);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 53;
            label1.Text = "Show";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(83, 92, 145);
            panel1.Controls.Add(TextPage);
            panel1.Location = new Point(1153, 624);
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
            ButtonNext.Location = new Point(1219, 624);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(108, 35);
            ButtonNext.TabIndex = 51;
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
            ButtonPreviuos.Location = new Point(1045, 624);
            ButtonPreviuos.Name = "ButtonPreviuos";
            ButtonPreviuos.Size = new Size(108, 35);
            ButtonPreviuos.TabIndex = 50;
            ButtonPreviuos.Text = "Previous";
            ButtonPreviuos.TextColor = Color.DimGray;
            ButtonPreviuos.UseVisualStyleBackColor = false;
            // 
            // ComboEntries
            // 
            ComboEntries.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboEntries.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ComboEntries.ForeColor = Color.Black;
            ComboEntries.FormattingEnabled = true;
            ComboEntries.Location = new Point(85, 172);
            ComboEntries.Name = "ComboEntries";
            ComboEntries.Size = new Size(69, 33);
            ComboEntries.TabIndex = 48;
            // 
            // GridListData
            // 
            GridListData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListData.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            GridListData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            GridListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            GridListData.DefaultCellStyle = dataGridViewCellStyle8;
            GridListData.Location = new Point(27, 233);
            GridListData.Name = "GridListData";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            GridListData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            GridListData.RowHeadersWidth = 51;
            GridListData.RowTemplate.Height = 29;
            GridListData.Size = new Size(1300, 358);
            GridListData.TabIndex = 44;
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
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(577, 25);
            label3.Name = "label3";
            label3.Size = new Size(201, 62);
            label3.TabIndex = 94;
            label3.Text = "Riwayat";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(1135, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(13, 3);
            panel2.TabIndex = 93;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(27, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(1300, 3);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // RiwayatPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1374, 703);
            Controls.Add(PanelBooking);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "RiwayatPelanggan";
            PanelBooking.ResumeLayout(false);
            PanelBooking.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TextPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridListData).EndInit();
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
        private ComboBox ComboEntries;
        private DataGridView GridListData;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerFilter1;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerFilter2;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
    }