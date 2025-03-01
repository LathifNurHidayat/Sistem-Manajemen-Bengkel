using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class DataSparepartForm : Form
    {
        private readonly SparepartDal _sparepartDal;
        private readonly PenggunaanSparepartDal _bookingSparepartDal;
        private readonly BookingDal _bookingDal;

        private BindingList<SparepartDto> _sparepartAll;
        private BindingList<SparepartDto> _sparepartRequired;

        private BindingSource bsAll;
        private BindingSource bsRequired;

        private int _idBooking;

        public DataSparepartForm(int id_booking)
        {
            InitializeComponent();
            _sparepartDal = new SparepartDal();
            _bookingSparepartDal = new PenggunaanSparepartDal();
            _bookingDal = new BookingDal();

            _sparepartAll = new BindingList<SparepartDto>();
            _sparepartRequired = new BindingList<SparepartDto>();

            bsAll = new BindingSource { DataSource = _sparepartAll };
            GridListSparepart.DataSource = bsAll;

            bsRequired = new BindingSource { DataSource = _sparepartRequired };
            GridListSparepartUse.DataSource = bsRequired;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            _idBooking = id_booking;
            GetData(id_booking);
            LoadData();
            CustomDataGrid(GridListSparepart);
            CustomDataGrid(GridListSparepartUse);

            RegisterControlEvent();
        }

        private void CustomDataGrid(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            grid.ColumnHeadersHeight = 50;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            grid.DefaultCellStyle.Font = new Font("Arial", 10);
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            grid.RowHeadersVisible = false;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AllowUserToResizeRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.RowTemplate.Height = 40; grid.ReadOnly = false;
            grid.AllowUserToAddRows = false;  

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.Columns["IdBookingSparepart"].Visible = false;


            if (grid.Name == "GridListSparepart")
            {
                grid.ReadOnly = true;

                grid.Columns["IdSparepart"].FillWeight = 15;
                grid.Columns["NamaSparepart"].FillWeight = 40;
                grid.Columns["Stok"].FillWeight = 10;
                grid.Columns["Harga"].FillWeight= 35;

                grid.Columns["Stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                grid.Columns["Harga"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid.Columns["Jumlah"].Visible = false;
                grid.Columns["TotalHarga"].Visible = false;
                grid.Columns["IdSparepart"].Visible = false;
            }
            else if (grid.Name == "GridListSparepartUse")
            {
                grid.Columns["NamaSparepart"].ReadOnly = true;
                grid.Columns["TotalHarga"].ReadOnly = true;

                grid.Columns["IdSparepart"].FillWeight = 15;
                grid.Columns["NamaSparepart"].FillWeight = 40;
                grid.Columns["Jumlah"].FillWeight = 15;
                grid.Columns["TotalHarga"].FillWeight = 35;

                grid.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns["TotalHarga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                grid.Columns["TotalHarga"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grid.Columns["Stok"].Visible = false;
                grid.Columns["Harga"].Visible = false;
                grid.Columns["IdSparepart"].Visible = false;
            }

            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (col.Name == "Jumlah" || col.Name == "Stok")
                    continue;

                col.DefaultCellStyle.Padding = new Padding(20, 0, 20, 0);
            }

            grid.ResumeLayout();
        }


        private void LoadData()
        {
            _sparepartAll.Clear();
            string filter = TextSearch.Text.Trim();

            var sparepart = _sparepartDal.ListSparepart(filter)
                .Select(x => new SparepartDto
                {
                    IdSparepart = x.id_sparepart,
                    NamaSparepart = x.nama_sparepart,
                    Stok = x.stok,
                    Harga = x.harga,
                });

            if (sparepart == null) return;

            foreach (var item in sparepart)
                _sparepartAll.Add(item);

            bsAll.ResetBindings(false);
        }

        private void GetData(int id_booking_sparepart)
        {
            _sparepartRequired.Clear();

            var data = _bookingSparepartDal.GetData(id_booking_sparepart).Select(x => new SparepartDto
            {
                IdBookingSparepart = x.id_penggunaan_sparepart,
                IdSparepart = x.id_sparepart,
                NamaSparepart = x.nama_sparepart,
                Stok = x.stok,
                Harga = x.harga,
                Jumlah = x.jumlah,
                TotalHarga = x.total_harga
            });

            if (data == null) return;

            foreach (var item in data)
                _sparepartRequired.Add(item);
        }

        public void SaveData()
        {
            _bookingSparepartDal.DeleteData(_idBooking);

            foreach (var item in _sparepartRequired)
            {
                var bookingSparepart = new PenggunaanSparepartModel
                {
                    id_penggunaan_sparepart = _idBooking,
                    id_sparepart = item.IdSparepart,
                    jumlah = item.Jumlah,
                    total_harga = item.TotalHarga
                };
                if (bookingSparepart == null) return;

                _bookingSparepartDal.InsertData(bookingSparepart);
            }
        }

        private void RegisterControlEvent()
        {
            GridListSparepart.CellDoubleClick += GridListSparepart_CellDoubleClick;
            GridListSparepartUse.CellValueChanged += GridListSparepartUse_CellValueChanged;
            GridListSparepartUse.CellBeginEdit += GridListSparepartUse_CellBeginEdit;
            GridListSparepartUse.CellDoubleClick += GridListSparepartUse_CellDoubleClick;
            GridListSparepartUse.CellValidating += GridListSparepartUse_CellValidating;

            TextSearch.TextChanged += TextSearch_TextChanged;
            ButtonSearch.Click += ButtonSearch_Click;
            TextSearch.KeyDown += TextSearch_KeyDown;

            ButtonBatal.Click += ButtonBatal_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
        }


        private async void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            SaveData();
            this.DialogResult = DialogResult.OK;
        }


        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void TextSearch_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ButtonSearch.PerformClick();
        }

        private void ButtonSearch_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextSearch.Text))
                LoadData();
        }

        private async void TextSearch_TextChanged(object? sender, EventArgs e)
        {   
            if (TextSearch.Text.Length == 0)
                LoadData();
        }

        private void GridListSparepartUse_CellValidating(object? sender, DataGridViewCellValidatingEventArgs e)
        {
            if (GridListSparepartUse.Columns[e.ColumnIndex].Name == "Jumlah")
            {
                string input = e.FormattedValue.ToString();
                if (!int.TryParse(input, out int output))
                {
                    MesboxHelper.ShowError("Input harus berupa angka");
                    e.Cancel = true;
                }
            }
        }

        private void GridListSparepart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedSparepart = (SparepartDto)GridListSparepart.Rows[e.RowIndex].DataBoundItem;

            if (selectedSparepart.Stok == 0)
            {
                MesboxHelper.ShowError("Mohon maaf \nStok sparepart tidak tersedia");
                return;
            }

            if (_sparepartRequired.Any(s => s.IdSparepart == selectedSparepart.IdSparepart))
            {
                MesboxHelper.ShowError("Sparepart sudah ditambahkan");
                return;
            }

            var sp = new SparepartDto
            {
                IdSparepart = selectedSparepart.IdSparepart,
                NamaSparepart = selectedSparepart.NamaSparepart,
                Harga = selectedSparepart.Harga,
                Stok = selectedSparepart.Stok,
                Jumlah = 1,
                TotalHarga = selectedSparepart.Harga
            };

            _sparepartRequired.Add(sp);
            bsRequired.ResetBindings(false);
        }


        private int _lastJumlah;
        private void GridListSparepartUse_CellBeginEdit(object? sender, DataGridViewCellCancelEventArgs e)
        {
            var sparepart = (SparepartDto)GridListSparepartUse.Rows[e.RowIndex].DataBoundItem;
            _lastJumlah = sparepart.Jumlah;
        }

        private void GridListSparepartUse_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var sparepart = (SparepartDto)GridListSparepartUse.Rows[e.RowIndex].DataBoundItem;

            if (sparepart.Jumlah > sparepart.Stok)
            {
                sparepart.Jumlah = _lastJumlah;
                MesboxHelper.ShowError("Jumlah yang dimasukkan melebihi stok yang tersedia.");
            }

            sparepart.TotalHarga = sparepart.Harga * sparepart.Jumlah;
            bsRequired.ResetBindings(false);
        }

        private void GridListSparepartUse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var sparepart = (SparepartDto)GridListSparepartUse.Rows[e.RowIndex].DataBoundItem;
            _sparepartRequired.Remove(sparepart);
            bsRequired.ResetBindings(false);
        }

        public class SparepartDto
        {
            public int IdBookingSparepart {  get; set; }


            public int IdSparepart { get; set; }
            public string NamaSparepart { get; set; }
            public int Stok { get; set; }
            public decimal Harga { get; set; }


            public int Jumlah { get; set; }
            public decimal TotalHarga { get; set; }
        }
    }
}
