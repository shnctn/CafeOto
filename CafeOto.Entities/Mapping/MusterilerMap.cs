using CafeOto.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeOto.Entities.Mapping
{
    public class MusterilerMap : EntityTypeConfiguration<Musteriler>
    {
        public MusterilerMap()
        {
            this.ToTable("Musteriler");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Aciklama).HasMaxLength(350).HasColumnType("varchar");
            this.Property(p => p.AdSoyad).HasMaxLength(20).HasColumnType("varchar");
            this.Property(p => p.Adres).HasMaxLength(350).HasColumnType("varchar");
            this.Property(p => p.telefon).HasMaxLength(350).HasColumnType("varchar");
            this.Property(p => p.Email).HasMaxLength(25).HasColumnType("varchar");

        }
    }
}
