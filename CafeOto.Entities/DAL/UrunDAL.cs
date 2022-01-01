using CafeOto.Entities.Models;
using CafeOto.Entities.Repository;
using CafeOto.Entities.Validations;
using System.Linq;

namespace CafeOto.Entities.DAL
{
    public class UrunDAL : EntityRepositoryBase<CafeContext, Urun, UrunValidator>
    {
        public object Urunlistele(CafeContext context)
        {
            var liste = (from u in context.Urun
                         select new
                         {
                             u.Id,
                             u.MenuId,
                             Menu = u.Menu.Adi,
                             u.UrunAdi,
                             u.UrunKodu,
                             u.BirimFiyat,
                             u.BirimFiyat2,
                             u.BirimFiyat3,
                             u.Aciklama,
                             u.Resim,
                             u.Tarih
                         }).ToList();
            return liste;
        }
    }
}
