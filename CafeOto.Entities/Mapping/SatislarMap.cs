using CafeOto.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeOto.Entities.Mapping
{
    public class SatislarMap : EntityTypeConfiguration<Satislar>
    {
        public SatislarMap()
        {
            this.ToTable("Satislar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SatisKodu).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.Aciklama).HasMaxLength(300).HasColumnType("varchar");
            this.Property(p => p.SonIslemTarih).HasColumnType("date");

            this.HasOptional(p => p.Musteriler).WithMany(p => p.Satislar).HasForeignKey(p => p.MusteriId);
        }
    }
}
