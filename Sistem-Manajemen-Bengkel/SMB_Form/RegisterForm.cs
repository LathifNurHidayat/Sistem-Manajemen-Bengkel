using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Form.LoginRegister
{

    public partial class RegisterForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        private Form _form;
        public RegisterForm(Form form)
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();
            _form = form;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            LabelNIK.Visible = false;
            LabelNoHP.Visible = false;
            LabelEmail.Visible = false;

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
            TextEmail.TextChanged += TextInput_TextChanged;
            TextEmail.TextChanged += TextInput_TextChanged;
            ButtonDaftar.Click += ButtonDaftar_Click;
        }

        private void ButtonDaftar_Click(object? sender, EventArgs e)
        {
            if (LabelNIK.Visible || LabelNoHP.Visible || LabelEmail.Visible  || LabelConfirmPass.Visible)
            {
                MessageBox.Show("Data yang anda masukkan tidak valid");
                return;
            }

            var pelanggan = new PelangganModel
            {
                no_ktp = Convert.ToInt32(TextNIK.Text.Trim()),
                no_hp = TextNomorHP.Text.Trim(),
                nama_pelanggan = TextEmail.Text.Trim(),
                alamat = TextAlamat.Text.Trim(),
                email = TextConfirmPassword.Text.Trim(),
            };

            _pelangganDal.InsertData(pelanggan);
            ClearForm();
            _form.Show();
            this.Close();
        }

        private async void TextInput_TextChanged(object? sender, EventArgs e)
        {
            await Task.Delay(1000);
            TextBox textbox = (TextBox)sender;

            if (textbox.Tag == "Email")
            {
                if (!Regex.IsMatch(TextEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    await Task.Delay(1000);
                    LabelEmail.Text = "Masukan email yang valid";
                    LabelEmail.Visible = true;
                    return;
                }
                else
                {
                    LabelEmail.Visible = false;
                    LabelEmail.Text = "Email sudah terdaftar";
                }
            }

            int no_ktp = Convert.ToInt32(TextNIK.Text);
            string no_hp = TextNomorHP.Text.Trim();
            string email = TextEmail.Text.Trim();

            var cekData = _pelangganDal.ValidasiDaftar(no_ktp, no_hp, email);
            if (cekData == 0)
                return;
            if (cekData == 1)
                LabelNIK.Visible = true;
            else
                LabelNIK.Visible = false;
            if (cekData == 2)
                LabelNoHP.Visible = true;
            else
                LabelNoHP.Visible = false;
            if (cekData == 3)
                LabelEmail.Visible = true;
            else
                LabelEmail.Visible = false;
        }

        private void LinkLogin_Click(object? sender, EventArgs e)
        {
            _form.Show();
            this.Close();
        }

        private void ClearForm()
        {
            TextNIK.Clear();
            TextNomorHP.Clear();
            TextNamaLengkap.Clear();
            TextAlamat.Clear();
            TextEmail.Clear();
            TextPassword.Clear();
            TextConfirmPassword.Clear();
        }
    }
}