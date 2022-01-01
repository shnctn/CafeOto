using CafeOto.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeOto.Entities.Mapping
{
    public class MasaHareketleriMap : EntityTypeConfiguration<MasaHareketleri>
    {
        public MasaHareketleriMap()
        {
            this.ToTable("MasaHareketleri");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SatisKodu).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.Aciklama).HasMaxLength(350).HasColumnType("varchar");
            this.Property(p => p.SonIslemTarih).HasColumnType("date");
            this.HasRequired(x => x.Masalar).WithMany(x => x.MasaHareketleri).HasForeignKey(x => x.MasaId);
            this.HasRequired(x => x.Urun).WithMany(x => x.MasaHareketleri).HasForeignKey(x => x.UrunId);
        }
    }
}
