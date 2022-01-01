using CafeOto.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeOto.Entities.Mapping
{
    public class KullanicilarMap : EntityTypeConfiguration<Kullanicilar>
    {
        public KullanicilarMap()
        {
            this.ToTable("Kullanicilar");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AdSoyad).HasMaxLength(150).HasColumnType("varchar");
            this.Property(p => p.Telefon).HasMaxLength(11).HasColumnType("varchar");
            this.Property(p => p.Email).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.Gorevi).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.KullaniciAdi).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.Parola).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.HatirlatmaSorusu).HasMaxLength(150).HasColumnType("varchar");
            this.Property(p => p.Cevap).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.Adres).HasMaxLength(550).HasColumnType("varchar");
            this.Property(p => p.KayitTarihi).HasColumnType("date");
        }

    }
}
