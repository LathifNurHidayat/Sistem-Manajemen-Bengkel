namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.DashboardForm
{
    partial class InformasiBackupDatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformasiBackupDatabaseForm));
            ButtonClose = new SMB_CustomTolbox.LathifButton();
            label1 = new Label();
            gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            ButtonRestoreDatabase = new SMB_CustomTolbox.LathifButton();
            ButtonBackupDatabase = new SMB_CustomTolbox.LathifButton();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).BeginInit();
            gradientPanelExt1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonClose
            // 
            ButtonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonClose.BackColor = Color.Red;
            ButtonClose.BackgroundColor = Color.Red;
            ButtonClose.BorderColor = Color.DarkGray;
            ButtonClose.BorderRadius = 5;
            ButtonClose.BorderSize = 0;
            ButtonClose.FlatAppearance.BorderSize = 0;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonClose.ForeColor = Color.White;
            ButtonClose.Location = new Point(879, 388);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(135, 45);
            ButtonClose.TabIndex = 5;
            ButtonClose.Text = "❌ Close";
            ButtonClose.TextColor = Color.White;
            ButtonClose.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(458, 18);
            label1.Name = "label1";
            label1.Size = new Size(136, 45);
            label1.TabIndex = 6;
            label1.Text = "Perhatian";
            // 
            // gradientPanelExt1
            // 
            gradientPanelExt1.BackColor = Color.WhiteSmoke;
            gradientPanelExt1.Border = new Padding(2);
            gradientPanelExt1.BorderGap = 2;
            gradientPanelExt1.BorderStyle = BorderStyle.None;
            gradientPanelExt1.Controls.Add(ButtonRestoreDatabase);
            gradientPanelExt1.Controls.Add(ButtonBackupDatabase);
            gradientPanelExt1.Controls.Add(label2);
            gradientPanelExt1.Controls.Add(label1);
            gradientPanelExt1.CornerRadius = 10;
            gradientPanelExt1.Location = new Point(12, 12);
            gradientPanelExt1.Name = "gradientPanelExt1";
            gradientPanelExt1.Size = new Size(1002, 366);
            gradientPanelExt1.TabIndex = 7;
            // 
            // ButtonRestoreDatabase
            // 
            ButtonRestoreDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonRestoreDatabase.BackColor = Color.LightSlateGray;
            ButtonRestoreDatabase.BackgroundColor = Color.LightSlateGray;
            ButtonRestoreDatabase.BorderColor = Color.DarkGray;
            ButtonRestoreDatabase.BorderRadius = 5;
            ButtonRestoreDatabase.BorderSize = 0;
            ButtonRestoreDatabase.FlatAppearance.BorderSize = 0;
            ButtonRestoreDatabase.FlatStyle = FlatStyle.Flat;
            ButtonRestoreDatabase.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonRestoreDatabase.ForeColor = Color.White;
            ButtonRestoreDatabase.Location = new Point(517, 296);
            ButtonRestoreDatabase.Name = "ButtonRestoreDatabase";
            ButtonRestoreDatabase.Size = new Size(198, 45);
            ButtonRestoreDatabase.TabIndex = 23;
            ButtonRestoreDatabase.Text = "🔄 Restore Database ";
            ButtonRestoreDatabase.TextColor = Color.White;
            ButtonRestoreDatabase.UseVisualStyleBackColor = false;
            // 
            // ButtonBackupDatabase
            // 
            ButtonBackupDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ButtonBackupDatabase.BackColor = Color.Green;
            ButtonBackupDatabase.BackgroundColor = Color.Green;
            ButtonBackupDatabase.BorderColor = Color.DarkGray;
            ButtonBackupDatabase.BorderRadius = 5;
            ButtonBackupDatabase.BorderSize = 0;
            ButtonBackupDatabase.FlatAppearance.BorderSize = 0;
            ButtonBackupDatabase.FlatStyle = FlatStyle.Flat;
            ButtonBackupDatabase.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBackupDatabase.ForeColor = Color.White;
            ButtonBackupDatabase.Location = new Point(289, 296);
            ButtonBackupDatabase.Name = "ButtonBackupDatabase";
            ButtonBackupDatabase.Size = new Size(198, 45);
            ButtonBackupDatabase.TabIndex = 22;
            ButtonBackupDatabase.Text = "☁️ Backup Database";
            ButtonBackupDatabase.TextColor = Color.White;
            ButtonBackupDatabase.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 76);
            label2.Name = "label2";
            label2.Size = new Size(940, 187);
            label2.TabIndex = 7;
            label2.Text = resources.GetString("label2.Text");
            // 
            // InformasiBackupDatabaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1026, 445);
            Controls.Add(gradientPanelExt1);
            Controls.Add(ButtonClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InformasiBackupDatabaseForm";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)gradientPanelExt1).EndInit();
            gradientPanelExt1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SMB_CustomTolbox.LathifButton ButtonClose;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private Label label2;
        private SMB_CustomTolbox.LathifButton ButtonRestoreDatabase;
        private SMB_CustomTolbox.LathifButton ButtonBackupDatabase;
    }
}