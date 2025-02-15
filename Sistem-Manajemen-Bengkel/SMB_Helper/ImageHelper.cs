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
                return null;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }


        public static Image ByteToImage(byte[] image_data)
        {
            if (image_data == null || image_data.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(image_data))
            {
                return Image.FromStream(ms);
            }
        }


        #endregion


        #region Set Image

        public static Image GetCircularImage(Image image)
        {
            if (image == null)
                return null;

            int diameter = Math.Min(image.Width, image.Height);

            Bitmap circularImage = new Bitmap(diameter, diameter, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics g = Graphics.FromImage(circularImage))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;// agar tepinya halus

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, diameter, diameter);// membuat lingkaran
                    g.SetClip(path);
                    g.Clear(Color.Transparent); // bg transparant

                    //jika gambar tidak persegi
                    int x = (image.Width - diameter) / 2;
                    int y = (image.Height - diameter) / 2;

                    g.DrawImage(image, new Rectangle(0, 0, diameter, diameter),
                                new Rectangle(x, y, diameter, diameter), GraphicsUnit.Pixel);
                }
            }
            return circularImage;
        }


        public static Image GetHighQualityThumbnail(Image image, int width, int height)
        {
            if (image == null) return null; 

            var destImage = new Bitmap(width, height);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceOver;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                var destRect = new Rectangle(0, 0, width, height);

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        #endregion
    }
}
