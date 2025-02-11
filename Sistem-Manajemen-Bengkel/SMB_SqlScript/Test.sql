INSERT INTO tb_pelanggan (no_ktp_pelanggan, nama_pelanggan, no_hp, alamat, email, password, total_servis)
VALUES
('3201011000010001', 'Ahmad Syaiful', '081234567890', 'Jakarta', 'ahmad@example.com', 'ef92b778bafee02a',4),
('3201011000010002', 'Rina Lestari', '081298765432', 'Bandung', 'rina@example.com', 'ef92b778bafee02a',6),
('3201011000010003', 'Budi Santoso', '082345678901', 'Surabaya', 'budi@example.com', 'ef92b778bafee02a',8),
('3201011000010004', 'Siti Aminah', '083456789012', 'Medan', 'siti@example.com', 'ef92b778bafee02a',3),
('3201011000010005', 'Dedi Prasetyo', '084567890123', 'Yogyakarta', 'dedi@example.com', 'ef92b778bafee02a',3),
('3201011000010006', 'Lina Kusuma', '085678901234', 'Semarang', 'lina@example.com', 'ef92b778bafee02a',45),
('3201011000010007', 'Eko Saputra', '086789012345', 'Palembang', 'eko@example.com', 'ef92b778bafee02a',4),
('3201011000010008', 'Tina Maharani', '087890123456', 'Makassar', 'tina@example.com', 'ef92b778bafee02a',21),
('3201011000010009', 'Fadli Akbar', '088901234567', 'Bali', 'fadli@example.com', 'ef92b778bafee02a',2),
('3201011000010010', 'Hana Wijaya', '089012345678', 'Balikpapan', 'hana@example.com', 'ef92b778bafee02a',6),
('3201011000010011', 'Rahmat Hidayat', '081234567899', 'Pontianak', 'rahmat@example.com', 'ef92b778bafee02a',2),
('3201011000010012', 'Sari Melati', '081234567898', 'Batam', 'sari@example.com', 'ef92b778bafee02a',4),
('3201011000010013', 'Andre Wahyudi', '081234567897', 'Lampung', 'andre@example.com', 'ef92b778bafee02a',2),
('3201011000010014', 'Desi Aprilia', '081234567896', 'Malang', 'desi@example.com', 'ef92b778bafee02a',7),
('3201011000010015', 'Bayu Setiawan', '081234567895', 'Pekanbaru', 'bayu@example.com', 'ef92b778bafee02a',9);

INSERT INTO tb_pegawai (no_ktp_pegawai, nama_pegawai, email, password, no_hp, alamat, role, image_name, image_data)
VALUES
('3201012000010001', 'Taufik Hidayat', 'taufik@example.com', 'ef92b778bafee02a', '081312345678', 'Jakarta', 1, NULL, NULL),
('3201012000010002', 'Lestari Putri', 'lestari@example.com', 'ef92b778bafee02a', '081323456789', 'Bandung', 2, NULL, NULL),
('3201012000010003', 'Hendra Saputra', 'hendra@example.com', 'ef92b778bafee02a', '081334567890', 'Surabaya', 2, NULL, NULL);

INSERT INTO tb_mekanik (no_ktp_mekanik, nama_mekanik, no_hp, alamat, spesialis, image_name, image_data)
VALUES
('3201013000010001', 'Bambang Sutrisno', '082345678901', 'Jakarta', 'Mesin', NULL, NULL),
('3201013000010002', 'Yanto Supriyadi', '083456789012', 'Bandung', 'Kelistrikan', NULL, NULL),
('3201013000010003', 'Sukarno', '084567890123', 'Surabaya', 'Body & Cat', NULL, NULL);

INSERT INTO tb_jasa_servis (jenis_servis, keterangan, biaya)
VALUES
('Ganti Oli', 'Penggantian oli mesin kendaraan', 150000),
('Tune Up', 'Pemeriksaan dan penyetelan mesin', 250000),
('Servis Rem', 'Pemeriksaan dan penggantian kampas rem', 200000);

INSERT INTO tb_batas_booking (tanggal, batas_booking)
VALUES
(GETDATE(), 10),
(GETDATE(), 15),
(GETDATE(), 12);

INSERT INTO tb_sparepart (nama_sparepart, harga, stok, stok_minimal, status_stok)
VALUES
('Busi NGK', 50000, 100, 10, 'Tersedia'),
('Kampas Rem', 120000, 50, 5, 'Tersedia'),
('Oli Mesin', 80000, 200, 20, 'Tersedia');

INSERT INTO tb_kendaraan (no_ktp_pelanggan, no_polisi, merek, transmisi, kapasitas_mesin, tahun)
VALUES
('3201011000010001', 'B 1234 ABC', 'Toyota Avanza', 'Manual', 1500, 2020),
('3201011000010002', 'D 5678 XYZ', 'Honda Jazz', 'Automatic', 1300, 2018),
('3201011000010003', 'L 9101 PQR', 'Mitsubishi Xpander', 'Automatic', 1500, 2021);

INSERT INTO tb_booking (no_ktp_pelanggan, no_ktp_mekanik, id_kendaraan, id_jasa_servis, tanggal, antrean, keluhan, status)
VALUES
('3201011000010001', '3201013000010001', 1, 1, GETDATE(), 1, 'Oli bocor', 'Menunggu'),
('3201011000010002', '3201013000010002', 2, 2, GETDATE(), 2, 'AC tidak dingin', 'Menunggu'),
('3201011000010003', '3201013000010003', 3, 3, GETDATE(), 3, 'Rem blong', 'Menunggu');

INSERT INTO tb_riwayat (id_jasa_servis, no_ktp_pelanggan, no_ktp_pegawai, no_ktp_mekanik, id_kendaraan, id_riwayat_sparepart, tanggal, keluhan, catatan, total_biaya, status)
VALUES
(1, '3201011000010001', '3201012000010001', '3201013000010001', 1, NULL, GETDATE(), 'Oli bocor', 'Ganti oli', 150000, 'Selesai'),
(2, '3201011000010002', '3201012000010002', '3201013000010002', 2, NULL, GETDATE(), 'AC tidak dingin', 'Tambah freon', 200000, 'Selesai'),
(3, '3201011000010003', '3201012000010003', '3201013000010003', 3, NULL, GETDATE(), 'Rem blong', 'Ganti kampas rem', 250000, 'Selesai');




SELECT * FROM tb_pelanggan ORDER BY created_at ASC  OFFSET 2 ROW FETCH NEXT 15 ROWS ONLY