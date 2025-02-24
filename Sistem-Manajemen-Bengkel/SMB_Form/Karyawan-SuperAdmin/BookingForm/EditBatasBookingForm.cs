using System;
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


namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class EditBatasBookingForm : Form
    {
        private readonly BatasBookingDal _batasBookingDal;
        public EditBatasBookingForm( )
        {
            InitializeComponent();
            _batasBookingDal = new BatasBookingDal();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitialComponent();

            LoadData();
            CustomDataGrid();
            RegisterControlEvent();
        }

        private void LoadData()
        {
            var data = _batasBookingDal.LoadBatasBooking().Select((x, index )=> new
            {
                No = index + 1,
                Id = x.id_batas_booking,
                Tanggal = x.tanggal == null ? "Default" : x.tanggal.ToString(),
                BatasBooking = x.batas_booking
            }).ToList();

            GridListData.DataSource = data;
        }

        private void InitialComponent()
        {
            PickerBookingTanggal.Culture = new CultureInfo("id-ID");
            PickerBookingTanggal.Value = DateTime.Now; 
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

            GridListData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridListData.Columns["No"].FillWeight = 10;
            GridListData.Columns["Id"].FillWeight = 10;
            GridListData.Columns["Tanggal"].FillWeight = 45;
            GridListData.Columns["BatasBooking"].FillWeight = 35;

            GridListData.Columns["BatasBooking"].HeaderText = "Batas Booking";
        }

        private void RegisterControlEvent()
        {
            ButtonBaru.Click += ButtonBaru_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
            ButtonClose.Click += ButtonClose_Click;
            GridListData.CellDoubleClick += GridListData_CellDoubleClick;
        }

        private void GridListData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            string tanggal = (string)GridListData.CurrentRow.Cells["Tanggal"].Value;
            int id = (int)GridListData.CurrentRow.Cells["Id"].Value;

            var data = _batasBookingDal.GetDataBatasBooking(id);
            if (data == null) return;

           // PickerBookingTanggal.Value = tanggal == "Default" ?? null,  : data.tanggal;
            TextBatas.Text = data.batas_booking.ToString();
        }

        private void ButtonClose_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonBaru_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }      
    }
}
