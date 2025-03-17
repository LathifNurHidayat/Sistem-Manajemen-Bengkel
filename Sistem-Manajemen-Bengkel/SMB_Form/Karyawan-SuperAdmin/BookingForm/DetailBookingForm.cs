using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal.SessionLogin;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.Windows.Forms.Tools;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class DetailBookingForm : Form
    {
        private readonly BookingDal _bookingDal;
        private readonly RiwayatDal _riwayatDal;
        private readonly JasaServisDal _jasaServisDal;
        private readonly MekanikDal _mekanikDal;
        private readonly PenggunaanSparepartDal _penggunaanSparepartDal;
        private readonly InvoiceDal _invoiceDal;

        private BookingModel _bookingData;
        private int _statusBooking;
        private int _idBooking;

        public DetailBookingForm(int id_booking)
        {
            InitializeComponent();
            _bookingDal = new BookingDal();
            _riwayatDal = new RiwayatDal();
            _jasaServisDal = new JasaServisDal();
            _mekanikDal = new MekanikDal();
            _penggunaanSparepartDal = new PenggunaanSparepartDal();
            _invoiceDal = new InvoiceDal();

            _idBooking = id_booking;

            InitialComboBox();
            GetData(id_booking);
            CustomComponentHelper.CustomPanel(panel1);
            RegisterControlEvent();
        }


        private void InitialComboBox()
        {
            var mekanik = _mekanikDal.ListMekanik().Select(x => new { x.no_ktp_mekanik, x.nama_mekanik }).ToList();
            mekanik.Insert(0, new { no_ktp_mekanik = "", nama_mekanik = "Pilih Mekanik" });

            var jasaServis = _jasaServisDal.ListJasaServis().Select(x => new { x.id_jasa_servis, x.jenis_servis }).ToList();
            jasaServis.Insert(0, new { id_jasa_servis = 0, jenis_servis = "Pilih Jenis Servis" });

            ComboMekanik.DisplayMember = "nama_mekanik";
            ComboMekanik.ValueMember = "no_ktp_mekanik";
            ComboMekanik.DataSource = mekanik;

            ComboJenisServis.DisplayMember = "jenis_servis";
            ComboJenisServis.ValueMember = "id_jasa_servis";
            ComboJenisServis.DataSource = jasaServis;
        }


        private void GetData(int id_booking)
        {
             _bookingData = _bookingDal.GetData(id_booking);
            if (_bookingData == null) return;

            _statusBooking = _bookingData.status;

            LabelAntreanAnda.Text = _bookingData.antrean.ToString();
            LabelIdBooking.Text = _bookingData.id_booking.ToString();
            LabelNama.Text = $": {_bookingData.nama_pelanggan}";
            LabelNoKTP.Text = $": {(string.IsNullOrEmpty(_bookingData.no_ktp_pelanggan) ? "[ Tamu ]" : _bookingData.no_ktp_pelanggan)}";
            LabelNoPol.Text = $": {_bookingData.no_polisi}";
            LabelKendaraan.Text = $": {_bookingData.nama_kendaraan}";
            LabelTanggal.Text = $": {_bookingData.tanggal:dd MMMM yyyy}";
            LabelKeluhan.Text = $": {_bookingData.keluhan}";

            ComboMekanik.SelectedValue = string.IsNullOrEmpty(_bookingData.no_ktp_mekanik) ? "" : _bookingData.no_ktp_mekanik;
            ComboJenisServis.SelectedValue = _bookingData.id_jasa_servis ?? 0;
            TextSparepart.Text = _bookingData.nama_sparepart;
            TextCatatan.Text = _bookingData.catatan;

            
            if (_bookingData.status == 2)
            {
                progres1.BackColor = System.Drawing.Color.LimeGreen;
                progresDikerjakan.BackColor = System.Drawing.Color.LimeGreen;

                ButtonAksi.BackColor = System.Drawing.Color.Green;
                ButtonAksi.Text = "Selesai";
            }
            else if (_bookingData.status == 3)
            {
                progres1.BackColor = System.Drawing.Color.LimeGreen;
                progresDikerjakan.BackColor = System.Drawing.Color.LimeGreen;

                progres2.BackColor = System.Drawing.Color.LimeGreen;
                progresSelesai.BackColor = System.Drawing.Color.LimeGreen;

                ButtonAksi.BackColor = System.Drawing.Color.Goldenrod;
                ButtonAksi.Text = "📤 Invoice";

                ComboMekanik.Enabled = false;
                ComboJenisServis.Enabled = false;

                ButtonSparepart.Enabled = false;
                TextCatatan.ReadOnly = true;
            }
            else if (_bookingData.status == 4)
            { 
                PictureSelesai.Image = Properties.Resources.cancelled;
                LabelSelesai.Text = "Dibatalkan";

                progres1.BackColor = System.Drawing.Color.Red;
                progresDikerjakan.BackColor = System.Drawing.Color.Red;

                progresMenunggu.BackColor = System.Drawing.Color.Red;

                progres2.BackColor = System.Drawing.Color.Red;
                progresSelesai.BackColor = System.Drawing.Color.Red;

                ButtonAksi.Visible = false;
                ButtonBatalkanBooking.Visible = false;
                ButtonBack.Location = ButtonAksi.Location;

                ComboMekanik.Enabled = false;
                ComboJenisServis.Enabled = false;

                ButtonSparepart.Enabled = false;
                TextCatatan.ReadOnly = true;
            }
        }

        private void RefreshSparepart(int id)
        {
            var sparepartList = _penggunaanSparepartDal.GetSparepart(id);

            if (sparepartList == null)
            {
                TextSparepart.Clear();
                return;
            }
                TextSparepart.Text = sparepartList.nama_sparepart;
        }


        private void SaveData()
        {
            var booking = new BookingModel
            {
                id_booking = _idBooking,
                no_ktp_mekanik = (string)ComboMekanik.SelectedValue ?? "",
                id_jasa_servis = (int)ComboJenisServis.SelectedValue == 0 ? 0 : (int)ComboJenisServis.SelectedValue,
                id_penggunaan_sparepart =  _idBooking,
                catatan = TextCatatan.Text,
                status = _statusBooking + 1
            };
            _bookingDal.UpdateData(booking);
        }

        private void InsertRiwayat( bool isClear)
        {
            if (_bookingData == null) return;

            var riwayat = new RiwayatModel
            {
                id_jasa_servis = _bookingData.id_jasa_servis ?? 0,
                no_ktp_pelanggan = _bookingData.no_ktp_pelanggan,
                no_ktp_pegawai = SessionLogin._sessionLoginPegawai.no_ktp_pegawai,
                no_ktp_mekanik = _bookingData.no_ktp_mekanik ?? "",
                id_kendaraan = _bookingData.id_kendaraan ?? 0,
                id_penggunaan_sparepart = _bookingData.id_booking,
                nama_pelanggan = string.IsNullOrEmpty(_bookingData.no_ktp_pelanggan) ?  _bookingData.nama_pelanggan : null,
                no_polisi = _bookingData.id_kendaraan == 0 ? _bookingData.no_polisi : null,
                merek = _bookingData.id_kendaraan == 0 ? _bookingData.merek : null,
                transmisi = _bookingData.id_kendaraan == 0 ? _bookingData.transmisi : null,
                kapasitas_mesin = _bookingData.id_kendaraan == 0 ? _bookingData.kapasitas_mesin : null,
                keluhan = _bookingData.keluhan,
                catatan = _bookingData.catatan,
                status = isClear ? 1 : 2
            };
            _riwayatDal.InsertData(riwayat);

        }

        private void RegisterControlEvent()
        {
            ButtonBack.Click += ButtonBatal_Click;
            ButtonSparepart.Click += ButtonSparepart_Click;
            ButtonAksi.Click += ButtonAksi_Click;
            ButtonInformationBatalBooking.Click += ButtonInformationBatalBooking_Click;
            ButtonBatalkanBooking.Click += ButtonBatalkanBooking_Click;
        }

        private void ButtonBatalkanBooking_Click(object? sender, EventArgs e)
        {
            if (_bookingData.status == 4 )
            {
                MesboxHelper.ShowError("Booking sudah dibatalkan !");
                return;
            }

            if (_bookingData.status != 1)
            {
                MesboxHelper.ShowError("Mohon Maaf \nPembatalan hanya bisa dilakukan jika status masih menunggu !");
                return;
            }

            if (!MesboxHelper.ShowConfirm("Apakah Anda yakin ingin membatalkan booking ini ?")) return;

            var booking = new BookingModel
            {
                id_booking = _idBooking,
                status = 4
            };
            _bookingDal.UpdateData(booking);

            NontifikasiFormHelper notifikasi = new NontifikasiFormHelper("Booking dibatalkan");
            notifikasi.Show();
            GetData(_idBooking);
            InsertRiwayat(false);
        }

        private void ButtonInformationBatalBooking_Click(object? sender, EventArgs e)
        {
            InformationPembatalanBookingForm information = new InformationPembatalanBookingForm();
            information.ShowDialog();   
        }

        private void ButtonAksi_Click(object? sender, EventArgs e)
        {
            if (_statusBooking == 1)
            {
                if (MesboxHelper.ShowConfirm("Apakah Anda yakin ingin memproses pelanggan ini? \nPerubahan ini tidak dapat dibatalkan."))
                {
                    SaveData();
                    NontifikasiFormHelper notifikasi = new NontifikasiFormHelper("Booking diproses");
                    notifikasi.Show();
                    GetData(_idBooking);
                }
            }
            else if (_statusBooking == 2)
            {
                if (ComboMekanik.SelectedIndex == 0 || ComboJenisServis.SelectedIndex == 0)
                {
                    MesboxHelper.ShowWarning("Harap pilih mekanik dan jenis servis terlebih dahulu.");
                    return;
                }

                if (MesboxHelper.ShowConfirm("Apakah Anda yakin ingin menyelesaikan proses ini? \nPerubahan ini tidak dapat dibatalkan."))
                {
                    SaveData();
                    NontifikasiFormHelper notifikasi = new NontifikasiFormHelper("Selesai");
                    notifikasi.Show();
                    GetData(_idBooking);
                    InsertRiwayat(true);
                }
            }
            else if (_statusBooking == 3)
            {
                var data = _invoiceDal.GetInvoice(_idBooking);
                if (data != null)
                {
                    Invoice_Laporan.GenerateInvoicePDF(data);    
                }

            }
        }


        private void ButtonSparepart_Click(object? sender, EventArgs e)
        {
            DataSparepartForm dataSparepartForm = new DataSparepartForm(_idBooking);
            if (dataSparepartForm.ShowDialog() == DialogResult.OK)
            {
                RefreshSparepart(_idBooking);
            }
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new BookingForm());
        }
    }
}
