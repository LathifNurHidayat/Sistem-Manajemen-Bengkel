using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class AntreanForm : Form
    {

        public AntreanForm(int antreanBaru, int antreanDikerjakan)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            SetAntrean(antreanBaru, antreanDikerjakan);

            ButtonBatal.Click += ButtonBatal_Click;
            ButtonBooking.Click += ButtonBooking_Click;
        }

        private void ButtonBooking_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void SetAntrean(int antreanBaru, int antreanDikerjakan)
        {
            if (antreanDikerjakan == -1)
            {
                LabelAntreanDikerjakan.Text = "Belum ada";
                LabelAntreanDikerjakan.Font = new Font(LabelAntreanDikerjakan.Font.FontFamily, 16);
            }
            else
            {
                LabelAntreanDikerjakan.Text = antreanDikerjakan.ToString();
                LabelAntreanDikerjakan.Font = new Font(LabelAntreanDikerjakan.Font.FontFamily, 36);
            }

            LabelAntreanAnda.Text = antreanBaru.ToString();
        }
    }
}
