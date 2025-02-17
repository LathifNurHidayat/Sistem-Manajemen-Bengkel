using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistem_Manajemen_Bengkel.SMB_Helper
{
    public partial class NontifikasiFormHelper : Form
    {
        private System.Windows.Forms.Timer fadeInTimer;
        private System.Windows.Forms.Timer fadeOutTimer;

        public NontifikasiFormHelper(string pesan)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.ShowInTaskbar = false;
            this.Opacity = 0;
            this.StartPosition = FormStartPosition.Manual;

            label1.Text = pesan;
            this.TransparencyKey = Color.Black;

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            this.Location = new Point(screenWidth - this.Width - 38, 70);

            fadeInTimer = new System.Windows.Forms.Timer();
            fadeInTimer.Interval = 1; 
            fadeInTimer.Tick += FadeIn;
            fadeInTimer.Start();


            fadeOutTimer = new System.Windows.Forms.Timer();
            fadeOutTimer.Interval = 1;
            fadeOutTimer.Tick += FadeOut;

            System.Windows.Forms.Timer waitTimer = new System.Windows.Forms.Timer();
            waitTimer.Interval = 1500; 
            waitTimer.Tick += (s, e) =>
            {
                waitTimer.Stop();
                fadeOutTimer.Start();
            };
            waitTimer.Start();
        }

        private void FadeIn(object? sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.15;
            else
                fadeInTimer.Stop();
        }

        private void FadeOut(object? sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity -= 0.15;
            else
            {
                fadeOutTimer.Stop();
                this.Close();
            }
        }
    }
}
