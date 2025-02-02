CREATE TABLE tb_sparepart (
    id_sparepart INT IDENTITY(1,1) PRIMARY KEY,
    nama_sparepart VARCHAR(100) NOT NULL DEFAULT(''),
    harga DECIMAL(15, 2) NOT NULL DEFAULT(0),
    stok INT NOT NULL DEFAULT(0),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE()
);