using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Sistem_Manajemen_Bengkel.SMB_Helper
{
    public class ImageHelper
    {
        #region Convert Image 
        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
                throw new ArgumentNullException(nameof(image), "Image tidak boleh null");

            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        
        public static Image Image_ByteToImage(byte[] image_data)
        {
            if (image_data == null || image_data.Length == 0)
                throw new ArgumentNullException(nameof(image_data), "Data gambar tidak boleh null atau kosong");

            using (MemoryStream ms = new MemoryStream(image_data))
            {
                return Image.FromStream(ms);
            }
        }

        #endregion


        #region Convert Image Show To Grid
        public static byte[] ResizeImageBytes(byte[] imageBytes, int maxWidth, int maxHeight)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                throw new ArgumentNullException(nameof(imageBytes), "Data gambar tidak boleh null atau kosong");

            // convert byte[] ke Image
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);

                // Hitung rasio untuk mempertahankan aspect ratio
                double ratioX = (double)maxWidth / image.Width;
                double ratioY = (double)maxHeight / image.Height;
                double ratio = Math.Min(ratioX, ratioY);

                int newWidth = (int)(image.Width * ratio);
                int newHeight = (int)(image.Height * ratio);

                Image resizedImage = new Bitmap(image, newWidth, newHeight);

                using (MemoryStream resizedStream = new MemoryStream())
                {
                    resizedImage.Save(resizedStream, ImageFormat.Png); // Simpan sebagai PNG atau format lain
                    return resizedStream.ToArray();
                }
            }
        }

        // Contoh fungsi tambahan: Resize Image ke ukuran maksimal tertentu (untuk file dari direktori)
        public static byte[] ImageToByteMaxSize(string imgDirectory, int width, int height)
        {
            Image image = Image.FromFile(imgDirectory);
            Image imageResize = ResizeImage(image, width, height);
            return ImageToByteArray(imageResize);
        }

        // Fungsi untuk meresize Image dengan mempertahankan aspect ratio
        public static Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            double ratioX = (double)maxWidth / image.Width;
            double ratioY = (double)maxHeight / image.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }
        #endregion

        #region LOAD IMAGE
        public static void LoadImageToPictureBox(PictureBox picture, string image_data)
        {
            byte[] imageBytes = System.Text.Encoding.UTF8.GetBytes(image_data);
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    picture.Image = Image.FromStream(ms);
                }
            }
        }
        #endregion
    }
}
