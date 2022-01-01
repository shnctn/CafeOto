using CafeOto.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeOto.Entities.Mapping
{
    public class OdemeHareketleriMap : EntityTypeConfiguration<OdemeHareketleri>
    {
        public OdemeHareketleriMap()
        {
            this.ToTable("OdemeHareketleri");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SatisKodu).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.Tarih).HasColumnType("date");
            this.Property(p => p.Odenen).HasPrecision(28, 2);
        }
    }
}
