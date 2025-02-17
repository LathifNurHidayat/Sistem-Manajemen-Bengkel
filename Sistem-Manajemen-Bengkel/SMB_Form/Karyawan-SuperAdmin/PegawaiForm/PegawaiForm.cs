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
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using static Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm.PelangganForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm
{
    public partial class PegawaiForm : Form
    {

        private readonly PegawaiDal _pegawaiDal;
        
        public PegawaiForm()
        {
            InitializeComponent();

            _pegawaiDal = new PegawaiDal();

            CustomComponent();
            LoadData();
            CustomDataGrid(GridListData);

            RegisterControlEvent();
        }

        private void CustomComponent()
        {
            List<int> entries = new() { 10, 25, 50, 100 };
            ComboEntries.DataSource = entries;
            List<string> sortBy = new() { "Semua (All)", "Petugas", "Super Admin" };
            ComboFilter.DataSource = sortBy;
            CustomComponentHelper.CustomDataGrid(GridListData);
            CustomComponentHelper.CustomPanel(PanelBooking);
        }

        public static void CustomDataGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.Columns["No"].FillWeight = 5;
            grid.Columns["Image"].FillWeight = 8;
            grid.Columns["NoKTP"].FillWeight = 12;
            grid.Columns["Nama"].FillWeight = 25;
            grid.Columns["NoHP"].FillWeight = 12;
            grid.Columns["Alamat"].FillWeight = 27;
            grid.Columns["Email"].FillWeight = 15;
            grid.Columns["Role"].FillWeight = 15;

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            }

            grid.Columns["NoKTP"].HeaderText = "No KTP";
            grid.Columns["Nama"].HeaderText = "Nama Pelanggan";
            grid.Columns["Image"].HeaderText = "Profile";
            grid.Columns["NoHP"].HeaderText = "No. HP";
            grid.Columns["Alamat"].HeaderText = "Alamat";
            grid.Columns["Email"].HeaderText = "Email";
            grid.Columns["Role"].HeaderText = "Role";

            grid.Columns["Role"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        int page = 1;
        int totalPage = 0;
        private void LoadData()
        {
            TextPage.Text = page.ToString();
            string search = TextSearch.Text.Trim();
            int rowPerPage = (int)ComboEntries.SelectedValue;
            int inRowPage = (page - 1) * rowPerPage;
            var dp = new DynamicParameters();
            string filters = string.Empty;

            if (ComboFilter.SelectedItem == "Petugas")
                filters += " AND role = 2 ";

            else if (ComboFilter.SelectedItem == "Super Admin")
                filters += " AND role = 1 ";

            if (!string.IsNullOrEmpty(search))
            {
                dp.Add("@Search", $"%{search}%");
                filters = @" AND (no_ktp_pegawai LIKE @Search OR 
                                  nama_pegawai LIKE @Search OR 
                                  no_hp LIKE @Search OR 
                                  alamat LIKE @Search OR 
                                  email LIKE @Search) ";
            }
            dp.Add("@offset", inRowPage);
            dp.Add("@fetch", rowPerPage);

            
            int totalEntries = _pegawaiDal.CountData(filters, dp);
            totalPage = (int)Math.Ceiling((double)totalEntries / rowPerPage);

            LabelShowEntries.Text = $"Showing {inRowPage + 1} to {inRowPage + rowPerPage} of {totalEntries} entries";

            var data = _pegawaiDal.ListData(filters, dp)
                .Select((x, index) => new
                {
                    No = inRowPage + index + 1,
                    Image = x.image_data != null ?
                            ImageHelper.GetHighQualityThumbnail(Image.FromStream(new MemoryStream(x.image_data)), 40, 40) :
                            ImageDirectoryHelper._defaultProfilesOnGrid,
                    NoKTP = x.no_ktp_pegawai,
                    Nama = x.nama_pegawai,
                    NoHP = x.no_hp,
                    Alamat = x.alamat,
                    Email = x.email,
                    Role = x.role == 1 ? ImageDirectoryHelper._roleSuperAdmin :
                           x.role == 2 ? ImageDirectoryHelper._rolePetugas : null
                }).ToList();

            GridListData.DataSource = data;
        }

        private void RegisterControlEvent()
        {
            ButtonTambah.Click += ButtonTambah_Click;
            ComboEntries.SelectedValueChanged += ComboEntries_SelectedValueChanged;
            ComboFilter.SelectedValueChanged += ComboFilter_SelectedIndexChanged;
            ButtonNext.Click += ButtonNext_Click;
            ButtonPreviuos.Click += ButtonPreviuos_Click;
            ButtonSearch.Click += ButtonSearch_Click;
            TextSearch.TextChanged += TextSearch_TextChanged;
            TextSearch.KeyDown += TextSearch_KeyDown;
            GridListData.CellMouseClick += GridListData_CellMouseClick;
            editToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
        }

        private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            string no_ktp = GridListData.CurrentRow?.Cells["NoKTP"]?.Value?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(no_ktp)) return;
            if (MesboxHelper.ShowConfirm("Anda yakin ingin menghapus data ?"))
            {
                _pegawaiDal.SoftDeleteData(no_ktp);
                LoadData();
            }
        }

        private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            string no_ktp = GridListData.CurrentRow?.Cells["NoKTP"]?.Value?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(no_ktp)) return;

            InputPegawaiForm pegawai = new InputPegawaiForm(no_ktp);
            if (pegawai.ShowDialog(this) == DialogResult.OK)
                LoadData();
        }

        private void GridListData_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                GridListData.ClearSelection();
                GridListData.CurrentCell = GridListData[e.ColumnIndex, e.RowIndex];
                contextMenuStrip.Show(Cursor.Position);
            }
        }

        private void ButtonTambah_Click(object? sender, EventArgs e)
        {
            InputPegawaiForm input = new InputPegawaiForm(string.Empty);
            if (input.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ButtonSearch_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextSearch.Text)) return;
            LoadData();
        }

        private void ButtonPreviuos_Click(object? sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                LoadData();
            }
        }

        private void ButtonNext_Click(object? sender, EventArgs e)
        {
            if (page < totalPage)
            {
                page++;
                LoadData();
            }
        }

        private void TextSearch_TextChanged(object? sender, EventArgs e)
        {
            if (TextSearch.Text.Length == 0)
            {
                page = 1;
                LoadData();
            }
        }

        private void TextSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                page = 1;
                ButtonSearch.PerformClick();
            }
        }

        private void ComboFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            page = 1;
            LoadData();
        }

        private void ComboEntries_SelectedValueChanged(object? sender, EventArgs e)
        {
            page = 1;
            LoadData();
        }
    }
}
