TRUNCATE TABLE tb_riwayat;
TRUNCATE TABLE tb_booking;
TRUNCATE TABLE tb_kendaraan;
TRUNCATE TABLE tb_sparepart;
TRUNCATE TABLE tb_batas_booking;
TRUNCATE TABLE tb_jasa_servis;
TRUNCATE TABLE tb_mekanik;
TRUNCATE TABLE tb_pegawai;
TRUNCATE TABLE tb_pelanggan;

-- Nilai hash untuk password "User_123"
-- Misalnya: 352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67


-- 1. Insert 20 Data ke tb_pelanggan
INSERT INTO tb_pelanggan 
    (no_ktp_pelanggan, nama_pelanggan, no_hp, alamat, email, password, total_servis, created_at)
VALUES
('32010110000001', 'Budi Santoso',   '081234567890', 'Jl. Merdeka No.12, Jakarta',            'budi.santoso@gmail.com',   '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 0,  '2024-01-01 08:00:00'),
('32010110000002', 'Ani Lestari',     '081298765432', 'Jl. Sudirman No.45, Bandung',            'ani.lestari@yahoo.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 1,  '2024-01-01 10:00:00'),
('32010110000003', 'Cahyo Pratama',   '081212345678', 'Jl. Gajah Mada No.8, Surabaya',            'cahyo.pratama@hotmail.com', '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 2,  '2024-01-01 12:00:00'),
('32010110000004', 'Dian Nurhayati',  '081234567893', 'Jl. Asia Afrika No.78, Bandung',         'dian.nurhayati@outlook.com','352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 3,  '2024-01-01 14:00:00'),
('32010110000005', 'Eko Wijaya',      '081298765435', 'Jl. Pemuda No.33, Semarang',             'eko.wijaya@gmail.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 4,  '2024-01-01 16:00:00'),
('32010110000006', 'Fani Amelia',     '081212345681', 'Jl. Diponegoro No.21, Yogyakarta',         'fani.amelia@yahoo.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 5,  '2024-01-01 18:00:00'),
('32010110000007', 'Guntur Prakoso',   '081234567896', 'Jl. Ahmad Yani No.55, Malang',             'guntur.prakoso@hotmail.com','352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 6,  '2024-01-01 20:00:00'),
('32010110000008', 'Hesti Rahayu',    '081298765438', 'Jl. Suryakencana No.9, Bogor',             'hesti.rahayu@outlook.com',  '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 7,  '2024-01-01 22:00:00'),
('32010110000009', 'Iwan Setiawan',   '081212345684', 'Jl. Cikapayang No.17, Bandung',            'iwan.setiawan@gmail.com',   '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 8,  '2024-01-02 00:00:00'),
('32010110000010', 'Jihan Permata',   '081234567899', 'Jl. Gatot Subroto No.3, Jakarta',          'jihan.permata@yahoo.com',   '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 9,  '2024-01-02 02:00:00'),
('32010110000011', 'Krisna Aditya',   '081298765441', 'Jl. Pahlawan No.7, Surabaya',              'krisna.aditya@hotmail.com','352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 10, '2024-01-02 04:00:00'),
('32010110000012', 'Lina Marlina',    '081212345687', 'Jl. Merak No.14, Semarang',                'lina.marlina@outlook.com',  '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 11, '2024-01-02 06:00:00'),
('32010110000013', 'Miko Pratama',    '081234567902', 'Jl. Kembang No.22, Yogyakarta',            'miko.pratama@gmail.com',    '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 12, '2024-01-02 08:00:00'),
('32010110000014', 'Nia Febrianti',   '081298765444', 'Jl. Mawar No.5, Malang',                   'nia.febrianti@yahoo.com',   '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 13, '2024-01-02 10:00:00'),
('32010110000015', 'Oki Ramadhan',    '081212345690', 'Jl. Anggrek No.11, Bogor',                 'oki.ramadhan@hotmail.com',  '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 14, '2024-01-02 12:00:00'),
('32010110000016', 'Putri Ayu',       '081234567905', 'Jl. Kenanga No.19, Bandung',              'putri.ayu@outlook.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 15, '2024-01-02 14:00:00'),
('32010110000017', 'Rudi Hermawan',   '081298765447', 'Jl. Dahlia No.8, Jakarta',                 'rudi.hermawan@gmail.com',   '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 16, '2024-01-02 16:00:00'),
('32010110000018', 'Sinta Dewi',      '081212345693', 'Jl. Melati No.25, Surabaya',               'sinta.dewi@yahoo.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 17, '2024-01-02 18:00:00'),
('32010110000019', 'Tono Saputra',    '081234567908', 'Jl. Cendana No.13, Semarang',              'tono.saputra@hotmail.com',  '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 18, '2024-01-02 20:00:00'),
('32010110000020', 'Umi Kalsum',      '081298765450', 'Jl. Flamboyan No.6, Yogyakarta',           'umi.kalsum@outlook.com',    '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', 19, '2024-01-02 22:00:00');


-- 2. Insert 20 Data ke tb_pegawai
INSERT INTO tb_pegawai 
    (no_ktp_pegawai, nama_pegawai, email, password, no_hp, alamat, role, image_data)
VALUES
('32010120000001', 'Siti Rahma',      'siti@x.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345600', 'Jl. Merdeka No.5, Jakarta',       1, NULL),
('32010120000002', 'Agus Salim',       'agus@x.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345601', 'Jl. Sudirman No.10, Bandung',     2, NULL),
('32010120000003', 'Dewi Lestari',     'dewi@x.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345602', 'Jl. Cempaka No.7, Surabaya',       1, NULL),
('32010120000004', 'Rizki Hidayat',    'rizki@x.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345603', 'Jl. Melati No.3, Jakarta',         2, NULL),
('32010120000005', 'Winda Sari',       'winda@x.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345604', 'Jl. Kebon Jeruk No.15, Bandung',   1, NULL),
('32010120000006', 'Fajar Nugroho',    'fajar@x.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345605', 'Jl. Merpati No.9, Semarang',       2, NULL),
('32010120000007', 'Lutfi Maulana',    'lutfi@x.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345606', 'Jl. Veteran No.20, Yogyakarta',    1, NULL),
('32010120000008', 'Rina Puspita',     'rina@x.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345607', 'Jl. Ahmad Yani No.30, Jakarta',    2, NULL),
('32010120000009', 'Budi Prasetyo',    'budi@x.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345608', 'Jl. Sudirman No.25, Bandung',     1, NULL),
('32010120000010', 'Slamet Wijaya',    'slamet@x.com',    '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345609', 'Jl. Cempaka No.12, Surabaya',      2, NULL),
('32010120000011', 'Dina Kartika',     'dina@x.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345610', 'Jl. Mawar No.5, Jakarta',         1, NULL),
('32010120000012', 'Aditya Pranata',   'aditya@x.com',    '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345611', 'Jl. Kebon Pisang No.7, Bandung',   2, NULL),
('32010120000013', 'Rizka Amalia',     'rizka@x.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345612', 'Jl. Pahlawan No.8, Semarang',      1, NULL),
('32010120000014', 'Feri Saputra',     'feri@x.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345613', 'Jl. Merdeka No.3, Yogyakarta',     2, NULL),
('32010120000015', 'Wahyu Firmansyah', 'wahyu@x.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345614', 'Jl. Veteran No.10, Jakarta',      1, NULL),
('32010120000016', 'Sari Ambarwati',   'sari@x.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345615', 'Jl. Pahlawan No.15, Bandung',      2, NULL),
('32010120000017', 'Anton Rahman',     'anton@x.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345616', 'Jl. Cempaka No.19, Surabaya',      1, NULL),
('32010120000018', 'Lilis Suryani',    'lilis@x.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345617', 'Jl. Kebon Jeruk No.22, Semarang',  2, NULL),
('32010120000019', 'Rizki Ananda',     'rizki@x.com',     '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345618', 'Jl. Merpati No.11, Yogyakarta',     1, NULL),
('32010120000020', 'Nina Pratiwi',     'nina@x.com',      '352ba3603bde1f9b3b6f8ad5142a8814f86a52f0f2a6190f938d848f122b1a67', '081312345619', 'Jl. Kebon Pisang No.16, Jakarta',   2, NULL);

-- 3. Insert 20 Data ke tb_mekanik
INSERT INTO tb_mekanik 
    (no_ktp_mekanik, nama_mekanik, no_hp, alamat, spesialis, image_data)
VALUES
('32010130000001', 'Slamet Hidayat',  '081423456700', 'Jl. Merdeka No.2, Bandung',    'Mesin',      NULL),
('32010130000002', 'Rina Kurnia',     '081423456701', 'Jl. Diponegoro No.10, Jakarta', 'Kelistrikan',NULL),
('32010130000003', 'Dedi Saputra',    '081423456702', 'Jl. Sudirman No.12, Semarang',  'Body & Cat',  NULL),
('32010130000004', 'Teguh Prasetyo',  '081423456703', 'Jl. Mawar No.4, Yogyakarta',    'Mesin',      NULL),
('32010130000005', 'Dewi Anggraeni',  '081423456704', 'Jl. Kebon Jeruk No.6, Jakarta',  'Kelistrikan',NULL),
('32010130000006', 'Agus Pranata',    '081423456705', 'Jl. Veteran No.8, Bandung',     'Body & Cat',  NULL),
('32010130000007', 'Siti Aminah',     '081423456706', 'Jl. Pahlawan No.3, Semarang',    'Mesin',      NULL),
('32010130000008', 'Budi Gunawan',    '081423456707', 'Jl. Merpati No.9, Yogyakarta',   'Kelistrikan',NULL),
('32010130000009', 'Lilis Suryani',   '081423456708', 'Jl. Cempaka No.5, Jakarta',     'Body & Cat',  NULL),
('32010130000010', 'Dodi Setiawan',   '081423456709', 'Jl. Cendana No.11, Bandung',     'Mesin',      NULL),
('32010130000011', 'Rizki Fajar',     '081423456710', 'Jl. Kenanga No.7, Semarang',     'Kelistrikan',NULL),
('32010130000012', 'Wati Lestari',    '081423456711', 'Jl. Anggrek No.8, Yogyakarta',    'Body & Cat',  NULL),
('32010130000013', 'Hendra Wijaya',   '081423456712', 'Jl. Melati No.3, Jakarta',       'Mesin',      NULL),
('32010130000014', 'Nia Fitria',      '081423456713', 'Jl. Mawar No.14, Bandung',       'Kelistrikan',NULL),
('32010130000015', 'Fajar Nugroho',   '081423456714', 'Jl. Siliwangi No.10, Semarang',   'Body & Cat',  NULL),
('32010130000016', 'Diana Puspita',   '081423456715', 'Jl. Merdeka No.20, Yogyakarta',   'Mesin',      NULL),
('32010130000017', 'Agung Setiawan',  '081423456716', 'Jl. Diponegoro No.7, Jakarta',   'Kelistrikan',NULL),
('32010130000018', 'Rizal Hamdani',   '081423456717', 'Jl. Sudirman No.16, Bandung',    'Body & Cat',  NULL),
('32010130000019', 'Sari Utami',      '081423456718', 'Jl. Veteran No.4, Semarang',      'Mesin',      NULL),
('32010130000020', 'Doni Prakoso',    '081423456719', 'Jl. Pahlawan No.12, Yogyakarta',  'Kelistrikan',NULL);



-- 4. Insert 20 Data ke tb_jasa_servis
INSERT INTO tb_jasa_servis 
    (jenis_servis, keterangan, biaya)
VALUES
('Ganti Oli',         'Penggantian oli mesin',                   150000),
('Tune Up',           'Penyetelan mesin dan pembersihan',         250000),
('Servis Rem',        'Pemeriksaan dan penggantian kampas rem',     200000),
('Ganti Filter',      'Penggantian filter udara dan oli',           100000),
('Balancing',         'Pemerataan roda',                           180000),
('Alignment',         'Penyelarasan suspensi',                     220000),
('Pembersihan AC',    'Pembersihan sistem pendingin',              200000),
('Perbaikan Mesin',   'Perbaikan komponen mesin',                  300000),
('Ganti Ban',         'Penggantian ban',                           500000),
('Service Rutin',     'Pemeriksaan rutin',                         120000),
('Ganti Oli Plus',    'Penggantian oli plus, servis ekstra',       200000),
('Tune Up Plus',      'Tune up dan servis ekstra',                300000),
('Servis Rem Plus',   'Rem lengkap dan penyesuaian',               250000),
('Ganti Filter Plus', 'Penggantian filter lengkap',                150000),
('Balancing Plus',    'Balancing dan pemeriksaan ban',             220000),
('Alignment Plus',    'Alignment dan perbaikan suspensi',           250000),
('Pembersihan AC Plus','Bersih total sistem AC',                   230000),
('Perbaikan Mesin Plus','Perbaikan menyeluruh',                    350000),
('Ganti Ban Plus',    'Ganti ban dan perawatan',                   600000),
('Service Rutin Plus','Pemeriksaan intensif',                      180000);


-- 5. Insert 20 Data ke tb_batas_booking
INSERT INTO tb_batas_booking 
    (tanggal, batas_booking)
VALUES
('2024-01-01', 10),
('2024-01-02', 11),
('2024-01-03', 12),
('2024-01-04', 13),
('2024-01-05', 14),
('2024-01-06', 15),
('2024-01-07', 16),
('2024-01-08', 17),
('2024-01-09', 18),
('2024-01-10', 19),
('2024-01-11', 10),
('2024-01-12', 11),
('2024-01-13', 12),
('2024-01-14', 13),
('2024-01-15', 14),
('2024-01-16', 15),
('2024-01-17', 16),
('2024-01-18', 17),
('2024-01-19', 18),
('2024-01-20', 19);



-- 6. Insert 20 Data ke tb_sparepart
INSERT INTO tb_sparepart 
    (nama_sparepart, harga, stok, stok_minimal, status_stok, image_data)
VALUES
('Busi NGK',                50000,  4, 10, 1, NULL),
('Kampas Rem',              120000,  0,  5, 0, NULL),
('Oli Mesin',               80000,   0, 20, 0, NULL),
('Filter Udara',            60000,   150, 15, 2, NULL),
('Filter Oli',              70000,   120, 12, 2, NULL),
('Aki',                     250000,  30,  5, 2, NULL),
('Busi Bosch',              55000,   100, 10, 2, NULL),
('Kampas Rem Premium',      150000,  40,  5, 2, NULL),
('Oli Mesin Synthetic',     80000,   180, 20, 2, NULL),
('Brake Fluid',             90000,   80,  8, 2, NULL),
('Busi NGK Plus',           55000,   90,  9, 2, NULL),
('Kampas Rem Plus',         130000,  60,  6, 2, NULL),
('Oli Mesin Plus',          85000,   170, 17, 2, NULL),
('Filter Udara Plus',       65000,   140, 14, 2, NULL),
('Filter Oli Plus',         75000,   110, 11, 2, NULL),
('Aki Plus',                260000,  25,  5, 2, NULL),
('Busi Bosch Plus',         60000,   95,  9, 2, NULL),
('Kampas Rem Super',        160000,  35,  5, 2, NULL),
('Oli Mesin Ultra',         90000,   150, 15, 2, NULL),
('Brake Fluid Plus',        95000,   70,  7, 2, NULL);





-- 7. Insert 20 Data ke tb_kendaraan
INSERT INTO tb_kendaraan 
    (no_ktp_pelanggan, no_polisi, merek, transmisi, kapasitas_mesin, tahun)
VALUES
('32010110000001', 'B 1234 ABC', 'Toyota Avanza',      1, 1500, 2020),
('32010110000002', 'D 5678 XYZ', 'Honda Jazz',         2, 1300, 2018),
('32010110000003', 'L 9101 PQR', 'Mitsubishi Xpander', 2, 1500, 2021),
('32010110000004', 'B 2345 DEF', 'Suzuki Ertiga',      1, 1200, 2019),
('32010110000005', 'D 6789 UVW', 'Honda Brio',         2, 1100, 2017),
('32010110000006', 'L 1011 LMN', 'Toyota Innova',      1, 2000, 2020),
('32010110000007', 'B 3456 GHI', 'Daihatsu Sigra',     2, 1300, 2018),
('32010110000008', 'D 7890 OPQ', 'Honda Mobilio',      1, 1500, 2019),
('32010110000009', 'L 1121 RST', 'Suzuki Ertiga',      2, 1200, 2021),
('32010110000010', 'B 1314 UVW', 'Toyota Avanza',      1, 1500, 2018),
('32010110000011', 'D 1516 XYZ', 'Honda Jazz',         2, 1300, 2020),
('32010110000012', 'L 1718 ABC', 'Mitsubishi Xpander', 2, 1500, 2017),
('32010110000013', 'B 1920 DEF', 'Suzuki Ertiga',      1, 1200, 2019),
('32010110000014', 'D 2122 GHI', 'Honda Brio',         2, 1100, 2020),
('32010110000015', 'L 2324 JKL', 'Toyota Innova',      1, 2000, 2021),
('32010110000016', 'B 2526 MNO', 'Daihatsu Sigra',     2, 1300, 2018),
('32010110000017', 'D 2728 PQR', 'Honda Mobilio',      1, 1500, 2019),
('32010110000018', 'L 2930 STU', 'Suzuki Ertiga',      2, 1200, 2020),
('32010110000019', 'B 3132 VWX', 'Toyota Avanza',      1, 1500, 2017),
('32010110000020', 'D 3334 YZA', 'Honda Jazz',         2, 1300, 2021);



-- 8. Insert 20 Data ke tb_booking
INSERT INTO tb_booking 
    (no_ktp_pelanggan, no_ktp_mekanik, id_kendaraan, id_jasa_servis, tanggal, antrean, keluhan, status)
VALUES
('32010110000001', '32010130000001', 1, 1, DATEADD(MINUTE, 1, GETDATE()), 1, 'Oli bocor', 'Menunggu'),
('32010110000002', '32010130000002', 2, 2, DATEADD(MINUTE, 2, GETDATE()), 2, 'AC tidak dingin', 'Menunggu'),
('32010110000003', '32010130000003', 3, 3, DATEADD(MINUTE, 3, GETDATE()), 3, 'Rem blong', 'Menunggu'),
('32010110000004', '32010130000004', 4, 4, DATEADD(MINUTE, 4, GETDATE()), 4, 'Lampu redup', 'Menunggu'),
('32010110000005', '32010130000005', 5, 5, DATEADD(MINUTE, 5, GETDATE()), 5, 'Bunyi aneh', 'Menunggu'),
('32010110000006', '32010130000006', 6, 6, DATEADD(MINUTE, 6, GETDATE()), 6, 'Oli encer', 'Menunggu'),
('32010110000007', '32010130000007', 7, 7, DATEADD(MINUTE, 7, GETDATE()), 7, 'AC kembung', 'Menunggu'),
('32010110000008', '32010130000008', 8, 8, DATEADD(MINUTE, 8, GETDATE()), 8, 'Mesin panas', 'Menunggu'),
('32010110000009', '32010130000009', 9, 9, DATEADD(MINUTE, 9, GETDATE()), 9, 'Klakson tidak berbunyi', 'Menunggu'),
('32010110000010', '32010130000010', 10, 10, DATEADD(MINUTE, 10, GETDATE()), 10, 'Ban aus', 'Menunggu'),
('32010110000011', '32010130000011', 11, 11, DATEADD(MINUTE, 11, GETDATE()), 11, 'Lampu mati', 'Menunggu'),
('32010110000012', '32010130000012', 12, 12, DATEADD(MINUTE, 12, GETDATE()), 12, 'AC bocor', 'Menunggu'),
('32010110000013', '32010130000013', 13, 13, DATEADD(MINUTE, 13, GETDATE()), 13, 'Klakson rusak', 'Menunggu'),
('32010110000014', '32010130000014', 14, 14, DATEADD(MINUTE, 14, GETDATE()), 14, 'Mesin bergemuruh', 'Menunggu'),
('32010110000015', '32010130000015', 15, 15, DATEADD(MINUTE, 15, GETDATE()), 15, 'Oli encer', 'Menunggu'),
('32010110000016', '32010130000016', 16, 16, DATEADD(MINUTE, 16, GETDATE()), 16, 'Ban kempes', 'Menunggu'),
('32010110000017', '32010130000017', 17, 17, DATEADD(MINUTE, 17, GETDATE()), 17, 'Rem kurang', 'Menunggu'),
('32010110000018', '32010130000018', 18, 18, DATEADD(MINUTE, 18, GETDATE()), 18, 'Lampu redup', 'Menunggu'),
('32010110000019', '32010130000019', 19, 19, DATEADD(MINUTE, 19, GETDATE()), 19, 'AC berisik', 'Menunggu'),
('32010110000020', '32010130000020', 20, 20, DATEADD(MINUTE, 20, GETDATE()), 20, 'Mesin tidak mau hidup', 'Menunggu');




-- 9. Insert 20 Data ke tb_riwayat
INSERT INTO tb_riwayat 
    (id_jasa_servis, no_ktp_pelanggan, no_ktp_pegawai, no_ktp_mekanik, id_kendaraan, id_riwayat_sparepart, tanggal, keluhan, catatan, total_biaya, status)
VALUES
(1, '32010110000001', '32010120000001', '32010130000001', 1, NULL, DATEADD(MINUTE, 1, GETDATE()), 'Oli bocor', 'Ganti oli', 150000, 'Selesai'),
(2, '32010110000002', '32010120000002', '32010130000002', 2, NULL, DATEADD(MINUTE, 2, GETDATE()), 'AC tidak dingin', 'Tambah freon', 250000, 'Selesai'),
(3, '32010110000003', '32010120000003', '32010130000003', 3, NULL, DATEADD(MINUTE, 3, GETDATE()), 'Rem blong', 'Ganti kampas rem', 200000, 'Selesai'),
(4, '32010110000004', '32010120000004', '32010130000004', 4, NULL, DATEADD(MINUTE, 4, GETDATE()), 'Lampu redup', 'Perbaikan lampu', 180000, 'Selesai'),
(5, '32010110000005', '32010120000005', '32010130000005', 5, NULL, DATEADD(MINUTE, 5, GETDATE()), 'Bunyi aneh', 'Periksa sensor', 120000, 'Selesai'),
(6, '32010110000006', '32010120000006', '32010130000006', 6, NULL, DATEADD(MINUTE, 6, GETDATE()), 'Oli encer', 'Ganti oli', 150000, 'Selesai'),
(7, '32010110000007', '32010120000007', '32010130000007', 7, NULL, DATEADD(MINUTE, 7, GETDATE()), 'AC kembung', 'Bersihkan AC', 200000, 'Selesai'),
(8, '32010110000008', '32010120000008', '32010130000008', 8, NULL, DATEADD(MINUTE, 8, GETDATE()), 'Mesin panas', 'Cooling system check', 220000, 'Selesai'),
(9, '32010110000009', '32010120000009', '32010130000009', 9, NULL, DATEADD(MINUTE, 9, GETDATE()), 'Klakson tidak berbunyi', 'Ganti klakson', 120000, 'Selesai'),
(10, '32010110000010', '32010120000010', '32010130000010', 10, NULL, DATEADD(MINUTE, 10, GETDATE()), 'Ban aus', 'Ganti ban', 500000, 'Selesai'),
(11, '32010110000011', '32010120000011', '32010130000011', 11, NULL, DATEADD(MINUTE, 11, GETDATE()), 'Lampu mati', 'Ganti bohlam', 90000, 'Selesai'),
(12, '32010110000012', '32010120000012', '32010130000012', 12, NULL, DATEADD(MINUTE, 12, GETDATE()), 'AC bocor', 'Perbaikan AC', 200000, 'Selesai'),
(13, '32010110000013', '32010120000013', '32010130000013', 13, NULL, DATEADD(MINUTE, 13, GETDATE()), 'Klakson rusak', 'Ganti klakson', 150000, 'Selesai'),
(14, '32010110000014', '32010120000014', '32010130000014', 14, NULL, DATEADD(MINUTE, 14, GETDATE()), 'Mesin bergemuruh', 'Perbaikan mesin', 300000, 'Selesai'),
(15, '32010110000015', '32010120000015', '32010130000015', 15, NULL, DATEADD(MINUTE, 15, GETDATE()), 'Oli encer', 'Ganti oli', 150000, 'Selesai'),
(16, '32010110000016', '32010120000016', '32010130000016', 16, NULL, DATEADD(MINUTE, 16, GETDATE()), 'Ban kempes', 'Isi angin ban', 180000, 'Selesai'),
(17, '32010110000017', '32010120000017', '32010130000017', 17, NULL, DATEADD(MINUTE, 17, GETDATE()), 'Rem kurang', 'Ganti kampas rem', 200000, 'Selesai'),
(18, '32010110000018', '32010120000018', '32010130000018', 18, NULL, DATEADD(MINUTE, 18, GETDATE()), 'Lampu redup', 'Ganti bohlam', 120000, 'Selesai'),
(19, '32010110000019', '32010120000019', '32010130000019', 19, NULL, DATEADD(MINUTE, 19, GETDATE()), 'AC berisik', 'Service AC', 220000, 'Selesai'),
(20, '32010110000020', '32010120000020', '32010130000020', 20, NULL, DATEADD(MINUTE, 20, GETDATE()), 'Mesin tidak mau hidup', 'Perbaikan mesin', 300000, 'Selesai');








--select * from tb_kendaraan;
--select * from tb_sparepart;
--update tb_kendaraan set deleted_at = NULL 
SELECT * FROM sys.dm_exec_requests;
EXEC sp_who2;
