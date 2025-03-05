using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.Input;

namespace Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.DashboardForm
{
    public partial class JamKerjaForm : Form
    {
        private readonly JamKerjaDal _jamKerjaDal;
        public JamKerjaForm()
        {
            InitializeComponent();
            _jamKerjaDal = new JamKerjaDal();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            GetData();
            RegisterControlEvent();
        }

        private void GetData()
        {
            var data = _jamKerjaDal.GetData()?.ToDictionary(x => x.hari, x => (x.jam_buka, x.jam_tutup));

            if (data == null || data.Count == 0) return;

            SeninBuka.Value = data.ContainsKey("Senin") ? DateTime.Today + data["Senin"].Item1 : DateTime.Today;
            SeninTutup.Value = data.ContainsKey("Senin") ? DateTime.Today + data["Senin"].Item2 : DateTime.Today;

            SelasaBuka.Value = data.ContainsKey("Selasa") ? DateTime.Today + data["Selasa"].Item1 : DateTime.Today;
            SelasaTutup.Value = data.ContainsKey("Selasa") ? DateTime.Today + data["Selasa"].Item2 : DateTime.Today;

            RabuBuka.Value = data.ContainsKey("Rabu") ? DateTime.Today + data["Rabu"].Item1 : DateTime.Today;
            RabuTutup.Value = data.ContainsKey("Rabu") ? DateTime.Today + data["Rabu"].Item2 : DateTime.Today;

            KamisBuka.Value = data.ContainsKey("Kamis") ? DateTime.Today + data["Kamis"].Item1 : DateTime.Today;
            KamisTutup.Value = data.ContainsKey("Kamis") ? DateTime.Today + data["Kamis"].Item2 : DateTime.Today;

            JumatBuka.Value = data.ContainsKey("Jumat") ? DateTime.Today + data["Jumat"].Item1 : DateTime.Today;
            JumatTutup.Value = data.ContainsKey("Jumat") ? DateTime.Today + data["Jumat"].Item2 : DateTime.Today;

            SabtuBuka.Value = data.ContainsKey("Sabtu") ? DateTime.Today + data["Sabtu"].Item1 : DateTime.Today;
            SabtuTutup.Value = data.ContainsKey("Sabtu") ? DateTime.Today + data["Sabtu"].Item2 : DateTime.Today;

            MingguBuka.Value = data.ContainsKey("Minggu") ? DateTime.Today + data["Minggu"].Item1 : DateTime.Today;
            MingguTutup.Value = data.ContainsKey("Minggu") ? DateTime.Today + data["Minggu"].Item2 : DateTime.Today;
        }



        private void SaveData()
        {
            List<string> hari = new List<string>()
            {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };

            List<SfDateTimeEdit> picker = new List<SfDateTimeEdit>()
            {
                SeninBuka, SeninTutup, SelasaBuka, SelasaTutup, RabuBuka, RabuTutup,
                KamisBuka, KamisTutup, JumatBuka, JumatTutup, SabtuBuka, SabtuTutup,
                MingguBuka, MingguTutup
            };

            var jamKerjaList = new List<JamKerjaModel>();

            for (int i = 0; i< hari.Count; i++)
            {
                var jam_buka = picker[i * 2].Value.HasValue ? picker[i * 2].Value.Value.TimeOfDay : (TimeSpan?)null;
                var jam_tutup = picker[i * 2 + 1].Value.HasValue ? picker[i * 2 + 1].Value.Value.TimeOfDay : (TimeSpan?)null;

                var jamKerja = new JamKerjaModel
                {
                    hari = hari[i],
                    jam_buka = jam_buka,
                    jam_tutup = jam_tutup
                };

                jamKerjaList.Add(jamKerja);
            }

            foreach (var item in jamKerjaList)
                _jamKerjaDal.UpdateData(item);
        }


        private void RegisterControlEvent()
        {
            ButtonBatal.Click += ButtonBatal_Click;
            ButtonSimpan.Click += ButtonSimpan_Click;
        }

        private void ButtonSimpan_Click(object? sender, EventArgs e)
        {
            SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonBatal_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
