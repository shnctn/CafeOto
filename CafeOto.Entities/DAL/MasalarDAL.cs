using CafeOto.Entities.Models;
using CafeOto.Entities.Repository;
using CafeOto.Entities.Validations;
using System.Linq;

namespace CafeOto.Entities.DAL
{
    public class MasalarDAL : EntityRepositoryBase<CafeContext, Masalar, MasalarValidator>
    {
        public object MasalariListele(CafeContext context)
        {
            // masalar listesi gelmiyor bakılacak
            var model = (from masa in context.Masalar
                         join k in context.Kullanicilar on masa.KullaniciId equals k.Id into kullanici
                         from kullanicimasa in kullanici.DefaultIfEmpty()
                         select new
                         {
                             masa.Id,
                             masa.MasaAdi,
                             masa.Aciklama,
                             masa.Durumu,
                             masa.EklemeTarih,
                             masa.Islem,
                             masa.RezerveMi,
                             masa.SonIslemTarih,
                             Kullanici = kullanicimasa.KullaniciAdi

                         }).ToList();
            return model;
        }
    }
}

