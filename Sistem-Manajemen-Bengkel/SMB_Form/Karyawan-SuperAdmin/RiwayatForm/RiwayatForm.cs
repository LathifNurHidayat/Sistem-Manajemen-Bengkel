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
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.RiwayatForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class RiwayatForm : Form
    {
        private readonly RiwayatDal _riwayatDal;
        private bool _isCustomShow = false;
        public RiwayatForm()
        {
            InitializeComponent();
            _riwayatDal = new RiwayatDal();

            CustomComponent();
            LoadData();
            CustomDataGrid(GridListData);
            RegisterControlEvent();

            if (SessionLoginHelper._sessionLoginPegawai.role == "Petugas")
            {
                ButtonEksport.Visible = false;
            }
        }

        private void CustomComponent()
        {
            List<string> tanggal = new() {"Hari ini", "Semua (All)", "7 hari terakhir", "30 hari terakhir" , "Custom"};
            ComboFilter.DataSource = tanggal;

            List<int> entries = new() { 10, 25, 50, 100 };
            ComboEntries.DataSource = entries;

            CustomComponentHelper.CustomDataGrid(GridListData);
            CustomComponentHelper.CustomPanel(PanelBooking);

            PickerFilter1.Value = DateTime.Today;
            PickerFilter1.Format = "dd MMMM yyyy";
            PickerFilter1.Culture = new System.Globalization.CultureInfo("id-ID");

            PickerFilter2.Value = DateTime.Today;
            PickerFilter2.Format = "dd MMMM yyyy";
            PickerFilter2.Culture = new System.Globalization.CultureInfo("id-ID");
        }


        public static void CustomDataGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            grid.Columns["No"].Width = 70;
            grid.Columns["Tanggal"].Width = 150;
            grid.Columns["NoKTP"].Width = 150;
            grid.Columns["Pelanggan"].Width = 200;
            grid.Columns["Petugas"].Width = 150;
            grid.Columns["Mekanik"].Width = 150;
            grid.Columns["NoPolisi"].Width = 120;
            grid.Columns["Kendaraan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns["Keluhan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns["Catatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns["TotalBiaya"].Width = 150;
            grid.Columns["Status"].Width = 200;



            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Padding = new Padding(15, 0, 0, 0);
            }

            grid.Columns["NoKTP"].HeaderText = "No KTP";
            grid.Columns["Pelanggan"].HeaderText = "Nama Pelanggan";
            grid.Columns["NoPolisi"].HeaderText = "No Polisi";
            grid.Columns["TotalBiaya"].HeaderText = "Total Biaya";

        }



        int page = 1;
        int totalPage = 0;
        private void LoadData()
        {
            TextPage.Text = page.ToString();
            string search = TextSearch.Text.Trim();
            int rowPerPage = (int)ComboEntries.SelectedValue;
            string filterTanggal = ComboFilter.SelectedIndex == 0 ? DateTime.Today.ToString("yyyy-MM-dd") :
                                   ComboFilter.SelectedIndex == 1 ? string.Empty :
                                   ComboFilter.SelectedItem?.ToString() ?? string.Empty;
            string comboFilter = ComboFilter.SelectedItem?.ToString() ?? string.Empty;

            DateTime tanggal_1 = PickerFilter1.Value ?? DateTime.Today;
            DateTime tanggal_2 = PickerFilter2.Value ?? DateTime.Today;

            int inRowPage = (page - 1) * rowPerPage;
            var dp = new DynamicParameters();
            string filters = string.Empty;

            if (!string.IsNullOrEmpty(filterTanggal) && DateTime.TryParse(filterTanggal, out DateTime parsedDate))
            {
                if (!string.IsNullOrEmpty(filters))
                    filters += " AND";
                else
                    filters += " WHERE";
                
                switch (comboFilter)
                {
                    case "Hari ini":
                        filters += " aa.tanggal = CAST(@tanggal AS DATE)";
                        dp.Add("@tanggal", parsedDate, DbType.Date);
                        break;
                    case "7 hari terakhir":
                        filters += " aa.tanggal BETWEEN CAST(@tanggal_1 AS DATE) AND CAST(@tanggal_2 AS DATE)";
                        dp.Add("@tanggal_1", DateTime.Today.AddDays(-7), DbType.Date);
                        dp.Add("@tanggal_2", DateTime.Today, DbType.Date);
                        break;
                    case "30 hari terakhir":
                        filters += " aa.tanggal BETWEEN CAST(@tanggal_1 AS DATE) AND CAST(@tanggal_2 AS DATE)";
                        dp.Add("@tanggal_1", DateTime.Today.AddDays(-30), DbType.Date);
                        dp.Add("@tanggal_2", DateTime.Today, DbType.Date);
                        break;
                    default:
                        filters += "";
                        break;
                }
            }

            if (_isCustomShow)
            {
                if (!string.IsNullOrEmpty(filters))
                    filters += " AND";
                else
                    filters += " WHERE";

                filters += " aa.tanggal BETWEEN CAST(@tanggal_1 AS DATE) AND CAST(@tanggal_2 AS DATE)";
                dp.Add("@tanggal_1", tanggal_1, DbType.Date);
                dp.Add("@tanggal_2", tanggal_2, DbType.Date);
            }

            if (!string.IsNullOrEmpty(search))
            {
                if (!string.IsNullOrEmpty(filters))
                    filters += " AND";
                else
                    filters += " WHERE";

                filters += @" (aa.no_ktp_pelanggan LIKE @Search OR bb.jenis_servis LIKE @Search OR dd.nama_pegawai LIKE @Search OR
                               ee.nama_mekanik LIKE @Search OR COALESCE (ff.no_polisi, aa.no_polisi) LIKE @Search OR
                               aa.keluhan LIKE @Search OR aa.catatan LIKE @Search OR CAST(aa.total_biaya AS VARCHAR) LIKE @Search OR
                         COALESCE(cc.nama_pelanggan, aa.nama_pelanggan) LIKE @Search OR
                         CASE 
                            WHEN (aa.merek IS NULL OR aa.merek = '') AND (aa.kapasitas_mesin IS NULL OR aa.kapasitas_mesin = '')
                            THEN CONCAT(COALESCE(ff.merek, ''), ' ', COALESCE(ff.kapasitas_mesin, ''), 'cc')
                            ELSE CONCAT(COALESCE(aa.merek, ''), ' ', COALESCE(aa.kapasitas_mesin, ''), 'cc')
                          END LIKE LOWER(@Search))";

                dp.Add("@Search", $"%{search}%");
            } 

            dp.Add("@offset", inRowPage, DbType.Int32);
            dp.Add("@fetch", rowPerPage, DbType.Int32);

            int totalEntries = _riwayatDal.CountData(filters, dp);
            totalPage = (int)Math.Ceiling((double)totalEntries / rowPerPage);

            LabelShowEntries.Text = $"Showing {inRowPage + 1} to {Math.Min(inRowPage + rowPerPage, totalEntries)} of {totalEntries} entries";

            var data = _riwayatDal.ListData(filters, dp)
                .Select((x, index) => new
                {
                    No = inRowPage + index + 1,
                    Tanggal = x.tanggal.ToString("dd/MM/yyyy"),
                    NoKTP = x.no_ktp_pelanggan ?? "[Tamu]",
                    Pelanggan = x.nama_pelanggan,
                    Petugas = x.nama_pegawai,
                    Mekanik = x.nama_mekanik,
                    NoPolisi = x.no_polisi,
                    Kendaraan = x.nama_kendaraan,
                    Keluhan = x.keluhan ?? "-",
                    Catatan = x.catatan ?? "-",
                    TotalBiaya = string.Format(new System.Globalization.CultureInfo("id-ID"), "Rp{0:N0}", x.total_biaya) ?? "-",
                    Status = x.status == 1 ? ImageDirectoryHelper._statusSelesai : ImageDirectoryHelper._statusDibatalkan
                }).ToList();

            
            GridListData.DataSource = data;
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
            PickerFilter1.ValueChanged += PickerFilter_ValueChanged;
            PickerFilter2.ValueChanged += PickerFilter_ValueChanged;
            ButtonEksport.Click += ButtonEksport_Click;
        }

        private void ButtonEksport_Click(object? sender, EventArgs e)
        {
            SetPrintLaporanForm setPrintLaporanForm = new SetPrintLaporanForm();
            if (setPrintLaporanForm.ShowDialog() == DialogResult.OK)
            {
                NontifikasiFormHelper nontifikasi = new NontifikasiFormHelper("Laporan berhasil disimpan");
                nontifikasi.Show();
            }
        }

        private void PickerFilter_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            ComboFilter.SelectedItem = "Custom";
            _isCustomShow = true;
            page = 1;
            LoadData();
        }

      

        private void ButtonTambah_Click(object? sender, EventArgs e)
        {
            InputPegawaiForm input = new InputPegawaiForm(string.Empty);
            if (input.ShowDialog(this) == DialogResult.OK)
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
            if (ComboFilter.SelectedItem == "Custom")
                _isCustomShow = true;
            else
                _isCustomShow = false;

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
