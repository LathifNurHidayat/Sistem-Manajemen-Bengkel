using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.StartupForm
{
    public partial class StartupForm : Form
    {
        private System.Windows.Forms.Timer _opacityTimer;
        private System.Windows.Forms.Timer _delayTimer;

        public StartupForm()
        {
            InitializeComponent();
            SetupFormHelper.SetupForm(this);

            this.Opacity = 0;
            this._opacityTimer = new System.Windows.Forms.Timer();
            this._delayTimer = new System.Windows.Forms.Timer();

            this.Load += LoadForm_Load;
            this._opacityTimer.Interval = 10;
            this._opacityTimer.Tick += _opacityTimer_Tick;
            this._delayTimer.Interval = 2000;
            this._delayTimer.Tick += _delayTimer_Tick;
        }

        private void LoadForm_Load(object? sender, EventArgs e)
        {
            this._opacityTimer.Start();
        }

        private void _opacityTimer_Tick(object? sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                this._opacityTimer.Stop();
                this._delayTimer.Start();
            }
        }

        private void _delayTimer_Tick(object? sender, EventArgs e)
        {
            this._delayTimer.Stop();
            MainMenuFirst mainForm = new MainMenuFirst();
            mainForm.WindowState = FormWindowState.Maximized;
            mainForm.Show();
            this.Hide();
        }
    }
}