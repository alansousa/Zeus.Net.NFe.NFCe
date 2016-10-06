using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_CONTRATO_SLAMap : EntityTypeConfiguration<FA_CONTRATO_SLA>
    {
        public FA_CONTRATO_SLAMap()
        {
            // Primary Key
            this.HasKey(t => t.SLA_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("FA_CONTRATO_SLA");
            this.Property(t => t.SLA_ID).HasColumnName("SLA_ID");
            this.Property(t => t.CON_ID).HasColumnName("CON_ID");
            this.Property(t => t.TSL_ID).HasColumnName("TSL_ID");

            // Relationships
            this.HasRequired(t => t.FA_CONTRATO_CON)
                .WithMany(t => t.FA_CONTRATO_SLA)
                .HasForeignKey(d => d.CON_ID);
            this.HasRequired(t => t.FA_CONTRATO_TIPOS_SLA_TSL)
                .WithMany(t => t.FA_CONTRATO_SLA)
                .HasForeignKey(d => d.TSL_ID);

        }
    }
}
