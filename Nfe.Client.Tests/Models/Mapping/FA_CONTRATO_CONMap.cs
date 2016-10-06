using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_CONTRATO_CONMap : EntityTypeConfiguration<FA_CONTRATO_CON>
    {
        public FA_CONTRATO_CONMap()
        {
            // Primary Key
            this.HasKey(t => t.CON_ID);

            // Properties
            this.Property(t => t.CON_NUMERO)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CON_NUMERO_CLIENTE)
                .HasMaxLength(30);

            this.Property(t => t.CON_CAMINHO_ARQUIVO_SERVIDOR)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("FA_CONTRATO_CON");
            this.Property(t => t.CON_ID).HasColumnName("CON_ID");
            this.Property(t => t.CON_NUMERO).HasColumnName("CON_NUMERO");
            this.Property(t => t.CON_NUMERO_CLIENTE).HasColumnName("CON_NUMERO_CLIENTE");
            this.Property(t => t.CON_VALOR).HasColumnName("CON_VALOR");
            this.Property(t => t.CON_DATA_INICIO).HasColumnName("CON_DATA_INICIO");
            this.Property(t => t.CON_DURACAO).HasColumnName("CON_DURACAO");
            this.Property(t => t.CON_DATA_ULTIMA_RENOVACAO).HasColumnName("CON_DATA_ULTIMA_RENOVACAO");
            this.Property(t => t.CON_DATA_ULTIMO_VENCIMENTO).HasColumnName("CON_DATA_ULTIMO_VENCIMENTO");
            this.Property(t => t.CON_DATA_ULTIMA_EMISSAO).HasColumnName("CON_DATA_ULTIMA_EMISSAO");
            this.Property(t => t.CON_BASE_INTERVALO).HasColumnName("CON_BASE_INTERVALO");
            this.Property(t => t.CON_DIA_VENCIMENTO).HasColumnName("CON_DIA_VENCIMENTO");
            this.Property(t => t.CON_INTERVALO_GERAR_BOLETO_DIAS).HasColumnName("CON_INTERVALO_GERAR_BOLETO_DIAS");
            this.Property(t => t.CON_INTERVALO_GERAR_BOLETO_MESES).HasColumnName("CON_INTERVALO_GERAR_BOLETO_MESES");
            this.Property(t => t.CON_MESES_REJUSTAR).HasColumnName("CON_MESES_REJUSTAR");
            this.Property(t => t.CON_OBSERVACAO).HasColumnName("CON_OBSERVACAO");
            this.Property(t => t.CON_OBSERVACAO_NOTA).HasColumnName("CON_OBSERVACAO_NOTA");
            this.Property(t => t.CON_CAMINHO_ARQUIVO_SERVIDOR).HasColumnName("CON_CAMINHO_ARQUIVO_SERVIDOR");
            this.Property(t => t.CON_STATUS).HasColumnName("CON_STATUS");
            this.Property(t => t.CON_CRIACAO_USU_ID).HasColumnName("CON_CRIACAO_USU_ID");
            this.Property(t => t.CON_CRIACAO_DATA).HasColumnName("CON_CRIACAO_DATA");
            this.Property(t => t.CON_LIBERADO_REMESSA_ATENDIMENTO_USU_ID).HasColumnName("CON_LIBERADO_REMESSA_ATENDIMENTO_USU_ID");
            this.Property(t => t.CON_LIBERADO_REMESSA_ATENDIMENTO_DATA).HasColumnName("CON_LIBERADO_REMESSA_ATENDIMENTO_DATA");
            this.Property(t => t.CON_LIBERADO_FATURAMENTO_USU_ID).HasColumnName("CON_LIBERADO_FATURAMENTO_USU_ID");
            this.Property(t => t.CON_LIBERADO_FATURAMENTO_DATA).HasColumnName("CON_LIBERADO_FATURAMENTO_DATA");
            this.Property(t => t.CON_CANCELADO_USU_ID).HasColumnName("CON_CANCELADO_USU_ID");
            this.Property(t => t.CON_CANCELADO_DATA).HasColumnName("CON_CANCELADO_DATA");
            this.Property(t => t.CON_CANCELADO_MOTIVO).HasColumnName("CON_CANCELADO_MOTIVO");
            this.Property(t => t.PNE_ID).HasColumnName("PNE_ID");
            this.Property(t => t.TCO_ID).HasColumnName("TCO_ID");
            this.Property(t => t.IND_ID).HasColumnName("IND_ID");
            this.Property(t => t.CTC_ID).HasColumnName("CTC_ID");
            this.Property(t => t.EMP_ID).HasColumnName("EMP_ID");
            this.Property(t => t.CON_MESES).HasColumnName("CON_MESES");
            this.Property(t => t.CON_DIAS).HasColumnName("CON_DIAS");

            // Relationships
            this.HasRequired(t => t.FA_CONTRATO_INDICE_CORRECAO_IND)
                .WithMany(t => t.FA_CONTRATO_CON)
                .HasForeignKey(d => d.IND_ID);
            this.HasRequired(t => t.FA_CONTRATO_TIPO_TCO)
                .WithMany(t => t.FA_CONTRATO_CON)
                .HasForeignKey(d => d.TCO_ID);
            this.HasRequired(t => t.GE_CONTA_CORRENTE_CTC)
                .WithMany(t => t.FA_CONTRATO_CON)
                .HasForeignKey(d => d.CTC_ID);
            this.HasRequired(t => t.GE_EMPRESA_EMP)
                .WithMany(t => t.FA_CONTRATO_CON)
                .HasForeignKey(d => d.EMP_ID);
            this.HasRequired(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .WithMany(t => t.FA_CONTRATO_CON)
                .HasForeignKey(d => d.PNE_ID);

        }
    }
}
