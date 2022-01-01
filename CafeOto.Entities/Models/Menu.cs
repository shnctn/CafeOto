using CafeOto.Entities.Interfaces;
using System.Collections.Generic;

namespace CafeOto.Entities.Models
{

    public class Menu : IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<Urun> Urun { get; set; }

    }
}
