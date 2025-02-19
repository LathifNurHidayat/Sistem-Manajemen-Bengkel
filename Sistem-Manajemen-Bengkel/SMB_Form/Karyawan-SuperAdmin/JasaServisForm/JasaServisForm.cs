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
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.Windows.Forms.Tools;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class JasaServisForm : Form
    {
        private readonly JasaServisDal _jasaServisDal;

        public JasaServisForm()
        {
            InitializeComponent();
            _jasaServisDal = new JasaServisDal();

            CustomComponent();
            LoadData();
            CustomDataGrid(GridListData);
            RegisterControlEvent();
        }

        private void CustomComponent()
        {
            List<int> entries = new() { 10, 25, 50, 100 };
            ComboEntries.DataSource = entries;
            List<string> sortBy = new() { "Semua (All)", "Termurah", "Termahal" };
            ComboFilter.DataSource = sortBy;
            CustomComponentHelper.CustomDataGrid(GridListData);
            CustomComponentHelper.CustomPanel(PanelBooking);
        }

        public static void CustomDataGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.Columns["No"].FillWeight = 5;
            grid.Columns["Id"].FillWeight = 10;
            grid.Columns["Jenis"].FillWeight = 25;
            grid.Columns["Keterangan"].FillWeight = 35;
            grid.Columns["Biaya"].FillWeight = 15;

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Padding = new Padding(25, 0, 0, 0);
            }

            grid.Columns["No"].HeaderText = "No";
            grid.Columns["Id"].HeaderText = "ID Servis";
            grid.Columns["Jenis"].HeaderText = "Jenis Servis";
            grid.Columns["Keterangan"].HeaderText = "Keterangan";
            grid.Columns["Biaya"].HeaderText = "Biaya (Rp)";

            grid.Columns["Biaya"].DefaultCellStyle.Format = "N0"; 
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
            string order = string.Empty;

            if (!string.IsNullOrEmpty(search))
            {
                dp.Add("@Search", $"%{search}%");
                filters = @" AND (jenis_servis LIKE @Search OR 
                                  keterangan LIKE @Search OR 
                                  biaya LIKE @Search) ";
            }

            if (ComboFilter.SelectedItem == "Termurah")
                order += " biaya ASC ";
            else if (ComboFilter.SelectedItem == "Termahal")
                order += " biaya DESC ";
            else
                order += " id_jasa_servis ASC";

            dp.Add("@offset", inRowPage);
            dp.Add("@fetch", rowPerPage);

            int totalEntries = _jasaServisDal.CountData(filters, dp);
            totalPage = (int)Math.Ceiling((double)totalEntries / rowPerPage);

            LabelShowEntries.Text = $"Showing {inRowPage + 1} to {inRowPage + rowPerPage} of {totalEntries} entries";

            var data = _jasaServisDal.ListData(filters, order, dp)
                .Select((x, index) => new
                {
                    No = inRowPage + index + 1,
                    Id =  x.id_jasa_servis,
                    Jenis = x.jenis_servis,
                    Keterangan = x.keterangan,
                    Biaya = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp{0:N0}", x.biaya),
                }).ToList();

            GridListData.DataSource = data;
        }

        private void ClearForm()
        {
            TextIdJasaServis.Clear();
            TextJenisServis.Clear();
            TextKeterangan.Clear();
            TextBiaya.Clear();
        }

        private void GetData(int Id)
        {
            var jasaServis = _jasaServisDal.GetData(Id);
            if (jasaServis == null) return;

            TextIdJasaServis.Text = jasaServis.id_jasa_servis.ToString();
            TextJenisServis.Text = jasaServis.jenis_servis;
            TextBiaya.Text = jasaServis.biaya.ToString();
            TextKeterangan.Text = jasaServis.keterangan;
        }

        private void SaveData()
        {
            var jasaServis = new JasaServisModel
            {
                id_jasa_servis =  string.IsNullOrEmpty(TextIdJasaServis.Text) ? 0 : Convert.ToInt32(TextIdJasaServis.Text),
                jenis_servis = TextJenisServis.Text, 
                keterangan = TextKeterangan.Text, 
                biaya = (decimal)TextBiaya.DecimalValue,
            };

            if (string.IsNullOrEmpty(TextIdJasaServis.Text))
                _jasaServisDal.InsertData(jasaServis);
            else
                _jasaServisDal.UpdateData(jasaServis);
        }

        private void RegisterControlEvent() 
        {
            ComboEntries.SelectedValueChanged += ComboEntries_SelectedValueChanged;
            ComboFilter.SelectedValueChanged += ComboFilter_SelectedIndexChanged;
            ButtonNext.Click += ButtonNext_Click;
            ButtonPreviuos.Click += ButtonPreviuos_Click;
            ButtonSearch.Click += ButtonSearch_Click;
            TextSearch.TextChanged += TextSearch_TextChanged;
            TextSearch.KeyDown += TextSearch_KeyDown;
            GridListData.CellMouseClick += GridListData_CellMouseClick;
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            GridListData.CellDoubleClick += GridListData_CellContentDoubleClick;
            ButtonBaru.Click += ButtonBaru_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;


        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Anda yakin ingin menyimpan data?"))
            {
                MessageBox.Show(TextBiaya.DecimalValue.ToString());
                SaveData();
                LoadData();
                ClearForm();
                NontifikasiFormHelper nontifikasiForm = new NontifikasiFormHelper("Data berhasil disimpan");
                nontifikasiForm.ShowDialog(this);
            }
        }

        private void ButtonBaru_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void GridListData_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(GridListData.CurrentRow?.Cells["Id"]?.Value);
            if (ID == 0) return;
            
            ClearForm();
            GetData(ID);
        }

        private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            int ID = Convert.ToInt32(GridListData.CurrentRow?.Cells["Id"]?.Value);
            if (ID == 0) return;
            if (MesboxHelper.ShowConfirm("Anda yakin ingin menghapus data ?"))
            {
                _jasaServisDal.SoftDeleteData(ID);
                LoadData();
                ClearForm();
                NontifikasiFormHelper nontifikasiForm = new NontifikasiFormHelper("Data berhasil dihapus");
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
