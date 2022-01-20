using CafeOto.Entities.Interfaces;

namespace CafeOto.Entities.Models
{
    public class Roller : IEntity
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public string FormName { get; set; }
        public string ControlName { get; set; }
        public string ControlCaption { get; set; }
        public bool Visible { get; set; }
    }
}
