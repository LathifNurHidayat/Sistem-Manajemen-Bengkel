using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.SparepartForm
{
    partial class InputSparepartForm
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
            panel1 = new Panel();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            ButtonBatal = new SMB_CustomTolbox.LathifButton();
            panel3 = new Panel();
            label7 = new Label();
            panel11 = new Panel();
            TextStokMinimal = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            PictureSparepart = new PictureBox();
            label4 = new Label();
            panel7 = new Panel();
            TextStok = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ButtonPilihFile = new SMB_CustomTolbox.LathifButton();
            label2 = new Label();
            label10 = new Label();
            panel5 = new Panel();
            TextNamaSparepart = new TextBox();
            panel2 = new Panel();
            TextHarga = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextStokMinimal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureSparepart).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextStok).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TextHarga).BeginInit();
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
            panel1.Size = new Size(463, 789);
            panel1.TabIndex = 0;
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
            ButtonSimpan.Location = new Point(312, 723);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(135, 45);
            ButtonSimpan.TabIndex = 6;
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
            ButtonBatal.Location = new Point(149, 723);
            ButtonBatal.Name = "ButtonBatal";
            ButtonBatal.Size = new Size(135, 45);
            ButtonBatal.TabIndex = 7;
            ButtonBatal.Text = "❌ Batal";
            ButtonBatal.TextColor = Color.White;
            ButtonBatal.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(PictureSparepart);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(ButtonPilihFile);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(15, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 690);
            panel3.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(21, 596);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 39;
            label7.Text = "Stok Minimal";
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(TextStokMinimal);
            panel11.Location = new Point(21, 622);
            panel11.Name = "panel11";
            panel11.Size = new Size(386, 41);
            panel11.TabIndex = 5;
            // 
            // TextStokMinimal
            // 
            TextStokMinimal.AccessibilityEnabled = true;
            TextStokMinimal.BeforeTouchSize = new Size(60, 24);
            TextStokMinimal.BorderStyle = BorderStyle.None;
            TextStokMinimal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextStokMinimal.ForeColor = SystemColors.WindowText;
            TextStokMinimal.IntegerValue = 0L;
            TextStokMinimal.Location = new Point(6, 8);
            TextStokMinimal.MaxValue = 9876543210L;
            TextStokMinimal.MinValue = 0L;
            TextStokMinimal.Name = "TextStokMinimal";
            TextStokMinimal.Size = new Size(375, 24);
            TextStokMinimal.TabIndex = 5;
            // 
            // PictureSparepart
            // 
            PictureSparepart.BackColor = Color.White;
            PictureSparepart.BorderStyle = BorderStyle.FixedSingle;
            PictureSparepart.Location = new Point(117, 29);
            PictureSparepart.Name = "PictureSparepart";
            PictureSparepart.Size = new Size(200, 200);
            PictureSparepart.SizeMode = PictureBoxSizeMode.Zoom;
            PictureSparepart.TabIndex = 1;
            PictureSparepart.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 499);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 37;
            label4.Text = "Stok";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(TextStok);
            panel7.Location = new Point(21, 525);
            panel7.Name = "panel7";
            panel7.Size = new Size(386, 41);
            panel7.TabIndex = 4;
            // 
            // TextStok
            // 
            TextStok.AccessibilityEnabled = true;
            TextStok.BeforeTouchSize = new Size(60, 24);
            TextStok.BorderStyle = BorderStyle.None;
            TextStok.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextStok.ForeColor = SystemColors.WindowText;
            TextStok.IntegerValue = 0L;
            TextStok.Location = new Point(6, 7);
            TextStok.MaxValue = 9876543210L;
            TextStok.MinValue = 0L;
            TextStok.Name = "TextStok";
            TextStok.Size = new Size(375, 24);
            TextStok.TabIndex = 40;
            // 
            // ButtonPilihFile
            // 
            ButtonPilihFile.Anchor = AnchorStyles.None;
            ButtonPilihFile.BackColor = Color.Goldenrod;
            ButtonPilihFile.BackgroundColor = Color.Goldenrod;
            ButtonPilihFile.BorderColor = Color.DarkGray;
            ButtonPilihFile.BorderRadius = 5;
            ButtonPilihFile.BorderSize = 1;
            ButtonPilihFile.FlatAppearance.BorderSize = 0;
            ButtonPilihFile.FlatStyle = FlatStyle.Flat;
            ButtonPilihFile.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonPilihFile.ForeColor = Color.White;
            ButtonPilihFile.Location = new Point(117, 235);
            ButtonPilihFile.Name = "ButtonPilihFile";
            ButtonPilihFile.Size = new Size(200, 37);
            ButtonPilihFile.TabIndex = 1;
            ButtonPilihFile.Text = "📁 Pilih";
            ButtonPilihFile.TextColor = Color.White;
            ButtonPilihFile.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 402);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 31;
            label2.Text = "Harga";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 303);
            label10.Name = "label10";
            label10.Size = new Size(135, 23);
            label10.TabIndex = 30;
            label10.Text = "Nama Sparepart";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(TextNamaSparepart);
            panel5.Location = new Point(21, 331);
            panel5.Name = "panel5";
            panel5.Size = new Size(386, 41);
            panel5.TabIndex = 2;
            // 
            // TextNamaSparepart
            // 
            TextNamaSparepart.BorderStyle = BorderStyle.None;
            TextNamaSparepart.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextNamaSparepart.Location = new Point(6, 7);
            TextNamaSparepart.MaxLength = 50;
            TextNamaSparepart.Name = "TextNamaSparepart";
            TextNamaSparepart.Size = new Size(375, 24);
            TextNamaSparepart.TabIndex = 1;
            TextNamaSparepart.Tag = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextHarga);
            panel2.Location = new Point(21, 428);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 41);
            panel2.TabIndex = 3;
            // 
            // TextHarga
            // 
            TextHarga.AccessibilityEnabled = true;
            TextHarga.BeforeTouchSize = new Size(60, 24);
            TextHarga.BorderStyle = BorderStyle.None;
            TextHarga.DecimalValue = new decimal(new int[] { 0, 0, 0, 131072 });
            TextHarga.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextHarga.Location = new Point(6, 7);
            TextHarga.Name = "TextHarga";
            TextHarga.Size = new Size(375, 24);
            TextHarga.TabIndex = 40;
            TextHarga.Text = "Rp0,00";
            // 
            // InputSparepartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(487, 813);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "InputSparepartForm";
            StartPosition = FormStartPosition.CenterParent;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TextStokMinimal).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureSparepart).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TextStok).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TextHarga).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
        private SMB_CustomTolbox.LathifButton ButtonBatal;
        private Label label2;
        private Label label10;
        private Panel panel5;
        private TextBox TextNamaSparepart;
        private Panel panel2;
        private TextBox TextNamaLengkap;
        private Label LabelPassword;
        private Label LabelConfirmPass;
        private Label label9;
        private Panel panel8;
        private TextBox TextConfirmPassword;
        private Label LabelEmail;
        private Label label6;
        private Label label5;
        private Panel panel9;
        private TextBox TextPassword;
        private Panel panel10;
        private TextBox TextEmail;
        private Label label3;
        private MaterialSkin.Controls.MaterialRadioButton RadioKaryawan;
        private MaterialSkin.Controls.MaterialRadioButton RadioSuperAdmin;
        private Label label1;
        private Panel panel6;
        private TextBox TextNoHP;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private SMB_CustomTolbox.LathifButton ButtonPilihFile;
        private Label LabelNoHP;
        private Label label4;
        private Panel panel7;
        private TextBox TextAlamat;
        private LinkLabel LinkReset;
        private Label LabelResetPass;
        private PictureBox PictureSparepart;
        private Label label7;
        private Panel panel11;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextHarga;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox TextStokMinimal;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox TextStok;
    }
}