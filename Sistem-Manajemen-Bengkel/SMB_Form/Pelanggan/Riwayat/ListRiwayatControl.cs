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
            LabelTanggal.Text = $": {riwayat.tanggal.ToString("dd MMMM yyyy")}";
            LabelCatatan.Text = $": {riwayat.catatan}";
            LabelSparepart.Text = $": {riwayat.nama_sparepart}";
            LabelTotalBIaya.Text = $": Rp{riwayat.total_biaya}";

            PictureStatus.Image = riwayat.status == 1 ? ImageDirectoryHelper._statusSelesai : ImageDirectoryHelper._statusDibatalkan;
        }
    }
}
