using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal.SessionLogin;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.RiwayatForm
{
    public partial class RiwayatPelanggan : Form
    {
        private readonly RiwayatDal _riwayatDal;
        private string _no_ktp;
        public RiwayatPelanggan()
        {
            InitializeComponent();
            _riwayatDal = new RiwayatDal();
            _no_ktp = SessionLogin._sessionLoginPelanggan.no_ktp_pelanggan;

            InitialCombo_Grid();
            LoadData();

            RegisterControlEvent();
        }

        private void InitialCombo_Grid()
        {
            CustomComponentHelper.CustomDataGrid(GridListData);
        }


        private void LoadData()
        {
            var riwayat = _riwayatDal.ListDataWhereNoKtp(_no_ktp).Select((x, index ) => new
            {
                No = index + 1,
                Tanggal = x.tanggal,
                Kendaraan = $"{x.merek} - {x.no_polisi}",
                Keluhan = x.keluhan,
                Petugas = x.nama_pegawai,
                Mekanik = x.nama_mekanik,
                Sparepart = x.nama_sparepart,
                Catatan = x.catatan,
                TotalBiaya = $"Rp{x.total_biaya:N0}",
                Status = x.status
            }).ToList();

            if (riwayat.Count == 0)
                LabelDataKosong.Visible = true;

            GridListData.DataSource = riwayat;
        }

        
        private  void RegisterControlEvent()
        {

        }
    }
}
