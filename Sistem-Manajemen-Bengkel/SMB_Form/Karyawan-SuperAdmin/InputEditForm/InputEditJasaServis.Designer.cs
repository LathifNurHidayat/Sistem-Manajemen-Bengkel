namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.JasaServisForm
{
    partial class InputEditJasaServis
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
            panel3 = new Panel();
            TextPhoneNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            currencyTextBox1 = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            label3 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            ButtonCancel = new SMB_CustomTolbox.LathifButton();
            ButtonSave = new SMB_CustomTolbox.LathifButton();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currencyTextBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TextPhoneNumber);
            panel3.Location = new Point(28, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 40);
            panel3.TabIndex = 13;
            // 
            // TextPhoneNumber
            // 
            TextPhoneNumber.BorderStyle = BorderStyle.None;
            TextPhoneNumber.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPhoneNumber.Location = new Point(8, 8);
            TextPhoneNumber.MaxLength = 15;
            TextPhoneNumber.Name = "TextPhoneNumber";
            TextPhoneNumber.Size = new Size(380, 24);
            TextPhoneNumber.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 31;
            label1.Text = "Jenis Servis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(130, 43);
            label2.Name = "label2";
            label2.Size = new Size(203, 23);
            label2.TabIndex = 32;
            label2.Text = "( Ringan , Sedang, Berat )";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(28, 136);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 34;
            label5.Text = "Biaya";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(currencyTextBox1);
            panel1.Location = new Point(28, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 40);
            panel1.TabIndex = 33;
            // 
            // currencyTextBox1
            // 
            currencyTextBox1.AccessibilityEnabled = true;
            currencyTextBox1.BeforeTouchSize = new Size(380, 24);
            currencyTextBox1.BorderStyle = BorderStyle.None;
            currencyTextBox1.DecimalValue = new decimal(new int[] { 0, 0, 0, 131072 });
            currencyTextBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            currencyTextBox1.Location = new Point(8, 6);
            currencyTextBox1.Name = "currencyTextBox1";
            currencyTextBox1.Size = new Size(380, 24);
            currencyTextBox1.TabIndex = 37;
            currencyTextBox1.Text = "Rp0,00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 231);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 36;
            label3.Text = "Keterangan";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(28, 259);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 187);
            panel2.TabIndex = 35;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(8, 8);
            textBox2.MaxLength = 15;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(380, 170);
            textBox2.TabIndex = 0;
            // 
            // ButtonCancel
            // 
            ButtonCancel.BackColor = Color.Red;
            ButtonCancel.BackgroundColor = Color.Red;
            ButtonCancel.BorderColor = Color.DarkGray;
            ButtonCancel.BorderRadius = 5;
            ButtonCancel.BorderSize = 0;
            ButtonCancel.FlatAppearance.BorderSize = 0;
            ButtonCancel.FlatStyle = FlatStyle.Flat;
            ButtonCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonCancel.ForeColor = Color.White;
            ButtonCancel.Location = new Point(123, 488);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(135, 45);
            ButtonCancel.TabIndex = 38;
            ButtonCancel.Text = "❌ Cancel";
            ButtonCancel.TextColor = Color.White;
            ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.LimeGreen;
            ButtonSave.BackgroundColor = Color.LimeGreen;
            ButtonSave.BorderColor = Color.DarkGray;
            ButtonSave.BorderRadius = 5;
            ButtonSave.BorderSize = 0;
            ButtonSave.FlatAppearance.BorderSize = 0;
            ButtonSave.FlatStyle = FlatStyle.Flat;
            ButtonSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Location = new Point(292, 488);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(135, 45);
            ButtonSave.TabIndex = 37;
            ButtonSave.Text = "✅ Save";
            ButtonSave.TextColor = Color.White;
            ButtonSave.UseVisualStyleBackColor = false;
            // 
            // InputEditJasaServis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(460, 566);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InputEditJasaServis";
            StartPosition = FormStartPosition.CenterScreen;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)currencyTextBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private TextBox TextPhoneNumber;
        private Label label1;
        private Label label2;
        private Label label5;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox currencyTextBox1;
        private Label label3;
        private Panel panel2;
        private TextBox textBox2;
        private SMB_CustomTolbox.LathifButton ButtonCancel;
        private SMB_CustomTolbox.LathifButton ButtonSave;
    }
}