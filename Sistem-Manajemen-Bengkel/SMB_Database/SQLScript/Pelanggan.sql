CREATE TABLE tb_riwayat (
    id_riwayat INT IDENTITY(1,1) PRIMARY KEY, 
    id_jasa_servis INT NOT NULL DEFAULT(0),
    no_ktp INT NOT NULL DEFAULT(0), 
    id_kendaraan INT NOT NULL DEFAULT(0),
    id_riwayat_sparepart INT NOT NULL DEFAULT(0), 
    id_petugas INT NOT NULL DEFAULT(0), 
    tanggal DATETIME NOT NULL DEFAULT('2000-09-09'), 
    keluhan VARCHAR(225) NOT NULL DEFAULT(''), 
    catatan VARCHAR(225) NOT NULL DEFAULT(''),
    total_biaya DECIMAL(15, 2) NOT NULL DEFAULT(0), 
    status VARCHAR(50) NOT NULL DEFAULT(''),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(), 

    CONSTRAINT fk_jasa_servis FOREIGN KEY (id_jasa_servis) REFERENCES jasa_servis(id_jasa_servis),
    CONSTRAINT fk_pelanggan FOREIGN KEY (no_ktp) REFERENCES pelanggan(no_ktp),
    CONSTRAINT fk_kendaraan FOREIGN KEY (id_kendaraan) REFERENCES kendaraan(id_kendaraan),
    CONSTRAINT fk_riwayat_sparepart FOREIGN KEY (id_riwayat_sparepart) REFERENCES riwayat_sparepart(id_riwayat_sparepart),
    CONSTRAINT fk_petugas FOREIGN KEY (id_petugas) REFERENCES petugas(id_petugas)
);



CREATE TABLE 