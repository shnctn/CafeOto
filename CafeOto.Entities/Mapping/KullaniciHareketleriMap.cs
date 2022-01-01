using CafeOto.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeOto.Entities.Mapping
{
    public class KullaniciHareketleriMap : EntityTypeConfiguration<KullaniciHareketleri>
    {
        public KullaniciHareketleriMap()
        {
            this.ToTable("KullaniciHareketleri");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Aciklama).HasMaxLength(350).HasColumnType("varchar");
            this.HasRequired(x => x.Kullanicilar).WithMany(x => x.KullaniciHareketleri)
                .HasForeignKey(x => x.KullaniciId);
        }
    }
}
