using CafeOto.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeOto.Entities.Mapping
{
    public class MasalarMap : EntityTypeConfiguration<Masalar>
    {
        public MasalarMap()
        {
            this.ToTable("Masalar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MasaAdi).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.SatisKodu).HasMaxLength(15).HasColumnType("varchar");
            this.Property(p => p.EklemeTarih).HasColumnType("date");

            this.HasOptional(p => p.Kullanicilar).WithMany(p => p.Masalar).HasForeignKey(p => p.KullaniciId);
        }
    }
}
