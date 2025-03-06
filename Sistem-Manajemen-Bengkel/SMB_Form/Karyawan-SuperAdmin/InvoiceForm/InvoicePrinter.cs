using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

public class InvoicePrinter
{
    private readonly PenggunaanSparepartDal _penggunaanSparepartDal;
    private readonly InformasiBengkelDal _informasiBengkelDal;

    private readonly BookingModel _dataBooking;
    private readonly InformasiBengkelModel _informasiBengkel;
    private readonly PenggunaanSparepartModel _penggunaanSparepart;

    private readonly Font _fontHeader = new Font("Arial", 14, FontStyle.Bold);
    private readonly Font _fontRegular = new Font("Arial", 10);
    private readonly Font _fontBold = new Font("Arial", 10, FontStyle.Bold);

    public InvoicePrinter(BookingModel data)
    {
        _penggunaanSparepartDal = new PenggunaanSparepartDal();
        _informasiBengkelDal = new InformasiBengkelDal();

        _dataBooking = data;

        GetData();
    }

    private void GetData()
    {
      //  _informasiBengkel = _informasiBengkelDal.GetData() ?? new InformasiBengkelModel();

        //_penggunaanSparepart = _penggunaanSparepartDal.GetSparepart(_dataBooking.id_booking) ?? new PenggunaanSparepartModel();
    }

    public void PrintInvoice()
    {
        PrintDocument printDoc = new PrintDocument();
        printDoc.PrintPage += PrintPage;

        PrintPreviewDialog preview = new PrintPreviewDialog
        {
            Document = printDoc,
            Width = 800,
            Height = 600
        };
        preview.ShowDialog();
    }

    private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics g = e.Graphics;
        float y = 20;
        float x = 50;

        g.DrawString("INVOICE BENGKEL", _fontHeader, Brushes.Black, x, y);
        y += 30;

        g.DrawString($"No. Antrean: {_dataBooking.antrean}", _fontBold, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Nama Pelanggan: {_dataBooking.nama_pelanggan}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"No KTP: {(_dataBooking.no_ktp_pelanggan ?? "[Tamu]")}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"No Polisi: {_dataBooking.no_polisi}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Kendaraan: {_dataBooking.nama_kendaraan}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Tanggal Booking: {_dataBooking.tanggal:dd MMMM yyyy}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Keluhan: {_dataBooking.keluhan}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Mekanik: {(_dataBooking.no_ktp_mekanik ?? "[Belum Dipilih]")}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Sparepart: {_penggunaanSparepart.nama_sparepart ?? "-"}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Catatan: {_dataBooking.catatan ?? "-"}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        // Garis pemisah
        g.DrawLine(Pens.Black, x, y, x + 300, y);
        y += 10;

        // Biaya
        g.DrawString("Detail Biaya", _fontBold, Brushes.Black, x, y);
        y += 20;

     //   g.DrawString($"Biaya Jasa: Rp {_dataBooking.biaya_jasa:n0}", _fontRegular, Brushes.Black, x, y);
        y += 20;

     //   g.DrawString($"Biaya Sparepart: Rp {_dataBooking.biaya_sparepart:n0}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawLine(Pens.Black, x, y, x + 300, y);
        y += 10;

       // g.DrawString($"Total: Rp {_dataBooking.total:n0}", _fontBold, Brushes.Black, x, y);
    }
}
