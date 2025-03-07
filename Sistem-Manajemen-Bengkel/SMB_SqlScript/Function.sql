
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
        DECLARE @jam_tutup TIME = (SELECT jam_tutup FROM tb_jam_kerja WHERE hari = @hari);

        IF @waktu_booking >= @jam_tutup
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




--function hitung total pendapatan hari ini
CREATE FUNCTION fnc_TotalPendapatanHariIni(@tanggal DATE)
RETURNS DECIMAL(18, 0)
AS 
BEGIN    
    DECLARE @total DECIMAL(18, 0) = 0;
    
        SELECT @total = COALESCE(SUM(total_biaya), 0) 
        FROM tb_riwayat 
        WHERE CAST(tanggal AS DATE) = @tanggal AND status = 1;
    RETURN @total;
END;
GO  




--function total booking hari ini
CREATE FUNCTION fnc_TotalBookingHariIni(@tanggal DATE)
RETURNS INT
AS 
BEGIN
    DECLARE @total INT = 0;
    
    SELECT @total = COUNT(*) 
    FROM tb_booking
    WHERE CAST(tanggal AS DATE) = @tanggal;
    
    RETURN @total;
END;
GO



--function  total selesai servis hari ini 
CREATE FUNCTION fnc_TotalSelesaiServisHariIni(@tanggal DATE)
RETURNS INT
AS 
BEGIN 
    DECLARE @total INT = 0;
    
    SELECT @total = COUNT(*) 
    FROM tb_booking
    WHERE CAST(tanggal AS DATE) = @tanggal AND status = 3;
    
    RETURN @total;
END;
GO



--function total data pelanggan 
CREATE FUNCTION fnc_TotalDataPelanggan()
RETURNS INT 
AS 
BEGIN
    DECLARE @total INT;

    SELECT @total = COUNT(*) FROM tb_pelanggan;

    RETURN @total;
END;
GO


--function total servis tiap pelanggan
CREATE FUNCTION fnc_TotalServisPelanggan()
RETURNS @result TABLE 
(
    nama_pelanggan VARCHAR(50),
    total_servis INT
)
AS 
BEGIN     
    INSERT INTO @result (nama_pelanggan, total_servis)
    SELECT TOP 5 nama_pelanggan, total_servis 
    FROM tb_pelanggan 
    ORDER BY total_servis DESC;

    RETURN;
END;
GO

--Function list peringkat sparepart yang terjual
CREATE FUNCTION fnc_ListPeringkatSparepartTerjual()
RETURNS @result TABLE 
(
    nama_sparepart VARCHAR(50),
    jumlah_terjual INT
)
AS 
BEGIN
    INSERT INTO @result (nama_sparepart, jumlah_terjual)
    SELECT TOP 5 bb.nama_sparepart, SUM(aa.jumlah) AS jumlah_terjual
    FROM tb_penggunaan_sparepart aa 
    LEFT JOIN tb_sparepart bb ON aa.id_sparepart = bb.id_sparepart 
    GROUP BY bb.nama_sparepart;
    
    RETURN;
END;
GO



SELECT 
    b.id_booking, 
    p.nama_pelanggan, 
    k.merek AS nama_kendaraan, 
    k.no_polisi, 
    b.antrean, 
    js.jenis_servis AS jasa_servis,
    js.biaya AS biaya_jasa,

    STRING_AGG(sp.nama_sparepart, ',') AS sparepart, 
    STRING_AGG(CAST(ps.jumlah AS VARCHAR), ',') AS quantity,
STRING_AGG(CAST(CAST(ps.harga AS INT) AS VARCHAR), ',') AS harga_sparepart,

    (js.biaya + ISNULL(SUM(ps.harga), 0)) AS total_biaya_servis,

    b.catatan,
    ib.nama_bengkel,
    ib.alamat AS alamat_bengkel,
    ib.email AS email_bengkel,
    ib.no_telp AS no_telp_bengkel,
    b.tanggal
FROM tb_booking b
JOIN tb_pelanggan p ON b.no_ktp_pelanggan = p.no_ktp_pelanggan
JOIN tb_kendaraan k ON b.id_kendaraan = k.id_kendaraan
JOIN tb_jasa_servis js ON b.id_jasa_servis = js.id_jasa_servis
LEFT JOIN tb_penggunaan_sparepart ps ON b.id_booking = ps.id_penggunaan_sparepart
LEFT JOIN tb_sparepart sp ON ps.id_sparepart = sp.id_sparepart
CROSS JOIN tb_informasi_bengkel ib
WHERE b.id_booking = 37 AND b.status = 3  

GROUP BY 
    b.id_booking, p.nama_pelanggan, k.merek, k.no_polisi, b.antrean, 
    js.jenis_servis, js.biaya, 
    b.catatan, ib.nama_bengkel, 
    ib.alamat, ib.email, ib.no_telp, b.tanggal



    select * from tb_booking