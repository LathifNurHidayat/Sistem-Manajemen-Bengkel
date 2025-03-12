
--store prosedure insert riwayat
CREATE PROCEDURE sp_InsertRiwayat
    @id_jasa_servis INT,
    @no_ktp_pelanggan VARCHAR(20),
    @no_ktp_pegawai VARCHAR(20),
    @no_ktp_mekanik VARCHAR(20),
    @id_kendaraan INT,
    @id_penggunaan_sparepart INT,
    @nama_pelanggan VARCHAR(50),
    @no_polisi VARCHAR(20),
    @merek VARCHAR(50),
    @transmisi INT,
    @kapasitas_mesin INT,
    @tanggal DATETIME,
    @keluhan VARCHAR(225),
    @catatan VARCHAR(225),
    @status INT
AS
BEGIN
    SET NOCOUNT ON;

    
    DECLARE @biaya_servis DECIMAL(18,2) = 0;
    DECLARE @biaya_sparepart DECIMAL(18,2) = 0;
    DECLARE @total_biaya DECIMAL(18,2) = 0;

    IF @status <> 4
    BEGIN 
        SELECT @biaya_servis = COALESCE(biaya, 0) FROM tb_jasa_servis WHERE id_jasa_servis = @id_jasa_servis;
        SELECT @biaya_sparepart = COALESCE(SUM(harga), 0) FROM tb_penggunaan_sparepart WHERE id_penggunaan_sparepart = @id_penggunaan_sparepart;
        
        SET @total_biaya = @biaya_servis + @biaya_sparepart;
    END

    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO tb_riwayat (
            id_jasa_servis,
            no_ktp_pelanggan,
            no_ktp_pegawai,
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
            total_biaya,
            status
        ) 
        VALUES (
            @id_jasa_servis,
            @no_ktp_pelanggan,
            @no_ktp_pegawai,
            @no_ktp_mekanik,
            @id_kendaraan,
            @id_penggunaan_sparepart,
            @nama_pelanggan,
            @no_polisi,
            @merek,
            @transmisi,
            @kapasitas_mesin,
            @tanggal,
            @keluhan,
            @catatan,
            @total_biaya,
            @status);
        
        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH;

END;
GO



CREATE PROCEDURE sp_GetDashboardMetrics(@tanggal DATE)
AS
BEGIN
    -- Total Pendapatan Hari Ini
    SELECT COALESCE(SUM(total_biaya), 0) AS TotalPendapatanHariIni
    FROM tb_riwayat
    WHERE CAST(tanggal AS DATE) = @tanggal AND status = 1;

    -- Total Booking Hari Ini
    SELECT COUNT(*) AS TotalBookingHariIni
    FROM tb_booking
    WHERE CAST(tanggal AS DATE) = @tanggal;

    -- Total Selesai Servis Hari Ini
    SELECT COUNT(*) AS TotalSelesaiServisHariIni
    FROM tb_booking
    WHERE CAST(tanggal AS DATE) = @tanggal AND status = 3;

    -- Total Data Pelanggan
    SELECT COUNT(*) AS TotalDataPelanggan
    FROM tb_pelanggan;

    -- Total Servis Tiap Pelanggan
    SELECT TOP 5 nama_pelanggan, total_servis
    FROM tb_pelanggan
    ORDER BY total_servis DESC;

    -- Peringkat Sparepart Terjual
    SELECT TOP 5 bb.nama_sparepart, SUM(aa.jumlah) AS jumlah_terjual
    FROM tb_penggunaan_sparepart aa
    LEFT JOIN tb_sparepart bb ON aa.id_sparepart = bb.id_sparepart
    GROUP BY bb.nama_sparepart
    ORDER BY jumlah_terjual DESC;
END;
GO
