CREATE TRIGGER trg_KurangiStokSparepart 
ON tb_penggunaan_sparepart
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE tb_sparepart
    SET stok = stok - i.jumlah
    FROM tb_sparepart s
    INNER JOIN inserted i ON s.id_sparepart = i.id_sparepart;

    INSERT INTO tb_log_sparepart (id_sparepart, nama_sparepart, aksi, stok_awal, stok_akhir, tanggal)
    SELECT 
        i.id_sparepart,
        s.nama_sparepart,
        'Penggunaan',
        s.stok + i.jumlah, 
        s.stok,  
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
    SET NOCOUNT ON

    -- Tambahkan stok kembali
    UPDATE tb_sparepart
    SET stok = stok + d.jumlah
    FROM tb_sparepart s
    INNER JOIN deleted d ON s.id_sparepart = d.id_sparepart;

    -- Log pengembalian stok
    INSERT INTO tb_log_sparepart (id_sparepart, nama_sparepart, aksi, stok_awal, stok_akhir, tanggal)
    SELECT 
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

    INSERT INTO tb_log_sparepart (id_sparepart, nama_sparepart, aksi, stok_awal, stok_akhir, tanggal)
    SELECT 
        i.id_sparepart, 
        i.nama_sparepart, 
        'Insert', 
        NULL, -- Tidak ada stok awal saat insert
        i.stok, 
        GETDATE()
    FROM inserted i
    LEFT JOIN deleted d ON i.id_sparepart = d.id_sparepart
    WHERE d.id_sparepart IS NULL; 

    INSERT INTO tb_log_sparepart (id_sparepart, nama_sparepart, aksi, stok_awal, stok_akhir, tanggal)
    SELECT 
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

    INSERT INTO tb_log_sparepart (id_sparepart, nama_sparepart, aksi, stok_awal, stok_akhir, tanggal)
    SELECT 
        i.id_sparepart, 
        i.nama_sparepart, 
        'Soft Delete', 
        d.stok, 
        0,  
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
