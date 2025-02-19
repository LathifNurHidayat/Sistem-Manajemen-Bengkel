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

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class KendaraanForm : Form
    {
        private readonly KendaraanDal _kendaraanDal;
        public KendaraanForm()
        {
            InitializeComponent();
            _kendaraanDal = new KendaraanDal();
            CustomComponent();
            LoadData();
            CustomDataGrid(GridListData);

            RegisterControlEvent();
        }

        private void CustomComponent()
        {
            List<int> entries = new() { 10, 25, 50, 100 };
            ComboEntries.DataSource = entries;

            List<string> tahun = new() { "Semua (All)" };
            tahun.AddRange(_kendaraanDal.ListTahun().Select(x => x.ToString()));

            ComboFilter.DataSource = tahun;
            CustomComponentHelper.CustomDataGrid(GridListData);
            CustomComponentHelper.CustomPanel(PanelBooking);
        }


        private void CustomDataGrid(DataGridView grid)
        {
            grid.Columns["Id"].Visible = false;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Columns["No"].FillWeight = 5;
            grid.Columns["Pemilik"].FillWeight = 20;
            grid.Columns["NoPolisi"].FillWeight = 15;
            grid.Columns["Merek"].FillWeight = 15;
            grid.Columns["Transmisi"].FillWeight = 10;
            grid.Columns["KapasitasMesin"].FillWeight = 10;
            grid.Columns["Tahun"].FillWeight = 10;

            grid.Columns["No"].HeaderText = "No";
            grid.Columns["Pemilik"].HeaderText = "Pemilik";
            grid.Columns["NoPolisi"].HeaderText = "No. Polisi";
            grid.Columns["Merek"].HeaderText = "Merek";
            grid.Columns["Transmisi"].HeaderText = "Transmisi";
            grid.Columns["KapasitasMesin"].HeaderText = "Kapasitas Mesin (cc)";
            grid.Columns["Tahun"].HeaderText = "Tahun";

            grid.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
         
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Padding = new Padding(20, 0,0,0);
            }
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
            string filters_1 = string.Empty;
            string filters_2 = string.Empty;

            if (ComboFilter.SelectedItem == "Semua (All)")
                filters_1 += "";
            else
            {
                filters_1 += $" AND aa.tahun = {ComboFilter.SelectedItem}";
                filters_2 += $" AND tahun = {ComboFilter.SelectedItem}";
            }

            if (!string.IsNullOrEmpty(search)) 
            {
                dp.Add("@Search", $"%{search}%");
                filters_1 = @" AND (bb.nama_pelanggan LIKE @Search OR 
                                  aa.no_polisi LIKE @Search OR 
                                  aa.merek LIKE @Search OR 
                                  aa.transmisi LIKE @Search OR 
                                  aa.kapasitas_mesin LIKE @Search OR
                                  aa.tahun LIKE @Search) ";
            }
            dp.Add("@offset", inRowPage);
            dp.Add("@fetch", rowPerPage);

            int totalEntries = _kendaraanDal.CountData(filters_2, dp);
            totalPage = (int)Math.Ceiling((double)totalEntries / rowPerPage);

            LabelShowEntries.Text = $"Showing {inRowPage + 1} to {inRowPage + rowPerPage} of {totalEntries} entries";

            var data = _kendaraanDal.ListData(filters_1, dp)
                .Select((x, index) => new
                {
                    No = inRowPage + index + 1,
                    Id = x.id_kendaraan,
                    Pemilik = x.nama_pelanggan,
                    NoPolisi = x.no_polisi,
                    Merek = x.merek,
                    Transmisi = x.transmisi == 1 ? "Otomatis" : "Manual",
                    KapasitasMesin = x.kapasitas_mesin,
                    Tahun = x.tahun,
                }).ToList();

            GridListData.DataSource = data;

            // Tambahkan kolom link untuk Edit
            DataGridViewLinkColumn linkEdit = new DataGridViewLinkColumn();
            linkEdit.HeaderText = "Edit";
            linkEdit.Name = "Edit";
            linkEdit.Text = "Edit"; // Teks link
            linkEdit.UseColumnTextForLinkValue = true;
            linkEdit.LinkBehavior = LinkBehavior.NeverUnderline; // Hapus underline
            linkEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            linkEdit.Width = 50; // Sesuaikan ukuran
            GridListData.Columns.Add(linkEdit);

            // Tambahkan kolom link untuk Delete
            DataGridViewLinkColumn linkDelete = new DataGridViewLinkColumn();
            linkDelete.HeaderText = "Delete";
            linkDelete.Name = "Delete";
            linkDelete.Text = "Delete"; // Teks link
            linkDelete.UseColumnTextForLinkValue = true;
            linkDelete.LinkBehavior = LinkBehavior.NeverUnderline; // Hapus underline
            linkDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            linkDelete.Width = 50;
            GridListData.Columns.Add(linkDelete);



        }


        private void RegisterControlEvent()
        {
            ButtonTambah.Click += ButtonTambah_Click;
            ComboEntries.SelectedValueChanged += ComboEntries_SelectedValueChanged;
            ComboFilter.SelectedValueChanged += ComboFilter_SelectedValueChanged;
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
            int idKendaraan = (int)GridListData.CurrentRow.Cells["Id"].Value;
            if (idKendaraan == 0) return;

            if (MesboxHelper.ShowConfirm("Anda yakin ingin menghapus data ?"))
            {
                _kendaraanDal.SoftDeleteData(idKendaraan);
                LoadData();
                NontifikasiFormHelper nontifikasiForm = new NontifikasiFormHelper("Data berhasil dihapus");
                nontifikasiForm.ShowDialog(this);
            }
        }

        private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            int idKendaraan = (int)GridListData.CurrentRow.Cells["Id"].Value;
            if (idKendaraan == 0) return;

            InputKendaraanForm kendaraan = new InputKendaraanForm(idKendaraan);
            if (kendaraan.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
                NontifikasiFormHelper nontifikasiForm = new NontifikasiFormHelper("Data berhasil diperbarui");
                nontifikasiForm.ShowDialog(this);
            }
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
            InputKendaraanForm kendaraan = new InputKendaraanForm(0);
            if (kendaraan.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
                NontifikasiFormHelper nontifikasiForm = new NontifikasiFormHelper("Data berhasil ditambahkan");
                nontifikasiForm.ShowDialog(this);
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

        private void ComboFilter_SelectedValueChanged(object? sender, EventArgs e)
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