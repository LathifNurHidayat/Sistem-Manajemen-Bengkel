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
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm
{
    public partial class MenuDashboardAdminForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        private readonly BookingDal _bookingDal;

        public MenuDashboardAdminForm()
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();
            _bookingDal = new BookingDal();
            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            PanelBackground.Resize += PanelBackground_Resize;
            PanelData.Resize += (s, e) => PanelData.Invalidate();
        }

        private void PanelBackground_Resize(object? sender, EventArgs e)
        {
            int childPanelWidth = (PanelBackground.Width - 60) / 3;

            PanelPelanggan.Width = childPanelWidth;
            PanelAntrean.Width = childPanelWidth;
            PanelService.Width = childPanelWidth;

            PanelPelanggan.Location = new Point(15, PanelPelanggan.Location.Y);
            LabelTotalPelanggan.Location = new Point((PanelPelanggan.Width - LabelTotalPelanggan.Width) / 2, LabelTotalPelanggan.Location.Y);

            PanelAntrean.Location = new Point(childPanelWidth + 30, PanelAntrean.Location.Y);
            LabelTotalBooking.Location = new Point((PanelAntrean.Width - LabelTotalBooking.Width) / 2, LabelTotalBooking.Location.Y);

            PanelService.Location = new Point(childPanelWidth * 2 + 45, PanelService.Location.Y);
            LabelTotalService.Location = new Point((PanelService.Width - LabelTotalService.Width) / 2, LabelTotalService.Location.Y);

            CustomPanel(PanelPelanggan);
            CustomPanel(PanelAntrean);
            CustomPanel(PanelService);
            CustomPanel(PanelBackground);
        }

        private void CustomPanel(Panel panel)
        {
            int cornerRadius = 10;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // kiri atas
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // kanan atas
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // kanan bawah
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // kiri bawah
            path.CloseAllFigures();

            panel.Region?.Dispose();
            panel.Region = new Region(path);

            using (Graphics g = panel.CreateGraphics())
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
        }

    }
}
