CREATE TRIGGER trg_KurangiStokSparepart 
ON tb_penggunaan_sparepart
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Ambil no_ktp_pegawai dari SESSION_CONTEXT
    DECLARE @no_ktp_pegawai VARCHAR(20);
    SELECT @no_ktp_pegawai = CAST(SESSION_CONTEXT(N'no_ktp_pegawai') AS VARCHAR(20));

    -- Kurangi stok sparepart
    UPDATE tb_sparepart
    SET stok = stok - i.jumlah
    FROM tb_sparepart s
    INNER JOIN inserted i ON s.id_sparepart = i.id_sparepart;

    -- Log perubahan stok
    INSERT INTO tb_log_sparepart (no_ktp_pegawai, id_sparepart, nama_sparepart, aksi, stok_awal, stok_akhir, tanggal)
    SELECT 
        @no_ktp_pegawai, 
        i.id_sparepart,
        s.nama_sparepart,
        'Penggunaan',
        s.stok + i.jumlah,  -- Stok sebelum dikurangi
        s.stok,  -- Stok setelah dikurangi
        GETDATE()
    FROM inserted i
    INNER JOIN tb_sparepart s ON i.id_sparepart = s.id_sparepart;
END;
GO;





CREATE TRIGGER trg_KembalikanStokSparepart 
ON tb_penggunaan_sparepart
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Ambil no_ktp_pegawai dari SESSION_CONTEXT
    DECLARE @no_ktp_pegawai VARCHAR(20);
    SELECT @no_ktp_pegawai = CAST(SESSION_CONTEXT(N'no_ktp_pegawai') AS VARCHAR(20));

    -- Tambahkan stok kembali
    UPDATE tb_sparepart
    SET stok = stok + d.jumlah
    FROM tb_sparepart s
    INNER JOIN deleted d ON s.id_sparepart = d.id_sparepart;

    -- Log pengembalian stok
    INSERT INTO tb_log_sparepart (no_ktp_pegawai, id_sparepart, nama_sparepart, aksi, stok_awal, stok_akhir, tanggal)
    SELECT 
        @no_ktp_pegawai, 
        d.id_sparepart,
        s.nama_sparepart,
        'Dibatalkan',
        s.stok - d.jumlah,  -- Stok sebelum dikembalikan
        s.stok,  -- Stok setelah dikembalikan
        GETDATE()
    FROM deleted d
    INNER JOIN tb_sparepart s ON d.id_sparepart = s.id_sparepart;
END;
GO;



CREATE TRIGGER trg_LogSparepart
ON tb_sparepart
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

     -- Ambil no_ktp_pegawai dari SESSION_CONTEXT
    DECLARE @no_ktp_pegawai VARCHAR(20);
    SELECT @no_ktp_pegawai = CAST(SESSION_CONTEXT(N'no_ktp_pegawai') AS VARCHAR(20));


    -- Log saat INSERT
    INSERT INTO tb_log_sparepart (no_ktp_pegawai, id_sparepart, nama_sparepart, aksi, stok_awal, stok_akhir, tanggal)
    SELECT 
        @no_ktp_pegawai,
        i.id_sparepart, 
        i.nama_sparepart, 
        'Insert', 
        NULL, -- Tidak ada stok awal saat insert
        i.stok, 
        GETDATE()
    FROM inserted i
    LEFT JOIN deleted d ON i.id_sparepart = d.id_sparepart
    WHERE d.id_sparepart IS NULL; -- Data baru (insert)

    -- Log saat UPDATE
    INSERT INTO tb_log_sparepart (no_ktp_pegawai, id_sparepart, nama_sparepart, aksi, stok_awal, stok_akhir, tanggal)
    SELECT 
        @no_ktp_pegawai,
        i.id_sparepart, 
        i.nama_sparepart, 
        'Update', 
        d.stok, 
        i.stok, 
        GETDATE()
    FROM inserted i
    INNER JOIN deleted d ON i.id_sparepart = d.id_sparepart
    WHERE 
        (i.nama_sparepart <> d.nama_sparepart OR
         i.harga <> d.harga OR
         i.stok <> d.stok OR
         i.stok_minimal <> d.stok_minimal OR
         i.status_stok <> d.status_stok OR
         i.deleted_at <> d.deleted_at);
END;
GO





CREATE TRIGGER trg_SoftDeleteSparepart
ON tb_sparepart
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

      -- Ambil no_ktp_pegawai dari SESSION_CONTEXT
    DECLARE @no_ktp_pegawai VARCHAR(20);
    SELECT @no_ktp_pegawai = CAST(SESSION_CONTEXT(N'no_ktp_pegawai') AS VARCHAR(20));

    -- Log Soft Delete jika deleted_at berubah dari NULL menjadi tanggal
    INSERT INTO tb_log_sparepart (no_ktp_pegawai, id_sparepart, nama_sparepart, aksi, stok_awal, stok_akhir, tanggal)
    SELECT 
        @no_ktp_pegawai,
        i.id_sparepart, 
        i.nama_sparepart, 
        'Soft Delete', 
        d.stok, 
        0,  -- Setelah dihapus dianggap 0
        GETDATE()
    FROM inserted i
    INNER JOIN deleted d ON i.id_sparepart = d.id_sparepart
    WHERE d.deleted_at IS NULL AND i.deleted_at IS NOT NULL;
END;
GO





CREATE TRIGGER trg_UpdateTotalServisPelanggan 
ON tb_riwayat
AFTER INSERT 
AS 
BEGIN 
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM inserted WHERE status = 2 ) 
        RETURN;

    UPDATE tb_pelanggan SET total_servis = total_servis + 1
    WHERE no_ktp_pelanggan = (SELECT no_ktp_pelanggan FROM inserted);
END; 
GO;


select * from tb_riwayat

CREATE TRIGGER trg_InsertRiwayat
ON tb_booking
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cek apakah ada perubahan status menjadi 3 atau 4
    IF NOT EXISTS (SELECT 1 FROM inserted i INNER JOIN deleted d ON i.id_booking = d.id_booking WHERE i.status IN (3,4) AND i.status <> d.status)
        RETURN;

    -- Insert ke tb_riwayat jika status booking berubah menjadi 3 atau 4
    INSERT INTO tb_riwayat (
        id_jasa_servis,
        no_ktp_pelanggan,
        no_ktp_mekanik,
        id_kendaraan,
        id_penggunaan_sparepart,
        nama_pelanggan,
        no_polisi,
        merek,
        transmisi,
        kapasitas_mesin,
        tanggal,
        keluhan,
        catatan,
        status,
        total_biaya,
        created_at
    )
    SELECT 
        i.id_jasa_servis,
        i.no_ktp_pelanggan,
        i.no_ktp_mekanik,
        i.id_kendaraan,
        ps.id_penggunaan_sparepart,  -- Menggunakan ID dari tabel `tb_penggunaan_sparepart`
        i.nama_pelanggan,
        i.no_polisi,
        i.merek,
        i.transmisi,
        i.kapasitas_mesin,
        i.tanggal,
        i.keluhan,
        i.catatan,
        CASE 
            WHEN i.status = 3 THEN 1
            ELSE 2
        END,
        ISNULL(SUM(ps.harga), 0) + ISNULL(js.biaya, 0) AS total_biaya, -- Hitung total biaya per baris
        GETDATE()
    FROM inserted i
    INNER JOIN deleted d ON i.id_booking = d.id_booking
    LEFT JOIN tb_penggunaan_sparepart ps ON ps.id_penggunaan_sparepart = i.id_booking
    LEFT JOIN tb_jasa_servis js ON i.id_jasa_servis = js.id_jasa_servis
    WHERE i.status IN (3,4) AND d.status <> i.status  -- Pastikan status benar-benar berubah
    GROUP BY 
        i.id_jasa_servis, i.no_ktp_pelanggan, i.no_ktp_mekanik, i.id_kendaraan, 
        ps.id_penggunaan_sparepart, i.nama_pelanggan, i.no_polisi, i.merek, 
        i.transmisi, i.kapasitas_mesin, i.tanggal, i.keluhan, i.catatan, 
        js.biaya, i.status;

END;
GO
