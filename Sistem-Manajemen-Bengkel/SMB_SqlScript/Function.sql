
--fungasi Cek Kuota Booking -- Cek ketersediaan kuota booking
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