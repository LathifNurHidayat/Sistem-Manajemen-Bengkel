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

namespace Sistem_Manajemen_Bengkel.SMB_Form.KaryawanForm
{
    public partial class MenuDashboardKaryawanForm : Form
    {
        public MenuDashboardKaryawanForm()
        {
            InitializeComponent();
            RegisterControlEvent();

        }

        private void RegisterControlEvent()
        {
            PanelBackground.Resize += PanelBackground_Resize;
        }

        private void PanelBackground_Resize(object? sender, EventArgs e)
        {
            int childPanelWidth = (PanelBackground.Width - 60) / 3;

            PanelPelanggan.Width = childPanelWidth;
            PanelAntrean.Width = childPanelWidth;
            PanelService.Width = childPanelWidth;

            PanelPelanggan.Location = new Point(15, PanelPelanggan.Location.Y);
            CustomPanel(PanelPelanggan);
            TextTotalPelanggan.Location = new Point((PanelPelanggan.Width - TextTotalPelanggan.Width) / 2, TextTotalPelanggan.Location.Y);

            PanelAntrean.Location = new Point(childPanelWidth + 30, PanelAntrean.Location.Y);
            CustomPanel(PanelAntrean);
            TextTotalBooking.Location = new Point((PanelAntrean.Width - TextTotalBooking.Width) / 2, TextTotalBooking.Location.Y);

            PanelService.Location = new Point(childPanelWidth * 2 + 45, PanelService.Location.Y);
            CustomPanel(PanelService);
            TextTotalService.Location = new Point((PanelService.Width - TextTotalService.Width) / 2, TextTotalService.Location.Y);
        }


        private void CustomPanel(Panel panel)
        {
            int cornerRadius = 20;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // kiri atas
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // kanan atas
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // kanan bawah
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // kiri bawah
            path.CloseAllFigures();

            panel.Region = new Region(path);

            using (Graphics g = panel.CreateGraphics())
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
        }


    }
}
