
CREATE TABLE tb_booking (
    id_booking INT IDENTITY(1,1) PRIMARY KEY,
    no_ktp VARCHAR(20) NOT NULL DEFAULT(''),
    tanggal DATETIME NOT NULL DEFAULT('2000-09-09'),
    antrean INT NOT NULL DEFAULT(0),
    keluhan VARCHAR(225) NOT NULL DEFAULT(''),
    status VARCHAR(50) NOT NULL DEFAULT(''),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    CONSTRAINT fk_booking_pelanggan FOREIGN KEY (no_ktp) REFERENCES tb_pelanggan(no_ktp)
        ON DELETE CASCADE
);