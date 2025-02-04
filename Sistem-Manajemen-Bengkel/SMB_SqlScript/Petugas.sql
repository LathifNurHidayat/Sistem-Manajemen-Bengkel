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
INSERT INTO tb_petugas (nama_petugas, email, password, no_hp, alamat, role)
values ('Super Admin Bengkel', 'superadmin@gmail.com', 'Admin_#@123', '081234567890', '','Super Admin')