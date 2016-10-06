using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class CP_CONTA_A_PAGAR_CPAMap : EntityTypeConfiguration<CP_CONTA_A_PAGAR_CPA>
    {
        public CP_CONTA_A_PAGAR_CPAMap()
        {
            // Primary Key
            this.HasKey(t => t.CPA_ID);

            // Properties
            this.Property(t => t.CPA_TITULO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CPA_CODIGO_BARRAS_PAGAMENTO)
                .HasMaxLength(255);

            this.Property(t => t.CPA_VINCULO_PARCELAS)
                .HasMaxLength(50);

            this.Property(t => t.CPA_ENDIVIDAMENTO_CONTRATO)
                .HasMaxLength(100);

            this.Property(t => t.CPA_ENDIVIDAMENTO_TAXA)
                .HasMaxLength(50);

            this.Property(t => t.CPA_ENDIVIDAMENTO_GARANTIAS)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CP_CONTA_A_PAGAR_CPA");
            this.Property(t => t.CPA_ID).HasColumnName("CPA_ID");
            this.Property(t => t.CPA_EMPRESA).HasColumnName("CPA_EMPRESA");
            this.Property(t => t.CPA_TITULO).HasColumnName("CPA_TITULO");
            this.Property(t => t.CPA_PEDIDO_DE_COMPRA).HasColumnName("CPA_PEDIDO_DE_COMPRA");
            this.Property(t => t.CPA_PARCELA).HasColumnName("CPA_PARCELA");
            this.Property(t => t.CPA_PARCELA_REFINANCIAMENTO).HasColumnName("CPA_PARCELA_REFINANCIAMENTO");
            this.Property(t => t.CPA_LIBERADO_PAGAMENTO_USU_ID).HasColumnName("CPA_LIBERADO_PAGAMENTO_USU_ID");
            this.Property(t => t.CPA_LIBERADO_PAGAMENTO_DATA).HasColumnName("CPA_LIBERADO_PAGAMENTO_DATA");
            this.Property(t => t.CPA_VALOR).HasColumnName("CPA_VALOR");
            this.Property(t => t.CPA_DATA_EMISSAO).HasColumnName("CPA_DATA_EMISSAO");
            this.Property(t => t.CPA_DATA_VENCIMENTO).HasColumnName("CPA_DATA_VENCIMENTO");
            this.Property(t => t.CPA_DATA_PAGAMENTO).HasColumnName("CPA_DATA_PAGAMENTO");
            this.Property(t => t.CPA_DATA_PREVISAO_PAGAMENTO).HasColumnName("CPA_DATA_PREVISAO_PAGAMENTO");
            this.Property(t => t.CPA_DESCONTO).HasColumnName("CPA_DESCONTO");
            this.Property(t => t.CPA_ACRESCIMO).HasColumnName("CPA_ACRESCIMO");
            this.Property(t => t.CPA_PIS).HasColumnName("CPA_PIS");
            this.Property(t => t.CPA_IR).HasColumnName("CPA_IR");
            this.Property(t => t.CPA_INSS).HasColumnName("CPA_INSS");
            this.Property(t => t.CPA_ISS).HasColumnName("CPA_ISS");
            this.Property(t => t.CPA_VALOR_TOTAL_LIQUIDO).HasColumnName("CPA_VALOR_TOTAL_LIQUIDO");
            this.Property(t => t.CPA_CODIGO_BARRAS_PAGAMENTO).HasColumnName("CPA_CODIGO_BARRAS_PAGAMENTO");
            this.Property(t => t.CPA_FORNECEDOR).HasColumnName("CPA_FORNECEDOR");
            this.Property(t => t.CPA_PROJETO).HasColumnName("CPA_PROJETO");
            this.Property(t => t.CPA_CENTRO_CUSTO_RECEITA).HasColumnName("CPA_CENTRO_CUSTO_RECEITA");
            this.Property(t => t.CPA_CATEGORIA_PAGAMENTO).HasColumnName("CPA_CATEGORIA_PAGAMENTO");
            this.Property(t => t.CPA_TIPO_PAGAMENTO).HasColumnName("CPA_TIPO_PAGAMENTO");
            this.Property(t => t.CPA_OBSERVACOES).HasColumnName("CPA_OBSERVACOES");
            this.Property(t => t.CPA_MOTIVO_BAIXA_MANUAL).HasColumnName("CPA_MOTIVO_BAIXA_MANUAL");
            this.Property(t => t.CPA_STATUS).HasColumnName("CPA_STATUS");
            this.Property(t => t.LCC_ID).HasColumnName("LCC_ID");
            this.Property(t => t.CPA_DATA_VENCIMENTO_ORIGINAL).HasColumnName("CPA_DATA_VENCIMENTO_ORIGINAL");
            this.Property(t => t.CPA_CONTA_CORRENTE).HasColumnName("CPA_CONTA_CORRENTE");
            this.Property(t => t.CPA_COFINS).HasColumnName("CPA_COFINS");
            this.Property(t => t.CPA_CSLL).HasColumnName("CPA_CSLL");
            this.Property(t => t.CPA_TAXA_BANCARIA).HasColumnName("CPA_TAXA_BANCARIA");
            this.Property(t => t.CPA_RECORRENTE).HasColumnName("CPA_RECORRENTE");
            this.Property(t => t.CPA_RECORRENTE_FINALIZADO).HasColumnName("CPA_RECORRENTE_FINALIZADO");
            this.Property(t => t.CPA_VINCULO_PARCELAS).HasColumnName("CPA_VINCULO_PARCELAS");
            this.Property(t => t.CPA_ENDIVIDAMENTO_CONTRATO).HasColumnName("CPA_ENDIVIDAMENTO_CONTRATO");
            this.Property(t => t.CPA_ENDIVIDAMENTO_DATA_CONTRATACAO).HasColumnName("CPA_ENDIVIDAMENTO_DATA_CONTRATACAO");
            this.Property(t => t.CPA_ENDIVIDAMENTO_DATA_VENCIMENTO).HasColumnName("CPA_ENDIVIDAMENTO_DATA_VENCIMENTO");
            this.Property(t => t.CPA_ENDIVIDAMENTO_VALOR_CONTRATADO).HasColumnName("CPA_ENDIVIDAMENTO_VALOR_CONTRATADO");
            this.Property(t => t.CPA_ENDIVIDAMENTO_TAXA).HasColumnName("CPA_ENDIVIDAMENTO_TAXA");
            this.Property(t => t.CPA_ENDIVIDAMENTO_GARANTIAS).HasColumnName("CPA_ENDIVIDAMENTO_GARANTIAS");

            // Relationships
            this.HasRequired(t => t.CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR)
                .WithMany(t => t.CP_CONTA_A_PAGAR_CPA)
                .HasForeignKey(d => d.CPA_CATEGORIA_PAGAMENTO);
            this.HasRequired(t => t.CP_TIPO_PAGAMENTO_TPG)
                .WithMany(t => t.CP_CONTA_A_PAGAR_CPA)
                .HasForeignKey(d => d.CPA_TIPO_PAGAMENTO);
            this.HasRequired(t => t.GE_CENTRO_CUSTO_RECEITAS_CCR)
                .WithMany(t => t.CP_CONTA_A_PAGAR_CPA)
                .HasForeignKey(d => d.CPA_CENTRO_CUSTO_RECEITA);
            this.HasRequired(t => t.GE_EMPRESA_EMP)
                .WithMany(t => t.CP_CONTA_A_PAGAR_CPA)
                .HasForeignKey(d => d.CPA_EMPRESA);
            this.HasRequired(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .WithMany(t => t.CP_CONTA_A_PAGAR_CPA)
                .HasForeignKey(d => d.CPA_FORNECEDOR);
            this.HasRequired(t => t.GE_PROJETO_PJO)
                .WithMany(t => t.CP_CONTA_A_PAGAR_CPA)
                .HasForeignKey(d => d.CPA_PROJETO);
            this.HasOptional(t => t.GE_USUARIO_USU)
                .WithMany(t => t.CP_CONTA_A_PAGAR_CPA)
                .HasForeignKey(d => d.CPA_LIBERADO_PAGAMENTO_USU_ID);
            this.HasOptional(t => t.GE_CONTA_CORRENTE_CTC)
                .WithMany(t => t.CP_CONTA_A_PAGAR_CPA)
                .HasForeignKey(d => d.CPA_CONTA_CORRENTE);
            this.HasOptional(t => t.GE_LANCAMENTOS_CONTA_CORRENTE_LCC)
                .WithMany(t => t.CP_CONTA_A_PAGAR_CPA)
                .HasForeignKey(d => d.LCC_ID);

        }
    }
}
