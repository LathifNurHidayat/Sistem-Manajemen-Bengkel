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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            PanelBooking = new Panel();
            gradientPanelExt4 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            LabelDataKosong = new Label();
            GridListData = new DataGridView();
            panel3 = new Panel();
            label3 = new Label();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            PanelBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt4).BeginInit();
            gradientPanelExt4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListData).BeginInit();
            SuspendLayout();
            // 
            // PanelBooking
            // 
            PanelBooking.AutoScroll = true;
            PanelBooking.BackColor = Color.White;
            PanelBooking.Controls.Add(gradientPanelExt4);
            PanelBooking.Controls.Add(panel3);
            PanelBooking.Controls.Add(label3);
            PanelBooking.Dock = DockStyle.Fill;
            PanelBooking.Location = new Point(0, 0);
            PanelBooking.Name = "PanelBooking";
            PanelBooking.Size = new Size(1374, 703);
            PanelBooking.TabIndex = 0;
            // 
            // gradientPanelExt4
            // 
            gradientPanelExt4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            gradientPanelExt4.BackColor = Color.WhiteSmoke;
            gradientPanelExt4.Border = new Padding(2);
            gradientPanelExt4.BorderGap = 2;
            gradientPanelExt4.BorderStyle = BorderStyle.None;
            gradientPanelExt4.Controls.Add(LabelDataKosong);
            gradientPanelExt4.Controls.Add(GridListData);
            gradientPanelExt4.Location = new Point(27, 185);
            gradientPanelExt4.Name = "gradientPanelExt4";
            gradientPanelExt4.Size = new Size(1324, 438);
            gradientPanelExt4.TabIndex = 95;
            // 
            // LabelDataKosong
            // 
            LabelDataKosong.AutoSize = true;
            LabelDataKosong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDataKosong.Location = new Point(28, 14);
            LabelDataKosong.Name = "LabelDataKosong";
            LabelDataKosong.Size = new Size(216, 28);
            LabelDataKosong.TabIndex = 96;
            LabelDataKosong.Text = "*Tidak ada data riwayat";
            LabelDataKosong.Visible = false;
            // 
            // GridListData
            // 
            GridListData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListData.BorderStyle = BorderStyle.None;
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
            GridListData.Location = new Point(28, 49);
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
            GridListData.Size = new Size(1265, 347);
            GridListData.TabIndex = 53;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Gray;
            panel3.Location = new Point(27, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(1300, 3);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(542, 35);
            label3.Name = "label3";
            label3.Size = new Size(290, 46);
            label3.TabIndex = 94;
            label3.Text = "Riwayat Booking";
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
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt4).EndInit();
            gradientPanelExt4.ResumeLayout(false);
            gradientPanelExt4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridListData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBooking;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label3;
        private Panel panel3;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt4;
        private DataGridView GridListData;
        private Label LabelDataKosong;
    }
}