using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Manajemen_Bengkel.SMB_Helper
{
    public class ImageDirectoryHelper
    {
        public static Image _defaultProfilesOnGrid = ImageHelper.GetHighQualityThumbnail(Properties.Resources.user, 40, 40);
        public static Image _defaultProfiles = ImageHelper.GetHighQualityThumbnail(Properties.Resources.user, 100, 100);



        public static Image _statusMenunggu = ImageHelper.GetHighQualityThumbnail(Properties.Resources.Menunggu, 80, 40);

        public static Image _statusDikerjakan = ImageHelper.GetHighQualityThumbnail(Properties.Resources.Dikerjakan, 80, 40);

        public static Image _statusSelesai = ImageHelper.GetHighQualityThumbnail(Properties.Resources.Selesai, 80, 40);

        public static Image _statusDibatalkan = ImageHelper.GetHighQualityThumbnail(Properties.Resources.Dibatalkan, 80, 40);



        public static Image _roleSuperAdmin = ImageHelper.GetHighQualityThumbnail(Properties.Resources.SuperAdmin, 148, 40);

        public static Image _rolePetugas = ImageHelper.GetHighQualityThumbnail(Properties.Resources.Petugas, 148, 40);



        public static Image _sparepartHabis = ImageHelper.GetHighQualityThumbnail(Properties.Resources.Habis, 148, 40);

        public static Image _sparepartMenipis = ImageHelper.GetHighQualityThumbnail(Properties.Resources.Menipis, 148, 40);

        public static Image _sparepartTersedia = ImageHelper.GetHighQualityThumbnail(Properties.Resources.Tersedia, 148, 40);

        public static Image _sparepartDefault = ImageHelper.GetHighQualityThumbnail(Properties.Resources.gallery, 40, 40);
    }
}
