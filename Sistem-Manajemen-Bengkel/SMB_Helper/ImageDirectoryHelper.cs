using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Helper
{
    public class ImageDirectoryHelper
    {
        public static Image _defaultProfilesOnGrid = Properties.Resources.user1.GetThumbnailImage(40, 40, () => false, IntPtr.Zero);

        public static Image _statusMenunggu = Properties.Resources.Menunggu.GetThumbnailImage(80, 40, () => false, IntPtr.Zero);


        public static Image _statusDikerjakan = Properties.Resources.Dikerjakan.GetThumbnailImage(80, 40, () => false, IntPtr.Zero);

        public static Image _statusSelesai = Properties.Resources.Selesai.GetThumbnailImage(80, 40, () => false, IntPtr.Zero);

        public static Image _statusDibatalkan = Properties.Resources.Dibatalkan.GetThumbnailImage(80, 40, () => false, IntPtr.Zero);


        public static Image _roleSuperAdmin = Properties.Resources.SuperAdmin.GetThumbnailImage(148, 40, () => false, IntPtr.Zero);

        public static Image _rolePetugas = Properties.Resources.Petugas.GetThumbnailImage(148, 40, () => false, IntPtr.Zero);
    }
}
