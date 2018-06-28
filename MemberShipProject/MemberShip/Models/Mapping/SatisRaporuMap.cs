using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MemberShip.Models.Mapping
{
    public class SatisRaporuMap : EntityTypeConfiguration<SatisRaporu>
    {
        public SatisRaporuMap()
        {
            // Primary Key
            this.HasKey(t => t.Adi);

            // Properties
            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.UrunAdi)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("SatisRaporu");
            this.Property(t => t.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
        }
    }
}
