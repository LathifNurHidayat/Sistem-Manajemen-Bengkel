namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm
{
    partial class CropProfilesFormHelper
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
            PanelAntrean = new Panel();
            ButtonSimpan = new SMB_CustomTolbox.LathifButton();
            label2 = new Label();
            label1 = new Label();
            PictureHasil = new PictureBox();
            PictureFotoAwal = new PictureBox();
            ButtonPotong = new SMB_CustomTolbox.LathifButton();
            ButtonPilihFoto = new SMB_CustomTolbox.LathifButton();
            PanelAntrean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureHasil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureFotoAwal).BeginInit();
            SuspendLayout();
            // 
            // PanelAntrean
            // 
            PanelAntrean.BackColor = Color.White;
            PanelAntrean.Controls.Add(ButtonSimpan);
            PanelAntrean.Controls.Add(label2);
            PanelAntrean.Controls.Add(label1);
            PanelAntrean.Controls.Add(PictureHasil);
            PanelAntrean.Controls.Add(PictureFotoAwal);
            PanelAntrean.Controls.Add(ButtonPotong);
            PanelAntrean.Controls.Add(ButtonPilihFoto);
            PanelAntrean.Dock = DockStyle.Fill;
            PanelAntrean.Location = new Point(0, 0);
            PanelAntrean.Name = "PanelAntrean";
            PanelAntrean.Size = new Size(481, 416);
            PanelAntrean.TabIndex = 52;
            // 
            // ButtonSimpan
            // 
            ButtonSimpan.Anchor = AnchorStyles.None;
            ButtonSimpan.BackColor = Color.Green;
            ButtonSimpan.BackgroundColor = Color.Green;
            ButtonSimpan.BorderColor = Color.DarkGray;
            ButtonSimpan.BorderRadius = 5;
            ButtonSimpan.BorderSize = 0;
            ButtonSimpan.FlatAppearance.BorderSize = 0;
            ButtonSimpan.FlatStyle = FlatStyle.Flat;
            ButtonSimpan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSimpan.ForeColor = Color.White;
            ButtonSimpan.Location = new Point(12, 358);
            ButtonSimpan.Name = "ButtonSimpan";
            ButtonSimpan.Size = new Size(457, 46);
            ButtonSimpan.TabIndex = 30;
            ButtonSimpan.Text = "✅ Simpan";
            ButtonSimpan.TextColor = Color.White;
            ButtonSimpan.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(329, 36);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 28;
            label2.Text = "Hasil";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(77, 36);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 27;
            label1.Text = "Foto Awal";
            // 
            // PictureHasil
            // 
            PictureHasil.BorderStyle = BorderStyle.FixedSingle;
            PictureHasil.Location = new Point(255, 67);
            PictureHasil.Name = "PictureHasil";
            PictureHasil.Size = new Size(200, 200);
            PictureHasil.TabIndex = 26;
            PictureHasil.TabStop = false;
            // 
            // PictureFotoAwal
            // 
            PictureFotoAwal.BorderStyle = BorderStyle.FixedSingle;
            PictureFotoAwal.Location = new Point(27, 67);
            PictureFotoAwal.Name = "PictureFotoAwal";
            PictureFotoAwal.Size = new Size(200, 200);
            PictureFotoAwal.TabIndex = 25;
            PictureFotoAwal.TabStop = false;
            // 
            // ButtonPotong
            // 
            ButtonPotong.Anchor = AnchorStyles.None;
            ButtonPotong.BackColor = Color.FromArgb(83, 92, 145);
            ButtonPotong.BackgroundColor = Color.FromArgb(83, 92, 145);
            ButtonPotong.BorderColor = Color.DarkGray;
            ButtonPotong.BorderRadius = 5;
            ButtonPotong.BorderSize = 0;
            ButtonPotong.FlatAppearance.BorderSize = 0;
            ButtonPotong.FlatStyle = FlatStyle.Flat;
            ButtonPotong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonPotong.ForeColor = Color.White;
            ButtonPotong.Location = new Point(290, 282);
            ButtonPotong.Name = "ButtonPotong";
            ButtonPotong.Size = new Size(126, 39);
            ButtonPotong.TabIndex = 24;
            ButtonPotong.Text = "✂ Potong";
            ButtonPotong.TextColor = Color.White;
            ButtonPotong.UseVisualStyleBackColor = false;
            // 
            // ButtonPilihFoto
            // 
            ButtonPilihFoto.Anchor = AnchorStyles.None;
            ButtonPilihFoto.BackColor = Color.BurlyWood;
            ButtonPilihFoto.BackgroundColor = Color.BurlyWood;
            ButtonPilihFoto.BorderColor = Color.DarkGray;
            ButtonPilihFoto.BorderRadius = 5;
            ButtonPilihFoto.BorderSize = 0;
            ButtonPilihFoto.FlatAppearance.BorderSize = 0;
            ButtonPilihFoto.FlatStyle = FlatStyle.Flat;
            ButtonPilihFoto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonPilihFoto.ForeColor = Color.White;
            ButtonPilihFoto.Location = new Point(66, 282);
            ButtonPilihFoto.Name = "ButtonPilihFoto";
            ButtonPilihFoto.Size = new Size(126, 39);
            ButtonPilihFoto.TabIndex = 23;
            ButtonPilihFoto.Text = "📁 Pilih Foto";
            ButtonPilihFoto.TextColor = Color.White;
            ButtonPilihFoto.UseVisualStyleBackColor = false;
            // 
            // CropProfilesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 416);
            Controls.Add(PanelAntrean);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CropProfilesForm";
            StartPosition = FormStartPosition.CenterParent;
            PanelAntrean.ResumeLayout(false);
            PanelAntrean.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureHasil).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureFotoAwal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAntrean;
        private SMB_CustomTolbox.LathifButton ButtonPotong;
        private SMB_CustomTolbox.LathifButton ButtonPilihFoto;
        private PictureBox PictureFotoAwal;
        private Label label2;
        private Label label1;
        private PictureBox PictureHasil;
        private SMB_CustomTolbox.LathifButton ButtonSimpan;
    }
}