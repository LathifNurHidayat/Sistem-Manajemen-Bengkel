using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.SparepartForm
{
    public partial class InputSparepartForm : Form
    {
        private readonly SparepartDal _sparepartDal;
        private int _idSparepart;

        public InputSparepartForm(int id_sparepart)
        {
            InitializeComponent();
            _sparepartDal = new SparepartDal();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            _idSparepart = id_sparepart;


            if (_idSparepart != 0)
                GetData(_idSparepart);
            else
                PictureSparepart.Image = ImageHelper.GetHighQualityThumbnail(ImageDirectoryHelper._sparepartDefault, 200, 200);

            RegisterControlEvent();
        }

        private void GetData(int idSparepart)
        {
            var sparepart = _sparepartDal.GetData(_idSparepart);
            if (sparepart == null) return;

            PictureSparepart.Image = sparepart.image_data == null ?
                                        ImageHelper.GetHighQualityThumbnail(ImageDirectoryHelper._sparepartDefault, 200,200) :
                                        ImageHelper.ByteToImage(sparepart.image_data);

            TextNamaSparepart.Text = sparepart.nama_sparepart;
            TextHarga.DecimalValue = sparepart.harga;
            TextStok.IntegerValue = sparepart.stok;
            TextStokMinimal.IntegerValue = sparepart.stok_minimal;
        }

        private void SaveData()
        {
            var sparepart = new SparepartModel
            {
                id_sparepart = _idSparepart,
                image_data = PictureSparepart.Image == ImageDirectoryHelper._sparepartDefault ? null : 
                                ImageHelper.ImageToByteArray(PictureSparepart.Image),
                nama_sparepart = TextNamaSparepart.Text.Trim(),
                harga = TextHarga.DecimalValue,
                stok = (int)TextStok.IntegerValue,
                stok_minimal = (int)TextStokMinimal.IntegerValue,
            };

            if (_idSparepart == 0)
                _sparepartDal.InsertData(sparepart);
            else
                _sparepartDal.UpdateData(sparepart);
        }

        private void RegisterControlEvent()
        {
            ButtonSimpan.Click += ButtonSimpan_Click;
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonPilihFile.Click += ButtonPilihFile_Click;

        }

        private void ButtonPilihFile_Click(object? sender, EventArgs e)
        {
            CropProfilesFormHelper cropProfilesForm = new CropProfilesFormHelper();
            if (cropProfilesForm.ShowDialog() == DialogResult.OK)
                PictureSparepart.Image = cropProfilesForm._hasilCrop;
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextNamaSparepart.Text)||
                TextHarga.DecimalValue == 0)
            {
                MesboxHelper.ShowWarning("Data nama sparepart dan harga wajib diisi!");
                return;
            }
            SaveData();
            this.DialogResult = DialogResult.OK;
        }
    }
}
