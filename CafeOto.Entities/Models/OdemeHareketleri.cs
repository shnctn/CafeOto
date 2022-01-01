using CafeOto.Entities.Interfaces;
using System;

namespace CafeOto.Entities.Models
{
    public class OdemeHareketleri : IEntity
    {
        public int Id { get; set; }
        public string SatisKodu { get; set; }
        public string OdemeTuru { get; set; }
        public decimal Odenen { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }

    }
}
