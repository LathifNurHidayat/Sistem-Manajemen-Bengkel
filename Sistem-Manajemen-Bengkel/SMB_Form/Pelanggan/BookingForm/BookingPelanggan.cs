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
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal.SessionLogin;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.WinForms.DataGrid.Events;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.BookingForm
{
    public partial class BookingPelanggan : Form
    {
        private readonly KendaraanDal _kendaraanDal;
        private readonly BookingDal _bookingDal;
        private int _IdKendaraan;
        private string _no_ktp;

        public BookingPelanggan()
        {
            InitializeComponent();
            _kendaraanDal = new KendaraanDal();
            _bookingDal = new BookingDal();

            CustomComponentHelper.CustomDataGrid(GridListData);
            PickerBookingTanggal.Culture = new System.Globalization.CultureInfo("id-ID");
            PickerBookingTanggal.MinDateTime = DateTime.Today;
            _no_ktp = SessionLogin._sessionLoginPelanggan.no_ktp_pelanggan;

            LoadDataKendaraan();
            CustomDataGrid(GridListData);
            InitialComboKendaraan();
            InitialDataKendaraan();

            RegisterControlEvent();
        }

        #region KENDARAAN

        private void CustomDataGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grid.Columns["Id_Kendaraan"].Visible = false;

            grid.Columns["No"].FillWeight = 8;
            grid.Columns["NoPolisi"].FillWeight = 17;
            grid.Columns["Merek"].FillWeight = 25;
            grid.Columns["Transmisi"].FillWeight = 10;
            grid.Columns["KapasitasMesin"].FillWeight = 20;
            grid.Columns["Tahun"].FillWeight = 10;


            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle.Padding = new Padding(25, 0, 0, 0);
            }

            grid.Columns["NoPolisi"].HeaderText = "No. Polisi";
            grid.Columns["KapasitasMesin"].HeaderText = "Kapasitas Mesin";
        }

        private void InitialComboKendaraan()
        {
            List<string> transmisi = new List<string>() { "Otomatis", "Manual" };
            ComboTransmisi.DataSource = transmisi;
        }

        private void LoadDataKendaraan()
        {
            var kendaraan = _kendaraanDal.ListDataByNoKtp(SessionLogin._sessionLoginPelanggan.no_ktp_pelanggan).Select((x, index) => new
            {
                No = index + 1,
                Id_Kendaraan = x.id_kendaraan,
                NoPolisi = x.no_polisi,
                Merek = x.merek,
                Transmisi = x.transmisi == 1 ? "Otomatis" : "Manual",
                KapasitasMesin = $"{x.kapasitas_mesin} cc",
                Tahun = x.tahun
            }).ToList();
            GridListData.DataSource = kendaraan;
        }

        private void GetDataKendaraan(int id_kendaraan)
        {
            var data = _kendaraanDal.GetData(id_kendaraan);

            if (data == null) return;
            _IdKendaraan = data.id_kendaraan;
            TextNoPolisi.Text = data.no_polisi;
            TextMerek.Text = data.merek;
            ComboTransmisi.SelectedItem = data.transmisi == 1 ? "Otomatis" : "Manual";
            TextKapasitasMesin.Text = data.kapasitas_mesin.ToString();
            TextTahun.Text = data.tahun.ToString();

        }


        private void SaveDataKendaraan()
        {
            var kendaraan = new KendaraanModel
            {
                id_kendaraan = _IdKendaraan,
                no_ktp_pelanggan = SessionLogin._sessionLoginPelanggan.no_ktp_pelanggan,
                no_polisi = TextNoPolisi.Text,
                merek = TextMerek.Text,
                transmisi = ComboTransmisi.SelectedItem.ToString() == "Otomatis" ? 1 : 2,
                kapasitas_mesin = Convert.ToInt32(TextKapasitasMesin.Text),
                tahun = Convert.ToInt32(TextTahun.Text)
            };

            if (_IdKendaraan == 0)
                _kendaraanDal.InsertData(kendaraan);
            else
                _kendaraanDal.UpdateData(kendaraan);
        }


        private void ClearForm()
        {
            LabelKetEdit.Text = "Input Data";
            _IdKendaraan = 0;
            TextNoPolisi.Clear();
            TextMerek.Clear();
            ComboTransmisi.SelectedIndex = 0;
            TextKapasitasMesin.Clear();
            TextTahun.Clear();
        }

        #endregion



        #region BOOKING

        private void InitialDataKendaraan()
        {
            var data = _kendaraanDal.LoadNamaKendaraan(_no_ktp).Select(x => new
            {
                Id = x.id_kendaraan,
                NamaKendaraan = $"{x.merek} {x.kapasitas_mesin} cc"
            }).ToList();

            data.Insert(0, new { Id = 0, NamaKendaraan = "Pilih Kendaraan" });

            ComboKendaraan.DataSource = data;
            ComboKendaraan.ValueMember = "Id";
            ComboKendaraan.DisplayMember = "NamaKendaraan";
        }

        private void CekKetersediaan(DateTime tanggal)
        {
            var validasiOperasionalBengkel = _bookingDal.CekOperasionalBengkel(tanggal);
            if (validasiOperasionalBengkel != "")
            {
                MesboxHelper.ShowInfo(validasiOperasionalBengkel);
                return;
            }

            var booking = _bookingDal.CekKuotaBooking(tanggal);

            if (booking.AntreanBaru == -1)
            {
                MesboxHelper.ShowInfo($"Mohon Maaf \nKuota booking pada \"{tanggal.ToString("dddd, dd-MM-yyyy", new System.Globalization.CultureInfo("id-ID"))}\" sudah penuh. \nSilahkan pilih hari lain");
                return;
            }

            AntreanForm antreanForm = new AntreanForm(booking.AntreanBaru, booking.AntreanDikerjakan);
            if (antreanForm.ShowDialog() == DialogResult.OK)
            {
                SaveData(booking.AntreanBaru);
                NontifikasiFormHelper nontifikasi = new NontifikasiFormHelper("Booking berhasil");
                nontifikasi.Show();
                ClearForm();
            }
        }


        private void SaveData(int antrean)
        {
            var booking = new BookingModel
            {
                no_ktp_pelanggan = _no_ktp,
                id_kendaraan = (int)ComboKendaraan.SelectedValue,
                id_jasa_servis = null,
                tanggal = PickerBookingTanggal.Value ?? DateTime.Now,
                keluhan = TextKeluhanBooking.Text.Trim(),
                antrean = antrean,
                status = 1
            };

            _bookingDal.InsertData(booking);
        }

        private void ClearFormBooking()
        {
            ComboKendaraan.SelectedIndex = 0;
            TextKeluhanBooking.Clear();
            PickerBookingTanggal.Value = DateTime.Today;
        }

        #endregion


        private void RegisterControlEvent()
        {
            GridListData.CellDoubleClick += GridListData_CellDoubleClick;
            ButtonBaru.Click += ButtonBaru_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
            GridListData.CellMouseClick += GridListData_CellMouseClick;
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            ButtonCekKetersediaan.Click += ButtonCekKetersediaan_Click;
        }

        private void ButtonCekKetersediaan_Click(object? sender, EventArgs e)
        {
            if (ComboKendaraan.SelectedIndex == 0 || string.IsNullOrEmpty(TextKeluhanBooking.Text))
            {
                MesboxHelper.ShowWarning("Mohon lengkapi semua data yang dibutuhkan");
                return;
            }

            DateTime date = (DateTime)PickerBookingTanggal.Value;
            CekKetersediaan(date);
        }

        private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            int id = Convert.ToInt32(GridListData.CurrentRow.Cells["Id_Kendaraan"].Value);
            if (id == 0) return;

            if (MesboxHelper.ShowConfirm("Anda yakin ingin menghapus data ?"))
            {
                _kendaraanDal.SoftDeleteData(id);
                LoadDataKendaraan();
                ClearForm();
            }
        }

        private void GridListData_CellMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                GridListData.ClearSelection();
                GridListData.CurrentCell = GridListData[e.ColumnIndex, e.RowIndex];
                contextMenuStrip.Show(Cursor.Position);
            };
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextNoPolisi.Text) || string.IsNullOrEmpty(TextMerek.Text) || string.IsNullOrEmpty(TextKapasitasMesin.Text) || string.IsNullOrEmpty(TextTahun.Text))
            {
                MesboxHelper.ShowError("Data tidak boleh kosong");
                return;
            }

            if (MesboxHelper.ShowConfirm("Anda yakin ingin menyimpan data ?"))
            {
                SaveDataKendaraan();
                LoadDataKendaraan();
                ClearForm();
            }
        }

        private void ButtonBaru_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void GridListData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(GridListData.CurrentRow.Cells["Id_Kendaraan"].Value);
            if (id == 0) return;

            LabelKetEdit.Text = "Edit Data";
            GetDataKendaraan(id);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
