using CafeOto.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeOto.Entities.Models
{
    [Table("SatisKodu")]
    public class SatisKodu : IEntity
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]

        public string Tanim { get; set; }

        public int Sayi { get; set; }
    }
}
