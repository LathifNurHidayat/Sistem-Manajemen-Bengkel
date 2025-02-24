using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Helper
{
    public class ShowFormHelper
    {
        private static Panel _panelMain;

        public static void SetPanel(Panel panel)
        {
            _panelMain = panel;
        }
         
        public static void ShowFormInPanel(Form form)
        {
            if (_panelMain.Controls.Count > 0)
                _panelMain.Controls.RemoveAt(0);

            if (form == null) return;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            _panelMain.Tag = form;

            _panelMain.Controls.Add(form);
            form.Show();
        }
    }
}
