﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class PilihForm : Form
    {

        public PilihForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            ButtonPelanggan.Click += ButtonPelanggan_Click;
            ButtonTamu.Click += ButtonTamu_Click;
        }

        private void ButtonTamu_Click(object? sender, EventArgs e)
        {
            TamuBookingForm tamu = new TamuBookingForm();
            if (tamu.ShowDialog()== DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ButtonPelanggan_Click(object? sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new PelangganBookingForm());
            this.Close();
        }
    }
}