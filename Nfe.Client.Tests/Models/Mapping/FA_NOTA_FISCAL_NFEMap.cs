using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_NOTA_FISCAL_NFEMap : EntityTypeConfiguration<FA_NOTA_FISCAL_NFE>
    {
        public FA_NOTA_FISCAL_NFEMap()
        {
            // Primary Key
            this.HasKey(t => t.NFE_ID);

            // Properties
            this.Property(t => t.NFE_ARQUIVO_XML)
                .HasMaxLength(255);

            this.Property(t => t.NFE_DI_NUMERO)
                .HasMaxLength(30);

            this.Property(t => t.NFE_LOCAL_DESEMBARQUE)
                .HasMaxLength(50);

            this.Property(t => t.NFE_UF_DESEMBARQUE)
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("FA_NOTA_FISCAL_NFE");
            this.Property(t => t.NFE_ID).HasColumnName("NFE_ID");
            this.Property(t => t.PDV_ID).HasColumnName("PDV_ID");
            this.Property(t => t.TTR_ID).HasColumnName("TTR_ID");
            this.Property(t => t.TRA_ID).HasColumnName("TRA_ID");
            this.Property(t => t.NFE_NUMERO).HasColumnName("NFE_NUMERO");
            this.Property(t => t.NFE_VALOR_FRETE).HasColumnName("NFE_VALOR_FRETE");
            this.Property(t => t.NFE_VALOR_DESPESAS).HasColumnName("NFE_VALOR_DESPESAS");
            this.Property(t => t.TVO_ID).HasColumnName("TVO_ID");
            this.Property(t => t.NFE_QTD_VOLUMES).HasColumnName("NFE_QTD_VOLUMES");
            this.Property(t => t.NFE_PESO_LIQUIDO).HasColumnName("NFE_PESO_LIQUIDO");
            this.Property(t => t.NFE_PESO_BRUTO).HasColumnName("NFE_PESO_BRUTO");
            this.Property(t => t.NFE_OBSERVACAO).HasColumnName("NFE_OBSERVACAO");
            this.Property(t => t.NFE_VALOR_TOTAL).HasColumnName("NFE_VALOR_TOTAL");
            this.Property(t => t.NFE_VALOR_RETENCOES).HasColumnName("NFE_VALOR_RETENCOES");
            this.Property(t => t.NFE_VALOR_LIQUIDO).HasColumnName("NFE_VALOR_LIQUIDO");
            this.Property(t => t.NFE_BC_ICMS).HasColumnName("NFE_BC_ICMS");
            this.Property(t => t.NFE_VALOR_ICMS).HasColumnName("NFE_VALOR_ICMS");
            this.Property(t => t.NFE_BC_ICMS_ST).HasColumnName("NFE_BC_ICMS_ST");
            this.Property(t => t.NFE_VALOR_ICMS_ST).HasColumnName("NFE_VALOR_ICMS_ST");
            this.Property(t => t.NFE_VALOR_TOTAL_PRODUTOS).HasColumnName("NFE_VALOR_TOTAL_PRODUTOS");
            this.Property(t => t.NFE_VALOR_IPI).HasColumnName("NFE_VALOR_IPI");
            this.Property(t => t.NFE_STATUS).HasColumnName("NFE_STATUS");
            this.Property(t => t.NFE_ARQUIVO_XML).HasColumnName("NFE_ARQUIVO_XML");
            this.Property(t => t.NFE_MODALIDADE_FRETE).HasColumnName("NFE_MODALIDADE_FRETE");
            this.Property(t => t.NFE_DI_NUMERO).HasColumnName("NFE_DI_NUMERO");
            this.Property(t => t.NFE_VALOR_II).HasColumnName("NFE_VALOR_II");
            this.Property(t => t.NFE_DATA_REGISTRO).HasColumnName("NFE_DATA_REGISTRO");
            this.Property(t => t.NFE_LOCAL_DESEMBARQUE).HasColumnName("NFE_LOCAL_DESEMBARQUE");
            this.Property(t => t.NFE_UF_DESEMBARQUE).HasColumnName("NFE_UF_DESEMBARQUE");
            this.Property(t => t.NFE_TP_VIA_TRANSP).HasColumnName("NFE_TP_VIA_TRANSP");
            this.Property(t => t.NFE_VALOR_AFRMM).HasColumnName("NFE_VALOR_AFRMM");
            this.Property(t => t.NFE_DATA_EMISSAO).HasColumnName("NFE_DATA_EMISSAO");
            this.Property(t => t.NFE_CANCELADO_USU_ID).HasColumnName("NFE_CANCELADO_USU_ID");
            this.Property(t => t.NFE_CANCELADO_DATA).HasColumnName("NFE_CANCELADO_DATA");
            this.Property(t => t.NFE_CANCELADO_MOTIVO).HasColumnName("NFE_CANCELADO_MOTIVO");
            this.Property(t => t.NFE_ALTERACAO_OBS_USU_ID).HasColumnName("NFE_ALTERACAO_OBS_USU_ID");
            this.Property(t => t.NFE_ALTERACAO_OBS_DATA).HasColumnName("NFE_ALTERACAO_OBS_DATA");
            this.Property(t => t.NFE_VALOR_RETENCOES_PCC).HasColumnName("NFE_VALOR_RETENCOES_PCC");
            this.Property(t => t.NFE_VALOR_RETENCOES_IRRF).HasColumnName("NFE_VALOR_RETENCOES_IRRF");
            this.Property(t => t.NFE_VALOR_RETENCOES_INSS).HasColumnName("NFE_VALOR_RETENCOES_INSS");

            // Relationships
            this.HasRequired(t => t.PD_PEDIDO_VENDA_PDV)
                .WithMany(t => t.FA_NOTA_FISCAL_NFE)
                .HasForeignKey(d => d.PDV_ID);
            this.HasOptional(t => t.FA_TRANSPORTADORA_TRA)
                .WithMany(t => t.FA_NOTA_FISCAL_NFE)
                .HasForeignKey(d => d.TRA_ID);
            this.HasRequired(t => t.FA_TIPO_TRANSPORTE_TTR)
                .WithMany(t => t.FA_NOTA_FISCAL_NFE)
                .HasForeignKey(d => d.TTR_ID);
            this.HasOptional(t => t.FA_TIPO_VOLUME_TVO)
                .WithMany(t => t.FA_NOTA_FISCAL_NFE)
                .HasForeignKey(d => d.TVO_ID);

        }
    }
}
