CREATE TABLE tb_petugas (
    id_petugas INT IDENTITY(1,1) PRIMARY KEY,
    nama_petugas VARCHAR(100) NOT NULL DEFAULT(''),
    email VARCHAR(20) NOT NULL DEFAULT(''),
    password VARCHAR(225) NOT NULL DEFAULT(''),
    no_hp VARCHAR(50) NOT NULL DEFAULT(''),
    alamat VARCHAR(225) NOT NULL DEFAULT(''),
    role VARCHAR(50) NOT NULL DEFAULT(''),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE()
);

