using Sistem_Manajemen_Bengkel.SMB_CustomTolbox;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking
{
    partial class PilihBookingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihBookingControl));
            ButtonBookingServis = new LathifButton();
            ButtonDataBooking = new LathifButton();
            SuspendLayout();
            // 
            // ButtonBookingServis
            // 
            ButtonBookingServis.Anchor = AnchorStyles.None;
            ButtonBookingServis.BackColor = Color.Goldenrod;
            ButtonBookingServis.BackgroundColor = Color.Goldenrod;
            ButtonBookingServis.BorderColor = Color.PaleVioletRed;
            ButtonBookingServis.BorderRadius = 15;
            ButtonBookingServis.BorderSize = 0;
            ButtonBookingServis.FlatAppearance.BorderSize = 0;
            ButtonBookingServis.FlatStyle = FlatStyle.Flat;
            ButtonBookingServis.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonBookingServis.ForeColor = Color.White;
            ButtonBookingServis.Image = (Image)resources.GetObject("ButtonBookingServis.Image");
            ButtonBookingServis.ImageAlign = ContentAlignment.BottomCenter;
            ButtonBookingServis.Location = new Point(288, 363);
            ButtonBookingServis.Margin = new Padding(3, 4, 3, 4);
            ButtonBookingServis.Name = "ButtonBookingServis";
            ButtonBookingServis.Size = new Size(445, 332);
            ButtonBookingServis.TabIndex = 0;
            ButtonBookingServis.Text = "Booking Servis";
            ButtonBookingServis.TextColor = Color.White;
            ButtonBookingServis.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonBookingServis.UseVisualStyleBackColor = false;
            // 
            // ButtonDataBooking
            // 
            ButtonDataBooking.Anchor = AnchorStyles.None;
            ButtonDataBooking.BackColor = Color.SlateGray;
            ButtonDataBooking.BackgroundColor = Color.SlateGray;
            ButtonDataBooking.BorderColor = Color.PaleVioletRed;
            ButtonDataBooking.BorderRadius = 15;
            ButtonDataBooking.BorderSize = 0;
            ButtonDataBooking.FlatAppearance.BorderSize = 0;
            ButtonDataBooking.FlatStyle = FlatStyle.Flat;
            ButtonDataBooking.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonDataBooking.ForeColor = Color.White;
            ButtonDataBooking.Image = (Image)resources.GetObject("ButtonDataBooking.Image");
            ButtonDataBooking.ImageAlign = ContentAlignment.BottomCenter;
            ButtonDataBooking.Location = new Point(860, 372);
            ButtonDataBooking.Margin = new Padding(3, 4, 3, 4);
            ButtonDataBooking.Name = "ButtonDataBooking";
            ButtonDataBooking.Size = new Size(445, 332);
            ButtonDataBooking.TabIndex = 1;
            ButtonDataBooking.Text = "Data Booking";
            ButtonDataBooking.TextColor = Color.White;
            ButtonDataBooking.TextImageRelation = TextImageRelation.ImageAboveText;
            ButtonDataBooking.UseVisualStyleBackColor = false;
            // 
            // PilihBookingControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonDataBooking);
            Controls.Add(ButtonBookingServis);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PilihBookingControl";
            Size = new Size(1640, 1083);
            ResumeLayout(false);
        }

        #endregion

        private LathifButton ButtonBookingServis;
        private LathifButton ButtonDataBooking;
    }
}
