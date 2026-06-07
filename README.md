# Aplikasi Data Karyawan

Aplikasi web untuk mengelola data pribadi karyawan, dibangun menggunakan ASP.NET Core MVC.

---

## Teknologi yang Digunakan

- **Front End** : HTML, CSS, JavaScript, jQuery, Bootstrap 5
- **Back End**  : C# ASP.NET Core MVC
- **Database**  : Microsoft SQL Server

---

## Fitur

- Monitoring data karyawan
- Tambah data karyawan baru
- Edit data karyawan
- Detail data karyawan
- Hapus data karyawan dengan konfirmasi
- Pencarian berdasarkan NIK dan Nama

---

## Tampilan Aplikasi

### Home
<img width="1349" height="680" alt="image" src="https://github.com/user-attachments/assets/dbebf833-5dd1-4b67-9a31-be2470d04b88" />

### Monitoring Data Karyawan
<img width="1365" height="644" alt="image" src="https://github.com/user-attachments/assets/b9f145b7-6599-4b61-87c3-f4ac2fc33d98" />

### Tambah Data
<img width="1348" height="677" alt="image" src="https://github.com/user-attachments/assets/5ddd222a-320b-4f2e-bc7c-8f3b7d6353ef" />

### Edit Data
<img width="1351" height="678" alt="image" src="https://github.com/user-attachments/assets/61373461-315a-4b83-8e7b-925e6b3dcb02" />

### Detail Data
<img width="1348" height="691" alt="image" src="https://github.com/user-attachments/assets/5c9e1158-79f9-4ff7-8ca3-c9b1302cb7ae" />

### Hapus Data
<img width="1365" height="647" alt="image" src="https://github.com/user-attachments/assets/d3f6384e-cebc-49df-9344-4919d53f37fd" />

---

## Struktur Project

```
DataKaryApp/
├── Controllers/
│   ├── HomeController.cs
│   └── KaryawanController.cs
├── Models/
│   └── Karyawan.cs
├── Data/
│   └── AppDbContext.cs
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   ├── Karyawan/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   ├── Edit.cshtml
│   │   └── Detail.cshtml
│   └── Shared/
│       └── _Layout.cshtml
├── database/
│   └── DataKaryAppDB.sql
└── appsettings.json
```

---

## Cara Menjalankan

### Prasyarat

- .NET SDK 8.0 atau lebih baru
- Microsoft SQL Server
- Visual Studio / VS Code

### Langkah - langkah

1. **Clone repository ini**
```bash
git clone https://github.com/jefriwahyu/DataKaryApp.git
cd DataKaryApp
```

2. **Restore database** — buka SQL Server Management Studio (SSMS), lalu jalankan file `database/DataKaryAppDB.sql`

3. **Sesuaikan Connection String** di `appsettings.json`
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=NAMA_SERVER;Database=DataKaryAppDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```
Ganti `NAMA_SERVER` dengan nama SQL Server kamu.

4. **Jalankan aplikasi**
```bash
dotnet run
```

5. **Buka browser** dan akses
```
http://localhost:PORT
```

---

## Struktur Database

| Kolom        | Tipe      | Keterangan            |
|--------------|-----------|-----------------------|
| NIK          | bigint    | Primary Key           |
| NamaLengkap  | nvarchar  | Mandatory             |
| JenisKelamin | nvarchar  | Laki-laki / Perempuan |
| TanggalLahir | datetime2 | Nullable              |
| Alamat       | nvarchar  | -                     |
| Negara       | nvarchar  | -                     |

---

## Developer

- **Nama**    : [Nama Kamu]
- **Tanggal** : Juni 2026
