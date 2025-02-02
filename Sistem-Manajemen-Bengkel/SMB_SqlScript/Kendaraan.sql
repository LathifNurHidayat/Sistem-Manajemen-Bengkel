CREATE TABLE tb_kendaraan (
    id_kendaraan INT IDENTITY(1,1) PRIMARY KEY,
    no_ktp VARCHAR(20) NOT NULL DEFAULT(''),
    no_polisi VARCHAR(20) NOT NULL DEFAULT(''),
    merek VARCHAR(50) NOT NULL DEFAULT(''),
    transmisi VARCHAR(20) NOT NULL DEFAULT(''),
    kapasitas_mesin INT NOT NULL DEFAULT(0),
    tahun INT NOT NULL DEFAULT(0),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    CONSTRAINT fk_kendaraan_pelanggan FOREIGN KEY (no_ktp) REFERENCES tb_pelanggan(no_ktp)
        ON DELETE CASCADE
);
