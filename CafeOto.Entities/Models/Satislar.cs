using CafeOto.Entities.Interfaces;
using System;

namespace CafeOto.Entities.Models
{

    public class Satislar : IEntity
    {
        public int Id { get; set; }
        public string SatisKodu { get; set; }
        public int? MusteriId { get; set; }
        public decimal Tutar { get; set; }
        public decimal indirimToplami { get; set; }
        public decimal Odenen { get; set; }
        public decimal Kalan { get; set; }
        public string Aciklama { get; set; }
        public DateTime SonIslemTarih { get; set; }
        public virtual Musteriler Musteriler { get; set; }

    }
}
