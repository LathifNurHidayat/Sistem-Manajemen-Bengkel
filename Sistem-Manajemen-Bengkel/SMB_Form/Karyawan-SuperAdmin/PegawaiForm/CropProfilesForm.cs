using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm
{
    public partial class CropProfilesForm : Form
    {
        private bool _isMouseDown = false;
        private Point _startPoint;
        private Rectangle _selectionRect = Rectangle.Empty;
        private Image _gambarAsli = null;
        public Image _hasilCrop { get; private set; }

        public CropProfilesForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            RegisterControlEvent();
        }

        #region Prosedure 
        private void LoadImageFromFolder()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image loadedImage = Image.FromFile(ofd.FileName);
                    _gambarAsli = ResizeImageToFit(loadedImage, PictureFotoAwal.Size);
                    PictureFotoAwal.Image = _gambarAsli;
                    _selectionRect = Rectangle.Empty;
                    PictureHasil.Image = null;
                }
            }
        }

        private Image ResizeImageToFit(Image image, Size containerSize)
        {
            float ratioWidth = (float)containerSize.Width / image.Width;
            float ratioHeight = (float)containerSize.Height / image.Height;
            float ratio = Math.Min(ratioWidth, ratioHeight);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            Bitmap bmp = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return bmp;
        }

        // Fungsi untuk melakukan crop berdasarkan selection rectangle
        private Image CropImage(Image image, Rectangle cropArea)
        {
            Bitmap sourceBitmap = new Bitmap(image);
            Bitmap croppedBitmap = new Bitmap(cropArea.Width, cropArea.Height);
            using (Graphics g = Graphics.FromImage(croppedBitmap))
            {
                g.DrawImage(sourceBitmap, new Rectangle(0, 0, cropArea.Width, cropArea.Height),
                    cropArea, GraphicsUnit.Pixel);
            }
            return croppedBitmap;
        }
        #endregion

        #region Event

        private void RegisterControlEvent()
        {
            PictureFotoAwal.MouseDown += PictureFotoAwal_MouseDown;
            PictureFotoAwal.MouseMove += PictureFotoAwal_MouseMove;
            PictureFotoAwal.MouseUp += PictureFotoAwal_MouseUp;
            PictureFotoAwal.Paint += PictureFotoAwal_Paint;

            ButtonPilihFoto.Click += ButtonPilihFoto_Click;
            ButtonPotong.Click += ButtonPotong_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (PictureFotoAwal.Image == null)
            {
                MessageBox.Show("Gambar sumber tidak ditemukan.");
                return;
            }
            _hasilCrop = PictureHasil.Image;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


     

        private void PictureFotoAwal_MouseDown(object sender, MouseEventArgs e)
        {
            if (PictureFotoAwal.Image == null)
                return;

            _isMouseDown = true;
            _startPoint = e.Location;
            _selectionRect = new Rectangle(e.Location, new Size(0, 0));
        }

        // Event MouseMove pada PictureFotoAwal: update selection rectangle sehingga selalu berbentuk persegi
        private void PictureFotoAwal_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isMouseDown)
                return;

            Point currentPoint = e.Location;
            int deltaX = Math.Abs(currentPoint.X - _startPoint.X);
            int deltaY = Math.Abs(currentPoint.Y - _startPoint.Y);
            int side = Math.Min(deltaX, deltaY); // sisi persegi adalah nilai minimum dari deltaX dan deltaY

            int x = _startPoint.X;
            int y = _startPoint.Y;
            if (currentPoint.X < _startPoint.X)
                x = _startPoint.X - side;
            if (currentPoint.Y < _startPoint.Y)
                y = _startPoint.Y - side;

            _selectionRect = new Rectangle(x, y, side, side);
            PictureFotoAwal.Invalidate(); 
        }

        // Event MouseUp pada PictureFotoAwal: selesai memilih area crop
        private void PictureFotoAwal_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
        }

        // Event Paint pada PictureFotoAwal: gambar selection rectangle
        private void PictureFotoAwal_Paint(object sender, PaintEventArgs e)
        {
            if (_selectionRect != Rectangle.Empty && PictureFotoAwal.Image != null)
            {
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    e.Graphics.DrawRectangle(pen, _selectionRect);
                }
            }
        }

        private void ButtonPilihFoto_Click(object sender, EventArgs e)
        {
            LoadImageFromFolder();
        }

        private void ButtonPotong_Click(object sender, EventArgs e)
        {
            if (PictureFotoAwal.Image == null)
            {
                MesboxHelper.ShowWarning("Belum ada gambar yang dimuat.");
                return;
            }
            if (_selectionRect.Width <= 0 || _selectionRect.Height <= 0)
            {
                MesboxHelper.ShowWarning("Silakan pilih area untuk crop terlebih dahulu.");
                return;
            }
            Image croppedImage = CropImage(_gambarAsli, _selectionRect);
            PictureHasil.SizeMode = PictureBoxSizeMode.Zoom;
            PictureHasil.Image = croppedImage;

            _selectionRect = Rectangle.Empty;
            PictureFotoAwal.Invalidate();
        }
        #endregion
    }
}
