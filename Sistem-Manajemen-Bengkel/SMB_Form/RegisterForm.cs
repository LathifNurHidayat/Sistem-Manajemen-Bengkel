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

namespace Sistem_Manajemen_Bengkel.SMB_Form.LoginRegister
{

    public partial class RegisterForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        public RegisterForm()
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            CustomPanel(panel1);

            RegisterControlEvent();
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
        }


        private void RegisterControlEvent()
        {
            LinkMasuk.Click += LinkLogin_Click;
            TextNIK.TextChanged += TextInput_TextChanged;
            TextNomorHP.TextChanged += TextInput_TextChanged;
            TextUsername.TextChanged += TextInput_TextChanged;
            ButtonDaftar.Click += ButtonDaftar_Click;
        }

        private void ButtonDaftar_Click(object? sender, EventArgs e)
        {
            
        }

        private async void TextInput_TextChanged(object? sender, EventArgs e)
        {
            await Task.Delay(1000);

            int no_ktp = Convert.ToInt32(TextNIK.Text);
            string no_hp = TextNomorHP.Text.Trim();
            string nama_pelanggan = TextUsername.Text.Trim();

            var cekData = _pelangganDal.ValidasiDaftar(no_ktp, no_hp, nama_pelanggan);
            if (cekData == 0)
                return;

            if (cekData == 1)
                LabelNIK.Text = "NIK sudah terdaftar";
            else
                LabelNIK.Text = "";

            if (cekData == 2)
                LabelNoHP.Text = "Nomor HP sudah terdaftar";
            else
                LabelNoHP.Text = "";

            if (cekData == 3)
                LabelUsername.Text = "Username sudah terdaftar";
            else
                LabelUsername.Text = "";
        }

        private void LinkLogin_Click(object? sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
