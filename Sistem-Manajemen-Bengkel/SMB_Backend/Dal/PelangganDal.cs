using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Sistem_Manajemen_Bengkel.SMB_Backend.Model;
using Sistem_Manajemen_Bengkel.SMB_Database;
using System.Data;

namespace Sistem_Manajemen_Bengkel.SMB_Backend.Dal
{
    public class PelangganDal
    {

    }
}


CREATE TABLE tb_pelanggan (
	no_ktp INT PRIMARY KEY,
    nama_pelanggan VARCHAR(100) NOT NULL DEFAULT(''),
    no_hp VARCHAR(20) NOT NULL DEFAULT(''),
    alamat VARCHAR(225) NOT NULL DEFAULT(''),
    email VARCHAR(50) NOT NULL DEFAULT(''),
    password VARCHAR(225) NOT NULL DEFAULT(''),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE()
	);