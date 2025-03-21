﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Syncfusion.WinForms.Input.Enums;
using Syncfusion.WinForms.Input;
using System.Windows.Controls;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;


namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class EditBatasBookingForm : Form
    {
        private readonly BatasBookingDal _batasBookingDal;
        private List<DateTime> _tanggalList;

        private int _idBatasBooking = 0;
        private bool _isDefault = false;

        public EditBatasBookingForm( )
        {
            InitializeComponent();
            _batasBookingDal = new BatasBookingDal();
            _tanggalList = new ();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitialComponent();

            DeleteUsingTanggal();
            LoadData();
            CustomDataGrid();
            RegisterControlEvent();
        }


        private void InitialComponent()
        {
            PickerBookingTanggal.Culture = new CultureInfo("id-ID");
            PickerBookingTanggal.ReadOnly = true;
            PickerBookingTanggal.Enabled = true;
            PickerBookingTanggal.MinDateTime = DateTime.Today;
        }

        private void CustomDataGrid()
        {
            GridListData.EnableHeadersVisualStyles = false;
            GridListData.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            GridListData.ColumnHeadersHeight = 50;
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
            GridListData.RowTemplate.Height = 40;

            GridListData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridListData.Columns["No"].FillWeight = 15;
            GridListData.Columns["Tanggal"].FillWeight = 45;
            GridListData.Columns["BatasBooking"].FillWeight = 35;
            GridListData.Columns["BatasBooking"].HeaderText = "Batas Booking";

            GridListData.Columns["BatasBooking"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GridListData.Columns["Id"].Visible = false;
            GridListData.Columns["tgl"].Visible = false;
        }

        private void DeleteUsingTanggal()
        {
            var data = _batasBookingDal.LoadBatasBooking().Select((x => new { Tanggal = x.tanggal }));
           
            foreach (var item in data)
            {
                if (item.Tanggal == null ) continue;

                if (item.Tanggal < DateTime.Today)
                {
                    _batasBookingDal.DeleteUsingTanggal((DateTime)item.Tanggal);
                    ClearData();
                }
            }
        }

        private void LoadData()
        {
            var data = _batasBookingDal.LoadBatasBooking().Select((x, index ) => new
            {
                No = index + 1,
                Id = x.id_batas_booking,
                tgl = x.tanggal,
                Tanggal = x.tanggal?.ToString("dddd, dd-MM-yyyy", new System.Globalization.CultureInfo("id_ID")) ?? "Default",
                BatasBooking = x.batas_booking
            }).ToList();

            GridListData.DataSource = data;

            _tanggalList.Clear();
            foreach ( var item in data )
            {
                if (item.Tanggal != "Default")
                {
                    _tanggalList.Add((DateTime)item.tgl);
                }
            }
        }

        private void GetData(string tanggal)
        {
            var data = _batasBookingDal.GetDataBatasBooking(_idBatasBooking);
            if (data == null) return;

            if (tanggal == "Default")
            {
                PickerBookingTanggal.Enabled = false;
                PickerBookingTanggal.Format = " ";
                _isDefault = true;
            }
            else
            {
                PickerBookingTanggal.Enabled = true;
                PickerBookingTanggal.Format = "dddd,  dd-MM-yyyy";
                PickerBookingTanggal.Value = data.tanggal;
                _isDefault = false;
            }

            TextBatas.Text = data.batas_booking.ToString();
        }

        private void ClearData()
        {
            TextBatas.Clear();
            PickerBookingTanggal.Value = new DateTime(2000, 01, 01);
            PickerBookingTanggal.Enabled = true;
            PickerBookingTanggal.Format = "dddd,  dd-MM-yyyy";
            _idBatasBooking = 0;
        }

        private void SaveData()
        {
            var data = new BatasBookingModel
            {
                id_batas_booking = _idBatasBooking,
                tanggal = _isDefault ? null : PickerBookingTanggal.Value,
                batas_booking = Convert.ToInt32(TextBatas.Text)
            };

            if (_idBatasBooking == 0)
                _batasBookingDal.InsertBatasBooking(data);
            else
                _batasBookingDal.UpdateBatasBooking(data);
        }


        private void RegisterControlEvent()
        {
            ButtonBaru.Click += ButtonBaru_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
            ButtonClose.Click += ButtonClose_Click;
            GridListData.CellDoubleClick += GridListData_CellDoubleClick;
            GridListData.CellMouseClick += GridListData_CellMouseClick;
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            PickerBookingTanggal.DropDownClosed += PickerBookingTanggal_DropDownClosed;
        }

        private DateTime? _datetime = DateTime.Today;

        private void PickerBookingTanggal_DropDownClosed(object? sender, EventArgs e)
        {

            foreach (DateTime date in _tanggalList)
            {
                if (PickerBookingTanggal.Value == date )
                {
                    MesboxHelper.ShowInfo("Tanggal ini sudah terinsert. Silakan pilih tanggal lain");
                    PickerBookingTanggal.Value = _datetime;
                    return;
                }
            }
            _datetime = PickerBookingTanggal.Value;
        }


        private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32(GridListData.CurrentRow.Cells["Id"].Value);
            string tanggal = GridListData.CurrentRow.Cells["Tanggal"].Value?.ToString() ?? "Default";

            if (tanggal == "Default")
            {
                MesboxHelper.ShowWarning("Anda tidak bisa menghapus nilai default!");
                return;

            }               
            if (MesboxHelper.ShowConfirm("Anda yakin ingin menghapus data?"))
            {
                _batasBookingDal.DeleteBatasBooking(id);
                LoadData();
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

        private void GridListData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            string tanggal = GridListData.CurrentRow.Cells["Tanggal"].Value?.ToString() ?? "Default";
            _idBatasBooking = Convert.ToInt32(GridListData.CurrentRow.Cells["Id"].Value);
            GetData(tanggal);
        }

        private void ButtonClose_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (_idBatasBooking == 0 && string.IsNullOrEmpty(TextBatas.Text))
            {
                MesboxHelper.ShowWarning("Semua data wajib diisi!");
                return;
            }
            SaveData();
            LoadData();
            ClearData();
        }

        private void ButtonBaru_Click(object? sender, EventArgs e)
        {
            ClearData();
        }      
    }
}
