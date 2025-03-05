namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.DashboardForm
{
    partial class JamKerjaForm
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
            panel2 = new Panel();
            MingguTutup = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            MingguBuka = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            SabtuTutup = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            SabtuBuka = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            JumatTutup = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            JumatBuka = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            KamisTutup = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            KamisBuka = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            RabuTutup = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            RabuBuka = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            SelasaTutup = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            SelasaBuka = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            SeninTutup = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            SeninBuka = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            LabelJudul = new Label();
            label6 = new Label();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(LabelJudul);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ButtonSimpan);
            panel1.Controls.Add(ButtonBatal);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 533);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(MingguTutup);
            panel2.Controls.Add(MingguBuka);
            panel2.Controls.Add(SabtuTutup);
            panel2.Controls.Add(SabtuBuka);
            panel2.Controls.Add(JumatTutup);
            panel2.Controls.Add(JumatBuka);
            panel2.Controls.Add(KamisTutup);
            panel2.Controls.Add(KamisBuka);
            panel2.Controls.Add(RabuTutup);
            panel2.Controls.Add(RabuBuka);
            panel2.Controls.Add(SelasaTutup);
            panel2.Controls.Add(SelasaBuka);
            panel2.Controls.Add(SeninTutup);
            panel2.Controls.Add(SeninBuka);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(22, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 337);
            panel2.TabIndex = 80;
            // 
            // MingguTutup
            // 
            MingguTutup.AllowNull = true;
            MingguTutup.BackColor = Color.White;
            MingguTutup.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            MingguTutup.DateTimeIcon = null;
            MingguTutup.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            MingguTutup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MingguTutup.Format = "dddd,  dd MMMM yyyy";
            MingguTutup.Location = new Point(343, 282);
            MingguTutup.Name = "MingguTutup";
            MingguTutup.ShowDropDown = false;
            MingguTutup.Size = new Size(61, 26);
            MingguTutup.TabIndex = 104;
            MingguTutup.Tag = "Minggu";
            MingguTutup.ToolTipText = "";
            MingguTutup.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // MingguBuka
            // 
            MingguBuka.AllowNull = true;
            MingguBuka.BackColor = Color.White;
            MingguBuka.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            MingguBuka.DateTimeIcon = null;
            MingguBuka.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            MingguBuka.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MingguBuka.Format = "dddd,  dd MMMM yyyy";
            MingguBuka.Location = new Point(174, 282);
            MingguBuka.Name = "MingguBuka";
            MingguBuka.ShowDropDown = false;
            MingguBuka.Size = new Size(61, 26);
            MingguBuka.TabIndex = 103;
            MingguBuka.Tag = "Minggu";
            MingguBuka.ToolTipText = "";
            MingguBuka.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // SabtuTutup
            // 
            SabtuTutup.AllowNull = true;
            SabtuTutup.BackColor = Color.White;
            SabtuTutup.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            SabtuTutup.DateTimeIcon = null;
            SabtuTutup.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            SabtuTutup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SabtuTutup.Format = "dddd,  dd MMMM yyyy";
            SabtuTutup.Location = new Point(343, 243);
            SabtuTutup.Name = "SabtuTutup";
            SabtuTutup.ShowDropDown = false;
            SabtuTutup.Size = new Size(61, 26);
            SabtuTutup.TabIndex = 102;
            SabtuTutup.Tag = "Sabtu";
            SabtuTutup.ToolTipText = "";
            SabtuTutup.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // SabtuBuka
            // 
            SabtuBuka.AllowNull = true;
            SabtuBuka.BackColor = Color.White;
            SabtuBuka.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            SabtuBuka.DateTimeIcon = null;
            SabtuBuka.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            SabtuBuka.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SabtuBuka.Format = "dddd,  dd MMMM yyyy";
            SabtuBuka.Location = new Point(174, 243);
            SabtuBuka.Name = "SabtuBuka";
            SabtuBuka.ShowDropDown = false;
            SabtuBuka.Size = new Size(61, 26);
            SabtuBuka.TabIndex = 101;
            SabtuBuka.Tag = "Sabtu";
            SabtuBuka.ToolTipText = "";
            SabtuBuka.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // JumatTutup
            // 
            JumatTutup.AllowNull = true;
            JumatTutup.BackColor = Color.White;
            JumatTutup.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            JumatTutup.DateTimeIcon = null;
            JumatTutup.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            JumatTutup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            JumatTutup.Format = "dddd,  dd MMMM yyyy";
            JumatTutup.Location = new Point(343, 204);
            JumatTutup.Name = "JumatTutup";
            JumatTutup.ShowDropDown = false;
            JumatTutup.Size = new Size(61, 26);
            JumatTutup.TabIndex = 100;
            JumatTutup.Tag = "Jumat";
            JumatTutup.ToolTipText = "";
            JumatTutup.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // JumatBuka
            // 
            JumatBuka.AllowNull = true;
            JumatBuka.BackColor = Color.White;
            JumatBuka.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            JumatBuka.DateTimeIcon = null;
            JumatBuka.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            JumatBuka.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            JumatBuka.Format = "dddd,  dd MMMM yyyy";
            JumatBuka.Location = new Point(174, 204);
            JumatBuka.Name = "JumatBuka";
            JumatBuka.ShowDropDown = false;
            JumatBuka.Size = new Size(61, 26);
            JumatBuka.TabIndex = 99;
            JumatBuka.Tag = "Jumat";
            JumatBuka.ToolTipText = "";
            JumatBuka.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // KamisTutup
            // 
            KamisTutup.AllowNull = true;
            KamisTutup.BackColor = Color.White;
            KamisTutup.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            KamisTutup.DateTimeIcon = null;
            KamisTutup.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            KamisTutup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            KamisTutup.Format = "dddd,  dd MMMM yyyy";
            KamisTutup.Location = new Point(343, 165);
            KamisTutup.Name = "KamisTutup";
            KamisTutup.ShowDropDown = false;
            KamisTutup.Size = new Size(61, 26);
            KamisTutup.TabIndex = 98;
            KamisTutup.Tag = "Kamis";
            KamisTutup.ToolTipText = "";
            KamisTutup.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // KamisBuka
            // 
            KamisBuka.AllowNull = true;
            KamisBuka.BackColor = Color.White;
            KamisBuka.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            KamisBuka.DateTimeIcon = null;
            KamisBuka.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            KamisBuka.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            KamisBuka.Format = "dddd,  dd MMMM yyyy";
            KamisBuka.Location = new Point(174, 165);
            KamisBuka.Name = "KamisBuka";
            KamisBuka.ShowDropDown = false;
            KamisBuka.Size = new Size(61, 26);
            KamisBuka.TabIndex = 97;
            KamisBuka.Tag = "Kamis";
            KamisBuka.ToolTipText = "";
            KamisBuka.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // RabuTutup
            // 
            RabuTutup.AllowNull = true;
            RabuTutup.BackColor = Color.White;
            RabuTutup.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            RabuTutup.DateTimeIcon = null;
            RabuTutup.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            RabuTutup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RabuTutup.Format = "dddd,  dd MMMM yyyy";
            RabuTutup.Location = new Point(343, 126);
            RabuTutup.Name = "RabuTutup";
            RabuTutup.ShowDropDown = false;
            RabuTutup.Size = new Size(61, 26);
            RabuTutup.TabIndex = 96;
            RabuTutup.Tag = "Rabu";
            RabuTutup.ToolTipText = "";
            RabuTutup.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // RabuBuka
            // 
            RabuBuka.AllowNull = true;
            RabuBuka.BackColor = Color.White;
            RabuBuka.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            RabuBuka.DateTimeIcon = null;
            RabuBuka.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            RabuBuka.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RabuBuka.Format = "dddd,  dd MMMM yyyy";
            RabuBuka.Location = new Point(174, 126);
            RabuBuka.Name = "RabuBuka";
            RabuBuka.ShowDropDown = false;
            RabuBuka.Size = new Size(61, 26);
            RabuBuka.TabIndex = 95;
            RabuBuka.Tag = "Rabu";
            RabuBuka.ToolTipText = "";
            RabuBuka.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // SelasaTutup
            // 
            SelasaTutup.AllowNull = true;
            SelasaTutup.BackColor = Color.White;
            SelasaTutup.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            SelasaTutup.DateTimeIcon = null;
            SelasaTutup.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            SelasaTutup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SelasaTutup.Format = "dddd,  dd MMMM yyyy";
            SelasaTutup.Location = new Point(343, 87);
            SelasaTutup.Name = "SelasaTutup";
            SelasaTutup.ShowDropDown = false;
            SelasaTutup.Size = new Size(61, 26);
            SelasaTutup.TabIndex = 94;
            SelasaTutup.Tag = "Selasa";
            SelasaTutup.ToolTipText = "";
            SelasaTutup.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // SelasaBuka
            // 
            SelasaBuka.AllowNull = true;
            SelasaBuka.BackColor = Color.White;
            SelasaBuka.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            SelasaBuka.DateTimeIcon = null;
            SelasaBuka.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            SelasaBuka.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SelasaBuka.Format = "dddd,  dd MMMM yyyy";
            SelasaBuka.Location = new Point(174, 87);
            SelasaBuka.Name = "SelasaBuka";
            SelasaBuka.ShowDropDown = false;
            SelasaBuka.Size = new Size(61, 26);
            SelasaBuka.TabIndex = 93;
            SelasaBuka.Tag = "Selasa";
            SelasaBuka.ToolTipText = "";
            SelasaBuka.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // SeninTutup
            // 
            SeninTutup.AllowNull = true;
            SeninTutup.BackColor = Color.White;
            SeninTutup.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            SeninTutup.DateTimeIcon = null;
            SeninTutup.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            SeninTutup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SeninTutup.Format = "dddd,  dd MMMM yyyy";
            SeninTutup.Location = new Point(343, 48);
            SeninTutup.Name = "SeninTutup";
            SeninTutup.ShowDropDown = false;
            SeninTutup.Size = new Size(61, 26);
            SeninTutup.TabIndex = 92;
            SeninTutup.Tag = "Senin";
            SeninTutup.ToolTipText = "";
            SeninTutup.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // SeninBuka
            // 
            SeninBuka.AllowNull = true;
            SeninBuka.BackColor = Color.White;
            SeninBuka.DateTimeEditingMode = Syncfusion.WinForms.Input.Enums.DateTimeEditingMode.Mask;
            SeninBuka.DateTimeIcon = null;
            SeninBuka.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.ShortTime;
            SeninBuka.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SeninBuka.Format = "dddd,  dd MMMM yyyy";
            SeninBuka.Location = new Point(174, 48);
            SeninBuka.Name = "SeninBuka";
            SeninBuka.ShowDropDown = false;
            SeninBuka.Size = new Size(61, 26);
            SeninBuka.TabIndex = 91;
            SeninBuka.Tag = "Senin";
            SeninBuka.ToolTipText = "";
            SeninBuka.Value = new DateTime(2025, 2, 24, 7, 58, 7, 0);
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(329, 15);
            label11.Name = "label11";
            label11.Size = new Size(90, 23);
            label11.TabIndex = 89;
            label11.Text = "Jam Tutup";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(163, 15);
            label10.Name = "label10";
            label10.Size = new Size(84, 23);
            label10.TabIndex = 88;
            label10.Text = "Jam Buka";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(29, 15);
            label9.Name = "label9";
            label9.Size = new Size(42, 23);
            label9.TabIndex = 87;
            label9.Text = "Hari";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(18, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 3);
            panel3.TabIndex = 86;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(25, 285);
            label8.Name = "label8";
            label8.Size = new Size(70, 23);
            label8.TabIndex = 85;
            label8.Text = "Minggu";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(25, 246);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 84;
            label5.Text = "Sabtu";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(25, 207);
            label7.Name = "label7";
            label7.Size = new Size(57, 23);
            label7.TabIndex = 83;
            label7.Text = "Jumat";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(25, 168);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 82;
            label2.Text = "Kamis";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(25, 129);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 81;
            label4.Text = "Rabu";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 90);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 80;
            label1.Text = "Selasa";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 51);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 79;
            label3.Text = "Senin";
            // 
            // LabelJudul
            // 
            LabelJudul.AutoSize = true;
            LabelJudul.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            LabelJudul.ForeColor = Color.Black;
            LabelJudul.Location = new Point(188, 38);
            LabelJudul.Name = "LabelJudul";
            LabelJudul.Size = new Size(114, 31);
            LabelJudul.TabIndex = 71;
            LabelJudul.Text = "Jam Kerja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(107, 69);
            label6.Name = "label6";
            label6.Size = new Size(279, 23);
            label6.TabIndex = 72;
            label6.Text = "*Informasi jam operasional bengkel";
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonSimpan.BackColor = Color.ForestGreen;
            ButtonSimpan.BackgroundColor = Color.ForestGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(339, 471);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(130, 40);
            ButtonSimpan.TabIndex = 3;
            ButtonSimpan.Text = "✅ Simpan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
            // 
            // ButtonBatal
            // 
            ButtonBatal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonBatal.BackColor = Color.Red;
            ButtonBatal.BackgroundColor = Color.Red;
            ButtonBatal.BorderColor = Color.DarkGray;
            ButtonBatal.BorderRadius = 5;
            ButtonBatal.BorderSize = 0;
            ButtonBatal.FlatAppearance.BorderSize = 0;
            ButtonBatal.FlatStyle = FlatStyle.Flat;
            ButtonBatal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBatal.ForeColor = Color.White;
            ButtonBatal.Location = new Point(186, 471);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(130, 40);
            ButtonBatal.TabIndex = 4;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // JamKerjaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(515, 557);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "JamKerjaForm";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
        private Label LabelJudul;
        private Label label3;
        private Label label6;
        private Panel panel2;
        private Label label8;
        private Label label5;
        private Label label7;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Panel panel3;
        private Syncfusion.WinForms.Input.SfDateTimeEdit SeninBuka;
        private Syncfusion.WinForms.Input.SfDateTimeEdit MingguTutup;
        private Syncfusion.WinForms.Input.SfDateTimeEdit MingguBuka;
        private Syncfusion.WinForms.Input.SfDateTimeEdit SabtuTutup;
        private Syncfusion.WinForms.Input.SfDateTimeEdit SabtuBuka;
        private Syncfusion.WinForms.Input.SfDateTimeEdit JumatTutup;
        private Syncfusion.WinForms.Input.SfDateTimeEdit JumatBuka;
        private Syncfusion.WinForms.Input.SfDateTimeEdit KamisTutup;
        private Syncfusion.WinForms.Input.SfDateTimeEdit KamisBuka;
        private Syncfusion.WinForms.Input.SfDateTimeEdit RabuTutup;
        private Syncfusion.WinForms.Input.SfDateTimeEdit RabuBuka;
        private Syncfusion.WinForms.Input.SfDateTimeEdit SelasaTutup;
        private Syncfusion.WinForms.Input.SfDateTimeEdit SelasaBuka;
        private Syncfusion.WinForms.Input.SfDateTimeEdit SeninTutup;
    }
}