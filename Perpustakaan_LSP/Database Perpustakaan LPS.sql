CREATE DATABASE dbd_LPSlibrary;
USE dbd_LPSlibrary;


DROP TABLE BUKU;

CREATE TABLE BUKU (
    KODE_BUKU VARCHAR(15) NOT NULL,
    JUDUL_BUKU VARCHAR(45) NOT NULL,
    KATEGORI VARCHAR(20) NOT NULL,
    KODE_PENERBIT VARCHAR(15) NOT NULL,
    PENULIS VARCHAR(30) NOT NULL,
    DELETE_BUKU VARCHAR(1) NOT NULL,
    PRIMARY KEY (KODE_BUKU)
);

ALTER TABLE BUKU 
ADD CONSTRAINT FK_BUKU_PENERBIT 
FOREIGN KEY (KODE_PENERBIT) 
REFERENCES PENERBIT (KODE_PENERBIT) 
ON DELETE RESTRICT 
ON UPDATE RESTRICT;

INSERT INTO BUKU (KODE_BUKU, JUDUL_BUKU, KATEGORI, KODE_PENERBIT, PENULIS, DELETE_BUKU) 
VALUES
    ('BF001', 'Laskar Pelangi', 'Fiksi', 'PN001', 'Andrea Hirata', '0'),
    ('BF002', 'Sang Pemimpi', 'Fiksi', 'PN001', 'Andrea Hirata', '0'),
    ('BF003', 'Twivortiare', 'Romansa', 'PN002', 'Ika Natassa', '0'),
    ('BF004', 'Critical Eleven', 'Romansa', 'PN002', 'Ika Natassa', '0'),
    ('BF005', 'Susah Sinyal', 'Komedi', 'PN002', 'Ika Natassa', '0'),
    ('BF006', 'Marmut Merah Jambu', 'Komedi', 'PN003', 'Raditya Dika', '0'),
    ('BF007', 'Manusia Setengah Salmon', 'Komedi', 'PN003', 'Raditya Dika', '0'),
    ('BF008', 'The Christmas Pig', 'Dongeng', 'PN004', 'J.K. Rowling', '0'),
    ('BF009', 'Anak Semua Bangsa', 'Sejarah', 'PN005', 'Pramoedya Ananta Toer', '0'),
    ('BF010', 'Arok Dedes', 'Sejarah', 'PN005', 'Pramoedya Ananta Toer', '0');


select * from buku;

drop table MAHASISWA;

CREATE TABLE MAHASISWA
(
    NIM_MAHASISWA varchar(15) NOT NULL,
    NAMA_MAHASISWA varchar(35) NOT NULL,
    JENIS_KELAMIN_MAHASISWA char(1) NOT NULL,
    TELEPON_MAHASISWA varchar(13) NOT NULL,
    ALAMAT_MAHASISWA varchar(50),
    EMAIL_MAHASISWA varchar(25) NOT NULL,
    DELETE_MAHASISWA varchar(1) NOT NULL,
    PRIMARY KEY (NIM_MAHASISWA)
);

INSERT INTO MAHASISWA (NIM_MAHASISWA, NAMA_MAHASISWA, JENIS_KELAMIN_MAHASISWA, TELEPON_MAHASISWA, ALAMAT_MAHASISWA, EMAIL_MAHASISWA, DELETE_MAHASISWA)
VALUES
('20240901', 'Merlin', 'F', '081309120112', 'Jl. Merpati', 'merlin@gmail.com', '0'),
('20240902', 'Jenni', 'F', '081309111178', 'Jl. Garuda', 'jenni@gmail.com', '0'),
('20240903', 'Apin', 'M', '081109122762', 'Jl. Elang', 'apin@gmail.com', '0'),
('20240904', 'Budi', 'M', '081234567890', 'Jl. Kenari', 'budi@gmail.com', '0'),
('20240905', 'Siti', 'F', '081234567891', 'Jl. Kutilang', 'siti@gmail.com', '0'),
('20240906', 'Andi', 'M', '081234567892', 'Jl. Merpati', 'andi@gmail.com', '0'),
('20240907', 'Dewi', 'F', '081234567893', 'Jl. Cendrawasih', 'dewi@gmail.com', '0'),
('20240908', 'Rudi', 'M', '081234567894', 'Jl. Angsa', 'rudi@gmail.com', '0'),
('20240909', 'Lina', 'F', '081234567895', 'Jl. Rajawali', 'lina@gmail.com', '0'),
('20240910', 'Fajar', 'M', '081234567896', 'Jl. Merpati', 'fajar@gmail.com', '0');

select * from mahasiswa;

CREATE TABLE peminjaman (
    id_pinjam INT AUTO_INCREMENT PRIMARY KEY,
    nama_mahasiswa VARCHAR(100) NOT NULL,
    judul_buku VARCHAR(255) NOT NULL,
    tanggal_pinjam DATE NOT NULL,
    tanggal_pengembalian DATE NOT NULL
);

select * from peminjaman;