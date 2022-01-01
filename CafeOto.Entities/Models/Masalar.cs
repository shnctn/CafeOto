using CafeOto.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace CafeOto.Entities.Models
{
    public class Masalar : IEntity
    {
        public int Id { get; set; }
        public string MasaAdi { get; set; }
        public string Aciklama { get; set; }
        public bool Durumu { get; set; }
        public bool RezerveMi { get; set; }
        public DateTime EklemeTarih { get; set; }

        public DateTime SonIslemTarih { get; set; }
        public string Islem { get; set; }
        public string SatisKodu { get; set; }
        public int? KullaniciId { get; set; }

        public virtual ICollection<MasaHareketleri> MasaHareketleri { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
