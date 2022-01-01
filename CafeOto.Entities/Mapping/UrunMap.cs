using CafeOto.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeOto.Entities.Mapping
{
    public class UrunMap : EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            this.ToTable("Urun");
            this.HasKey(p => p.Id).Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.UrunAdi).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.UrunKodu).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.Aciklama).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.BirimFiyat).HasPrecision(28, 2);
            this.Property(p => p.BirimFiyat2).HasPrecision(28, 2);
            this.Property(p => p.BirimFiyat3).HasPrecision(28, 2);

            this.HasRequired(x => x.Menu).WithMany(x => x.Urun).HasForeignKey(x => x.MenuId);
        }
    }
}
