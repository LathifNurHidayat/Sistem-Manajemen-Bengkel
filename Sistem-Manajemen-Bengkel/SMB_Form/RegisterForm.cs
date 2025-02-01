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
            TextConfirmPassword.TextChanged += TextInput_TextChanged;
            TextPassword.TextChanged += TextInput_TextChanged;
            ButtonDaftar.Click += ButtonDaftar_Click;

            TextNIK.KeyPress += TextBox_KeyPress;
            TextNomorHP.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
            if (sender is not TextBox textbox) return; 

            await Task.Delay(500); 

            string text = textbox.Text.Trim();
            bool isValid = true;

            var ValidasiRules = new Dictionary<string, (string Pattern, Label LabelError, string PesanError)>
            {
                { "Email", (@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", LabelEmail, "Masukkan email yang valid") },
                { "NIK", (@"^[0-9]{16}$", LabelNIK, "NIK harus 16 digit") },
                { "NoHP", (@"^[0-9]{10,13}$", LabelNoHP, "No HP harus 10-13 digit") },
                { "Password", (@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$", LabelPassword, "Password minimal 8 karakter, harus ada huruf besar, kecil, dan angka") }
            };

            if (ValidasiRules.TryGetValue(textbox.Tag?.ToString() ?? "", out var rule))
            {
                isValid = Regex.IsMatch(text, rule.Pattern);
                rule.LabelError.Text = isValid ? "Sudah terdaftar" : rule.PesanError;
                rule.LabelError .Visible = !isValid;
            }

            if (textbox.Tag?.ToString() == "ConfirmPassword")
            {
                isValid = (text == TextPassword.Text);
                LabelConfirmPass.Visible = !isValid;
            }

            if (!isValid) return; 

            var cekData = _pelangganDal.ValidasiDaftar(TextNIK.Text, TextNomorHP.Text, TextEmail.Text);

            LabelNIK.Visible = (cekData == 1);
            LabelNoHP.Visible = (cekData == 2);
            LabelEmail.Visible = (cekData == 3);
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