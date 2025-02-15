using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class JasaServisForm : Form
    {
        private readonly JasaServisDal _jasaServisDal;

        public JasaServisForm()
        {
            InitializeComponent();
            _jasaServisDal = new JasaServisDal();
            RegisterControlEvent();
        }


        int page = 1;
        int totalPage = 0;
        private void LoadData()
        {
            TextPage.Text = page.ToString();
            string search = TextSearch.Text.Trim();
            int rowPerPage = (int)ComboEntries.SelectedValue;
            int inRowPage = (page - 1) * rowPerPage;
            var dp = new DynamicParameters();
            string filters = string.Empty;

            if (ComboFilter.SelectedItem == "Petugas")
                filters += " AND role = 2 ";

            else if (ComboFilter.SelectedItem == "Super Admin")
                filters += " AND role = 1 ";

            if (!string.IsNullOrEmpty(search))
            {
                dp.Add("@Search", $"%{search}%");
                filters = @" AND (no_ktp_pegawai LIKE @Search OR 
                                  nama_pegawai LIKE @Search OR 
                                  no_hp LIKE @Search OR 
                                  alamat LIKE @Search OR 
                                  email LIKE @Search) ";
            }
            dp.Add("@offset", inRowPage);
            dp.Add("@fetch", rowPerPage);


            int totalEntries = _jasaServisDal.CountData(filters, dp);
            totalPage = (int)Math.Ceiling((double)totalEntries / rowPerPage);

            LabelShowEntries.Text = $"Showing {inRowPage + 1} to {inRowPage + rowPerPage} of {totalEntries} entries";

            var data = _jasaServisDal.ListData(filters, dp)
                .Select((x, index) => new
                {
                    No = inRowPage + index + 1,
                    Image = x.image_data != null ?
                            ImageHelper.GetHighQualityThumbnail(Image.FromStream(new MemoryStream(x.image_data)), 40, 40) :
                            ImageDirectoryHelper._defaultProfilesOnGrid,
                    NoKTP = x.no_ktp_pegawai,
                    Nama = x.nama_pegawai,
                    NoHP = x.no_hp,
                    Alamat = x.alamat,
                    Email = x.email,
                    Role = x.role == 1 ? ImageDirectoryHelper._roleSuperAdmin :
                           x.role == 2 ? ImageDirectoryHelper._rolePetugas : null
                }).ToList();

            GridListData.DataSource = data;
        }

        private void RegisterControlEvent()
        {
        }

      
    }
}
