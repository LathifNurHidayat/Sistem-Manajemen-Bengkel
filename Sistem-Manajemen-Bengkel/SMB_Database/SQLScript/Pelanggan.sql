CREATE TABLE tb_pelanggan (
	no_ktp INT PRIMARY KEY,
	nama_pelanggan VARCHAR(100) NOT NULL DEFAULT(''),
	no_hp VARCHAR(20) NOT NULL DEFAULT(''),
    alamat VARCHAR(225) NOT NULL DEFAULT(''),
	email VARCHAR(50) NOT NULL DEFAULT(''),
	password VARCHAR(225) NOT NULL DEFAULT(''),
	created_at DATETIME DEFAULT GETDATE(),
	updated_at DATETIME DEFAULT GETDATE()
	)


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


CREATE TABLE tb_kendaraan (
    id_kendaraan INT IDENTITY(1,1) PRIMARY KEY,
    no_ktp INT NOT NULL,
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


CREATE TABLE tb_sparepart (
    id_sparepart INT IDENTITY(1,1) PRIMARY KEY,
    nama_sparepart VARCHAR(100) NOT NULL DEFAULT(''),
    harga DECIMAL(15, 2) NOT NULL DEFAULT(0),
    stok INT NOT NULL DEFAULT(0),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE()
);
  


CREATE TABLE tb_riwayat_sparepart (
    id_sparepart_riwayat INT NOT NULL,
    id_sparepart INT NOT NULL,


);



CREATE TABLE tb_jasa_servis (
    id_jasa_servis INT IDENTITY(1,1) PRIMARY KEY,
    jenis_servis VARCHAR(50) NOT NULL DEFAULT(''),
    keterangan VARCHAR(225) NOT NULL DEFAULT(''),
    biaya DECIMAL(15, 2) NOT NULL DEFAULT(0),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE()
);



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
    CONSTRAINT fk_riwayat_jasa_servis FOREIGN KEY (id_jasa_servis) REFERENCES tb_jasa_servis(id_jasa_servis)
        ON DELETE CASCADE,
    CONSTRAINT fk_riwayat_pelanggan FOREIGN KEY (no_ktp) REFERENCES tb_pelanggan(no_ktp)
        ON DELETE CASCADE,
    CONSTRAINT fk_riwayat_kendaraan FOREIGN KEY (id_kendaraan) REFERENCES tb_kendaraan(id_kendaraan)
        ON DELETE CASCADE,
    CONSTRAINT fk_riwayat_sparepart FOREIGN KEY (id_riwayat_sparepart) REFERENCES tb_riwayat_sparepart(id_sparepart_riwayat)
        ON DELETE CASCADE,
    CONSTRAINT fk_riwayat_petugas FOREIGN KEY (id_petugas) REFERENCES tb_petugas(id_petugas)
        ON DELETE CASCADE
);




CREATE TABLE tb_booking (
    id_booking INT IDENTITY(1,1) PRIMARY KEY,
    no_ktp INT NOT NULL,
    tanggal DATETIME NOT NULL DEFAULT('2000-09-09'),
    antrean INT NOT NULL DEFAULT(0),
    keluhan VARCHAR(225) NOT NULL DEFAULT(''),
    status VARCHAR(50) NOT NULL DEFAULT(''),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    CONSTRAINT fk_booking_pelanggan FOREIGN KEY (no_ktp) REFERENCES tb_pelanggan(no_ktp)
        ON DELETE CASCADE
);


