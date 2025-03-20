using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class InformasiBengkelDal
    {
        public InformasiBengkelModel? GetData()
        {
            const string sql = @"SELECT id_informasi_bengkel, nama_bengkel, alamat, email, no_telp FROM tb_informasi_bengkel";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return Conn.QueryFirstOrDefault<InformasiBengkelModel>(sql);
        }

        public void UpdateData(InformasiBengkelModel bengkel)
        {
            const string sql = @"UPDATE tb_informasi_bengkel 
                                SET 
                                    nama_bengkel = @nama_bengkel, 
                                    alamat = @alamat, 
                                    email = @email, 
                                    no_telp = @no_telp";


            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            var Dp = new DynamicParameters();
            Dp.Add("@nama_bengkel", bengkel.nama_bengkel);
            Dp.Add("@alamat", bengkel.alamat);
            Dp.Add("@email", bengkel.email);
            Dp.Add("@no_telp", bengkel.no_telp);

            Conn.Execute(sql, Dp);
        }

    }

}
