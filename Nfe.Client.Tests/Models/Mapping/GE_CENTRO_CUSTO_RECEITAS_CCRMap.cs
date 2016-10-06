using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_CENTRO_CUSTO_RECEITAS_CCRMap : EntityTypeConfiguration<GE_CENTRO_CUSTO_RECEITAS_CCR>
    {
        public GE_CENTRO_CUSTO_RECEITAS_CCRMap()
        {
            // Primary Key
            this.HasKey(t => t.CCR_ID);

            // Properties
            this.Property(t => t.CCR_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CCR_TIPO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("GE_CENTRO_CUSTO_RECEITAS_CCR");
            this.Property(t => t.CCR_ID).HasColumnName("CCR_ID");
            this.Property(t => t.CCR_DESCRICAO).HasColumnName("CCR_DESCRICAO");
            this.Property(t => t.CCR_TIPO).HasColumnName("CCR_TIPO");
        }
    }
}
