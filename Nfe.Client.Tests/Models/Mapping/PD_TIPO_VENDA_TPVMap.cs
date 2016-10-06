using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class PD_TIPO_VENDA_TPVMap : EntityTypeConfiguration<PD_TIPO_VENDA_TPV>
    {
        public PD_TIPO_VENDA_TPVMap()
        {
            // Primary Key
            this.HasKey(t => t.TPV_ID);

            // Properties
            this.Property(t => t.TPV_NOME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TPV_ENTRADA_SAIDA)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TPV_CFOP_SAIDA_DENTRO_ESTADO)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.TPV_CFOP_SAIDA_FORA_ESTADO)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.TPV_CFOP_ENTRADA_DENTRO_ESTADO)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.TPV_CFOP_ENTRADA_FORA_ESTADO)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.TPV_CFOP_SAIDA_DENTRO_ESTADO_ST)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.TPV_CFOP_SAIDA_FORA_ESTADO_ST)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.TPV_CFOP_ENTRADA_DENTRO_ESTADO_ST)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.TPV_CFOP_ENTRADA_FORA_ESTADO_ST)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.TPV_CFOP_IMPORTACAO)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.TPV_CFOP_EXPORTACAO)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.TPV_NOME_NF)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PD_TIPO_VENDA_TPV");
            this.Property(t => t.TPV_ID).HasColumnName("TPV_ID");
            this.Property(t => t.TPV_NOME).HasColumnName("TPV_NOME");
            this.Property(t => t.TPV_MOVIMENTA_ESTOQUE).HasColumnName("TPV_MOVIMENTA_ESTOQUE");
            this.Property(t => t.TPV_ENTRADA_SAIDA).HasColumnName("TPV_ENTRADA_SAIDA");
            this.Property(t => t.TPV_IMPORTACAO).HasColumnName("TPV_IMPORTACAO");
            this.Property(t => t.TPV_EXPORTACAO).HasColumnName("TPV_EXPORTACAO");
            this.Property(t => t.TPV_CFOP_SAIDA_DENTRO_ESTADO).HasColumnName("TPV_CFOP_SAIDA_DENTRO_ESTADO");
            this.Property(t => t.TPV_CFOP_SAIDA_FORA_ESTADO).HasColumnName("TPV_CFOP_SAIDA_FORA_ESTADO");
            this.Property(t => t.TPV_CFOP_ENTRADA_DENTRO_ESTADO).HasColumnName("TPV_CFOP_ENTRADA_DENTRO_ESTADO");
            this.Property(t => t.TPV_CFOP_ENTRADA_FORA_ESTADO).HasColumnName("TPV_CFOP_ENTRADA_FORA_ESTADO");
            this.Property(t => t.TPV_CFOP_SAIDA_DENTRO_ESTADO_ST).HasColumnName("TPV_CFOP_SAIDA_DENTRO_ESTADO_ST");
            this.Property(t => t.TPV_CFOP_SAIDA_FORA_ESTADO_ST).HasColumnName("TPV_CFOP_SAIDA_FORA_ESTADO_ST");
            this.Property(t => t.TPV_CFOP_ENTRADA_DENTRO_ESTADO_ST).HasColumnName("TPV_CFOP_ENTRADA_DENTRO_ESTADO_ST");
            this.Property(t => t.TPV_CFOP_ENTRADA_FORA_ESTADO_ST).HasColumnName("TPV_CFOP_ENTRADA_FORA_ESTADO_ST");
            this.Property(t => t.TPV_CFOP_IMPORTACAO).HasColumnName("TPV_CFOP_IMPORTACAO");
            this.Property(t => t.TPV_CFOP_EXPORTACAO).HasColumnName("TPV_CFOP_EXPORTACAO");
            this.Property(t => t.TIM_ID).HasColumnName("TIM_ID");
            this.Property(t => t.TPV_OBSERVACAO_NOTA_FISCAL).HasColumnName("TPV_OBSERVACAO_NOTA_FISCAL");
            this.Property(t => t.TPV_SIMPLES_REMESSA).HasColumnName("TPV_SIMPLES_REMESSA");
            this.Property(t => t.TPV_MOVIMENTACAO_FINANCEIRA).HasColumnName("TPV_MOVIMENTACAO_FINANCEIRA");
            this.Property(t => t.TPV_FATURA_LOCACAO).HasColumnName("TPV_FATURA_LOCACAO");
            this.Property(t => t.TPV_DEMONSTRACAO).HasColumnName("TPV_DEMONSTRACAO");
            this.Property(t => t.TPV_NOTA_IMPORTACAO_AEREA).HasColumnName("TPV_NOTA_IMPORTACAO_AEREA");
            this.Property(t => t.TPV_NOTA_IMPORTACAO_MARITIMA).HasColumnName("TPV_NOTA_IMPORTACAO_MARITIMA");
            this.Property(t => t.TPV_TOTALIZA_IMPOSTOS_OBSERVACAO).HasColumnName("TPV_TOTALIZA_IMPOSTOS_OBSERVACAO");
            this.Property(t => t.TPV_NOME_NF).HasColumnName("TPV_NOME_NF");

            // Relationships
            this.HasOptional(t => t.FA_TIPO_IMPOSTO_TIM)
                .WithMany(t => t.PD_TIPO_VENDA_TPV)
                .HasForeignKey(d => d.TIM_ID);

        }
    }
}
