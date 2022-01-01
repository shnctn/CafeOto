using CafeOto.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace CafeOto.Entities.Models
{
    public class Musteriler : IEntity
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public virtual ICollection<Satislar> Satislar { get; set; }
    }
}
