CREATE TABLE tb_jasa_servis (
    id_jasa_servis INT IDENTITY(1,1) PRIMARY KEY,
    jenis_servis VARCHAR(30) NOT NULL,
    keterangan VARCHAR(100) NOT NULL,
    biaya DECIMAL(10,2) NOT NULL DEFAULT(0),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE()
);
