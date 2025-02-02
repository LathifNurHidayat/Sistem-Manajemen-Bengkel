﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.Helper;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class PetugasDal
    {
        public PetugasModel? ValidasiLoginPetugas(string email, string password)
        {
            const string sql = "SELECT id_petugas, nama_petugas, role FROM tb_petugas WHERE email = @email AND password = @password";
            using var Conn = new SqlConnection(ConnStringHelper.GetConn());
            return Conn.QueryFirstOrDefault<PetugasModel>(sql, new { email, password });
        }
    }
}
