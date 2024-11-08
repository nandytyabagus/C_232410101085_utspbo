CREATE TABLE Buku (
    id_buku SERIAL PRIMARY KEY,
    Judul_Buku VARCHAR(100) NOT NULL,
    Penerbit VARCHAR(100),
    Tahun_Terbit INTEGER
);

CREATE TABLE Pengguna (
    id_Pengguna SERIAL PRIMARY KEY,
    username VARCHAR(100) NOT NULL,
    password VARCHAR(100) NOT NULL
);
