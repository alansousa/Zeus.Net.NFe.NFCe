using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class ES_DEPOSITO_DPTMap : EntityTypeConfiguration<ES_DEPOSITO_DPT>
    {
        public ES_DEPOSITO_DPTMap()
        {
            // Primary Key
            this.HasKey(t => t.DPT_ID);

            // Properties
            this.Property(t => t.DPT_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ES_DEPOSITO_DPT");
            this.Property(t => t.DPT_ID).HasColumnName("DPT_ID");
            this.Property(t => t.DPT_DESCRICAO).HasColumnName("DPT_DESCRICAO");
            this.Property(t => t.DPT_DESATIVADO).HasColumnName("DPT_DESATIVADO");
            this.Property(t => t.DPT_VALOR_FRETE).HasColumnName("DPT_VALOR_FRETE");
            this.Property(t => t.DPT_MATERIAL_USADO).HasColumnName("DPT_MATERIAL_USADO");
            this.Property(t => t.DPT_DESPESAS_ACESSORIAS).HasColumnName("DPT_DESPESAS_ACESSORIAS");
            this.Property(t => t.DPT_MOVIMENTA_ESTOQUE).HasColumnName("DPT_MOVIMENTA_ESTOQUE");
            this.Property(t => t.DPT_CALCULA_CUSTO_MEDIO).HasColumnName("DPT_CALCULA_CUSTO_MEDIO");
            this.Property(t => t.DPT_DISPONIVEL_PARA_VENDA).HasColumnName("DPT_DISPONIVEL_PARA_VENDA");
        }
    }
}
