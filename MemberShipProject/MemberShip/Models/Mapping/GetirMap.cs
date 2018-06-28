using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MemberShip.Models.Mapping
{
    public class GetirMap : EntityTypeConfiguration<Getir>
    {
        public GetirMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SatisID, t.PersonelAdı, t.UrunAdı });

            // Properties
            this.Property(t => t.SatisID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MusteriID)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.SevkAdi)
                .HasMaxLength(40);

            this.Property(t => t.SevkAdresi)
                .HasMaxLength(60);

            this.Property(t => t.SevkSehri)
                .HasMaxLength(15);

            this.Property(t => t.SevkBolgesi)
                .HasMaxLength(15);

            this.Property(t => t.SevkPostaKodu)
                .HasMaxLength(10);

            this.Property(t => t.SevkUlkesi)
                .HasMaxLength(15);

            this.Property(t => t.PersonelAdı)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.UrunAdı)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Getir");
            this.Property(t => t.SatisID).HasColumnName("SatisID");
            this.Property(t => t.MusteriID).HasColumnName("MusteriID");
            this.Property(t => t.PersonelID).HasColumnName("PersonelID");
            this.Property(t => t.SatisTarihi).HasColumnName("SatisTarihi");
            this.Property(t => t.OdemeTarihi).HasColumnName("OdemeTarihi");
            this.Property(t => t.SevkTarihi).HasColumnName("SevkTarihi");
            this.Property(t => t.ShipVia).HasColumnName("ShipVia");
            this.Property(t => t.NakliyeUcreti).HasColumnName("NakliyeUcreti");
            this.Property(t => t.SevkAdi).HasColumnName("SevkAdi");
            this.Property(t => t.SevkAdresi).HasColumnName("SevkAdresi");
            this.Property(t => t.SevkSehri).HasColumnName("SevkSehri");
            this.Property(t => t.SevkBolgesi).HasColumnName("SevkBolgesi");
            this.Property(t => t.SevkPostaKodu).HasColumnName("SevkPostaKodu");
            this.Property(t => t.SevkUlkesi).HasColumnName("SevkUlkesi");
            this.Property(t => t.PersonelAdı).HasColumnName("PersonelAdı");
            this.Property(t => t.UrunAdı).HasColumnName("UrunAdı");
        }
    }
}
