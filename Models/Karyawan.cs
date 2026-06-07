namespace DataPribadiApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Karyawan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long NIK { get; set;}

    [Required]
    public string NamaLengkap { get; set;} = string.Empty;

    public string JenisKelamin { get; set; } = string.Empty;

    public DateTime? TanggalLahir { get; set;} 

    public string Alamat { get; set;} = string.Empty;

    public string Negara { get; set;} = string.Empty;

    [NotMapped]
    public int Umur => TanggalLahir.HasValue
        ? DateTime.Today.Year - TanggalLahir.Value.Year
        : 0;
}
