﻿using System;
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
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.KandaraanForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.Grouping;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Kendaraan
{
    public partial class ListKendaraanControl : UserControl
    {
        private readonly KendaraanDal _kendaraanDal;
        private string _no_ktp_pelanggan = SessionLoginHelper._sessionLoginPelanggan.no_ktp_pelanggan;
        private int _id_kendaraan;

        public ListKendaraanControl(int id_kendaraan)
        {
            InitializeComponent();
            _kendaraanDal = new KendaraanDal();
            

            _id_kendaraan = id_kendaraan;
            SetData(id_kendaraan);
            RegisterControlEvent();
        }

        private void SetData(int id_kendaraan)
        {
            var kendaraan = _kendaraanDal.GetData(id_kendaraan);

            if (kendaraan == null) return;

            LabelNoPolisi.Text = kendaraan.no_polisi;
            LabelMerek.Text = kendaraan.merek;
            LabelKapasitasMesin.Text = $"{kendaraan.kapasitas_mesin} cc";
            LabelTahun.Text = kendaraan.tahun.ToString();
            LabelTransmisi.Text = kendaraan.transmisi == 1 ? "Otomatis" : "Manual";
            LabelTerakhirServis.Text = kendaraan.terakhir_servis.HasValue
                                     ? kendaraan.terakhir_servis.Value.ToString("dddd, dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID"))
                                     : "Belum ada data";

            if (LabelTerakhirServis.Text == "Belum ada data")
            {
                LabelTerakhirServis.ForeColor = Color.Red;
            }
        }

        private void RegisterControlEvent()
        {
            ButtonHapus.Click += ButtonHapus_Click;
            ButtonEdit.Click += ButtonEdit_Click;
        }

        private void ButtonEdit_Click(object? sender, EventArgs e)
        {
            EditInputKendaraanForm tambahKendaraanForm = new EditInputKendaraanForm( _id_kendaraan);
            if (tambahKendaraanForm.ShowDialog() == DialogResult.OK)
            {
                SetData(_id_kendaraan);
            }
        }

        private void ButtonHapus_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Apakah anda yakin ingin menghapus data kendaraan ?"))
            {
                _kendaraanDal.SoftDeleteData(_id_kendaraan);
                this.Dispose();
            }
        }
    }
}
