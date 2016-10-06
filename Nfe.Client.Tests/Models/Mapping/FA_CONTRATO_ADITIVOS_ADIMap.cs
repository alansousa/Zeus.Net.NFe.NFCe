using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_CONTRATO_ADITIVOS_ADIMap : EntityTypeConfiguration<FA_CONTRATO_ADITIVOS_ADI>
    {
        public FA_CONTRATO_ADITIVOS_ADIMap()
        {
            // Primary Key
            this.HasKey(t => t.ADI_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("FA_CONTRATO_ADITIVOS_ADI");
            this.Property(t => t.ADI_ID).HasColumnName("ADI_ID");
            this.Property(t => t.ADI_DATA).HasColumnName("ADI_DATA");
            this.Property(t => t.ADI_DESCRICAO).HasColumnName("ADI_DESCRICAO");
            this.Property(t => t.CON_ID).HasColumnName("CON_ID");

            // Relationships
            this.HasRequired(t => t.FA_CONTRATO_CON)
                .WithMany(t => t.FA_CONTRATO_ADITIVOS_ADI)
                .HasForeignKey(d => d.CON_ID);

        }
    }
}
