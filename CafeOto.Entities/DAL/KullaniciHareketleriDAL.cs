using CafeOto.Entities.Models;
using CafeOto.Entities.Repository;
using CafeOto.Entities.Validations;
using System;

namespace CafeOto.Entities.DAL
{
    public class KullaniciHareketleriDAL : EntityRepositoryBase<CafeContext, KullaniciHareketleri, KullaniciHareketleriValidator>
    {
        public static int kullaniciId { get; set; }
        public void kullaniciHareketleriEkle(CafeContext context, KullaniciHareketleri kullaniciHareketler, string Aciklama)
        {

            KullaniciHareketleriDAL kullaniciHareketleriDAL = new KullaniciHareketleriDAL();
            kullaniciHareketler.Tarih = DateTime.Now;
            kullaniciHareketler.Aciklama = Aciklama;
            if (kullaniciHareketleriDAL.AddOrUpdate(context, kullaniciHareketler))
            {
                kullaniciHareketleriDAL.save(context);
            }

        }
    }
}
