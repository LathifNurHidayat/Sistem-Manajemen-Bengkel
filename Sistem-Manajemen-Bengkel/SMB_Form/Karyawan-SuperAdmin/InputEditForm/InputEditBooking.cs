using System;
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
            List<string> d = new List<string>()
            {
                "aju", "kj,dmc","jhbjmn","jjb,n"
            };
            ComboKendaraan.DataSource = d;

            ButtonCekKetersediaan.Click += LathifButton1_Click;
        }

        private void LathifButton1_Click(object? sender, EventArgs e)
        {
            MesboxHelper.ShowWarning(ComboKendaraan?.SelectedItem?.ToString()?? "gfh");
        }

        private void ButtonCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object? sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InputEditBooking_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sfComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
