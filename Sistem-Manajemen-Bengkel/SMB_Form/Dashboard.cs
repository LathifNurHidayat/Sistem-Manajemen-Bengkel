using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm;
using Sistem_Manajemen_Bengkel.SMB_Form.KaryawanForm;
using Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            RegisterControlEvent();

            
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

        private void ShowFormInPanel(Form form)
        {
            if (PanelMain.Controls.Count > 0)
                PanelMain.Controls.RemoveAt(0);

            if (form == null) return;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            PanelMain.Tag = form;

            PanelMain.Controls.Add(form);
            form.Show();
        }

        private void RegisterControlEvent()
        {
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

        private void ButtonLogout_Click(object? sender, EventArgs e)
        {

        }

        private void ButtonLaporan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormInPanel(new LaporanForm());
        }

        private void ButtonSparepart_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormInPanel(new SparepartForm());

        }

        private void ButtonKaryawan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormInPanel(new SuperAdminForm.KaryawanForm());
        }

        private void ButtonKendaraan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormInPanel(new KendaraanForm());
        }

        private void ButtonPelanggan_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormInPanel(new PelangganForm());
        }

        private void ButtonRiwayat_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormInPanel(new RiwayatForm());
        }

        private void ButtonServis_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormInPanel(new ServisForm());
        }

        private void ButtonBooking_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormInPanel(new BookingForm());
        }

        private void ButtonDashboard_Click(object? sender, EventArgs e)
        {
            StyleButton(sender as Button);
            ShowFormInPanel(new MenuDashboardAdminForm());

        }
    }
}