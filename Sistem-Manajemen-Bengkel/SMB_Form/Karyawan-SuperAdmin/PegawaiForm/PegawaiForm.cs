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
using static Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm.PelangganForm;

namespace Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm
{
    public partial class PegawaiForm : Form
    {

        private readonly PegawaiDal _pegawaiDal;
        
        public PegawaiForm()
        {
            InitializeComponent();

            _pegawaiDal = new PegawaiDal();

            CustomComponent();
            LoadData();
        }

        private void CustomComponent()
        {
            List<int> entries = new() { 10, 25, 50, 100 };
            ComboEntries.DataSource = entries;
            List<string> sortBy = new() { "Semua (All)", "Karyawan", "Super Admin" };
            ComboFilter.DataSource = sortBy;
            CustomComponentHelper.CustomDataGrid(GridListData);
            // CustomComponentHelper.CustomPanel(PanelBooking);
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


            if (!string.IsNullOrEmpty(search))
            {
                dp.Add("@Search", $"%{search}%");
                filters = @" AND (no_ktp_pelanggan LIKE @Search OR 
                                  nama_pelanggan LIKE @Search OR 
                                  no_hp LIKE @Search OR 
                                  alamat LIKE @Search OR 
                                  email LIKE @Search)";
            }
            if (ComboFilter.SelectedItem == "Karyawan")
                filters = string.Join(" AND ", "role = 'Karyawan' ");

            else if (ComboFilter.SelectedItem == "Super Admin")
                filters = string.Join(" AND ", "role = 'Super Admin' ");

            dp.Add("@offset", inRowPage);
            dp.Add("@fetch", rowPerPage);

            int totalEntries = _pegawaiDal.CountData(filters);
            totalPage = (int)Math.Ceiling((double)totalEntries / rowPerPage);

            LabelShowEntries.Text = $"Showing {inRowPage + 1} to {inRowPage + rowPerPage} of {totalEntries} entries";

            var data = _pegawaiDal.ListData(filters, dp)
                .Select((x, index) => new
                {
                    No = inRowPage + index + 1,
                    Image = x.image_data != null ?
                            Image.FromStream(new MemoryStream(x.image_data))
                                .GetThumbnailImage(55, 55, () => false, IntPtr.Zero)
                            : ImageDirectoryHelper._defaultProfilesOnGrid,
                    NoKTP = x.no_ktp_pegawai,
                    Nama = x.nama_pegawai,
                    NoHP = x.no_hp,
                    Alamat = x.alamat,
                    Email = x.email,
                    Role = x.role
                }).ToList();

            GridListData.DataSource = data;
        }


    }
}
