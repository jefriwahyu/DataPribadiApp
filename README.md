# Aplikasi Data Pribadi Karyawan

Aplikasi web untuk mengelola data pribadi karyawan, dibangun menggunakan ASP.NET Core MVC dengan Entity Framework Core.

---

## Teknologi yang Digunakan

- **Front End** : HTML, CSS, JavaScript, jQuery, Bootstrap 5
- **Back End**  : C# ASP.NET Core MVC
- **ORM**       : Entity Framework Core
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

## Struktur Project

```
DataPribadiApp/
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
git clone https://github.com/USERNAME/NAMA_REPO.git
cd NAMA_REPO
```

2. **Restore database** — buka SQL Server Management Studio (SSMS), lalu jalankan file `database/DataPribadiDB.sql`

3. **Sesuaikan Connection String** di `appsettings.json`
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=NAMA_SERVER;Database=DataPribadiDB;Trusted_Connection=True;TrustServerCertificate=True;"
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

- **Nama**    : Jefri Wahyudiana Putra
- **Bulan** : Juni 2026
