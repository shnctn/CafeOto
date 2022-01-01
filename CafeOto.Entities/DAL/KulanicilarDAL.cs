using CafeOto.Entities.Models;
using CafeOto.Entities.Repository;
using CafeOto.Entities.Validations;

namespace CafeOto.Entities.DAL
{
    public class KulanicilarDAL : EntityRepositoryBase<CafeContext, Kullanicilar, KullanicilarValidator>
    {
    }
}
