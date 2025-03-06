namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Dashboard
{
    partial class DashboardPelanggan
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
            Label = new Label();
            PanelData = new SMB_CustomTolbox.LathifPanel();
            label10 = new Label();
            gradientPanelExt2 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            label8 = new Label();
            GridListPeringkatSparepart = new DataGridView();
            LabelPendapatan = new Label();
            gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            label9 = new Label();
            GridListPeringkatServis = new DataGridView();
            PanelBackground = new Panel();
            PanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt2).BeginInit();
            gradientPanelExt2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListPeringkatSparepart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).BeginInit();
            gradientPanelExt1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListPeringkatServis).BeginInit();
            SuspendLayout();
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Label.Location = new Point(11, 29);
            Label.Name = "Label";
            Label.Size = new Size(27, 42);
            Label.TabIndex = 6;
            Label.Text = " ";
            // 
            // PanelData
            // 
            PanelData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelData.BackColor = Color.White;
            PanelData.BorderColor = Color.PaleVioletRed;
            PanelData.BorderRadius = 10;
            PanelData.BorderSize = 0;
            PanelData.Controls.Add(label10);
            PanelData.Controls.Add(gradientPanelExt2);
            PanelData.Controls.Add(LabelPendapatan);
            PanelData.Controls.Add(gradientPanelExt1);
            PanelData.ForeColor = Color.White;
            PanelData.Location = new Point(11, 388);
            PanelData.Name = "PanelData";
            PanelData.Size = new Size(1057, 301);
            PanelData.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(21, 24);
            label10.Name = "label10";
            label10.Size = new Size(167, 25);
            label10.TabIndex = 18;
            label10.Text = "Pendapatan hari ini ";
            // 
            // gradientPanelExt2
            // 
            gradientPanelExt2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradientPanelExt2.BackColor = Color.Transparent;
            gradientPanelExt2.Border = new Padding(2);
            gradientPanelExt2.BorderGap = 2;
            gradientPanelExt2.BorderStyle = BorderStyle.None;
            gradientPanelExt2.Controls.Add(label8);
            gradientPanelExt2.Controls.Add(GridListPeringkatSparepart);
            gradientPanelExt2.CornerRadius = 10;
            gradientPanelExt2.Location = new Point(21, 106);
            gradientPanelExt2.Name = "gradientPanelExt2";
            gradientPanelExt2.Size = new Size(520, 171);
            gradientPanelExt2.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(20, 20);
            label8.Name = "label8";
            label8.Size = new Size(238, 25);
            label8.TabIndex = 17;
            label8.Text = "Peringkat Sparepart Terjual";
            // 
            // GridListPeringkatSparepart
            // 
            GridListPeringkatSparepart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListPeringkatSparepart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListPeringkatSparepart.Location = new Point(22, 60);
            GridListPeringkatSparepart.Name = "GridListPeringkatSparepart";
            GridListPeringkatSparepart.RowHeadersWidth = 51;
            GridListPeringkatSparepart.RowTemplate.Height = 29;
            GridListPeringkatSparepart.Size = new Size(475, 88);
            GridListPeringkatSparepart.TabIndex = 14;
            // 
            // LabelPendapatan
            // 
            LabelPendapatan.BackColor = Color.White;
            LabelPendapatan.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPendapatan.ForeColor = Color.DimGray;
            LabelPendapatan.Location = new Point(16, 46);
            LabelPendapatan.Name = "LabelPendapatan";
            LabelPendapatan.Size = new Size(412, 51);
            LabelPendapatan.TabIndex = 12;
            LabelPendapatan.Text = "Rp 12.000.000,00";
            LabelPendapatan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gradientPanelExt1
            // 
            gradientPanelExt1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gradientPanelExt1.BackColor = Color.Transparent;
            gradientPanelExt1.Border = new Padding(2);
            gradientPanelExt1.BorderGap = 2;
            gradientPanelExt1.BorderStyle = BorderStyle.None;
            gradientPanelExt1.Controls.Add(label9);
            gradientPanelExt1.Controls.Add(GridListPeringkatServis);
            gradientPanelExt1.CornerRadius = 10;
            gradientPanelExt1.Location = new Point(555, 106);
            gradientPanelExt1.Name = "gradientPanelExt1";
            gradientPanelExt1.Size = new Size(479, 171);
            gradientPanelExt1.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(17, 20);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 18;
            label9.Text = "Peringkat Servis";
            // 
            // GridListPeringkatServis
            // 
            GridListPeringkatServis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridListPeringkatServis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListPeringkatServis.Location = new Point(22, 58);
            GridListPeringkatServis.Name = "GridListPeringkatServis";
            GridListPeringkatServis.RowHeadersWidth = 51;
            GridListPeringkatServis.RowTemplate.Height = 29;
            GridListPeringkatServis.Size = new Size(435, 88);
            GridListPeringkatServis.TabIndex = 13;
            // 
            // PanelBackground
            // 
            PanelBackground.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PanelBackground.BackColor = Color.White;
            PanelBackground.Location = new Point(14, 14);
            PanelBackground.Name = "PanelBackground";
            PanelBackground.Size = new Size(1056, 351);
            PanelBackground.TabIndex = 13;
            // 
            // DashboardPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(PanelBackground);
            Controls.Add(PanelData);
            Controls.Add(Label);
            Name = "DashboardPelanggan";
            Text = " ";
            PanelData.ResumeLayout(false);
            PanelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt2).EndInit();
            gradientPanelExt2.ResumeLayout(false);
            gradientPanelExt2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridListPeringkatSparepart).EndInit();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).EndInit();
            gradientPanelExt1.ResumeLayout(false);
            gradientPanelExt1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridListPeringkatServis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Label;
        private SMB_CustomTolbox.LathifPanel PanelData;
        private Panel PanelBackground;
        private DataGridView GridListPeringkatServis;
        private Label LabelPendapatan;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt2;
        private DataGridView GridListPeringkatSparepart;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}