using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.DashboardForm
{
    public partial class JadwalLiburForm : Form
    {
        private readonly JadwalLiburDal _jadwalLiburDal;

        public JadwalLiburForm()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            _jadwalLiburDal = new JadwalLiburDal();
            PickerBookingTanggal.Culture = new System.Globalization.CultureInfo("id-ID");

            GetData();
            RegisterControlEvent();
            CustomDataGrid();
        }


        private void CustomDataGrid()
        {
            GridListData.EnableHeadersVisualStyles = false;
            GridListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            GridListData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            GridListData.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            GridListData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GridListData.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray;
            GridListData.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            GridListData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            GridListData.DefaultCellStyle.Font = new Font("Arial", 10);
            GridListData.DefaultCellStyle.ForeColor = Color.Black;
            GridListData.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
            GridListData.DefaultCellStyle.SelectionForeColor = Color.Black;
            GridListData.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            GridListData.RowHeadersVisible = false;
            GridListData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            GridListData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridListData.MultiSelect = false;
            GridListData.AllowUserToResizeRows = false;
            GridListData.AllowUserToOrderColumns = false;
            GridListData.ColumnHeadersHeight = 40;
            GridListData.RowTemplate.Height = 40;

            GridListData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridListData.Columns["tanggal_libur"].FillWeight = 100;

            GridListData.Columns["tanggal_libur"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            GridListData.Columns["tanggal_libur"].HeaderText = "Tanggal Libur";

            GridListData.Columns["id_jadwal_libur"].Visible = false;
            GridListData.Columns["is_libur"].Visible = false;
            GridListData.Columns["hari"].Visible = false;
            GridListData.Refresh();

        }

        private void GetData()
        {
            var data = _jadwalLiburDal.ListData();
            if (data == null) return;

            var hariCekBox = new Dictionary<string, CheckBox>(StringComparer.OrdinalIgnoreCase)
            {
                { "Senin", ComboSenin },
                { "Selasa", ComboSelasa },
                { "Rabu", ComboRabu },
                { "Kamis", ComboKamis },
                { "Jumat", ComboJumat },
                { "Sabtu", ComboSabtu },
                { "Minggu", ComboMinggu }
            };

            foreach (var hari in hariCekBox.Keys)
            {
                var dataHari = data.FirstOrDefault(x => x.hari.Equals(hari, StringComparison.OrdinalIgnoreCase));
                hariCekBox[hari].Checked = dataHari != null && dataHari.is_libur == 1;
            }
            
            LoadData();
        }

        private void LoadData()
        {
            var data = _jadwalLiburDal.ListData();
            if (data == null) return;

            GridListData.DataSource = data.Where(x => x.hari == null).ToList();
        }

        private void InsertDataBaru()
        {
            var DataTanggal = new JadwalLiburModel
            {
                tanggal_libur = PickerBookingTanggal.Value,
                is_libur = 1
            };
            if (DataTanggal == null) return;

            _jadwalLiburDal.InsertData(DataTanggal);
        }

        private void UpdateDataHari()
        {
            var hariCheckBox = new Dictionary<string, CheckBox>(StringComparer.OrdinalIgnoreCase)
            {
                { "Senin", ComboSenin },
                { "Selasa", ComboSelasa },
                { "Rabu", ComboRabu },
                { "Kamis", ComboKamis },
                { "Jumat", ComboJumat },
                { "Sabtu", ComboSabtu },
                { "Minggu", ComboMinggu }
            };

            var data = _jadwalLiburDal.ListData();

            foreach (var kvp in hariCheckBox)
            {
                string hari = kvp.Key;
                bool isChecked = kvp.Value.Checked;
                int is_libur = isChecked ? 1 : 0;

                var DataHari = data.FirstOrDefault(x => x.hari.Equals(hari, StringComparison.OrdinalIgnoreCase));
                if (DataHari != null)
                    _jadwalLiburDal.UpdateDataDefault(hari, is_libur);
            }
        }

        private void RegisterControlEvent()
        {
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
            ButtonTambahkan.Click += ButtonTambahkan_Click;
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            GridListData.CellMouseClick += GridListData_CellMouseClick;
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

        private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (MesboxHelper.ShowConfirm("Ada yakin ingin menghapus data ?"))
            {
                int id = Convert.ToInt32(GridListData.CurrentRow.Cells["id_jadwal_libur"].Value);

                _jadwalLiburDal.DeleteData(id);
                LoadData();
            }
        }

        private void ButtonTambahkan_Click(object? sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridListData.Rows)
            {
                if (row.Cells["tanggal_libur"].Value is DateTime tanggalLibur)
                {
                    if (tanggalLibur.Date == PickerBookingTanggal?.Value?.Date)
                    {
                        MesboxHelper.ShowError("Tanggal ini sudah terdaftar. Silakan pilih tanggal lain.");
                        return;
                    }
                }
            }


            InsertDataBaru();
            LoadData();
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            UpdateDataHari();
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
