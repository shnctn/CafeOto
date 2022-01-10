using CafeOto.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace CafeOto.Entities.Models
{

    public class Kullanicilar : IEntity
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Gorevi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string Cevap { get; set; }
        public string Aciklama { get; set; }
        public DateTime KayitTarihi { get; set; }
        public bool AktifMi { get; set; }=true;
        public bool isAdmin { get; set; } = false;
        public virtual ICollection<KullaniciHareketleri> KullaniciHareketleri { get; set; }
        public virtual ICollection<Masalar> Masalar { get; set; }

    }
}
