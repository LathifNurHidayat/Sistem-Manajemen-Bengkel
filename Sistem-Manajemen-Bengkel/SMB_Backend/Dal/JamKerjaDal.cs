using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistem_Manajemen_Bengkel.Helper;
using Dapper;
using Syncfusion.Windows.Forms.Chart;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class JamKerjaDal
    {
        public void SaveData(JamKerjaModel jamKerja)
        {
            const string sql = @"INSERT INTO tb_jam_kerja
                                    (hari, jam_buka, jam_tutup)
                                VALUES 
                                    (@hari, @jam_buka, @jam_tutup)";

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            var Dp = new DynamicParameters();

            Dp.Add("@hari", jamKerja.hari);
            Dp.Add("@jam_buka", jamKerja.jam_buka);
            Dp.Add("@jam_tutup", jamKerja.jam_tutup);

            Conn.Execute(sql, Dp);
        }


        public void UpdateData(JamKerjaModel jamKerja)
        {
            const string sql = @"UPDATE 
                                    tb_jam_kerja
                                SET 
                                    jam_buka = @jam_buka,
                                    jam_tutup = @jam_tutup
                                WHERE 
                                    hari = @hari"; 

            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            var Dp = new DynamicParameters();

            Dp.Add("@hari", jamKerja.hari);
            Dp.Add("@jam_buka", jamKerja.jam_buka);
            Dp.Add("@jam_tutup", jamKerja.jam_tutup);

            Conn.Execute(sql, Dp);
        }


        public IEnumerable<JamKerjaModel> GetData()
        {
            const string sql = @"SELECT 
                                    id_jam_kerja, hari, jam_buka, jam_tutup
                                FROM tb_jam_kerja";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.Query<JamKerjaModel>(sql);
        }

    }

   
}
