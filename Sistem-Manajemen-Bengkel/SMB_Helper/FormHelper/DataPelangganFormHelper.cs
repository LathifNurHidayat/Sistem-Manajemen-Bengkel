using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.WinForms.DataGrid;
using static Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm.PelangganForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.KandaraanForm
{
    public partial class DataPelangganFormHelper : Form
    {
        private readonly PelangganDal _pelangganDal;
        public string _no_ktp_pelanggan { get; set; }

        public DataPelangganFormHelper()
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            CustomComponent();
            LoadData();
            CustomDataGrid();
            RegisterControlEvent();
        }

        private void CustomComponent()
        {
            List<int> entries = new() { 10, 25, 50, 100 };
            ComboEntries.DataSource = entries;
        }

        private void LoadData()
        {
            string search = TextSearch.Text.Trim();
            int rowPerPage = (int)ComboEntries.SelectedValue;
            var dp = new DynamicParameters();
            string filters = string.Empty;

            if (!string.IsNullOrEmpty(search))
            {
                dp.Add("@Search", $"%{search}%");
                filters = @" AND (no_ktp_pelanggan LIKE @Search OR 
                                  nama_pelanggan LIKE @Search)";
            }

            dp.Add("@offset", 0);
            dp.Add("@fetch", rowPerPage);

            var data = _pelangganDal.ListData(filters, " created_at ASC ", dp)
                .Select((x, index) => new 
                {
                    No = index + 1,
                    Nomor_KTP = x.no_ktp_pelanggan,
                    Nama_Pelanggan = x.nama_pelanggan,
                }).ToList();

            GridListData.DataSource = data;
        }

        private void CustomDataGrid()
        {
            CustomComponentHelper.CustomDataGrid(GridListData);
            GridListData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            GridListData.Columns["No"].FillWeight = 15;
            GridListData.Columns["Nomor_KTP"].FillWeight = 35;
            GridListData.Columns["Nomor_KTP"].HeaderText = "Nomor KTP";
            GridListData.Columns["Nama_Pelanggan"].FillWeight = 55;
            GridListData.Columns["Nama_Pelanggan"].HeaderText = "Nama Pelanggan";
            
            foreach(DataGridViewColumn col in GridListData.Columns)
            {
                col.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            }

            GridListData.ResumeLayout();
        }


        private void RegisterControlEvent()
        {
            ButtonSearch.Click += ButtonSearch_Click;
            ButtonPilih.Click += ButtonPilih_Click;

            TextSearch.TextChanged += TextSearch_TextChanged;
            TextSearch.KeyDown += TextSearch_KeyDown;
            ComboEntries.SelectedValueChanged += ComboEntries_SelectedValueChanged;
            GridListData.CellDoubleClick += GridListData_CellDoubleClick;
        }

        private void GridListData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            string no_ktp = GridListData.CurrentRow.Cells["Nomor_KTP"].Value.ToString();
            if (string.IsNullOrEmpty(no_ktp))
                return;
            _no_ktp_pelanggan = no_ktp;
            this.DialogResult = DialogResult.OK;
        }

        private void TextSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonSearch.PerformClick();
        }

        private void ComboEntries_SelectedValueChanged(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void TextSearch_TextChanged(object? sender, EventArgs e)
        {
            if (TextSearch.Text.Length == 0)
                LoadData();
        }

        private void ButtonPilih_Click(object? sender, EventArgs e)
        {
            string no_ktp = GridListData.CurrentRow.Cells["Nomor_KTP"].Value.ToString();
            if (string.IsNullOrEmpty(no_ktp))
                return;
            _no_ktp_pelanggan = no_ktp;
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonSearch_Click(object? sender, EventArgs e)
        {
            LoadData();
        }
    }
}
