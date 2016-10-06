using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class CP_CONTA_A_RECEBER_CREMap : EntityTypeConfiguration<CP_CONTA_A_RECEBER_CRE>
    {
        public CP_CONTA_A_RECEBER_CREMap()
        {
            // Primary Key
            this.HasKey(t => t.CRE_ID);

            // Properties
            this.Property(t => t.CRE_TITULO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CRE_FATURA_NUMERO_NOTA)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CRE_FATURA_NUMERO_PARCELA)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.CRE_CODIGO_BARRAS_PAGAMENTO)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("CP_CONTA_A_RECEBER_CRE");
            this.Property(t => t.CRE_ID).HasColumnName("CRE_ID");
            this.Property(t => t.CRE_TITULO).HasColumnName("CRE_TITULO");
            this.Property(t => t.CRE_FATURA_NUMERO_NOTA).HasColumnName("CRE_FATURA_NUMERO_NOTA");
            this.Property(t => t.CRE_FATURA_NUMERO_PARCELA).HasColumnName("CRE_FATURA_NUMERO_PARCELA");
            this.Property(t => t.CRE_PARCELA_REFINANCIAMENTO).HasColumnName("CRE_PARCELA_REFINANCIAMENTO");
            this.Property(t => t.CRE_DATA_EMISSAO).HasColumnName("CRE_DATA_EMISSAO");
            this.Property(t => t.CRE_DATA_VENCIMENTO).HasColumnName("CRE_DATA_VENCIMENTO");
            this.Property(t => t.CRE_DATA_PAGAMENTO).HasColumnName("CRE_DATA_PAGAMENTO");
            this.Property(t => t.CRE_DATA_PREVISAO_PAGAMENTO).HasColumnName("CRE_DATA_PREVISAO_PAGAMENTO");
            this.Property(t => t.CRE_VALOR).HasColumnName("CRE_VALOR");
            this.Property(t => t.CRE_DESCONTO).HasColumnName("CRE_DESCONTO");
            this.Property(t => t.CRE_ACRESCIMO).HasColumnName("CRE_ACRESCIMO");
            this.Property(t => t.CRE_PIS).HasColumnName("CRE_PIS");
            this.Property(t => t.CRE_IR).HasColumnName("CRE_IR");
            this.Property(t => t.CRE_INSS).HasColumnName("CRE_INSS");
            this.Property(t => t.CRE_ISS).HasColumnName("CRE_ISS");
            this.Property(t => t.CRE_VALOR_TOTAL_LIQUIDO).HasColumnName("CRE_VALOR_TOTAL_LIQUIDO");
            this.Property(t => t.CRE_CODIGO_BARRAS_PAGAMENTO).HasColumnName("CRE_CODIGO_BARRAS_PAGAMENTO");
            this.Property(t => t.CRE_RECORRENTE).HasColumnName("CRE_RECORRENTE");
            this.Property(t => t.CRE_OBSERVACOES).HasColumnName("CRE_OBSERVACOES");
            this.Property(t => t.CRE_MOTIVO_BAIXA_MANUAL).HasColumnName("CRE_MOTIVO_BAIXA_MANUAL");
            this.Property(t => t.CRE_CLIENTE).HasColumnName("CRE_CLIENTE");
            this.Property(t => t.CRE_PROJETO).HasColumnName("CRE_PROJETO");
            this.Property(t => t.CRE_TIPO_DOCUMENTO).HasColumnName("CRE_TIPO_DOCUMENTO");
            this.Property(t => t.CRE_CENTRO_CUSTO_RECEITA).HasColumnName("CRE_CENTRO_CUSTO_RECEITA");
            this.Property(t => t.CRE_CATEGORIA_PAGAMENTO).HasColumnName("CRE_CATEGORIA_PAGAMENTO");
            this.Property(t => t.CRE_TIPO_PAGAMENTO).HasColumnName("CRE_TIPO_PAGAMENTO");
            this.Property(t => t.CRE_POSICAO_TITULO).HasColumnName("CRE_POSICAO_TITULO");
            this.Property(t => t.CRE_CONTA_CORRENTE).HasColumnName("CRE_CONTA_CORRENTE");
            this.Property(t => t.CRE_EMPRESA).HasColumnName("CRE_EMPRESA");
            this.Property(t => t.CRE_STATUS).HasColumnName("CRE_STATUS");
            this.Property(t => t.LCC_ID).HasColumnName("LCC_ID");
            this.Property(t => t.CRE_DATA_VENCIMENTO_ORIGINAL).HasColumnName("CRE_DATA_VENCIMENTO_ORIGINAL");
            this.Property(t => t.CRE_PENALIDADE).HasColumnName("CRE_PENALIDADE");
            this.Property(t => t.CRE_COFINS).HasColumnName("CRE_COFINS");
            this.Property(t => t.CRE_CSLL).HasColumnName("CRE_CSLL");
            this.Property(t => t.NFE_ID).HasColumnName("NFE_ID");

            // Relationships
            this.HasRequired(t => t.CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR)
                .WithMany(t => t.CP_CONTA_A_RECEBER_CRE)
                .HasForeignKey(d => d.CRE_CATEGORIA_PAGAMENTO);
            this.HasRequired(t => t.CP_TIPO_PAGAMENTO_TPG)
                .WithMany(t => t.CP_CONTA_A_RECEBER_CRE)
                .HasForeignKey(d => d.CRE_TIPO_PAGAMENTO);
            this.HasRequired(t => t.GE_CENTRO_CUSTO_RECEITAS_CCR)
                .WithMany(t => t.CP_CONTA_A_RECEBER_CRE)
                .HasForeignKey(d => d.CRE_CENTRO_CUSTO_RECEITA);
            this.HasOptional(t => t.GE_CONTA_CORRENTE_CTC)
                .WithMany(t => t.CP_CONTA_A_RECEBER_CRE)
                .HasForeignKey(d => d.CRE_CONTA_CORRENTE);
            this.HasRequired(t => t.GE_EMPRESA_EMP)
                .WithMany(t => t.CP_CONTA_A_RECEBER_CRE)
                .HasForeignKey(d => d.CRE_EMPRESA);
            this.HasRequired(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .WithMany(t => t.CP_CONTA_A_RECEBER_CRE)
                .HasForeignKey(d => d.CRE_CLIENTE);
            this.HasRequired(t => t.GE_POSICAO_TITULO_POT)
                .WithMany(t => t.CP_CONTA_A_RECEBER_CRE)
                .HasForeignKey(d => d.CRE_POSICAO_TITULO);
            this.HasRequired(t => t.GE_PROJETO_PJO)
                .WithMany(t => t.CP_CONTA_A_RECEBER_CRE)
                .HasForeignKey(d => d.CRE_PROJETO);
            this.HasRequired(t => t.GE_TIPO_DOCUMENTO_TDO)
                .WithMany(t => t.CP_CONTA_A_RECEBER_CRE)
                .HasForeignKey(d => d.CRE_TIPO_DOCUMENTO);
            this.HasOptional(t => t.GE_LANCAMENTOS_CONTA_CORRENTE_LCC)
                .WithMany(t => t.CP_CONTA_A_RECEBER_CRE)
                .HasForeignKey(d => d.LCC_ID);

        }
    }
}
