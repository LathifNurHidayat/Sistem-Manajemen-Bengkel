
CREATE TABLE tb_pelanggan (
    no_ktp_pelanggan VARCHAR(20) NOT NULL PRIMARY KEY,
    nama_pelanggan VARCHAR(100),
    no_hp VARCHAR(20),
    alamat VARCHAR(225), 
    email VARCHAR(50),
    password VARCHAR(225),
    total_servis INT,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL
);


CREATE TABLE tb_pegawai (
    no_ktp_pegawai VARCHAR(20) NOT NULL PRIMARY KEY,
    nama_pegawai VARCHAR(100),
    email VARCHAR(20),
    password VARCHAR(225),
    no_hp VARCHAR(50),
    alamat VARCHAR(225),
    role INT,
    image_data VARBINARY(MAX),
    created_at DATETIME DEFAULT GETDATE(),  
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL
);

CREATE TABLE tb_mekanik (
    no_ktp_mekanik VARCHAR(20) NOT NULL PRIMARY KEY,
    nama_mekanik VARCHAR(100),
    no_hp VARCHAR(50),
    alamat VARCHAR(225),
    spesialis VARCHAR(225),
    image_data VARBINARY(MAX),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL
);

CREATE TABLE tb_jasa_servis (
    id_jasa_servis INT IDENTITY(1,1) PRIMARY KEY,
    jenis_servis VARCHAR(50),
    keterangan VARCHAR(225),
    biaya DECIMAL(18,2),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL
);

CREATE TABLE tb_batas_booking(
    id_batas_booking INT IDENTITY(1,1) PRIMARY KEY,
    tanggal DATETIME,
    batas_booking INT,
    created_at DATETIME DEFAULT GETDATE()
);

CREATE TABLE tb_sparepart(
    id_sparepart INT IDENTITY(1,1) PRIMARY KEY,
    nama_sparepart VARCHAR(50),
    harga DECIMAL(18,2),
    stok INT,
    stok_minimal INT,
    status_stok INT,
    image_data VARBINARY(MAX),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL
);


CREATE TABLE tb_kendaraan (
    id_kendaraan INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    no_ktp_pelanggan VARCHAR(20),
    no_polisi VARCHAR(20),
    merek VARCHAR(50),
    transmisi INT,
    kapasitas_mesin INT,
    tahun INT,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL,

    CONSTRAINT fk_kendaraan_pelanggan FOREIGN KEY (no_ktp_pelanggan) REFERENCES tb_pelanggan(no_ktp_pelanggan)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);



CREATE  TABLE tb_penggunaan_sparepart (
    id_penggunaan_sparepart INT IDENTITY(1,1) PRIMARY KEY,
    id_sparepart INT,
    jumlah INT,
    harga Decimal(18,2),
    CONSTRAINT fk_penggunaan_sparepart_sparepart FOREIGN KEY (id_sparepart) REFERENCES tb_sparepart(id_sparepart),
);

CREATE TABLE tb_booking (
    id_booking INT IDENTITY(1,1) PRIMARY KEY,
    no_ktp_pelanggan VARCHAR(20),
    no_ktp_mekanik VARCHAR(20),
    id_kendaraan INT,
    id_jasa_servis INT,
    id_penggunaan_sparepart INT,

    nama_pelanggan VARCHAR(50),
    no_polisi VARCHAR(20),
    merek VARCHAR(50),
    transmisi INT,
    kapasitas_mesin INT,

    tanggal DATETIME,
    antrean INT,
    keluhan VARCHAR(225),
    catatan VARCHAR(225),
    status INT,
    created_at DATETIME DEFAULT GETDATE(),
    
    CONSTRAINT fk_booking_pelanggan FOREIGN KEY (no_ktp_pelanggan) REFERENCES tb_pelanggan(no_ktp_pelanggan)
        ON DELETE CASCADE
        ON UPDATE CASCADE,

    CONSTRAINT fk_booking_mekanik FOREIGN KEY (no_ktp_mekanik) REFERENCES tb_mekanik(no_ktp_mekanik)
        ON UPDATE CASCADE,

    CONSTRAINT fk_booking_kendaraan FOREIGN KEY (id_kendaraan) REFERENCES tb_kendaraan(id_kendaraan),

    CONSTRAINT fk_booking_jasa_servis FOREIGN KEY (id_jasa_servis) REFERENCES tb_jasa_servis(id_jasa_servis),

    CONSTRAINT fk_booking_penggunaan_sparepart FOREIGN KEY (id_penggunaan_sparepart) REFERENCES tb_penggunaan_sparepart (id_penggunaan_sparepart)
);


CREATE TABLE tb_riwayat(
    id_riwayat INT IDENTITY(1,1) PRIMARY KEY,
    id_jasa_servis INT,
    no_ktp_pelanggan VARCHAR(20),
    no_ktp_pegawai VARCHAR(20),
    no_ktp_mekanik VARCHAR(20),
    id_kendaraan INT,
    id_penggunaan_sparepart INT,

    nama_pelanggan VARCHAR(50),
    no_polisi VARCHAR(20),
    merek VARCHAR(50),
    transmisi INT,
    kapasitas_mesin INT,

    tanggal DATETIME,
    keluhan VARCHAR(225),
    catatan VARCHAR(225),
    total_biaya DECIMAL(18,2),
    status VARCHAR(50),
    created_at DATETIME DEFAULT GETDATE(),

    CONSTRAINT fk_riwayat_jasa_servis FOREIGN KEY (id_jasa_servis) REFERENCES tb_jasa_servis(id_jasa_servis),
    CONSTRAINT fk_riwayat_pelanggan FOREIGN KEY (no_ktp_pelanggan) REFERENCES tb_pelanggan(no_ktp_pelanggan)
        ON UPDATE CASCADE 
        ON DELETE CASCADE,

    CONSTRAINT fk_riwayat_pegawai FOREIGN KEY (no_ktp_pegawai) REFERENCES tb_pegawai(no_ktp_pegawai)
        ON UPDATE CASCADE, 

    CONSTRAINT fk_riwayat_mekanik FOREIGN KEY (no_ktp_mekanik) REFERENCES tb_mekanik(no_ktp_mekanik)
        ON UPDATE CASCADE, 

    CONSTRAINT fk_riwayat_kendaraan FOREIGN KEY (id_kendaraan) REFERENCES tb_kendaraan(id_kendaraan),
    CONSTRAINT fk_riwayat_penggunaan_sparepart FOREIGN KEY (id_penggunaan_sparepart) REFERENCES tb_penggunaan_sparepart(id_penggunaan_sparepart)
);


CREATE TABLE tb_log_sparepart (
    id_log_sparepart INT IDENTITY(1,1) PRIMARY KEY,
    no_ktp_pegawai VARCHAR(20),
    id_sparepart INT,
    nama_sparepart VARCHAR(50),
    aksi VARCHAR(50),
    stok_awal INT,
    stok_akhir INT,
    tanggal DATETIME,

    CONSTRAINT dk_log_sparepart_pegawai FOREIGN KEY (no_ktp_pegawai) REFERENCES tb_pegawai(no_ktp_pegawai),
);

