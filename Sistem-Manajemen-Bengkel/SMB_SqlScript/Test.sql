-------------------------------------------------
-- 1. Insert 500 Data ke tb_pelanggan
-------------------------------------------------
DECLARE @i INT = 1;
WHILE @i <= 100
BEGIN
    INSERT INTO tb_pelanggan 
        (no_ktp_pelanggan, nama_pelanggan, no_hp, alamat, email, password, total_servis)
    VALUES (
        -- Membuat no_ktp_pelanggan secara unik misalnya dengan menggabungkan prefix dengan nilai counter
        '32010110000' + RIGHT('000' + CAST(@i AS VARCHAR(4)), 4),  
        'Pelanggan_' + CAST(@i AS VARCHAR(10)),  
        '0812' + RIGHT('000000000' + CAST(@i AS VARCHAR(9)), 9),  
        'Alamat Pelanggan ' + CAST(@i AS VARCHAR(10)),  
        'pelanggan' + CAST(@i AS VARCHAR(10)) + '@example.com',  
        'password' + CAST(@i AS VARCHAR(10)),  
        0  -- Misal total_servis diinisialisasi 0
    );
    SET @i = @i + 1;
END;

-------------------------------------------------
-- 2. Insert 500 Data ke tb_pegawai
-------------------------------------------------
SET @i = 1;
WHILE @i <= 500
BEGIN
    INSERT INTO tb_pegawai 
        (no_ktp_pegawai, nama_pegawai, email, password, no_hp, alamat, role, image_name, image_data)
    VALUES (
        '32010120000' + RIGHT('000' + CAST(@i AS VARCHAR(4)), 4),
        'Pegawai_' + CAST(@i AS VARCHAR(10)),
        'pegawai' + CAST(@i AS VARCHAR(10)) + '@example.com',
        'password' + CAST(@i AS VARCHAR(10)),
        '0813' + RIGHT('000000000' + CAST(@i AS VARCHAR(9)), 9),
        'Alamat Pegawai ' + CAST(@i AS VARCHAR(10)),
        CASE WHEN @i % 2 = 0 THEN 1 ELSE 2 END,  -- Contoh pembagian role secara bergantian
        NULL,
        NULL
    );
    SET @i = @i + 1;
END;

-------------------------------------------------
-- 3. Insert 500 Data ke tb_mekanik
-------------------------------------------------
SET @i = 1;
WHILE @i <= 500
BEGIN
    INSERT INTO tb_mekanik 
        (no_ktp_mekanik, nama_mekanik, no_hp, alamat, spesialis, image_name, image_data)
    VALUES (
        '32010130000' + RIGHT('000' + CAST(@i AS VARCHAR(4)), 4),
        'Mekanik_' + CAST(@i AS VARCHAR(10)),
        '0814' + RIGHT('000000000' + CAST(@i AS VARCHAR(9)), 9),
        'Alamat Mekanik ' + CAST(@i AS VARCHAR(10)),
        CASE 
            WHEN @i % 3 = 0 THEN 'Mesin'
            WHEN @i % 3 = 1 THEN 'Kelistrikan'
            ELSE 'Body & Cat'
        END,
        NULL,
        NULL
    );
    SET @i = @i + 1;
END;

-------------------------------------------------
-- 4. Insert 500 Data ke tb_jasa_servis
-------------------------------------------------
SET @i = 1;
WHILE @i <= 500
BEGIN
    INSERT INTO tb_jasa_servis 
        (jenis_servis, keterangan, biaya)
    VALUES (
        'Jasa Servis ' + CAST(@i AS VARCHAR(10)),
        'Keterangan jasa servis ' + CAST(@i AS VARCHAR(10)),
        100000 + (@i * 1000)  -- Contoh perhitungan biaya
    );
    SET @i = @i + 1;
END;

-------------------------------------------------
-- 5. Insert 500 Data ke tb_batas_booking
-------------------------------------------------
SET @i = 1;
WHILE @i <= 500
BEGIN
    INSERT INTO tb_batas_booking 
        (tanggal, batas_booking)
    VALUES (
        DATEADD(DAY, @i, GETDATE()),
        10 + (@i % 10)  -- Nilai batas booking antara 10 s.d. 19
    );
    SET @i = @i + 1;
END;

-------------------------------------------------
-- 6. Insert 500 Data ke tb_sparepart
-------------------------------------------------
SET @i = 1;
WHILE @i <= 500
BEGIN
    INSERT INTO tb_sparepart 
        (nama_sparepart, harga, stok, stok_minimal, status_stok)
    VALUES (
        'Sparepart ' + CAST(@i AS VARCHAR(10)),
        50000 + (@i * 100),  
        100 + @i,
        10,
        'Tersedia'
    );
    SET @i = @i + 1;
END;

-------------------------------------------------
-- 7. Insert 500 Data ke tb_kendaraan
-------------------------------------------------
SET @i = 1;
WHILE @i <= 500
BEGIN
    INSERT INTO tb_kendaraan 
        (no_ktp_pelanggan, no_polisi, merek, transmisi, kapasitas_mesin, tahun)
    VALUES (
        '32010110000' + RIGHT('000' + CAST(@i AS VARCHAR(4)), 4),  -- Mengacu ke tb_pelanggan
        'B ' + CAST(1000 + @i AS VARCHAR(10)) + ' ABC',
        'Merek_' + CAST(@i AS VARCHAR(10)),
        CASE WHEN @i % 2 = 0 THEN 'Automatic' ELSE 'Manual' END,
        1500 + (@i % 3) * 100,
        2000 + (@i % 25)
    );
    SET @i = @i + 1;
END;

-------------------------------------------------
-- 8. Insert 500 Data ke tb_booking
-------------------------------------------------
SET @i = 1;
WHILE @i <= 500
BEGIN
    INSERT INTO tb_booking 
        (no_ktp_pelanggan, no_ktp_mekanik, id_kendaraan, id_jasa_servis, tanggal, antrean, keluhan, status)
    VALUES (
        '32010110000' + RIGHT('000' + CAST(@i AS VARCHAR(4)), 4),
        '32010130000' + RIGHT('000' + CAST(@i AS VARCHAR(4)), 4),
         @i,        -- Asumsikan id_kendaraan dihasilkan berurutan dari 1 ke 500
         @i,        -- Asumsikan id_jasa_servis dihasilkan berurutan dari 1 ke 500
        DATEADD(MINUTE, @i, GETDATE()),
         @i,        -- Nomor antrean sama dengan counter
        'Keluhan ' + CAST(@i AS VARCHAR(10)),
        'Menunggu'
    );
    SET @i = @i + 1;
END;

-------------------------------------------------
-- 9. Insert 500 Data ke tb_riwayat
-------------------------------------------------
SET @i = 1;
WHILE @i <= 500
BEGIN
    INSERT INTO tb_riwayat 
        (id_jasa_servis, no_ktp_pelanggan, no_ktp_pegawai, no_ktp_mekanik, id_kendaraan, id_riwayat_sparepart, tanggal, keluhan, catatan, total_biaya, status)
    VALUES (
         @i,  -- id_jasa_servis (misal sama dengan counter)
        '32010110000' + RIGHT('000' + CAST(@i AS VARCHAR(4)), 4),
        '32010120000' + RIGHT('000' + CAST(@i AS VARCHAR(4)), 4),
        '32010130000' + RIGHT('000' + CAST(@i AS VARCHAR(4)), 4),
         @i,  -- id_kendaraan
         NULL,  -- id_riwayat_sparepart dibiarkan NULL atau bisa diisi sesuai kebutuhan
        DATEADD(MINUTE, @i, GETDATE()),
        'Keluhan ' + CAST(@i AS VARCHAR(10)),
        'Catatan ' + CAST(@i AS VARCHAR(10)),
        100000 + (@i * 500),
        'Selesai'
    );
    SET @i = @i + 1;
END;




