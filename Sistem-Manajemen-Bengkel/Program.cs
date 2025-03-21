using Sistem_Manajemen_Bengkel.SMB_Backend.Dal;
using Sistem_Manajemen_Bengkel.SMB_Form;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.BookingForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.InputEditForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.KandaraanForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.MekanikForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.PopUpForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.MainMenuForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdminForm;
using Sistem_Manajemen_Bengkel.SMB_Form.LoginRegisterForm;
using Sistem_Manajemen_Bengkel.SMB_Form.SuperAdminForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.DashboardForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Pelanggan.MainMenuForm;
using Sistem_Manajemen_Bengkel.SMB_Form.Karyawan_SuperAdmin.RiwayatForm;
using Sistem_Manajemen_Bengkel.SMB_Form.StartupForm;

namespace Sistem_Manajemen_Bengkel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWX5fcHRQRmdcUUx2WEQ=");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new StartupForm());
        }
    }
} 