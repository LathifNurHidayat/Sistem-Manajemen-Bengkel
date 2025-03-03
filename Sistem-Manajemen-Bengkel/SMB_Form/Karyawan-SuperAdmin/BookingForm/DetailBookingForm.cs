﻿using System;
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
using Sistem_Manajemen_Bengkel.SMB_Helper;
using Syncfusion.Windows.Forms.Tools;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm
{
    public partial class DetailBookingForm : Form
    {
        private readonly BookingDal _bookingDal;
        private readonly JasaServisDal _jasaServisDal;
        private readonly MekanikDal _mekanikDal;

        private int _statusBooking;
        private int _idBooking;

        public DetailBookingForm(int id_booking)
        {
            InitializeComponent();
            _bookingDal = new BookingDal();
            _jasaServisDal = new JasaServisDal();
            _mekanikDal = new MekanikDal();
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
            var data = _bookingDal.GetData(id_booking);
            if (data == null) return;

            _statusBooking = data.status;

            LabelAntreanAnda.Text = data.antrean.ToString();
            LabelIdBooking.Text = data.id_booking.ToString();
            LabelNama.Text = $": {data.nama_pelanggan}";
            LabelNoKTP.Text = $": {(string.IsNullOrEmpty(data.no_ktp_pelanggan) ? "[ Tamu ]" : data.no_ktp_pelanggan)}";
            LabelNoPol.Text = $": {data.no_polisi}";
            LabelKendaraan.Text = $": {data.nama_kendaraan}";
            LabelTanggal.Text = $": {data.tanggal:dd MMMM yyyy}";
            LabelKeluhan.Text = $": {data.keluhan}";


            ComboMekanik.SelectedValue = string.IsNullOrEmpty(data.no_ktp_mekanik) ? "" : data.no_ktp_mekanik;
            ComboJenisServis.SelectedValue = data.id_jasa_servis ?? 0;
            TextSparepart.Text = data.nama_sparepart;
            TextCatatan.Text = data.catatan;

            if (data.status == 2)
            {
                progres1.BackColor = System.Drawing.Color.LimeGreen;
                progresDikerjakan.BackColor = System.Drawing.Color.LimeGreen;

                ButtonAksi.BackColor = System.Drawing.Color.Green;
                ButtonAksi.Text = "Selesai";
            }
            else if (data.status == 3)
            {
                progres1.BackColor = System.Drawing.Color.LimeGreen;
                progresDikerjakan.BackColor = System.Drawing.Color.LimeGreen;

                progres2.BackColor = System.Drawing.Color.LimeGreen;
                progresSelesai.BackColor = System.Drawing.Color.LimeGreen;

                ButtonAksi.Visible = false;
                ButtonClose.Location = ButtonAksi.Location;
            }
        }

        private void RegisterControlEvent()
        {
            ButtonClose.Click += ButtonBatal_Click;
            ButtonSparepart.Click += ButtonSparepart_Click;
            ButtonAksi.Click += ButtonAksi_Click;
        }

        private void ButtonAksi_Click(object? sender, EventArgs e)
        {
            if (_statusBooking == 1)
            {
                if (MesboxHelper.ShowConfirm("Apakah Anda yakin ingin memproses booking dari pelanggan ini?"))
                {
                     
                }
            }
        }

        private void ButtonSparepart_Click(object? sender, EventArgs e)
        {
            DataSparepartForm dataSparepartForm = new DataSparepartForm(_idBooking);
            if (dataSparepartForm.ShowDialog(this) == DialogResult.OK)
            {
                GetData(_idBooking);
            }
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            ShowFormHelper.ShowFormInPanel(new BookingForm());
        }
    } 
}
