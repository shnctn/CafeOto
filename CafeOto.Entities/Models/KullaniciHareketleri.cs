using CafeOto.Entities.Interfaces;
using System;

namespace CafeOto.Entities.Models
{
    public class KullaniciHareketleri : IEntity
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public virtual Kullanicilar Kullanicilar { get; set; }

    }
}
