using System.ComponentModel;
using System.Data;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm
{
    public partial class PelangganForm : Form
    {
        private readonly PelangganDal _pelangganDal;
        private BindingList<PelangganDto> _listPelanggan;

        public PelangganForm()
        {
            InitializeComponent();
            _pelangganDal = new PelangganDal();
            _listPelanggan = new BindingList<PelangganDto>();

            CustomComponent();
            LoadData();
            RegisterControlEvent();
        }

        private void CustomComponent()
        {
            CustomComponentHelper.CustomDataGrid(GridListData);
            // CustomComponentHelper.CustomPanel(PanelBooking);
        }

        private void LoadData()
        {
            _listPelanggan.Clear();
            var data = _pelangganDal.ListData().Select((x, index) => new PelangganDto
            {
                No = index + 1,
                Nomor_KTP = x.no_ktp_pelanggan,
                Nama_Pelanggan = x.nama_pelanggan,
                Nomor_HP = x.no_hp,
                Alamat = x.alamat,
                Email = x.email,
                Total_Servis = x.total_servis
            }).ToList();
            
            foreach (var item in data)
                _listPelanggan.Add(item);

            GridListData.DataSource = _listPelanggan;

            GridListData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridListData.Columns["No"].FillWeight = 5;
            GridListData.Columns["Nomor_KTP"].FillWeight = 12;
            GridListData.Columns["Nama_Pelanggan"].FillWeight = 25;
            GridListData.Columns["Nomor_HP"].FillWeight = 12;
            GridListData.Columns["Alamat"].FillWeight = 28;
            GridListData.Columns["Email"].FillWeight = 15;
            GridListData.Columns["Total_Servis"].FillWeight = 12;

            foreach (DataGridViewColumn col in GridListData.Columns)
            {
                col.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);
            }

            GridListData.Columns["Nomor_KTP"].HeaderText = "No KTP";
            GridListData.Columns["Nama_Pelanggan"].HeaderText = "Nama Pelanggan";
            GridListData.Columns["Nomor_HP"].HeaderText = "No. HP";
            GridListData.Columns["Alamat"].HeaderText = "Alamat";
            GridListData.Columns["Email"].HeaderText = "Email";
            GridListData.Columns["Total_Servis"].HeaderText = "Total Servis";

            // Menengahkan nilai pada Total Servis agar lebih rapih
            GridListData.Columns["Total_Servis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


        private void RegisterControlEvent()
        {   TextSearch.KeyDown += (s, e) =>{if (e.KeyCode == Keys.Enter)  ButtonSearch.PerformClick();};
            TextSearch.TextChanged += (s, e) => { if (TextSearch.Text.Length == 0) LoadData(); };
            ButtonSearch.Click += ButtonSearch_Click;
        } 

        private void ButtonSearch_Click(object? sender, EventArgs e)
        {
            string input = TextSearch.Text.Trim();
            var result = _listPelanggan
                .Where(p => p.Nomor_KTP.Contains(input, StringComparison.OrdinalIgnoreCase) ||
                            p.Nama_Pelanggan.Contains(input, StringComparison.OrdinalIgnoreCase) ||
                            p.Nomor_HP.Contains(input, StringComparison.OrdinalIgnoreCase) ||
                            p.Email.Contains(input, StringComparison.OrdinalIgnoreCase) ||
                            p.Alamat.Contains(input, StringComparison.OrdinalIgnoreCase))
                .ToList();

            GridListData.DataSource = result;
        }


        public class PelangganDto
        {
            public int No { get; set; }
            public string Nomor_KTP { get; set; }
            public string Nama_Pelanggan { get; set; }
            public string Nomor_HP { get; set; }
            public string Alamat { get; set; }
            public string Email { get; set; }
            public int Total_Servis { get; set; }
        }
    }
}
