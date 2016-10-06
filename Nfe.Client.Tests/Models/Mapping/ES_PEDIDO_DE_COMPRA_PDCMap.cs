using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class ES_PEDIDO_DE_COMPRA_PDCMap : EntityTypeConfiguration<ES_PEDIDO_DE_COMPRA_PDC>
    {
        public ES_PEDIDO_DE_COMPRA_PDCMap()
        {
            // Primary Key
            this.HasKey(t => t.PDC_ID);

            // Properties
            this.Property(t => t.PDC_NUMERO_NOTA_FISCAL)
                .HasMaxLength(50);

            this.Property(t => t.PDC_NUMERO_PDV_FORNECEDOR)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("ES_PEDIDO_DE_COMPRA_PDC");
            this.Property(t => t.PDC_ID).HasColumnName("PDC_ID");
            this.Property(t => t.PDC_DATA_EMISSAO).HasColumnName("PDC_DATA_EMISSAO");
            this.Property(t => t.PDC_DATA_PREVISAO_ENTREGA).HasColumnName("PDC_DATA_PREVISAO_ENTREGA");
            this.Property(t => t.PDC_NUMERO_NOTA_FISCAL).HasColumnName("PDC_NUMERO_NOTA_FISCAL");
            this.Property(t => t.PDC_NUMERO_PDV_FORNECEDOR).HasColumnName("PDC_NUMERO_PDV_FORNECEDOR");
            this.Property(t => t.PDC_VALOR).HasColumnName("PDC_VALOR");
            this.Property(t => t.PDC_ACRESCIMO).HasColumnName("PDC_ACRESCIMO");
            this.Property(t => t.PDC_ABATIMENTO).HasColumnName("PDC_ABATIMENTO");
            this.Property(t => t.PDC_VALOR_TOTAL_LIQUIDO).HasColumnName("PDC_VALOR_TOTAL_LIQUIDO");
            this.Property(t => t.PDC_INCLUSAO_USUARIO).HasColumnName("PDC_INCLUSAO_USUARIO");
            this.Property(t => t.PDC_INCLUSAO_DATA).HasColumnName("PDC_INCLUSAO_DATA");
            this.Property(t => t.PDC_LIBERACAO_USUARIO).HasColumnName("PDC_LIBERACAO_USUARIO");
            this.Property(t => t.PDC_LIBERACAO_DATA).HasColumnName("PDC_LIBERACAO_DATA");
            this.Property(t => t.PDC_RECEBIMENTO_USUARIO).HasColumnName("PDC_RECEBIMENTO_USUARIO");
            this.Property(t => t.PDC_RECEBIMENTO_DATA).HasColumnName("PDC_RECEBIMENTO_DATA");
            this.Property(t => t.PDC_FATURAMENTO_USUARIO).HasColumnName("PDC_FATURAMENTO_USUARIO");
            this.Property(t => t.PDC_FATURAMENTO_DATA).HasColumnName("PDC_FATURAMENTO_DATA");
            this.Property(t => t.PDC_TIPO).HasColumnName("PDC_TIPO");
            this.Property(t => t.PDC_STATUS).HasColumnName("PDC_STATUS");
            this.Property(t => t.PDC_OBSERVACOES).HasColumnName("PDC_OBSERVACOES");
            this.Property(t => t.PDC_FORNECEDOR).HasColumnName("PDC_FORNECEDOR");
            this.Property(t => t.PDC_PROJETO).HasColumnName("PDC_PROJETO");
            this.Property(t => t.PDC_CENTRO_CUSTO_RECEITA).HasColumnName("PDC_CENTRO_CUSTO_RECEITA");
            this.Property(t => t.PDC_CATEGORIA_PAGAMENTO).HasColumnName("PDC_CATEGORIA_PAGAMENTO");
            this.Property(t => t.PDC_TIPO_PAGAMENTO).HasColumnName("PDC_TIPO_PAGAMENTO");
            this.Property(t => t.PDC_EMPRESA).HasColumnName("PDC_EMPRESA");
            this.Property(t => t.PDC_CONTATO).HasColumnName("PDC_CONTATO");
            this.Property(t => t.PDC_FORMA_PAGAMENTO).HasColumnName("PDC_FORMA_PAGAMENTO");

            // Relationships
            this.HasRequired(t => t.CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR)
                .WithMany(t => t.ES_PEDIDO_DE_COMPRA_PDC)
                .HasForeignKey(d => d.PDC_CATEGORIA_PAGAMENTO);
            this.HasRequired(t => t.CP_CONDICOES_PAGTO_CPA)
                .WithMany(t => t.ES_PEDIDO_DE_COMPRA_PDC)
                .HasForeignKey(d => d.PDC_FORMA_PAGAMENTO);
            this.HasRequired(t => t.CP_TIPO_PAGAMENTO_TPG)
                .WithMany(t => t.ES_PEDIDO_DE_COMPRA_PDC)
                .HasForeignKey(d => d.PDC_TIPO_PAGAMENTO);
            this.HasRequired(t => t.GE_CENTRO_CUSTO_RECEITAS_CCR)
                .WithMany(t => t.ES_PEDIDO_DE_COMPRA_PDC)
                .HasForeignKey(d => d.PDC_CENTRO_CUSTO_RECEITA);
            this.HasRequired(t => t.GE_CONTATO_PARCEIRO_CON)
                .WithMany(t => t.ES_PEDIDO_DE_COMPRA_PDC)
                .HasForeignKey(d => d.PDC_CONTATO);
            this.HasRequired(t => t.GE_EMPRESA_EMP)
                .WithMany(t => t.ES_PEDIDO_DE_COMPRA_PDC)
                .HasForeignKey(d => d.PDC_EMPRESA);
            this.HasRequired(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .WithMany(t => t.ES_PEDIDO_DE_COMPRA_PDC)
                .HasForeignKey(d => d.PDC_FORNECEDOR);
            this.HasRequired(t => t.GE_PROJETO_PJO)
                .WithMany(t => t.ES_PEDIDO_DE_COMPRA_PDC)
                .HasForeignKey(d => d.PDC_PROJETO);

        }
    }
}
