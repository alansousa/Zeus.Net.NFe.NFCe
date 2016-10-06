using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_POSICAO_TITULO_POTMap : EntityTypeConfiguration<GE_POSICAO_TITULO_POT>
    {
        public GE_POSICAO_TITULO_POTMap()
        {
            // Primary Key
            this.HasKey(t => t.POT_ID);

            // Properties
            this.Property(t => t.POT_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GE_POSICAO_TITULO_POT");
            this.Property(t => t.POT_ID).HasColumnName("POT_ID");
            this.Property(t => t.POT_DESCRICAO).HasColumnName("POT_DESCRICAO");
        }
    }
}
