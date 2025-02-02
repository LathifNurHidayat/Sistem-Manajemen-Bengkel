﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class InputEditBooking : Form
    {
        public InputEditBooking()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            ButtonSave.Click += ButtonSave_Click;
            ButtonCancel.Click += ButtonCancel_Click;
        }

        private void ButtonCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            
        }
    }
}
