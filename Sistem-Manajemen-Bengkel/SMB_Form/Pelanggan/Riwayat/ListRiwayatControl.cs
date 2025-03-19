using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.Riwayat
{
    public partial class ListRiwayatControl : UserControl
    {
        private readonly RiwayatDal _riwayatDal;
        public ListRiwayatControl(int id_riwayat)
        {
            InitializeComponent();
            _riwayatDal = new RiwayatDal();

            GetData(id_riwayat);
        }

        private void GetData(int id_riwayat)
        {
            var riwayat = _riwayatDal.GetData(id_riwayat);

            if (riwayat == null) return;

            LabelNoPolisi.Text = $": {riwayat.no_polisi}";
            LabelMerek.Text = $": {riwayat.merek}";
            LabelKapasitasMesin.Text = $": {riwayat.kapasitas_mesin} cc";
            LabelPetugas.Text = $": {riwayat.nama_pegawai}";
            LabelKeluhan.Text = $": {riwayat.keluhan}";
            LabelTanggal.Text = $": {riwayat.tanggal.ToString("dddd, dd MMMM yyyy", new System.Globalization.CultureInfo("id-ID"))}";
            LabelCatatan.Text = $"{(string.IsNullOrEmpty(riwayat.catatan) ? "Tidak ada" : riwayat.catatan)}";
            LabelSparepart.Text = string.IsNullOrWhiteSpace(riwayat.nama_sparepart) ? "Tidak ada" : riwayat.nama_sparepart;
            LabelTotalBiaya.Text = $" Rp {riwayat.total_biaya:N0}";

            PictureStatus.Image = riwayat.status == 1 ? ImageDirectoryHelper._statusSelesai : ImageDirectoryHelper._statusDibatalkan;


            if (LabelCatatan.Text == "Tidak ada")
                LabelCatatan.ForeColor = Color.Red; 
            if (LabelSparepart.Text == "Tidak ada")
                LabelSparepart.ForeColor = Color.Red;
        }
    }
}