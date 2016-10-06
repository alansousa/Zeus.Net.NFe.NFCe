using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_CONTRATO_ALTERACOES_ALTMap : EntityTypeConfiguration<FA_CONTRATO_ALTERACOES_ALT>
    {
        public FA_CONTRATO_ALTERACOES_ALTMap()
        {
            // Primary Key
            this.HasKey(t => t.ALT_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("FA_CONTRATO_ALTERACOES_ALT");
            this.Property(t => t.ALT_ID).HasColumnName("ALT_ID");
            this.Property(t => t.ALT_DATA).HasColumnName("ALT_DATA");
            this.Property(t => t.ALT_DESCRICAO).HasColumnName("ALT_DESCRICAO");
            this.Property(t => t.CON_ID).HasColumnName("CON_ID");

            // Relationships
            this.HasRequired(t => t.FA_CONTRATO_CON)
                .WithMany(t => t.FA_CONTRATO_ALTERACOES_ALT)
                .HasForeignKey(d => d.CON_ID);

        }
    }
}
