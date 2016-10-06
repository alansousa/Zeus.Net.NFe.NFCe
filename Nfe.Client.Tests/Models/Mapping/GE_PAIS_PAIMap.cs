using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_PAIS_PAIMap : EntityTypeConfiguration<GE_PAIS_PAI>
    {
        public GE_PAIS_PAIMap()
        {
            // Primary Key
            this.HasKey(t => t.PAI_ID);

            // Properties
            this.Property(t => t.PAI_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PAI_ISO_2)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.PAI_ISO_3)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.PAI_NOME)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GE_PAIS_PAI");
            this.Property(t => t.PAI_ID).HasColumnName("PAI_ID");
            this.Property(t => t.PAI_ISO_2).HasColumnName("PAI_ISO_2");
            this.Property(t => t.PAI_ISO_3).HasColumnName("PAI_ISO_3");
            this.Property(t => t.PAI_NOME).HasColumnName("PAI_NOME");
        }
    }
}
