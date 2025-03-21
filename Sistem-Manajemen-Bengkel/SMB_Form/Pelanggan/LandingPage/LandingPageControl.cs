﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.LoginRegisterForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Booking;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.LandingPage
{
    public partial class LandingPageControl : UserControl
    {
        private bool _isLogin = false;
        public LandingPageControl(bool isLogin)
        {
            InitializeComponent();
            _isLogin = isLogin;

            RegisterControlEvent();
        }


        private void RegisterControlEvent()
        {
            ButtonBookingSekarang.Click += ButtonBookingSekarang_Click;
        }

        private void ButtonBookingSekarang_Click(object? sender, EventArgs e)
        {
            if (_isLogin == false)
            {
                if (MesboxHelper.ShowConfirm("Mohon Maaf \nAnda harus login terlebih dahulu"))
                {
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                return;
            }
            else
            {
               MainMenuFirst.ShowUserControlInPanel(new PilihBookingControl());
            }
        }

    }
}
