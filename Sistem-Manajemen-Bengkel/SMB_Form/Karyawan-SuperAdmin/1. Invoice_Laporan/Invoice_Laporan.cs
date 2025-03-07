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
}
