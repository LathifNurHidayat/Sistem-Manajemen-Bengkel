using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Helper
{
    public class CustomComponentHelper
    {
        public static void CustomPanel(Panel panel)
        {
            int cornerRadius = 10;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // kiri atas
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // kanan atas
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // kanan bawah
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // kiri bawah
            path.CloseAllFigures();

            panel.Region = new Region(path);
        }
    }
}
