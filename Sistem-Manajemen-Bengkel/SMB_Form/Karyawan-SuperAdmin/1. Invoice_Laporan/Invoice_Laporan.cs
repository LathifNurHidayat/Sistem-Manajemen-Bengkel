using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection.Metadata;
using System.Windows.Documents;
using OxyPlot;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Document = iTextSharp.text.Document;
using Font = iTextSharp.text.Font;
using Paragraph = iTextSharp.text.Paragraph;
using PageSize = iTextSharp.text.PageSize;
using System.Diagnostics;
using Element = iTextSharp.text.Element;
using System.Windows.Media;
using ClosedXML.Excel;
using System.Runtime.CompilerServices;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;

public class Invoice_Laporan
{
    public static void GenerateInvoicePDF(InvoiceModel invoice)
    {
        string fileName = $"Invoice_{invoice.nama_pelanggan}_{invoice.tanggal:dd-MM-yyyy}.pdf";
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

        Document doc = new Document(PageSize.A4);
        PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
        doc.Open();

        Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22);
        Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
        Font bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

        doc.Add(new Paragraph(invoice.nama_bengkel, titleFont));
        doc.Add(new Paragraph(invoice.alamat_bengkel, bodyFont));
        doc.Add(new Paragraph($"Email: {invoice.email_bengkel} | Telp: {invoice.no_telp_bengkel}", bodyFont));
        doc.Add(new Paragraph("------------------------------------------------------------------"));

        doc.Add(new Paragraph($"Antrean Nomor: {invoice.antrean}", headerFont));
        doc.Add(new Paragraph($"Tanggal: {invoice.tanggal:dd MMM yyyy}", bodyFont));
        doc.Add(new Paragraph($"Pelanggan: {invoice.nama_pelanggan}", bodyFont));
        doc.Add(new Paragraph($"Kendaraan: {invoice.nama_kendaraan} ({invoice.no_polisi})", bodyFont));
        doc.Add(new Paragraph("------------------------------------------------------------------"));
        doc.Add(new Paragraph(" "));

        PdfPTable table = new PdfPTable(3);
        table.WidthPercentage = 100;
        table.SetWidths(new float[] { 50f, 20f, 30f });

        table.AddCell(new PdfPCell(new Phrase("Barang / Jasa", headerFont))
        {
            HorizontalAlignment = Element.ALIGN_CENTER
        });

        table.AddCell(new PdfPCell(new Phrase("Quantity", headerFont))
        {
            HorizontalAlignment = Element.ALIGN_CENTER
        });

        table.AddCell(new PdfPCell(new Phrase("Harga", headerFont))
        {
            HorizontalAlignment = Element.ALIGN_CENTER
        });

        table.AddCell(new PdfPCell(new Phrase(invoice.jasa_servis, bodyFont)));
        table.AddCell(new PdfPCell(new Phrase("1", bodyFont))
        {
            HorizontalAlignment = Element.ALIGN_CENTER
        }); 

        table.AddCell(new PdfPCell(new Phrase($"Rp {invoice.biaya_jasa:N0}", bodyFont)));

        if (invoice.List_sparepart.Count >= 1)
        {
            for (int i = 0; i < invoice.List_sparepart.Count; i ++ )
            { 
                table.AddCell(new PdfPCell(new Phrase(invoice.List_sparepart[i], bodyFont)));

                table.AddCell(new PdfPCell(new Phrase(invoice.List_quantity[i], bodyFont))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER
                });

                table.AddCell(new PdfPCell(new Phrase($"Rp {invoice.List_harga_sparepart[i]:N0}", bodyFont)));
            }
        }

        doc.Add(table);
        doc.Add(new Paragraph($"Total: Rp {invoice.total_biaya_servis:N0}", headerFont));
        doc.Add(new Paragraph($"Catatan: {invoice.catatan}", bodyFont));

        doc.Close();
        Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
    }


    public static void GenerateLaporan( DateTime tanggal_1, DateTime tanggal_2)
    {
        LaporanDal _laporanDal = new LaporanDal();

        var laporan =  _laporanDal.ListLaporan(tanggal_1, tanggal_2).ToList();
        if (laporan.Count  == 0 || laporan == null)
        {
            MesboxHelper.ShowError($"Mohon maaf \nTidak ada data pada rentang tanggal \"{tanggal_1.ToString("dd-MM-yyyy")}\" - \"{tanggal_2.ToString("dd-MM-yyyy")}\". \nSilakan pilih tanggal yang lain.");
            return;
        }


        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Laporan Riwayat Servis");

            worksheet.Cell(1, 1).Value = $"Rentang Tanggal : {tanggal_1.ToString("dd-MMMM-yyyy")} - {tanggal_2.ToString("dd-MMMM-yyyy")}";

            // Header
            worksheet.Cell(2, 1).Value = "Tanggal";
            worksheet.Cell(2, 2).Value = "No KTP Pelanggan";
            worksheet.Cell(2, 3).Value = "Nama Pelanggan";
            worksheet.Cell(2, 4).Value = "Nama Kendaraan";
            worksheet.Cell(2, 5).Value = "Nama Petugas";
            worksheet.Cell(2, 6).Value = "Nama Mekanik";
            worksheet.Cell(2, 7).Value = "Jasa Servis";
            worksheet.Cell(2, 8).Value = "Nama Sparepart";
            worksheet.Cell(2, 9).Value = "Keluhan";
            worksheet.Cell(2, 10).Value = "Catatan";
            worksheet.Cell(2, 11).Value = "Total Biaya";
            worksheet.Cell(2, 12).Value = "Status";

            int row = 3;

            foreach (var item in laporan)
            {
                worksheet.Cell(row, 1).Value = item.tanggal;
                worksheet.Cell(row, 2).Value = item.no_ktp_pelanggan ?? "[Tamu]";
                worksheet.Cell(row, 3).Value = item.nama_pelanggan;
                worksheet.Cell(row, 4).Value = item.nama_kendaraan;
                worksheet.Cell(row, 5).Value = item.nama_petugas;
                worksheet.Cell(row, 6).Value = item.nama_mekanik;
                worksheet.Cell(row, 7).Value = item.jasa_servis;
                worksheet.Cell(row, 8).Value = item.nama_sparepart;
                worksheet.Cell(row, 9).Value = item.keluhan;
                worksheet.Cell(row, 10).Value = item.catatan;
                worksheet.Cell(row, 11).Value = $"Rp{item.total_biaya:N0}";
                worksheet.Cell(row, 12).Value = item.status == 1 ? "Selesai" : "Dibatalkan";

                row++;
            }

            // Membuat tabel dari data
            var range = worksheet.Range(2, 1, row - 1, 12); 
            var table = range.CreateTable();
            table.Theme = XLTableTheme.TableStyleLight10; 

            // Menyesuaikan ukuran kolom
            worksheet.Columns().AdjustToContents();

            // Simpan file menggunakan SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                Title = "Simpan Laporan",
                FileName = "Laporan_Riwayat_Servis.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
            }
        }
    }
}
