using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class ES_ESTOQUE_MOVIMENTACAO_EMVMap : EntityTypeConfiguration<ES_ESTOQUE_MOVIMENTACAO_EMV>
    {
        public ES_ESTOQUE_MOVIMENTACAO_EMVMap()
        {
            // Primary Key
            this.HasKey(t => t.EMV_ID);

            // Properties
            this.Property(t => t.EMV_TIPO_OPERACAO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.EMV_NUMERO_NOTA)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ES_ESTOQUE_MOVIMENTACAO_EMV");
            this.Property(t => t.EMV_ID).HasColumnName("EMV_ID");
            this.Property(t => t.EMV_QTDE).HasColumnName("EMV_QTDE");
            this.Property(t => t.EMV_PRECO_UNITARIO).HasColumnName("EMV_PRECO_UNITARIO");
            this.Property(t => t.EMV_DATA).HasColumnName("EMV_DATA");
            this.Property(t => t.EMV_TIPO_OPERACAO).HasColumnName("EMV_TIPO_OPERACAO");
            this.Property(t => t.EMV_NUMERO_NOTA).HasColumnName("EMV_NUMERO_NOTA");
            this.Property(t => t.EMV_OBSERVACOES).HasColumnName("EMV_OBSERVACOES");
            this.Property(t => t.PNE_ID).HasColumnName("PNE_ID");
            this.Property(t => t.EMP_ID).HasColumnName("EMP_ID");
            this.Property(t => t.ITE_ID).HasColumnName("ITE_ID");
            this.Property(t => t.DPT_ID).HasColumnName("DPT_ID");
            this.Property(t => t.USU_ID).HasColumnName("USU_ID");
            this.Property(t => t.ENV_TIPO_MOVIMENTACAO).HasColumnName("ENV_TIPO_MOVIMENTACAO");
            this.Property(t => t.NFE_ID).HasColumnName("NFE_ID");
            this.Property(t => t.EMV_SALDO).HasColumnName("EMV_SALDO");
            this.Property(t => t.EMV_CUSTO_MEDIO).HasColumnName("EMV_CUSTO_MEDIO");

            // Relationships
            this.HasRequired(t => t.ES_DEPOSITO_DPT)
                .WithMany(t => t.ES_ESTOQUE_MOVIMENTACAO_EMV)
                .HasForeignKey(d => d.DPT_ID);
            this.HasRequired(t => t.ES_ITEM_ITE)
                .WithMany(t => t.ES_ESTOQUE_MOVIMENTACAO_EMV)
                .HasForeignKey(d => d.ITE_ID);
            this.HasRequired(t => t.GE_EMPRESA_EMP)
                .WithMany(t => t.ES_ESTOQUE_MOVIMENTACAO_EMV)
                .HasForeignKey(d => d.EMP_ID);
            this.HasRequired(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .WithMany(t => t.ES_ESTOQUE_MOVIMENTACAO_EMV)
                .HasForeignKey(d => d.PNE_ID);

        }
    }
}
