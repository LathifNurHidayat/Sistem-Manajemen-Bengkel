﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.KandaraanForm
{
    public partial class TambahKendaraanForm : Form
    {
        private readonly KendaraanDal _kendaraanDal;
        private string _no_ktp_pelanggan;
        private int _id_kendaraan;

        public TambahKendaraanForm(int id,string no_ktp_pelanggan)
        {
            InitializeComponent();
            _kendaraanDal = new KendaraanDal();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            _id_kendaraan = id;
            _no_ktp_pelanggan = no_ktp_pelanggan;

            if (id != 0)
                GetData(id);

            InitialComponent();
            RegisterControlEvent();
        }

        private void InitialComponent()
        {
            List<string> transmisi = new List<string>() { "Transmisi Otomatis", "Transmisi Manual" };
            ComboTransmisi.DataSource = transmisi;
        }


        private void GetData(int kendaraanId)
        {
            var kendaraan = _kendaraanDal.GetData(kendaraanId);

            if (kendaraan != null)
            {
                TextNoPolisi.Text = kendaraan.no_polisi;
                TextMerek.Text = kendaraan.merek;
                ComboTransmisi.SelectedValue = kendaraan.transmisi == 1 ? "Transmisi Otomatis" : "Transmisi Manual";
                TextKapasitasMesin.Text = kendaraan.kapasitas_mesin.ToString();
                TextTahun.Text = kendaraan.tahun.ToString();
            }
        }


        private void SaveData()
        {
            var kendaraan = new KendaraanModel
            {
                no_ktp_pelanggan = _no_ktp_pelanggan,
                no_polisi = TextNoPolisi.Text,
                merek = TextMerek.Text,
                transmisi = ComboTransmisi.SelectedValue == "Transmisi Otomatis" ? 1 : 2,
                kapasitas_mesin = Convert.ToInt32(TextKapasitasMesin.Text),
                tahun = Convert.ToInt32(TextTahun.Text)
            };
            
            if (_id_kendaraan == 0)
                _kendaraanDal.InsertData(kendaraan);
            else
                _kendaraanDal.UpdateData(kendaraan);

        }

        private void RegisterControlEvent()
        {
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
            TextKapasitasMesin.KeyPress += TextBox_KeyPress;
            TextTahun.KeyPress += TextBox_KeyPress;
        }

        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(TextNoPolisi.Text) || string.IsNullOrWhiteSpace(TextMerek.Text) ||
                          string.IsNullOrWhiteSpace(TextKapasitasMesin.Text) || string.IsNullOrWhiteSpace(TextTahun.Text))
            {
                MesboxHelper.ShowWarning("Semua data wajib diisi");
                return;
            }

            SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
