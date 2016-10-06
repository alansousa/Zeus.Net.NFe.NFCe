using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_CONTRATO_INDICE_CORRECAO_INDMap : EntityTypeConfiguration<FA_CONTRATO_INDICE_CORRECAO_IND>
    {
        public FA_CONTRATO_INDICE_CORRECAO_INDMap()
        {
            // Primary Key
            this.HasKey(t => t.IND_ID);

            // Properties
            this.Property(t => t.IND_DESCRICAO)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("FA_CONTRATO_INDICE_CORRECAO_IND");
            this.Property(t => t.IND_ID).HasColumnName("IND_ID");
            this.Property(t => t.IND_DESCRICAO).HasColumnName("IND_DESCRICAO");
        }
    }
}
