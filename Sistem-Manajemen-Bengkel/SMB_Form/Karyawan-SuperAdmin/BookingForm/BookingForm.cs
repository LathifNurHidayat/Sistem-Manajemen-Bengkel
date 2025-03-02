using System;
using System.Linq;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Globalization;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm;
using Dapper;
using System.Reflection;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class BookingForm : Form
    {
        private readonly BookingDal _bookingDal;
        private readonly BatasBookingDal _batasBookingDal;
        private Timer _timer;

        public BookingForm()
        {
            InitializeComponent();
            _bookingDal = new BookingDal();
            _batasBookingDal = new BatasBookingDal();

            InitialTimer();
            CustomComponent();
            LoadData();
            CustomDataGrid(GridListData);

            RegisterControlEvent();
        }

        private void InitialTimer()
        {
            LabelHariTanggal.Text = DateTime.Now.ToString("dddd, dd - MM - yyyy", new CultureInfo("id-ID"));

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += (s, e) =>
            {
                LabelJam.Text = DateTime.Now.ToString("HH:mm:ss");
            };
            _timer.Start();
        }

        private void CustomComponent()
        {
            List<int> entries = new() { 10, 25, 50, 100 };
            ComboEntries.DataSource = entries;

            List<string> filter = new() { "Hari ini", "Semua (All)"};
            var dataTanggal = _bookingDal.GetDataTanggal();
            filter.AddRange(dataTanggal.Select(x => x.ToString("dd/MM/yyyy")).ToList());
            ComboFilter.DataSource = filter;

            CustomComponentHelper.CustomDataGrid(GridListData);
            CustomComponentHelper.CustomPanel(PanelBooking);

            var tanggal = DateTime.Today.Date;
            TextBatasBooking.Text = _batasBookingDal.ShowBatasBooking(tanggal).ToString();
        }

        public static void CustomDataGrid(DataGridView grid)
        {

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            grid.ScrollBars = ScrollBars.Both;
            grid.Columns["Id"].Visible = false;

            grid.Columns["No"].Width = 100;
            grid.Columns["Tanggal"].Width = 150;
            grid.Columns["Pelanggan"].Width = 300;
            grid.Columns["NoHP"].Width = 150;
            grid.Columns["Kendaraan"].Width = 300;
            grid.Columns["Keluhan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns["Antrean"].Width = 130;
            grid.Columns["Status"].Width = 200;

            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Padding = new Padding(20, 0, 0, 0);
            }

            grid.Columns["No"].HeaderText = "No";
            grid.Columns["Tanggal"].HeaderText = "Tanggal";
            grid.Columns["Pelanggan"].HeaderText = "Pelanggan";
            grid.Columns["NoHP"].HeaderText = "No. HP";
            grid.Columns["Kendaraan"].HeaderText = "Kendaraan";
            grid.Columns["Keluhan"].HeaderText = "Keluhan";
            grid.Columns["Antrean"].HeaderText = "Antrean";
            grid.Columns["Status"].HeaderText = "Status";

            grid.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        int page = 1;
        int totalPage = 0;
        private void LoadData()
        {
            TextPage.Text = page.ToString();
            string search = TextSearch.Text.Trim();
            int rowPerPage = (int)ComboEntries.SelectedValue;
            string filterTanggal = ComboFilter.SelectedIndex == 0 ? DateTime.Today.ToString() : 
                                   ComboFilter.SelectedIndex == 1 ? string.Empty :
                                   ComboFilter.SelectedItem.ToString();
            int inRowPage = (page - 1) * rowPerPage;
            var dp = new DynamicParameters();
            string filters = string.Empty;

            if (!string.IsNullOrEmpty(filterTanggal))
            {
                filters += " WHERE aa.tanggal = CAST(@tanggal AS DATE)";
                dp.Add("@tanggal", DateTime.Parse(filterTanggal));
            }

            if (!string.IsNullOrEmpty(search))
            {
                if (!string.IsNullOrEmpty(filters))
                    filters += " AND";
                else
                    filters += " WHERE";

                filters += @" (bb.no_hp LIKE @Search OR
                       LOWER(COALESCE(bb.nama_pelanggan, aa.nama_pelanggan)) LIKE LOWER(@Search) OR
                       LOWER( CASE 
                               WHEN (aa.merek IS NULL OR aa.merek = '') AND (aa.kapasitas_mesin IS NULL OR aa.kapasitas_mesin = '')
                               THEN CONCAT(COALESCE(dd.merek, ''), ' ', COALESCE(dd.kapasitas_mesin, ''), 'cc')
                               ELSE CONCAT(COALESCE(aa.merek, ''), ' ', COALESCE(aa.kapasitas_mesin, ''), 'cc')
                             END 
                       ) LIKE LOWER(@Search))";

                dp.Add("@Search", $"%{search}%");
            }

            dp.Add("@offset", inRowPage);
            dp.Add("@fetch", rowPerPage);

            int totalEntries = _bookingDal.CountData(filters, dp);
            totalPage = (int)Math.Ceiling((double)totalEntries / rowPerPage);

            LabelShowEntries.Text = $"Showing {inRowPage + 1} to {inRowPage + rowPerPage} of {totalEntries} entries";

            var data = _bookingDal.ListData(filters, dp)
                .Select((x, index) => new
                {
                    Id = x.id_booking,
                    No = inRowPage + index + 1,
                    Tanggal = x.tanggal.ToString("dd/MM/yyyy"),
                    Pelanggan = x.nama_pelanggan,
                    NoHP = x.no_hp,
                    Kendaraan = x.nama_kendaraan,
                    Keluhan = x.keluhan,
                    Antrean = $"Ke - {x.antrean}",
                    Status = x.status == 1 ?
                            ImageDirectoryHelper._statusMenunggu : x.status == 2 ?
                            ImageDirectoryHelper._statusDikerjakan : x.status == 3 ?
                            ImageDirectoryHelper._statusSelesai : ImageDirectoryHelper._statusDibatalkan
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
            ButtonUbahBatasBooking.Click += ButtonUbahBatasBooking_Click;
            GridListData.CellMouseClick += GridListData_CellMouseClick;
            editToolStripMenuItem.Click += EditToolStripMenuItem_Click;
            GridListData.CellDoubleClick += GridListData_CellDoubleClick;
            ComboFilter.SelectedIndexChanged += ComboFilter_SelectedIndexChanged;
        }

        private void ComboFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void GridListData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = (int)GridListData.CurrentRow.Cells["Id"].Value;
            if (id == 0) return;
            ShowFormHelper.ShowFormInPanel(new DetailBookingForm(id));
        }

        private void EditToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            int id = (int)GridListData.CurrentRow.Cells["Id"].Value;
            if (id == 0) return;
            ShowFormHelper.ShowFormInPanel(new DetailBookingForm(id));
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

        private void ButtonUbahBatasBooking_Click(object? sender, EventArgs e)
        {
            EditBatasBookingForm editBatasBookingForm = new EditBatasBookingForm();
            editBatasBookingForm.ShowDialog(this);

            var tanggal = DateTime.Today.Date;
            TextBatasBooking.Text = _batasBookingDal.ShowBatasBooking(tanggal).ToString();
        }

        private void ButtonTambah_Click(object? sender, EventArgs e)
        {
            PilihForm pilihForm = new PilihForm();
            if (pilihForm.ShowDialog() == DialogResult.OK)
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

        private void ComboEntries_SelectedValueChanged(object? sender, EventArgs e)
        {
            page = 1;
            LoadData();
        }
    }
}