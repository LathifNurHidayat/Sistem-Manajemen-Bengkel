

-- function cek buka tutup bengkel , cek jam booking
CREATE FUNCTION fnc_CekOperasionalBengkel(@tanggal DATE, @waktu TIME)
RETURNS VARCHAR(255) 
AS
BEGIN
    DECLARE @result VARCHAR(255) = '';
    DECLARE @bookingDate DATE = @tanggal;
    DECLARE @hariInggris VARCHAR(20) = DATENAME(WEEKDAY, @tanggal); 
    DECLARE @hari VARCHAR(20) = '';
    DECLARE @waktu_booking TIME = @waktu;

    SET @hari = 
        CASE @hariInggris
            WHEN 'Sunday' THEN 'Minggu'
            WHEN 'Monday' THEN 'Senin'
            WHEN 'Tuesday' THEN 'Selasa'
            WHEN 'Wednesday' THEN 'Rabu'
            WHEN 'Thursday' THEN 'Kamis'
            WHEN 'Friday' THEN 'Jumat'
            WHEN 'Saturday' THEN 'Sabtu'
        END;

    -- 1. cek apakah tanggal booking adalah hari libur 
    IF EXISTS (SELECT 1 FROM tb_jadwal_libur WHERE CAST(tanggal_libur AS DATE) = @bookingDate AND is_libur = 1)
    BEGIN
        SET @result = 'Mohon Maaf, pada tanggal ' + CONVERT(VARCHAR(10), @bookingDate, 103) + ' bengkel tutup.';
        RETURN @result;
    END

    -- 2. cek apakah hari booking == hari libur berdasarkan nama hari
    IF EXISTS (SELECT 1 FROM tb_jadwal_libur WHERE hari = @hari AND is_libur = 1)
    BEGIN
        SET @result = 'Mohon Maaf, pada hari ' + @hari + ' bengkel tutup.';
        RETURN @result;
    END

    --3. cek apakah hari booking = hari ini
    IF @hari = (CASE DATENAME(WEEKDAY, GETDATE())
                    WHEN 'Sunday' THEN 'Minggu'
                    WHEN 'Monday' THEN 'Senin'
                    WHEN 'Tuesday' THEN 'Selasa'
                    WHEN 'Wednesday' THEN 'Rabu'
                    WHEN 'Thursday' THEN 'Kamis'
                    WHEN 'Friday' THEN 'Jumat'
                    WHEN 'Saturday' THEN 'Sabtu'
                END)
    BEGIN

        DECLARE @jam_tutup TIME;

        SET @jam_tutup = DATEADD(MINUTE, -30, (SELECT jam_tutup FROM tb_jam_kerja WHERE hari = @hari));

        IF @waktu_booking >=  @jam_tutup 
        BEGIN 
            SET @result = 'Mohon Maaf, bengkel sudah tutup pada jam ' + CONVERT(VARCHAR(8), @jam_tutup, 108) + '. Silahkan booking di hari lain.';
            RETURN @result;
        END
    END

    RETURN @result;  
END;
GO




--function Cek Kuota Booking -- Cek ketersediaan kuota booking
CREATE FUNCTION fnc_ValidasiKuotaBooking(@tanggal DATE)
RETURNS @Result TABLE
(
    AntreanBaru INT,
    AntreanDikerjakan INT
)
AS
BEGIN  

    DECLARE @booking_count INT = (SELECT COUNT(*) FROM tb_booking WHERE tanggal = @tanggal);
    
    DECLARE @batas_booking INT = COALESCE(
                                    (SELECT batas_booking FROM tb_batas_booking WHERE tanggal  = @tanggal),
                                    (SELECT batas_booking FROM tb_batas_booking WHERE tanggal IS NULL));
    
    DECLARE @antreanBaru INT;

    IF @booking_count < @batas_booking 
        SET @antreanBaru = @booking_count + 1;
    ELSE 
        SET @antreanBaru = -1;

    DECLARE @antreanDikerjakan INT = COALESCE(
        (SELECT TOP 1 antrean 
            FROM tb_booking 
            WHERE tanggal = @tanggal AND status IN (2, 3)
            ORDER BY antrean DESC), -1 );
    
    INSERT INTO @Result (AntreanBaru, AntreanDikerjakan)
    VALUES (@antreanBaru, @antreanDikerjakan);
    
    RETURN;
END;
GO




