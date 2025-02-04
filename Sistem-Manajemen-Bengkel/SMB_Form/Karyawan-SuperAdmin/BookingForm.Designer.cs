namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    partial class BookingForm
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
            panel1 = new Panel();
            textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            label7 = new Label();
            ButtonTambah = new SMB_CustomTolbox.LathifButton();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBoxExt1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(ButtonTambah);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 679);
            panel1.TabIndex = 15;
            // 
            // textBoxExt1
            // 
            textBoxExt1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxExt1.BeforeTouchSize = new Size(362, 34);
            textBoxExt1.Border3DStyle = Border3DStyle.Bump;
            textBoxExt1.BorderColor = Color.DimGray;
            textBoxExt1.BorderStyle = BorderStyle.FixedSingle;
            textBoxExt1.FocusBorderColor = Color.Black;
            textBoxExt1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxExt1.Location = new Point(683, 151);
            textBoxExt1.Name = "textBoxExt1";
            textBoxExt1.PlaceholderText = "🔍   Search";
            textBoxExt1.Size = new Size(362, 34);
            textBoxExt1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 35);
            label7.Name = "label7";
            label7.Size = new Size(183, 42);
            label7.TabIndex = 24;
            label7.Text = "📆  Booking";
            // 
            // ButtonTambah
            // 
            ButtonTambah.BackColor = Color.MediumSlateBlue;
            ButtonTambah.BackgroundColor = Color.MediumSlateBlue;
            ButtonTambah.BorderColor = Color.DarkGray;
            ButtonTambah.BorderRadius = 5;
            ButtonTambah.BorderSize = 0;
            ButtonTambah.FlatAppearance.BorderSize = 0;
            ButtonTambah.FlatStyle = FlatStyle.Flat;
            ButtonTambah.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonTambah.ForeColor = Color.White;
            ButtonTambah.Location = new Point(32, 140);
            ButtonTambah.Name = "ButtonTambah";
            ButtonTambah.Size = new Size(135, 45);
            ButtonTambah.TabIndex = 23;
            ButtonTambah.Text = "➕ Tambah ";
            ButtonTambah.TextColor = Color.White;
            ButtonTambah.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1019, 437);
            dataGridView1.TabIndex = 26;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(221, 230, 237);
            ClientSize = new Size(1082, 703);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "BookingForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxExt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Label label7;
        private SMB_CustomTolbox.LathifButton ButtonTambah;
        private DataGridView dataGridView1;
    }
}