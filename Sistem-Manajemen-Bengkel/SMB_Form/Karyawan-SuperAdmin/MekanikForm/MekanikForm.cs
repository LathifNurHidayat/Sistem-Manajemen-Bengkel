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

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.MekanikForm
{
    public partial class MekanikForm : Form
    {
        private readonly MekanikDal _mekanikDal;
        public MekanikForm()
        {
            InitializeComponent();
            _mekanikDal = new MekanikDal();

            CustomComponent();
            LoadData();
            CustomDataGrid(GridListData);

            RegisterControlEvent();
        }

        private void CustomComponent()
        {
            List<int> entries = new() { 10, 25, 50, 100 };
            ComboEntries.DataSource = entries;
            CustomComponentHelper.CustomDataGrid(GridListData);
            CustomComponentHelper.CustomPanel(PanelBooking);
        }

        public static void CustomDataGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.Columns["No"].FillWeight = 5;
            grid.Columns["Image"].FillWeight = 8;
            grid.Columns["NoKTP"].FillWeight = 15;
            grid.Columns["Nama"].FillWeight = 25;
            grid.Columns["NoHP"].FillWeight = 12;
            grid.Columns["Alamat"].FillWeight = 25;
            grid.Columns["Spesialis"].FillWeight = 20;

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            }

            grid.Columns["No"].HeaderText = "No";
            grid.Columns["Image"].HeaderText = "Profile";
            grid.Columns["NoKTP"].HeaderText = "No KTP";
            grid.Columns["Nama"].HeaderText = "Nama Mekanik";
            grid.Columns["NoHP"].HeaderText = "No. HP";
            grid.Columns["Alamat"].HeaderText = "Alamat";
            grid.Columns["Spesialis"].HeaderText = "Spesialis";

            //grid.Columns["Image"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

            if (!string.IsNullOrEmpty(search))
            {
                dp.Add("@Search", $"%{search}%");
                filters = @" AND (no_ktp_mekanik LIKE @Search OR 
                                  nama_mekanik LIKE @Search OR 
                                  no_hp LIKE @Search OR 
                                  alamat LIKE @Search OR 
                                  spesialis LIKE @Search) ";
            }
            dp.Add("@offset", inRowPage);
            dp.Add("@fetch", rowPerPage);


            int totalEntries = _mekanikDal.CountData(filters, dp);
            totalPage = (int)Math.Ceiling((double)totalEntries / rowPerPage);

            LabelShowEntries.Text = $"Showing {inRowPage + 1} to {inRowPage + rowPerPage} of {totalEntries} entries";

            var data = _mekanikDal.ListData(filters, dp)
                .Select((x, index) => new
                {
                    No = inRowPage + index + 1,
                    Image = x.image_data != null ?
                            ImageHelper.GetHighQualityThumbnail(Image.FromStream(new MemoryStream(x.image_data)), 40, 40) :
                            ImageDirectoryHelper._defaultProfilesOnGrid,
                    NoKTP = x.no_ktp_mekanik,
                    Nama = x.nama_mekanik,
                    NoHP = x.no_hp,
                    Alamat = x.alamat,
                    Spesialis = x.spesialis
                }).ToList();

            GridListData.DataSource = data;
        }

        private void RegisterControlEvent()
        {
            ButtonTambah.Click += ButtonTambah_Click;
            ComboEntries.SelectedValueChanged += ComboEntries_SelectedValueChanged;
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
                _mekanikDal.SoftDeleteData(no_ktp);
                LoadData();
            }
        }

        private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            string no_ktp = GridListData.CurrentRow?.Cells["NoKTP"]?.Value?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(no_ktp)) return;

            InputMekanikForm pegawai = new InputMekanikForm(no_ktp);
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
                NontifikasiFormHelper nontifikasiForm = new NontifikasiFormHelper("Data berhasil disimpan");
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

        private void ComboEntries_SelectedValueChanged(object? sender, EventArgs e)
        {
            page = 1;
            LoadData();
        }
    }
}
