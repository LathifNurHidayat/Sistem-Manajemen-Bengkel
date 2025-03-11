
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

    DECLARE @biaya_servis DECIMAL(18,2) ; 
    DECLARE @biaya_sparepart DECIMAL(18,2) ;

    SELECT @biaya_servis = biaya FROM tb_jasa_servis WHERE id_jasa_servis = @id_jasa_servis;
    SELECT @biaya_sparepart = SUM(harga) FROM tb_penggunaan_sparepart WHERE id_penggunaan_sparepart = @id_penggunaan_sparepart

    DECLARE @total_biaya DECIMAL(18,2) = @biaya_servis + COALESCE(@biaya_sparepart, 0);


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




