using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm
{
    public partial class InputPegawai : Form
    {
        public InputPegawai()
        {
            InitializeComponent();
            RegisterControlEvent();
        }

        private void RegisterControlEvent()
        {
            ButtonEditProfiles.Click += ButtonEditProfiles_Click;
        }

        private void ButtonEditProfiles_Click(object? sender, EventArgs e)
        {
            CropProfilesForm cropProfilesForm = new CropProfilesForm();
            cropProfilesForm.ShowDialog(this);
            if (cropProfilesForm._hasilCrop == null) return;
            PictureProfiles.Image = null;
            PictureProfiles.Image = cropProfilesForm._hasilCrop;
        }
    }
}
