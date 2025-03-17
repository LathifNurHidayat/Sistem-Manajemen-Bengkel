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
using Rectangle = iTextSharp.text.Rectangle;
using Image = iTextSharp.text.Image;

public class Invoice_Laporan
{
    public static void GenerateInvoicePDF(InvoiceModel invoice)
    {
        string fileName = $"Invoice_{invoice.nama_pelanggan}_{invoice.tanggal:dd-MM-yyyy}.pdf";
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

        Document doc = new Document(PageSize.A4, 40, 40, 60, 60);
        PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
        doc.Open();

        // Load Logo (Pastikan file logo tersedia)
        string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png"); // Sesuaikan path logo
        if (File.Exists(logoPath))
        {
            Image logo = Image.GetInstance(logoPath);
            logo.ScaleAbsolute(100f, 50f);
            logo.Alignment = Element.ALIGN_LEFT;
            doc.Add(logo);
        }

        // Informasi Bengkel
        Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, BaseColor.BLACK);
        Font subTitleFont = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.DARK_GRAY);
        Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
        Font bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

        Paragraph title = new Paragraph(invoice.nama_bengkel, titleFont);
        title.Alignment = Element.ALIGN_LEFT;
        doc.Add(title);

        Paragraph infoBengkel = new Paragraph($"{invoice.alamat_bengkel}\nEmail: {invoice.email_bengkel} | Telp: {invoice.no_telp_bengkel}\n\n", subTitleFont);
        infoBengkel.Alignment = Element.ALIGN_LEFT;
        doc.Add(infoBengkel);

        doc.Add(new Paragraph("------------------------------------------------------------------\n"));

        // Informasi Invoice
        PdfPTable infoTable = new PdfPTable(2);
        infoTable.WidthPercentage = 100;
        infoTable.SetWidths(new float[] { 30f, 70f });

        infoTable.AddCell(GetCell("Antrean Nomor:", headerFont, true));
        infoTable.AddCell(GetCell(invoice.antrean.ToString(), bodyFont, false));

        infoTable.AddCell(GetCell("Tanggal:", headerFont, true));
        infoTable.AddCell(GetCell(invoice.tanggal.ToString("dd MMM yyyy"), bodyFont, false));

        infoTable.AddCell(GetCell("Pelanggan:", headerFont, true));
        infoTable.AddCell(GetCell(invoice.nama_pelanggan, bodyFont, false));

        infoTable.AddCell(GetCell("Kendaraan:", headerFont, true));
        infoTable.AddCell(GetCell($"{invoice.nama_kendaraan} ({invoice.no_polisi})", bodyFont, false));

        doc.Add(infoTable);
        doc.Add(new Paragraph("\n"));

        // Tabel Layanan & Sparepart
        PdfPTable table = new PdfPTable(3);
        table.WidthPercentage = 100;
        table.SetWidths(new float[] { 50f, 20f, 30f });

        // Header Tabel
        table.AddCell(GetStyledCell("Barang / Jasa", headerFont, BaseColor.LIGHT_GRAY));
        table.AddCell(GetStyledCell("Quantity", headerFont, BaseColor.LIGHT_GRAY));
        table.AddCell(GetStyledCell("Harga", headerFont, BaseColor.LIGHT_GRAY));

        // Jasa Servis
        table.AddCell(GetStyledCell(invoice.jasa_servis, bodyFont, BaseColor.WHITE));
        table.AddCell(GetStyledCell("1", bodyFont, BaseColor.WHITE, Element.ALIGN_CENTER));
        table.AddCell(GetStyledCell($"Rp {invoice.biaya_jasa:N0}", bodyFont, BaseColor.WHITE));

        // Spareparts
        if (invoice.List_sparepart.Count >= 1)
        {
            for (int i = 0; i < invoice.List_sparepart.Count; i++)
            {
                table.AddCell(GetStyledCell(invoice.List_sparepart[i], bodyFont, BaseColor.WHITE));
                table.AddCell(GetStyledCell(invoice.List_quantity[i], bodyFont, BaseColor.WHITE, Element.ALIGN_CENTER));
                table.AddCell(GetStyledCell($"Rp {invoice.List_harga_sparepart[i]:N0}", bodyFont, BaseColor.WHITE));
            }
        }

        doc.Add(table);
        doc.Add(new Paragraph("\n"));

        // Total Harga
        Paragraph total = new Paragraph($"Total: Rp {invoice.total_biaya_servis:N0}", titleFont);
        total.Alignment = Element.ALIGN_RIGHT;
        doc.Add(total);

        // Catatan
        if (!string.IsNullOrWhiteSpace(invoice.catatan))
        {
            doc.Add(new Paragraph("\nCatatan:", headerFont));
            doc.Add(new Paragraph(invoice.catatan, bodyFont));
        }

        doc.Close();
        Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
    }

    // Membuat Cell untuk Informasi Bengkel
    private static PdfPCell GetCell(string text, Font font, bool bold)
    {
        PdfPCell cell = new PdfPCell(new Phrase(text, font))
        {
            Border = Rectangle.NO_BORDER,
            Padding = 5
        };
        if (bold)
            cell.BackgroundColor = new BaseColor(230, 230, 230); // Background abu-abu muda
        return cell;
    }

    // Membuat Cell dengan Gaya
    private static PdfPCell GetStyledCell(string text, Font font, BaseColor bgColor, int align = Element.ALIGN_LEFT)
    {
        PdfPCell cell = new PdfPCell(new Phrase(text, font))
        {
            BackgroundColor = bgColor,
            HorizontalAlignment = align,
            Padding = 5
        };
        return cell;
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

            // Membuat  style tabel nya
            var range = worksheet.Range(2, 1, row - 1, 12); 
            var table = range.CreateTable();
            table.Theme = XLTableTheme.TableStyleLight10; 

            // untuk menyesuaikan ukuran kolom secara otomatis
            worksheet.Columns().AdjustToContents();

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
