using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_CONTRATO_TIPOS_SLA_TSLMap : EntityTypeConfiguration<FA_CONTRATO_TIPOS_SLA_TSL>
    {
        public FA_CONTRATO_TIPOS_SLA_TSLMap()
        {
            // Primary Key
            this.HasKey(t => t.TSL_ID);

            // Properties
            this.Property(t => t.TSL_DESCRICAO)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("FA_CONTRATO_TIPOS_SLA_TSL");
            this.Property(t => t.TSL_ID).HasColumnName("TSL_ID");
            this.Property(t => t.TSL_DESCRICAO).HasColumnName("TSL_DESCRICAO");
        }
    }
}
