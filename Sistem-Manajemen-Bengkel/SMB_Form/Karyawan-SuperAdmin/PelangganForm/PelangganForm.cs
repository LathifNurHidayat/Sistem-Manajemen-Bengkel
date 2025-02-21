using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class PelangganForm : Form
    {
        private readonly PelangganDal _pelangganDal;

        public PelangganForm()
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();
            CustomComponent();
            LoadData();
            CustomDataGrid(GridListData);
            RegisterControlEvent();
        }

        #region PROSEDURE

        private void CustomComponent()
        {
            List<int> entries = new() { 10, 25, 50, 100 };
            ComboEntries.DataSource = entries;
            List<string> sortBy = new() { "Default", "Servis Terbanyak", "Servis Tersedikit" };
            ComboFilter.DataSource = sortBy;
            CustomComponentHelper.CustomDataGrid(GridListData);
            CustomComponentHelper.CustomPanel(PanelBooking);
        }



        int page = 1;
        int totalPage;
        private void LoadData()
        {
            TextPage.Text = page.ToString();
            string search = TextSearch.Text.Trim();
            int rowPerPage = (int)ComboEntries.SelectedValue;
            int inRowPage = (page - 1) * rowPerPage;
            var dp = new DynamicParameters();
            string filters = string.Empty;
            string orderBy = string.Empty;
            string comboFilterCek = (string)ComboFilter.SelectedItem;

            if (comboFilterCek == "Default")
                orderBy = " created_at ASC";
            else if (comboFilterCek == "Servis Terbanyak")
                orderBy = " total_servis DESC";
            else if (comboFilterCek == "Servis Tersedikit")
                orderBy = " total_servis ASC";

            if (!string.IsNullOrEmpty(search))
            {
                dp.Add("@Search", $"%{search}%");
                filters = @" AND (no_ktp_pelanggan LIKE @Search OR 
                                  nama_pelanggan LIKE @Search OR 
                                  no_hp LIKE @Search OR 
                                  alamat LIKE @Search OR 
                                  email LIKE @Search)";
            }

            dp.Add("@offset", inRowPage);
            dp.Add("@fetch", rowPerPage);

            int totalEntries = _pelangganDal.CountData(filters, dp);
            totalPage = (int)Math.Ceiling((double) totalEntries / rowPerPage);

            LabelShowEntries.Text = $"Showing {inRowPage + 1} to {inRowPage + rowPerPage} of {totalEntries} entries";

            var data = _pelangganDal.ListData(filters, orderBy ,dp) 
                .Select((x, index) => new PelangganDto
                {
                    No = inRowPage + index + 1,
                    Nomor_KTP = x.no_ktp_pelanggan,
                    Nama_Pelanggan = x.nama_pelanggan,
                    Nomor_HP = x.no_hp,
                    Alamat = x.alamat,
                    Email = x.email,
                    Total_Servis = x.total_servis
                }).ToList();

            GridListData.DataSource = data;
        }

        private void CustomDataGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Columns["No"].FillWeight = 5;
            grid.Columns["Nomor_KTP"].FillWeight = 12;
            grid.Columns["Nama_Pelanggan"].FillWeight = 25;
            grid.Columns["Nomor_HP"].FillWeight = 12;
            grid.Columns["Alamat"].FillWeight = 28;
            grid.Columns["Email"].FillWeight = 15;
            grid.Columns["Total_Servis"].FillWeight = 12;

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            }

            grid.Columns["Nomor_KTP"].HeaderText = "No KTP";
            grid.Columns["Nama_Pelanggan"].HeaderText = "Nama Pelanggan";
            grid.Columns["Nomor_HP"].HeaderText = "No. HP";
            grid.Columns["Alamat"].HeaderText = "Alamat";
            grid.Columns["Email"].HeaderText = "Email";
            grid.Columns["Total_Servis"].HeaderText = "Total Servis";

            grid.Columns["Total_Servis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        #endregion

        #region EVENT

        private void RegisterControlEvent()
        {
            TextSearch.KeyDown += TextSearch_KeyDown;
            TextSearch.TextChanged += TextSearch_TextChanged;
            ButtonSearch.Click += ButtonSearch_Click;
            ButtonTambah.Click += ButtonTambah_Click;
            GridListData.CellMouseClick += GridListData_CellMouseClick;
            ComboEntries.SelectedValueChanged += ComboEntries_SelectedValueChanged;
            ComboFilter.SelectedIndexChanged += ComboFilter_SelectedIndexChanged;
            ButtonNext.Click += ButtonNext_Click;
            ButtonPreviuos.Click += ButtonPreviuos_Click;
            editToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
        }

        private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            string no_ktp = GridListData.CurrentRow?.Cells["Nomor_KTP"]?.Value?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(no_ktp)) return;
            if (MesboxHelper.ShowConfirm("Anda yakin ingin menghapus data ?"))
            {
                _pelangganDal.SoftDeleteData(no_ktp);
                LoadData();
                NontifikasiFormHelper nontifikasiForm = new NontifikasiFormHelper("Data berhasil dihapus");
                nontifikasiForm.Show();
            }
        }

        private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            string no_ktp = GridListData.CurrentRow?.Cells["Nomor_KTP"]?.Value?.ToString()?? string.Empty;
            if (string.IsNullOrEmpty(no_ktp)) return;
            InputPelangganForm inputPelanggan = new InputPelangganForm(no_ktp);
            if (inputPelanggan.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
                NontifikasiFormHelper nontifikasiForm = new NontifikasiFormHelper("Data berhasil diperbarui");
                nontifikasiForm.Show();
            }
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
            InputPelangganForm inputPelanggan = new InputPelangganForm(string.Empty);
            if (inputPelanggan.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
                NontifikasiFormHelper nontifikasiForm = new NontifikasiFormHelper("Data berhasil ditambahkan");
                nontifikasiForm.Show();
            }
        }

        private void ButtonSearch_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextSearch.Text)) return;
            LoadData();
        }

        #endregion 


        public class PelangganDto
        {
            public int No { get; set; }
            public string Nomor_KTP { get; set; }
            public string Nama_Pelanggan { get; set; }
            public string Nomor_HP { get; set; }
            public string Alamat { get; set; }
            public string Email { get; set; }
            public int Total_Servis { get; set; }
        }
    }
}
