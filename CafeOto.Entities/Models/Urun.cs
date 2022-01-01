using CafeOto.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace CafeOto.Entities.Models
{

    public class Urun : IEntity
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public string UrunKodu { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal BirimFiyat2 { get; set; }
        public decimal BirimFiyat3 { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public virtual Menu Menu { get; set; }
        public string Resim { get; set; }
        public virtual ICollection<MasaHareketleri> MasaHareketleri { get; set; }

    }
}
