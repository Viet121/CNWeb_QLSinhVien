using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("KHOA")]
    public class Khoa
    {
        [Key]

        public string? MaK {get; set;}
        public string? TenK {get; set;}
    }
}