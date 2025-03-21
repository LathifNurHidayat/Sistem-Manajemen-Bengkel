﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon;
using Dapper;
using Sistem_Manajemen_Bengkel.Helper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class BatasBookingDal
    {
        public IEnumerable<BatasBookingModel> LoadBatasBooking()
        {
            const string sql = "SELECT id_batas_booking, tanggal, batas_booking FROM tb_batas_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return Conn.Query<BatasBookingModel>(sql);
        }

        public int? ShowBatasBooking(DateTime tanggal)
        {
            const string sql = @"SELECT 
                                    batas_booking 
                                FROM 
                                    tb_batas_booking
                                WHERE
                                    CAST(tanggal AS DATE) = CAST(@tanggal AS DATE) OR
                                    tanggal IS NULL
                                ORDER BY CASE 
                                    WHEN  CAST(tanggal AS DATE) = CAST(@tanggal AS DATE) THEN 0
                                    ELSE 1
                                    END ";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return Conn.QueryFirstOrDefault<int>(sql, new {tanggal});
        }

        public void InsertBatasBooking(BatasBookingModel batas)
        {
            const string sql = @"INSERT INTO tb_batas_booking 
                                    (tanggal, batas_booking)
                                VALUES 
                                    (@tanggal, @batas_booking)";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            
            var Dp = new DynamicParameters();
            Dp.Add("@tanggal", batas.tanggal);
            Dp.Add("@batas_booking", batas.batas_booking);

            Conn.Execute(sql, Dp);
        }

        public void UpdateBatasBooking(BatasBookingModel batas)
        {
            const string sql = @"UPDATE tb_batas_booking SET 
                                    tanggal = @tanggal, 
                                    batas_booking = @batas_booking
                                WHERE 
                                    id_batas_booking = @id_batas_booking";

            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
          
            var Dp = new DynamicParameters();
            Dp.Add("@id_batas_booking", batas.id_batas_booking);
            Dp.Add("@tanggal", batas.tanggal); 
            Dp.Add("@batas_booking", batas.batas_booking);

            Conn.Execute(sql, Dp);
        }

        public void DeleteBatasBooking(int id_batas_booking)
        {
            const string sql = @"DELETE FROM tb_batas_booking WHERE id_batas_booking = @id_batas_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            Conn.Execute(sql, new { id_batas_booking});
        }
        
        public void DeleteUsingTanggal(DateTime tanggal)
        {
            const string sql = @"DELETE FROM tb_batas_booking WHERE tanggal = @tanggal";
            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            Conn.Execute(sql, new { tanggal});
        }

        public BatasBookingModel? GetDataBatasBooking (int id_batas_booking)
        {
            const string sql = @"SELECT id_batas_booking , tanggal, batas_booking FROM tb_batas_booking WHERE id_batas_booking = @id_batas_booking";
            using var Conn = new SqlConnection(ConnStringHelper.GetConnByUserID());
            return Conn.QueryFirstOrDefault<BatasBookingModel>(sql, new { id_batas_booking });
        }

    }

   
}
