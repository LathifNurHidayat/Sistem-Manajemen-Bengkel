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

namespace Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm
{
    public partial class SparepartForm : Form
    {
        private readonly SparepartDal _sparepartDal;

        public SparepartForm()
        {
            InitializeComponent();
            _sparepartDal = new SparepartDal();

            CustomComponent();
            LoadData();
           // CustomDataGrid(GridListData);

            RegisterControlEvent();
        }

        private void CustomComponent()
        {
            List<int> entries = new() { 10, 25, 50, 100 };
            ComboEntries.DataSource = entries;
            List<string> sortBy = new() { "Semua (All)", "Stok Tersedia", "Stok Menipis", "Stok Habis" };
            ComboFilter.DataSource = sortBy;
            CustomComponentHelper.CustomDataGrid(GridListData);
            CustomComponentHelper.CustomPanel(PanelBooking);
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

            if (ComboFilter.SelectedItem == "Stok Tersedia")
                filters += " AND status_stok = 2 ";

            else if (ComboFilter.SelectedItem == "Stok Menipis")
                filters += " AND status_stok = 1 ";
            
            else if (ComboFilter.SelectedItem == "Stok Habis")
                filters += " AND status_stok = 0 ";

            if (!string.IsNullOrEmpty(search))
            {
                dp.Add("@Search", $"%{search}%");
                filters = @" AND (nama_sparepart LIKE @Search OR 
                                  harga LIKE @Search OR 
                                  stok LIKE @Search OR 
                                  stok_minimal LIKE @Search ) ";
            }
            dp.Add("@offset", inRowPage);
            dp.Add("@fetch", rowPerPage);


            int totalEntries = _sparepartDal.CountData(filters, dp);
            totalPage = (int)Math.Ceiling((double)totalEntries / rowPerPage);

            LabelShowEntries.Text = $"Showing {inRowPage + 1} to {inRowPage + rowPerPage} of {totalEntries} entries";

            var data = _sparepartDal.ListData(filters, dp)
                .Select((x, index) => new
                {
                    No = inRowPage + index + 1,
                    Id = x.id_sparepart,
                    Image = x.image_data != null ?
                            ImageHelper.GetHighQualityThumbnail(Image.FromStream(new MemoryStream(x.image_data)), 40, 40) :
                            ImageDirectoryHelper._sparepartDefault,
                    NamaSparepart = x.nama_sparepart,
                    Harga = x.harga,
                    Stok = x.stok,
                    StokMinimal = x.stok_minimal,
                    StatusStok = x.status_stok == 0 ? ImageDirectoryHelper._sparepartHabis : 
                                 x.status_stok == 1 ? ImageDirectoryHelper._sparepartMenipis :
                                 ImageDirectoryHelper._sparepartTersedia
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

        //BELUM DIEDIT 

        private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            int Id = (int)GridListData.CurrentRow.Cells["Id"].Value;
            if (Id == 0) return;

            if (MesboxHelper.ShowConfirm("Anda yakin ingin menghapus data ?"))
            {
                _sparepartDal.SoftDeleteData(Id);
                LoadData();
            }
        }

        private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            int Id = (int)GridListData.CurrentRow.Cells["Id"].Value;
            if (Id == 0) return;

        /*    InputPegawaiForm pegawai = new InputPegawaiForm(no_ktp);
            if (pegawai.ShowDialog(this) == DialogResult.OK)
                LoadData();*/
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
          /*  InputPegawaiForm input = new InputPegawaiForm(string.Empty);
            if (input.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }*/
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
