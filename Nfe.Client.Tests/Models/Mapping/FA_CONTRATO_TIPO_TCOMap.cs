using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_CONTRATO_TIPO_TCOMap : EntityTypeConfiguration<FA_CONTRATO_TIPO_TCO>
    {
        public FA_CONTRATO_TIPO_TCOMap()
        {
            // Primary Key
            this.HasKey(t => t.TCO_ID);

            // Properties
            this.Property(t => t.TCO_DESCRICAO)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("FA_CONTRATO_TIPO_TCO");
            this.Property(t => t.TCO_ID).HasColumnName("TCO_ID");
            this.Property(t => t.TCO_DESCRICAO).HasColumnName("TCO_DESCRICAO");
            this.Property(t => t.PJO_ID).HasColumnName("PJO_ID");
            this.Property(t => t.CCR_ID).HasColumnName("CCR_ID");
            this.Property(t => t.CPR_ID).HasColumnName("CPR_ID");
            this.Property(t => t.TPG_ID).HasColumnName("TPG_ID");
            this.Property(t => t.TPV_ID).HasColumnName("TPV_ID");
            this.Property(t => t.ITE_ID).HasColumnName("ITE_ID");

            // Relationships
            this.HasRequired(t => t.CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR)
                .WithMany(t => t.FA_CONTRATO_TIPO_TCO)
                .HasForeignKey(d => d.CPR_ID);
            this.HasRequired(t => t.CP_TIPO_PAGAMENTO_TPG)
                .WithMany(t => t.FA_CONTRATO_TIPO_TCO)
                .HasForeignKey(d => d.TPG_ID);
            this.HasRequired(t => t.ES_ITEM_ITE)
                .WithMany(t => t.FA_CONTRATO_TIPO_TCO)
                .HasForeignKey(d => d.ITE_ID);
            this.HasRequired(t => t.GE_CENTRO_CUSTO_RECEITAS_CCR)
                .WithMany(t => t.FA_CONTRATO_TIPO_TCO)
                .HasForeignKey(d => d.CCR_ID);
            this.HasRequired(t => t.GE_PROJETO_PJO)
                .WithMany(t => t.FA_CONTRATO_TIPO_TCO)
                .HasForeignKey(d => d.PJO_ID);
            this.HasRequired(t => t.PD_TIPO_VENDA_TPV)
                .WithMany(t => t.FA_CONTRATO_TIPO_TCO)
                .HasForeignKey(d => d.TPV_ID);

        }
    }
}
