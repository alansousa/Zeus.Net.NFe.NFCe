using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_EMPRESA_EMPMap : EntityTypeConfiguration<GE_EMPRESA_EMP>
    {
        public GE_EMPRESA_EMPMap()
        {
            // Primary Key
            this.HasKey(t => t.EMP_ID);

            // Properties
            this.Property(t => t.EMP_NOME_FANTASIA)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.EMP_UF)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.EMP_IBG_CODIGO_CIDADE)
                .HasMaxLength(7);

            this.Property(t => t.EMP_CERTIFICADO_NFE_SENHA)
                .HasMaxLength(30);

            this.Property(t => t.EMP_RAZAO_SOCIAL)
                .HasMaxLength(150);

            this.Property(t => t.EMP_TELEFONE)
                .HasMaxLength(30);

            this.Property(t => t.EMP_CELULAR)
                .HasMaxLength(30);

            this.Property(t => t.EMP_EMAIL)
                .HasMaxLength(150);

            this.Property(t => t.EMP_URL)
                .HasMaxLength(150);

            this.Property(t => t.EMP_CPNJ_CPF)
                .HasMaxLength(14);

            this.Property(t => t.EMP_IE)
                .HasMaxLength(20);

            this.Property(t => t.EMP_IE_SUBSTITUICAO_TRIBUTARIA)
                .HasMaxLength(20);

            this.Property(t => t.EMP_IM)
                .HasMaxLength(30);

            this.Property(t => t.EMP_INSS)
                .HasMaxLength(30);

            this.Property(t => t.EMP_SUFRAMA)
                .HasMaxLength(30);

            this.Property(t => t.EMP_NOME_CURTO)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("GE_EMPRESA_EMP");
            this.Property(t => t.EMP_ID).HasColumnName("EMP_ID");
            this.Property(t => t.EMP_NOME_FANTASIA).HasColumnName("EMP_NOME_FANTASIA");
            this.Property(t => t.EMP_UF).HasColumnName("EMP_UF");
            this.Property(t => t.EMP_NUM_NF_VENDA).HasColumnName("EMP_NUM_NF_VENDA");
            this.Property(t => t.EMP_NUM_NF_SERVICO).HasColumnName("EMP_NUM_NF_SERVICO");
            this.Property(t => t.EMP_NUM_NF_FATURA_LOCACAO).HasColumnName("EMP_NUM_NF_FATURA_LOCACAO");
            this.Property(t => t.EMP_IBG_CODIGO_CIDADE).HasColumnName("EMP_IBG_CODIGO_CIDADE");
            this.Property(t => t.EMP_CERTIFICADO_NFE).HasColumnName("EMP_CERTIFICADO_NFE");
            this.Property(t => t.EMP_CERTIFICADO_NFE_SENHA).HasColumnName("EMP_CERTIFICADO_NFE_SENHA");
            this.Property(t => t.EMP_DIRETORIO_XML).HasColumnName("EMP_DIRETORIO_XML");
            this.Property(t => t.EMP_DIRETORIO_XML_TEMP).HasColumnName("EMP_DIRETORIO_XML_TEMP");
            this.Property(t => t.EMP_RAZAO_SOCIAL).HasColumnName("EMP_RAZAO_SOCIAL");
            this.Property(t => t.EMP_TELEFONE).HasColumnName("EMP_TELEFONE");
            this.Property(t => t.EMP_CELULAR).HasColumnName("EMP_CELULAR");
            this.Property(t => t.EMP_EMAIL).HasColumnName("EMP_EMAIL");
            this.Property(t => t.EMP_URL).HasColumnName("EMP_URL");
            this.Property(t => t.EMP_CPNJ_CPF).HasColumnName("EMP_CPNJ_CPF");
            this.Property(t => t.EMP_IE).HasColumnName("EMP_IE");
            this.Property(t => t.EMP_IE_SUBSTITUICAO_TRIBUTARIA).HasColumnName("EMP_IE_SUBSTITUICAO_TRIBUTARIA");
            this.Property(t => t.EMP_IM).HasColumnName("EMP_IM");
            this.Property(t => t.EMP_INSS).HasColumnName("EMP_INSS");
            this.Property(t => t.EMP_SUFRAMA).HasColumnName("EMP_SUFRAMA");
            this.Property(t => t.EMP_SIMPLES).HasColumnName("EMP_SIMPLES");
            this.Property(t => t.EMP_REGIME_TRIBUTARIO).HasColumnName("EMP_REGIME_TRIBUTARIO");
            this.Property(t => t.CNA_ID).HasColumnName("CNA_ID");
            this.Property(t => t.EMP_NOME_CURTO).HasColumnName("EMP_NOME_CURTO");

            // Relationships
            this.HasOptional(t => t.GE_CNAE_CNA)
                .WithMany(t => t.GE_EMPRESA_EMP)
                .HasForeignKey(d => d.CNA_ID);

        }
    }
}
