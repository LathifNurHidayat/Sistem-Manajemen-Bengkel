namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.DashboardForm
{
    partial class JadwalLiburForm
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
            panel1 = new Panel();
            panel3 = new Panel();
            GridListData = new DataGridView();
            ButtonTambahkan = new SMB_CustomTolbox.LathifButton();
            label2 = new Label();
            PickerBookingTanggal = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            panel2 = new Panel();
            label1 = new Label();
            ComboSabtu = new MaterialSkin.Controls.MaterialCheckbox();
            ComboMinggu = new MaterialSkin.Controls.MaterialCheckbox();
            ComboSelasa = new MaterialSkin.Controls.MaterialCheckbox();
            ComboRabu = new MaterialSkin.Controls.MaterialCheckbox();
            ComboKamis = new MaterialSkin.Controls.MaterialCheckbox();
            ComboJumat = new MaterialSkin.Controls.MaterialCheckbox();
            ComboSenin = new MaterialSkin.Controls.MaterialCheckbox();
            LabelJudul = new Label();
            label6 = new Label();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            contextMenuStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridListData).BeginInit();
            panel2.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(LabelJudul);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ButtonSimpan);
            panel1.Controls.Add(ButtonBatal);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 727);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(GridListData);
            panel3.Controls.Add(ButtonTambahkan);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(PickerBookingTanggal);
            panel3.Location = new Point(25, 368);
            panel3.Name = "panel3";
            panel3.Size = new Size(444, 280);
            panel3.TabIndex = 82;
            // 
            // GridListData
            // 
            GridListData.BackgroundColor = Color.White;
            GridListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridListData.Location = new Point(11, 92);
            GridListData.Name = "GridListData";
            GridListData.RowHeadersWidth = 51;
            GridListData.RowTemplate.Height = 29;
            GridListData.Size = new Size(421, 175);
            GridListData.TabIndex = 95;
            // 
            // ButtonTambahkan
            // 
            ButtonTambahkan.BackColor = Color.FromArgb(83, 92, 145);
            ButtonTambahkan.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonTambahkan.BorderColor = Color.DarkGray;
            ButtonTambahkan.BorderRadius = 3;
            ButtonTambahkan.BorderSize = 0;
            ButtonTambahkan.FlatAppearance.BorderSize = 0;
            ButtonTambahkan.FlatStyle = FlatStyle.Flat;
            ButtonTambahkan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonTambahkan.ForeColor = Color.White;
            ButtonTambahkan.Location = new Point(294, 35);
            ButtonTambahkan.Name = "ButtonTambahkan";
            ButtonTambahkan.Size = new Size(138, 35);
            ButtonTambahkan.TabIndex = 94;
            ButtonTambahkan.Text = "➕ Tambahkan";
            ButtonTambahkan.TextColor = Color.White;
            ButtonTambahkan.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(11, 12);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 92;
            label2.Text = "Jadwal libur khusus :";
            // 
            // PickerBookingTanggal
            // 
            PickerBookingTanggal.AllowNull = true;
            PickerBookingTanggal.BackColor = Color.White;
            PickerBookingTanggal.DateTimeIcon = null;
            PickerBookingTanggal.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.Custom;
            PickerBookingTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PickerBookingTanggal.Format = "dddd, dd MMMM yyyy";
            PickerBookingTanggal.Location = new Point(11, 38);
            PickerBookingTanggal.Name = "PickerBookingTanggal";
            PickerBookingTanggal.Size = new Size(258, 30);
            PickerBookingTanggal.TabIndex = 93;
            PickerBookingTanggal.ToolTipText = "";
            PickerBookingTanggal.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ComboSabtu);
            panel2.Controls.Add(ComboMinggu);
            panel2.Controls.Add(ComboSelasa);
            panel2.Controls.Add(ComboRabu);
            panel2.Controls.Add(ComboKamis);
            panel2.Controls.Add(ComboJumat);
            panel2.Controls.Add(ComboSenin);
            panel2.Location = new Point(25, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 211);
            panel2.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 82;
            label1.Text = "Liburkan pada :";
            // 
            // ComboSabtu
            // 
            ComboSabtu.AutoSize = true;
            ComboSabtu.BackColor = Color.White;
            ComboSabtu.Depth = 0;
            ComboSabtu.Location = new Point(171, 151);
            ComboSabtu.Margin = new Padding(0);
            ComboSabtu.MouseLocation = new Point(-1, -1);
            ComboSabtu.MouseState = MaterialSkin.MouseState.HOVER;
            ComboSabtu.Name = "ComboSabtu";
            ComboSabtu.ReadOnly = false;
            ComboSabtu.Ripple = true;
            ComboSabtu.Size = new Size(77, 37);
            ComboSabtu.TabIndex = 86;
            ComboSabtu.Text = "Sabtu";
            ComboSabtu.UseVisualStyleBackColor = false;
            // 
            // ComboMinggu
            // 
            ComboMinggu.AutoSize = true;
            ComboMinggu.BackColor = Color.White;
            ComboMinggu.Depth = 0;
            ComboMinggu.Location = new Point(319, 151);
            ComboMinggu.Margin = new Padding(0);
            ComboMinggu.MouseLocation = new Point(-1, -1);
            ComboMinggu.MouseState = MaterialSkin.MouseState.HOVER;
            ComboMinggu.Name = "ComboMinggu";
            ComboMinggu.ReadOnly = false;
            ComboMinggu.Ripple = true;
            ComboMinggu.Size = new Size(89, 37);
            ComboMinggu.TabIndex = 85;
            ComboMinggu.Text = "Minggu";
            ComboMinggu.UseVisualStyleBackColor = false;
            // 
            // ComboSelasa
            // 
            ComboSelasa.AutoSize = true;
            ComboSelasa.BackColor = Color.White;
            ComboSelasa.Depth = 0;
            ComboSelasa.Location = new Point(28, 98);
            ComboSelasa.Margin = new Padding(0);
            ComboSelasa.MouseLocation = new Point(-1, -1);
            ComboSelasa.MouseState = MaterialSkin.MouseState.HOVER;
            ComboSelasa.Name = "ComboSelasa";
            ComboSelasa.ReadOnly = false;
            ComboSelasa.Ripple = true;
            ComboSelasa.Size = new Size(83, 37);
            ComboSelasa.TabIndex = 84;
            ComboSelasa.Text = "Selasa";
            ComboSelasa.UseVisualStyleBackColor = false;
            // 
            // ComboRabu
            // 
            ComboRabu.AutoSize = true;
            ComboRabu.BackColor = Color.White;
            ComboRabu.Depth = 0;
            ComboRabu.Location = new Point(28, 151);
            ComboRabu.Margin = new Padding(0);
            ComboRabu.MouseLocation = new Point(-1, -1);
            ComboRabu.MouseState = MaterialSkin.MouseState.HOVER;
            ComboRabu.Name = "ComboRabu";
            ComboRabu.ReadOnly = false;
            ComboRabu.Ripple = true;
            ComboRabu.Size = new Size(72, 37);
            ComboRabu.TabIndex = 83;
            ComboRabu.Text = "Rabu";
            ComboRabu.UseVisualStyleBackColor = false;
            // 
            // ComboKamis
            // 
            ComboKamis.AutoSize = true;
            ComboKamis.BackColor = Color.White;
            ComboKamis.Depth = 0;
            ComboKamis.Location = new Point(171, 45);
            ComboKamis.Margin = new Padding(0);
            ComboKamis.MouseLocation = new Point(-1, -1);
            ComboKamis.MouseState = MaterialSkin.MouseState.HOVER;
            ComboKamis.Name = "ComboKamis";
            ComboKamis.ReadOnly = false;
            ComboKamis.Ripple = true;
            ComboKamis.Size = new Size(80, 37);
            ComboKamis.TabIndex = 82;
            ComboKamis.Text = "Kamis";
            ComboKamis.UseVisualStyleBackColor = false;
            // 
            // ComboJumat
            // 
            ComboJumat.AutoSize = true;
            ComboJumat.BackColor = Color.White;
            ComboJumat.Depth = 0;
            ComboJumat.Location = new Point(171, 98);
            ComboJumat.Margin = new Padding(0);
            ComboJumat.MouseLocation = new Point(-1, -1);
            ComboJumat.MouseState = MaterialSkin.MouseState.HOVER;
            ComboJumat.Name = "ComboJumat";
            ComboJumat.ReadOnly = false;
            ComboJumat.Ripple = true;
            ComboJumat.Size = new Size(81, 37);
            ComboJumat.TabIndex = 81;
            ComboJumat.Text = "Jumat";
            ComboJumat.UseVisualStyleBackColor = false;
            // 
            // ComboSenin
            // 
            ComboSenin.AutoSize = true;
            ComboSenin.BackColor = Color.White;
            ComboSenin.Depth = 0;
            ComboSenin.Location = new Point(28, 45);
            ComboSenin.Margin = new Padding(0);
            ComboSenin.MouseLocation = new Point(-1, -1);
            ComboSenin.MouseState = MaterialSkin.MouseState.HOVER;
            ComboSenin.Name = "ComboSenin";
            ComboSenin.ReadOnly = false;
            ComboSenin.Ripple = true;
            ComboSenin.Size = new Size(75, 37);
            ComboSenin.TabIndex = 80;
            ComboSenin.Text = "Senin";
            ComboSenin.UseVisualStyleBackColor = false;
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJudul.ForeColor = Color.Black;
            LabelJudul.Location = new Point(166, 38);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(143, 31);
            LabelJudul.TabIndex = 71;
            LabelJudul.Text = "Jadwal Libur";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(54, 69);
            label6.Name = "label6";
            label6.Size = new Size(382, 23);
            label6.TabIndex = 72;
            label6.Text = "*Jadwal ini mencegah booking saat bengkel libur";
            label6.TextAlign = ContentAlignment.TopCenter;
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
            ButtonSimpan.Location = new Point(339, 666);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(130, 40);
            ButtonSimpan.TabIndex = 3;
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
            ButtonBatal.Location = new Point(186, 666);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(130, 40);
            ButtonBatal.TabIndex = 4;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
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
            // JadwalLiburForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(515, 751);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "JadwalLiburForm";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridListData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
        private Label LabelJudul;
        private Label label6;
        private CheckBox checkBox1;
        private MaterialSkin.Controls.MaterialCheckbox ComboSenin;
        private Panel panel2;
        private Label label1;
        private MaterialSkin.Controls.MaterialCheckbox ComboSabtu;
        private MaterialSkin.Controls.MaterialCheckbox ComboMinggu;
        private MaterialSkin.Controls.MaterialCheckbox ComboSelasa;
        private MaterialSkin.Controls.MaterialCheckbox ComboRabu;
        private MaterialSkin.Controls.MaterialCheckbox ComboKamis;
        private MaterialSkin.Controls.MaterialCheckbox ComboJumat;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private Panel panel3;
        private Label label2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit PickerBookingTanggal;
        private SMB_CustomTolbox.LathifButton ButtonTambahkan;
        private DataGridView GridListData;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx contextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}