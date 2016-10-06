using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_IBGE_IBGMap : EntityTypeConfiguration<GE_IBGE_IBG>
    {
        public GE_IBGE_IBGMap()
        {
            // Primary Key
            this.HasKey(t => t.IBG_CODCID);

            // Properties
            this.Property(t => t.IBG_CIDADE)
                .HasMaxLength(40);

            this.Property(t => t.IBG_UF)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.IBG_CODCID)
                .IsRequired();

            this.Property(t => t.IBG_CODUF)
                .HasMaxLength(2);

            this.Property(t => t.IBG_NOMEUF)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("GE_IBGE_IBG");
            this.Property(t => t.IBG_CIDADE).HasColumnName("IBG_CIDADE");
            this.Property(t => t.IBG_UF).HasColumnName("IBG_UF");
            this.Property(t => t.IBG_CODCID).HasColumnName("IBG_CODCID");
            this.Property(t => t.IBG_CODUF).HasColumnName("IBG_CODUF");
            this.Property(t => t.IBG_NOMEUF).HasColumnName("IBG_NOMEUF");
        }
    }
}
