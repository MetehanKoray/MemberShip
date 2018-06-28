using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MemberShip.Models.Mapping
{
    public class UrunRaporlaMap : EntityTypeConfiguration<UrunRaporla>
    {
        public UrunRaporlaMap()
        {
            // Primary Key
            this.HasKey(t => t.UrunAdi);

            // Properties
            this.Property(t => t.UrunAdi)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.BirimdekiMiktar)
                .HasMaxLength(20);

            this.Property(t => t.KategoriAdi)
                .HasMaxLength(15);

            this.Property(t => t.SirketAdi)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("UrunRaporla");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.BirimdekiMiktar).HasColumnName("BirimdekiMiktar");
            this.Property(t => t.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(t => t.KategoriAdi).HasColumnName("KategoriAdi");
            this.Property(t => t.SirketAdi).HasColumnName("SirketAdi");
        }
    }
}
