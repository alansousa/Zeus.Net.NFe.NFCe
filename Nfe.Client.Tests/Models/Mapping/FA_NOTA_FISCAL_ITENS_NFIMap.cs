using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_NOTA_FISCAL_ITENS_NFIMap : EntityTypeConfiguration<FA_NOTA_FISCAL_ITENS_NFI>
    {
        public FA_NOTA_FISCAL_ITENS_NFIMap()
        {
            // Primary Key
            this.HasKey(t => t.NFI_ID);

            // Properties
            this.Property(t => t.NFI_PRODUTO_DESCRICAO)
                .HasMaxLength(255);

            this.Property(t => t.NFI_CST_ICMS)
                .HasMaxLength(3);

            this.Property(t => t.NFI_CST_IPI)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("FA_NOTA_FISCAL_ITENS_NFI");
            this.Property(t => t.NFI_ID).HasColumnName("NFI_ID");
            this.Property(t => t.NFE_ID).HasColumnName("NFE_ID");
            this.Property(t => t.PIT_ID).HasColumnName("PIT_ID");
            this.Property(t => t.NFI_PIS_ALIQUOTA).HasColumnName("NFI_PIS_ALIQUOTA");
            this.Property(t => t.NFI_PIS_VALOR).HasColumnName("NFI_PIS_VALOR");
            this.Property(t => t.NFI_COFINS_ALIQUOTA).HasColumnName("NFI_COFINS_ALIQUOTA");
            this.Property(t => t.NFI_COFINS_VALOR).HasColumnName("NFI_COFINS_VALOR");
            this.Property(t => t.NFI_CSLL_ALIQUOTA).HasColumnName("NFI_CSLL_ALIQUOTA");
            this.Property(t => t.NFI_CSLL_VALOR).HasColumnName("NFI_CSLL_VALOR");
            this.Property(t => t.NFI_IRRF_ALIQUOTA).HasColumnName("NFI_IRRF_ALIQUOTA");
            this.Property(t => t.NFI_IRRF_VALOR).HasColumnName("NFI_IRRF_VALOR");
            this.Property(t => t.NFI_INSS_ALIQUOTA).HasColumnName("NFI_INSS_ALIQUOTA");
            this.Property(t => t.NFI_INSS_VALOR).HasColumnName("NFI_INSS_VALOR");
            this.Property(t => t.NFI_IPI_ALIQUOTA).HasColumnName("NFI_IPI_ALIQUOTA");
            this.Property(t => t.NFI_IPI_VALOR).HasColumnName("NFI_IPI_VALOR");
            this.Property(t => t.NFI_ICMS_ALIQUOTA).HasColumnName("NFI_ICMS_ALIQUOTA");
            this.Property(t => t.NFI_ICMS_VALOR).HasColumnName("NFI_ICMS_VALOR");
            this.Property(t => t.NFI_ISS_ALIQUOTA).HasColumnName("NFI_ISS_ALIQUOTA");
            this.Property(t => t.NFI_ISS_VALOR).HasColumnName("NFI_ISS_VALOR");
            this.Property(t => t.NFI_PRODUTO_DESCRICAO).HasColumnName("NFI_PRODUTO_DESCRICAO");
            this.Property(t => t.NFI_PRODUTO_QTDE).HasColumnName("NFI_PRODUTO_QTDE");
            this.Property(t => t.NFI_PRODUTO_PRECO_UNITARIO).HasColumnName("NFI_PRODUTO_PRECO_UNITARIO");
            this.Property(t => t.NFI_PRODUTO_PRECO_TOTAL).HasColumnName("NFI_PRODUTO_PRECO_TOTAL");
            this.Property(t => t.NFI_ICMS_ST_ALIQUOTA).HasColumnName("NFI_ICMS_ST_ALIQUOTA");
            this.Property(t => t.NFI_ICMS_ST_VALOR).HasColumnName("NFI_ICMS_ST_VALOR");
            this.Property(t => t.NFI_BC_ICMS).HasColumnName("NFI_BC_ICMS");
            this.Property(t => t.NFI_BC_ICMS_ST).HasColumnName("NFI_BC_ICMS_ST");
            this.Property(t => t.NFI_CST_ICMS).HasColumnName("NFI_CST_ICMS");
            this.Property(t => t.NFI_CST_IPI).HasColumnName("NFI_CST_IPI");
            this.Property(t => t.NFI_DIFAL_PORCENTAGEM).HasColumnName("NFI_DIFAL_PORCENTAGEM");
            this.Property(t => t.NFI_BC).HasColumnName("NFI_BC");
            this.Property(t => t.NFI_II_ALIQUOTA).HasColumnName("NFI_II_ALIQUOTA");
            this.Property(t => t.NFI_II_VALOR).HasColumnName("NFI_II_VALOR");
            this.Property(t => t.NFI_NUMERO_SEQ_ADIC).HasColumnName("NFI_NUMERO_SEQ_ADIC");
            this.Property(t => t.NFI_PIS_VALOR_RETENCAO).HasColumnName("NFI_PIS_VALOR_RETENCAO");
            this.Property(t => t.NFI_COFINS_VALOR_RETENCAO).HasColumnName("NFI_COFINS_VALOR_RETENCAO");
            this.Property(t => t.NFI_CSLL_VALOR_RETENCAO).HasColumnName("NFI_CSLL_VALOR_RETENCAO");
            this.Property(t => t.NFI_IRRF_VALOR_RETENCAO).HasColumnName("NFI_IRRF_VALOR_RETENCAO");
            this.Property(t => t.NFI_INSS_VALOR_RETENCAO).HasColumnName("NFI_INSS_VALOR_RETENCAO");
            this.Property(t => t.NFI_FRETE).HasColumnName("NFI_FRETE");
            this.Property(t => t.NFI_OUTRAS_DESPESAS).HasColumnName("NFI_OUTRAS_DESPESAS");
            this.Property(t => t.NFI_ISS_RETENCAO_ALIQUOTA).HasColumnName("NFI_ISS_RETENCAO_ALIQUOTA");
            this.Property(t => t.NFI_ISS_RETENCAO_VALOR).HasColumnName("NFI_ISS_RETENCAO_VALOR");

            // Relationships
            this.HasRequired(t => t.FA_NOTA_FISCAL_NFE)
                .WithMany(t => t.FA_NOTA_FISCAL_ITENS_NFI)
                .HasForeignKey(d => d.NFE_ID);

        }
    }
}
