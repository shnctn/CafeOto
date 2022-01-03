using CafeOto.Entities.Interfaces;
using System;

namespace CafeOto.Entities.Models
{

    public class MasaHareketleri : IEntity
    {
        public int Id { get; set; }
        public string SatisKodu { get; set; }
        public int? MasaId { get; set; }
        // public int MenuId { get; set; }
        public int UrunId { get; set; }
        public int Miktari { get; set; }
        public decimal BirimFiyati { get; set; }
        public decimal IndirimTutari { get; set; }
        public string Aciklama { get; set; }
        public DateTime SonIslemTarih { get; set; }
        public virtual Masalar Masalar { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
