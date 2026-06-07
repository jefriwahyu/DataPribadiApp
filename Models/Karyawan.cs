namespace DataKaryApp.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Karyawan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long NIK { get; set; }

    [Required]
    public string NamaLengkap { get; set; } = string.Empty;

    public string JenisKelamin { get; set; } = string.Empty;

    public DateTime? TanggalLahir { get; set; }

    public string Alamat { get; set; } = string.Empty;

    public string Negara { get; set; } = string.Empty;

    [NotMapped]
    public int Umur
    {
        get
        {
            if (!TanggalLahir.HasValue) return 0;
            var today = DateTime.Today;
            var age = today.Year - TanggalLahir.Value.Year;
            // Kurangi 1 kalau bulan dan tanggal ulang tahun belum lewat tahun ini
            if (TanggalLahir.Value.Month > today.Month ||
                (TanggalLahir.Value.Month == today.Month && TanggalLahir.Value.Day > today.Day))
            {
                age--;
            }
            return age;
        }
    }
}
