using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class PelangganForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        private BindingList<PelangganDto> _listPelanggan;

        public PelangganForm()
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();

            CustomComponent();
            LoadData();
            RegisterControlEvent();
        }

        private void CustomComponent()
        {
            CustomComponentHelper.CustomDataGrid(GridListData);
        }

        private void LoadData()
        {
            var data = _pelangganDal.ListData().Select(x => new PelangganDto
            {
                Nomor_KTP  = x.no_ktp_pelanggan,
                Nama_Pelanggan = x.nama_pelanggan,
                Nomor_HP = x.no_hp,
                Alamat = x.alamat,
                Email = x.email,
            }).ToList();
            foreach (var item in data)
            {
                item.No = data.IndexOf(item) + 1;
                _listPelanggan.Add(item);
            }

            GridListData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            GridListData.Columns["Nomor_KTP"].FillWeight = 15;
            GridListData.Columns["Nama_Pelanggan"].FillWeight = 20;
            GridListData.Columns["Nomor_HP"].FillWeight = 15;
            GridListData.Columns["Alamat"].FillWeight = 25;
            GridListData.Columns["Email"].FillWeight = 20;

            // Padding untuk teks di dalam kolom
            GridListData.Columns["Nomor_KTP"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            GridListData.Columns["Nama_Pelanggan"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            GridListData.Columns["Nomor_HP"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            GridListData.Columns["Alamat"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            GridListData.Columns["Email"].DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);

            // Menyesuaikan alignment untuk beberapa kolom
            GridListData.Columns["Nomor_HP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridListData.Columns["Nomor_KTP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Menonaktifkan sorting pada beberapa kolom
            GridListData.Columns["Nomor_KTP"].SortMode = DataGridViewColumnSortMode.NotSortable;
            GridListData.Columns["Nomor_HP"].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Mengatur header text yang lebih rapi
            GridListData.Columns["Nomor_KTP"].HeaderText = "No KTP";
            GridListData.Columns["Nama_Pelanggan"].HeaderText = "Nama Pelanggan";
            GridListData.Columns["Nomor_HP"].HeaderText = "No. HP";
            GridListData.Columns["Alamat"].HeaderText = "Alamat";
            GridListData.Columns["Email"].HeaderText = "Email";
        }
        


        private void RegisterControlEvent()
        {
            TextSearch.TextChanged += TextSearch_TextChanged;
        }

        private void TextSearch_TextChanged(object? sender, EventArgs e)
        {
            var result = _listPelanggan
                .Where(p => p.Nama_Pelanggan.Contains(TextSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                            p.Email.Contains(TextSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                            p.Alamat.Contains(TextSearch.Text, StringComparison.OrdinalIgnoreCase))
                .ToList();

            GridListData.DataSource = result;
        }

        public class PelangganDto
        {
            public int No { get; set; }
            public string Nomor_KTP { get; set; }
            public string Nama_Pelanggan { get; set; }
            public string Nomor_HP { get; set; }
            public string Alamat { get; set; }
            public string Email { get; set; }
        }
}
