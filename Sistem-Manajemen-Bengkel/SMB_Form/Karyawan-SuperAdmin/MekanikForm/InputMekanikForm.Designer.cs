namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    partial class InputMekanikForm
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
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            TextSpesialis = new TextBox();
            label4 = new Label();
            LabelNoHP = new Label();
            panel7 = new Panel();
            TextAlamat = new TextBox();
            label1 = new Label();
            panel6 = new Panel();
            TextNoHP = new TextBox();
            LabelNIK = new Label();
            label10 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            TextNamaLengkap = new TextBox();
            panel5 = new Panel();
            TextNoKTP = new TextBox();
            PictureProfiles = new SMB_CustomTolbox.RJCircularPictureBox();
            ButtonEditProfiles = new SMB_CustomTolbox.LathifButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProfiles).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ButtonSimpan);
            panel1.Controls.Add(ButtonBatal);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 814);
            panel1.TabIndex = 0;
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonSimpan.BackColor = Color.ForestGreen;
            ButtonSimpan.BackgroundColor = Color.ForestGreen;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(427, 749);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(135, 45);
            ButtonSimpan.TabIndex = 2;
            ButtonSimpan.Text = "✅ Simpan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
            // 
            // ButtonBatal
            // 
            ButtonBatal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonBatal.BackColor = Color.Red;
            ButtonBatal.BackgroundColor = Color.Red;
            ButtonBatal.BorderColor = Color.DarkGray;
            ButtonBatal.BorderRadius = 5;
            ButtonBatal.BorderSize = 0;
            ButtonBatal.FlatAppearance.BorderSize = 0;
            ButtonBatal.FlatStyle = FlatStyle.Flat;
            ButtonBatal.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBatal.ForeColor = Color.White;
            ButtonBatal.Location = new Point(274, 749);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(135, 45);
            ButtonBatal.TabIndex = 3;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(LabelNoHP);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(LabelNIK);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(PictureProfiles);
            panel3.Controls.Add(ButtonEditProfiles);
            panel3.Location = new Point(23, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(539, 704);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 562);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 69;
            label3.Text = "Spesialis";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(TextSpesialis);
            panel4.Location = new Point(28, 589);
            panel4.Name = "panel4";
            panel4.Size = new Size(482, 83);
            panel4.TabIndex = 6;
            // 
            // TextSpesialis
            // 
            TextSpesialis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextSpesialis.BorderStyle = BorderStyle.None;
            TextSpesialis.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextSpesialis.Location = new Point(4, 4);
            TextSpesialis.MaxLength = 100;
            TextSpesialis.Multiline = true;
            TextSpesialis.Name = "TextSpesialis";
            TextSpesialis.Size = new Size(471, 70);
            TextSpesialis.TabIndex = 1;
            TextSpesialis.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 475);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 67;
            label4.Text = "Alamat";
            // 
            // LabelNoHP
            // 
            LabelNoHP.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNoHP.ForeColor = Color.Red;
            LabelNoHP.Location = new Point(206, 389);
            LabelNoHP.Name = "LabelNoHP";
            LabelNoHP.Size = new Size(305, 23);
            LabelNoHP.TabIndex = 66;
            LabelNoHP.Tag = "NoHP";
            LabelNoHP.Text = "⚠ No. HP sudah terdaftar";
            LabelNoHP.TextAlign = ContentAlignment.MiddleRight;
            LabelNoHP.Visible = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextAlamat);
            panel7.Location = new Point(29, 502);
            panel7.Name = "panel7";
            panel7.Size = new Size(482, 41);
            panel7.TabIndex = 5;
            // 
            // TextAlamat
            // 
            TextAlamat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextAlamat.BorderStyle = BorderStyle.None;
            TextAlamat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextAlamat.Location = new Point(6, 7);
            TextAlamat.MaxLength = 100;
            TextAlamat.Name = "TextAlamat";
            TextAlamat.Size = new Size(471, 24);
            TextAlamat.TabIndex = 1;
            TextAlamat.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 388);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 65;
            label1.Text = "No. HP";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(TextNoHP);
            panel6.Location = new Point(29, 415);
            panel6.Name = "panel6";
            panel6.Size = new Size(482, 41);
            panel6.TabIndex = 4;
            // 
            // TextNoHP
            // 
            TextNoHP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextNoHP.BorderStyle = BorderStyle.None;
            TextNoHP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNoHP.Location = new Point(6, 7);
            TextNoHP.MaxLength = 13;
            TextNoHP.Name = "TextNoHP";
            TextNoHP.Size = new Size(471, 24);
            TextNoHP.TabIndex = 1;
            TextNoHP.Tag = "NoHP";
            // 
            // LabelNIK
            // 
            LabelNIK.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNIK.ForeColor = Color.Red;
            LabelNIK.Location = new Point(206, 215);
            LabelNIK.Name = "LabelNIK";
            LabelNIK.Size = new Size(305, 23);
            LabelNIK.TabIndex = 63;
            LabelNIK.Tag = "NIK";
            LabelNIK.Text = "⚠ No. KTP sudah terdaftar";
            LabelNIK.TextAlign = ContentAlignment.MiddleRight;
            LabelNIK.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(29, 214);
            label10.Name = "label10";
            label10.Size = new Size(71, 23);
            label10.TabIndex = 61;
            label10.Text = "No. KTP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 301);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 62;
            label2.Text = "Nama Lengkap";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextNamaLengkap);
            panel2.Location = new Point(29, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 41);
            panel2.TabIndex = 3;
            // 
            // TextNamaLengkap
            // 
            TextNamaLengkap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextNamaLengkap.BorderStyle = BorderStyle.None;
            TextNamaLengkap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNamaLengkap.Location = new Point(6, 7);
            TextNamaLengkap.MaxLength = 50;
            TextNamaLengkap.Name = "TextNamaLengkap";
            TextNamaLengkap.Size = new Size(471, 24);
            TextNamaLengkap.TabIndex = 1;
            TextNamaLengkap.Tag = "";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TextNoKTP);
            panel5.Location = new Point(29, 241);
            panel5.Name = "panel5";
            panel5.Size = new Size(482, 41);
            panel5.TabIndex = 2;
            // 
            // TextNoKTP
            // 
            TextNoKTP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextNoKTP.BorderStyle = BorderStyle.None;
            TextNoKTP.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNoKTP.Location = new Point(6, 7);
            TextNoKTP.MaxLength = 16;
            TextNoKTP.Name = "TextNoKTP";
            TextNoKTP.Size = new Size(471, 24);
            TextNoKTP.TabIndex = 1;
            TextNoKTP.Tag = "NIK";
            // 
            // PictureProfiles
            // 
            PictureProfiles.BackgroundImageLayout = ImageLayout.Stretch;
            PictureProfiles.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            PictureProfiles.BorderColor = Color.FromArgb(83, 92, 145);
            PictureProfiles.BorderColor2 = Color.FromArgb(83, 92, 145);
            PictureProfiles.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            PictureProfiles.BorderSize = 2;
            PictureProfiles.GradientAngle = 50F;
            PictureProfiles.Image = Properties.Resources.mechanic;
            PictureProfiles.Location = new Point(201, 10);
            PictureProfiles.Name = "PictureProfiles";
            PictureProfiles.Size = new Size(134, 134);
            PictureProfiles.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureProfiles.TabIndex = 38;
            PictureProfiles.TabStop = false;
            // 
            // ButtonEditProfiles
            // 
            ButtonEditProfiles.Anchor = AnchorStyles.None;
            ButtonEditProfiles.BackColor = Color.FromArgb(83, 92, 145);
            ButtonEditProfiles.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonEditProfiles.BorderColor = Color.DarkGray;
            ButtonEditProfiles.BorderRadius = 5;
            ButtonEditProfiles.BorderSize = 0;
            ButtonEditProfiles.FlatAppearance.BorderSize = 0;
            ButtonEditProfiles.FlatStyle = FlatStyle.Flat;
            ButtonEditProfiles.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonEditProfiles.ForeColor = Color.White;
            ButtonEditProfiles.Location = new Point(215, 151);
            ButtonEditProfiles.Name = "ButtonEditProfiles";
            ButtonEditProfiles.Size = new Size(107, 37);
            ButtonEditProfiles.TabIndex = 1;
            ButtonEditProfiles.Text = "🖍 Edit";
            ButtonEditProfiles.TextColor = Color.White;
            ButtonEditProfiles.UseVisualStyleBackColor = false;
            // 
            // InputMekanikForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(610, 838);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InputMekanikForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureProfiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private SMB_CustomTolbox.LathifButton ButtonEditProfiles;
        private SMB_CustomTolbox.RJCircularPictureBox PictureProfiles;
        private Label label4;
        private Label LabelNoHP;
        private Panel panel7;
        private TextBox TextAlamat;
        private Label label1;
        private Panel panel6;
        private TextBox TextNoHP;
        private Label LabelNIK;
        private Label label10;
        private Label label2;
        private Panel panel2;
        private TextBox TextNamaLengkap;
        private Panel panel5;
        private TextBox TextNoKTP;
        private Label label3;
        private Panel panel4;
        private TextBox TextSpesialis;
    }
}