using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_PARCEIRO_NEGOCIO_PNEMap : EntityTypeConfiguration<GE_PARCEIRO_NEGOCIO_PNE>
    {
        public GE_PARCEIRO_NEGOCIO_PNEMap()
        {
            // Primary Key
            this.HasKey(t => t.PNE_ID);

            // Properties
            this.Property(t => t.PNE_RAZAO_SOCIAL)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.PNE_NOME_FANTASIA)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.PNE_IE)
                .HasMaxLength(20);

            this.Property(t => t.PNE_IM)
                .HasMaxLength(30);

            this.Property(t => t.PNE_IE_SUBSTITUICAO_TRIBUTARIA)
                .HasMaxLength(20);

            this.Property(t => t.PNE_INSS)
                .HasMaxLength(30);

            this.Property(t => t.PNE_SUFRAMA)
                .HasMaxLength(30);

            this.Property(t => t.PNE_TELEFONE)
                .HasMaxLength(30);

            this.Property(t => t.PNE_CELULAR)
                .HasMaxLength(30);

            this.Property(t => t.PNE_EMAIL)
                .HasMaxLength(150);

            this.Property(t => t.PNE_URL)
                .HasMaxLength(150);

            this.Property(t => t.PNE_NUM_BANCO)
                .HasMaxLength(5);

            this.Property(t => t.PNE_NOME_BANCO)
                .HasMaxLength(30);

            this.Property(t => t.PNE_AGENCIA)
                .HasMaxLength(20);

            this.Property(t => t.PNE_AGENCIA_DIGITO)
                .HasMaxLength(2);

            this.Property(t => t.PNE_CONTA_CORRENTE)
                .HasMaxLength(30);

            this.Property(t => t.PNE_CONTA_CORRENTE_DIGITO)
                .HasMaxLength(2);

            this.Property(t => t.CardCode)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("GE_PARCEIRO_NEGOCIO_PNE");
            this.Property(t => t.PNE_ID).HasColumnName("PNE_ID");
            this.Property(t => t.TPN_ID).HasColumnName("TPN_ID");
            this.Property(t => t.GPN_ID).HasColumnName("GPN_ID");
            this.Property(t => t.PNE_TIPO_CONTRIBUINTE).HasColumnName("PNE_TIPO_CONTRIBUINTE");
            this.Property(t => t.PNE_CATEGORIA_PARCEIRO).HasColumnName("PNE_CATEGORIA_PARCEIRO");
            this.Property(t => t.PNE_RAZAO_SOCIAL).HasColumnName("PNE_RAZAO_SOCIAL");
            this.Property(t => t.PNE_NOME_FANTASIA).HasColumnName("PNE_NOME_FANTASIA");
            this.Property(t => t.CNA_ID).HasColumnName("CNA_ID");
            this.Property(t => t.PNE_CPNJ_CPF).HasColumnName("PNE_CPNJ_CPF");
            this.Property(t => t.PNE_IE).HasColumnName("PNE_IE");
            this.Property(t => t.PNE_IM).HasColumnName("PNE_IM");
            this.Property(t => t.PNE_IE_SUBSTITUICAO_TRIBUTARIA).HasColumnName("PNE_IE_SUBSTITUICAO_TRIBUTARIA");
            this.Property(t => t.PAI_ID).HasColumnName("PAI_ID");
            this.Property(t => t.PNE_INSS).HasColumnName("PNE_INSS");
            this.Property(t => t.PNE_SUFRAMA).HasColumnName("PNE_SUFRAMA");
            this.Property(t => t.PNE_SIMPLES).HasColumnName("PNE_SIMPLES");
            this.Property(t => t.PNE_ASSOCIADO_PNE_ID).HasColumnName("PNE_ASSOCIADO_PNE_ID");
            this.Property(t => t.PNE_DATA_ULTIMA_ATUALIZACAO).HasColumnName("PNE_DATA_ULTIMA_ATUALIZACAO");
            this.Property(t => t.PNE_BLOQUEIO).HasColumnName("PNE_BLOQUEIO");
            this.Property(t => t.PNE_DATA_BLOQUEIO).HasColumnName("PNE_DATA_BLOQUEIO");
            this.Property(t => t.PNE_USUARIO_BLOQUEIO).HasColumnName("PNE_USUARIO_BLOQUEIO");
            this.Property(t => t.VEN_ID).HasColumnName("VEN_ID");
            this.Property(t => t.CPA_ID).HasColumnName("CPA_ID");
            this.Property(t => t.PNE_OBS).HasColumnName("PNE_OBS");
            this.Property(t => t.PNE_TELEFONE).HasColumnName("PNE_TELEFONE");
            this.Property(t => t.PNE_CELULAR).HasColumnName("PNE_CELULAR");
            this.Property(t => t.PNE_EMAIL).HasColumnName("PNE_EMAIL");
            this.Property(t => t.PNE_URL).HasColumnName("PNE_URL");
            this.Property(t => t.PNE_LIMITE_DESCONTO).HasColumnName("PNE_LIMITE_DESCONTO");
            this.Property(t => t.PNE_LIMITE_CREDITO).HasColumnName("PNE_LIMITE_CREDITO");
            this.Property(t => t.PNE_NUM_BANCO).HasColumnName("PNE_NUM_BANCO");
            this.Property(t => t.PNE_NOME_BANCO).HasColumnName("PNE_NOME_BANCO");
            this.Property(t => t.PNE_AGENCIA).HasColumnName("PNE_AGENCIA");
            this.Property(t => t.PNE_AGENCIA_DIGITO).HasColumnName("PNE_AGENCIA_DIGITO");
            this.Property(t => t.PNE_CONTA_CORRENTE).HasColumnName("PNE_CONTA_CORRENTE");
            this.Property(t => t.PNE_CONTA_CORRENTE_DIGITO).HasColumnName("PNE_CONTA_CORRENTE_DIGITO");
            this.Property(t => t.CardCode).HasColumnName("CardCode");
            this.Property(t => t.TPV_ID_NF_VENDA).HasColumnName("TPV_ID_NF_VENDA");
            this.Property(t => t.PIM_ID_NF_VENDA).HasColumnName("PIM_ID_NF_VENDA");
            this.Property(t => t.TPV_ID_NF_SERVICO).HasColumnName("TPV_ID_NF_SERVICO");
            this.Property(t => t.PIM_ID_NF_SERVICO).HasColumnName("PIM_ID_NF_SERVICO");
            this.Property(t => t.TPV_ID_NF_LICENCA).HasColumnName("TPV_ID_NF_LICENCA");
            this.Property(t => t.PIM_ID_NF_LICENCA).HasColumnName("PIM_ID_NF_LICENCA");
            this.Property(t => t.TPV_ID_NF_FATURA_LOCACAO).HasColumnName("TPV_ID_NF_FATURA_LOCACAO");
            this.Property(t => t.PIM_ID_NF_FATURA_LOCACAO).HasColumnName("PIM_ID_NF_FATURA_LOCACAO");
            this.Property(t => t.ISS_SERVICO).HasColumnName("ISS_SERVICO");
            this.Property(t => t.ISS_LICENCA).HasColumnName("ISS_LICENCA");

            // Relationships
            this.HasOptional(t => t.FA_PARAMETROS_IMPOSTOS_PIM)
                .WithMany(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .HasForeignKey(d => d.PIM_ID_NF_FATURA_LOCACAO);
            this.HasOptional(t => t.FA_PARAMETROS_IMPOSTOS_PIM1)
                .WithMany(t => t.GE_PARCEIRO_NEGOCIO_PNE1)
                .HasForeignKey(d => d.PIM_ID_NF_LICENCA);
            this.HasOptional(t => t.FA_PARAMETROS_IMPOSTOS_PIM2)
                .WithMany(t => t.GE_PARCEIRO_NEGOCIO_PNE2)
                .HasForeignKey(d => d.PIM_ID_NF_SERVICO);
            this.HasOptional(t => t.FA_PARAMETROS_IMPOSTOS_PIM3)
                .WithMany(t => t.GE_PARCEIRO_NEGOCIO_PNE3)
                .HasForeignKey(d => d.PIM_ID_NF_VENDA);
            this.HasOptional(t => t.PD_TIPO_VENDA_TPV)
                .WithMany(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .HasForeignKey(d => d.TPV_ID_NF_FATURA_LOCACAO);
            this.HasOptional(t => t.PD_TIPO_VENDA_TPV1)
                .WithMany(t => t.GE_PARCEIRO_NEGOCIO_PNE1)
                .HasForeignKey(d => d.TPV_ID_NF_LICENCA);
            this.HasOptional(t => t.PD_TIPO_VENDA_TPV2)
                .WithMany(t => t.GE_PARCEIRO_NEGOCIO_PNE2)
                .HasForeignKey(d => d.TPV_ID_NF_SERVICO);
            this.HasOptional(t => t.PD_TIPO_VENDA_TPV3)
                .WithMany(t => t.GE_PARCEIRO_NEGOCIO_PNE3)
                .HasForeignKey(d => d.TPV_ID_NF_VENDA);

        }
    }
}
