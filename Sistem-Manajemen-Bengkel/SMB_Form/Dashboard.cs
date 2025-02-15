﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm;
using Sistem_Manajemen_Bengkel.SMB_Form.KaryawanForm;
using Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form
{
    public partial class Dashboard : Form
    {
        private Form _mainForm;
        private long _id;
        private string _username;
        private string _role;

        public Dashboard(/*long id, string username, string role*/)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            /*       _id = id;
                 LabelUsername.Text = username;
                  LabelRole.Text = role;*/
            CekRole();

            RegisterControlEvent();
            ShowFormHelper.SetPanel(PanelMain);
        }

        private void CekRole()
        {
            if (_role == "Super Admin")
            {
                ButtonKaryawan.Visible = true;
                ButtonLaporan.Visible = true;
            }
            else
            {
                ButtonKaryawan.Visible = false;
                ButtonLaporan.Visible = false;
            }
        }

        private void StyleButton(Button button)
        {
            List<Button> menu = new List<Button>()
            {
                ButtonDashboard, ButtonBooking, ButtonServis, ButtonRiwayat, ButtonPelanggan,
                ButtonKendaraan, ButtonKaryawan, ButtonSparepart, ButtonLaporan, ButtonLogout
            };

            foreach (Button coloringButton in menu)
            {
                if (coloringButton == button)
                {
                    coloringButton.ForeColor = Color.Black;
                    coloringButton.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    coloringButton.ForeColor = Color.Gray;
                    coloringButton.BackColor = Color.Transparent;
                }
            }
        }

      

        private void RegisterControlEvent()
        {
            this.FormClosed += Dashboard_FormClosed;
            this.Load += Dashboard_Load;
            ButtonDashboard.Click += ButtonDashboard_Click;
            ButtonBooking.Click += ButtonBooking_Click;
            ButtonServis.Click += ButtonServis_Click;
            ButtonRiwayat.Click += ButtonRiwayat_Click;
            ButtonPelanggan.Click += ButtonPelanggan_Click;
            ButtonKendaraan.Click += ButtonKendaraan_Click;
            ButtonKaryawan.Click += ButtonKaryawan_Click;
            ButtonSparepart.Click += ButtonSparepart_Click;
            ButtonLaporan.Click += ButtonLaporan_Click;
            ButtonLogout.Click += ButtonLogout_Click;

        }

        private void Dashboard_Load(object? sender, EventArgs e)
        {
            ButtonDashboard.PerformClick();
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void ButtonLogout_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormHelper.ShowFormInPanel(new InvoiceForm());
        }

        private void ButtonLaporan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormHelper.ShowFormInPanel(new LaporanForm());
        }

        private void ButtonSparepart_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormHelper.ShowFormInPanel(new SparepartForm());

        }

        private void ButtonKaryawan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormHelper.ShowFormInPanel(new SuperAdminForm.PegawaiForm());
        }

        private void ButtonKendaraan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormHelper.ShowFormInPanel(new KendaraanForm());
        }

        private void ButtonPelanggan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormHelper.ShowFormInPanel(new PelangganForm());
        }

        private void ButtonRiwayat_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormHelper.ShowFormInPanel(new RiwayatForm());
        }

        private void ButtonServis_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormHelper.ShowFormInPanel(new JasaServisForm());
        }

        private void ButtonBooking_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormHelper.ShowFormInPanel(new BookingForm());
        }

        private void ButtonDashboard_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            if (_role == "Super Admin")
                ShowFormHelper.ShowFormInPanel(new MenuDashboardAdminForm());
            else if (_role == "Karyawan")
                ShowFormHelper.ShowFormInPanel(new MenuDashboardKaryawanForm());
        }
    }
}