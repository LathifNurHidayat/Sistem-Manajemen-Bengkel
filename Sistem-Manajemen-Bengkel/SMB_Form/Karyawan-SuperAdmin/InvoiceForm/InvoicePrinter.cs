using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

public class InvoicePrinter
{
    private readonly BookingModel _data;
    private readonly Font _fontHeader = new Font("Arial", 14, FontStyle.Bold);
    private readonly Font _fontRegular = new Font("Arial", 10);
    private readonly Font _fontBold = new Font("Arial", 10, FontStyle.Bold);

    public InvoicePrinter(BookingModel data)
    {
        _data = data;
    }

    public void PrintInvoice()
    {
        PrintDocument printDoc = new PrintDocument();
        printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

        PrintPreviewDialog preview = new PrintPreviewDialog
        {
            Document = printDoc,
            Width = 800,
            Height = 600
        };
        preview.ShowDialog();
    }

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics g = e.Graphics;
        float y = 20;
        float x = 50;

        g.DrawString("INVOICE BENGKEL", _fontHeader, Brushes.Black, x, y);
        y += 30;

        g.DrawString($"No. Antrean: {_data.antrean}", _fontBold, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Nama Pelanggan: {_data.nama_pelanggan}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"No KTP: {(_data.no_ktp_pelanggan ?? "[Tamu]")}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"No Polisi: {_data.no_polisi}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Kendaraan: {_data.nama_kendaraan}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Tanggal Booking: {_data.tanggal:dd MMMM yyyy}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Keluhan: {_data.keluhan}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Mekanik: {(_data.no_ktp_mekanik ?? "[Belum Dipilih]")}", _fontRegular, Brushes.Black, x, y);
        y += 20;

    //    g.DrawString($"Jenis Servis: {(_data.jenis_servis ?? "Tidak ada")}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Sparepart: {_data.nama_sparepart ?? "-"}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawString($"Catatan: {_data.catatan ?? "-"}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        // Garis pemisah
        g.DrawLine(Pens.Black, x, y, x + 300, y);
        y += 10;

        // Biaya
        g.DrawString("Detail Biaya", _fontBold, Brushes.Black, x, y);
        y += 20;

   //     g.DrawString($"Biaya Jasa: Rp {_data.biaya_jasa:n0}", _fontRegular, Brushes.Black, x, y);
        y += 20;

    //    g.DrawString($"Biaya Sparepart: Rp {_data.biaya_sparepart:n0}", _fontRegular, Brushes.Black, x, y);
        y += 20;

        g.DrawLine(Pens.Black, x, y, x + 300, y);
        y += 10;

      //  g.DrawString($"Total: Rp {_data.total:n0}", _fontBold, Brushes.Black, x, y);
    }
}
