CREATE TABLE tb_riwayat_sparepart (
    id_sparepart_riwayat INT NOT NULL,
    id_sparepart INT NOT NULL,
    CONSTRAINT fk_riwayatdetil_riwayat FOREIGN KEY (id_sparepart_riwayat) REFERENCES tb_riwayat (id_riwayat) 
        ON DELETE CASCADE   
);
