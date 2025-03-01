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
