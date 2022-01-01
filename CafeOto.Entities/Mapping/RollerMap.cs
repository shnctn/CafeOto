using CafeOto.Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CafeOto.Entities.Mapping
{
    public class RollerMap : EntityTypeConfiguration<Roller>
    {
        public RollerMap()
        {
            this.ToTable("Roller");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FormName).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.ControlName).HasMaxLength(50).HasColumnType("varchar");
            this.Property(p => p.ControlCaption).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
