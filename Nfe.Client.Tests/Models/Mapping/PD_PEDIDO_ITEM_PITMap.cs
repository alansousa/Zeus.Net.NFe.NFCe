using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class PD_PEDIDO_ITEM_PITMap : EntityTypeConfiguration<PD_PEDIDO_ITEM_PIT>
    {
        public PD_PEDIDO_ITEM_PITMap()
        {
            // Primary Key
            this.HasKey(t => t.PIT_ID);

            // Properties
            this.Property(t => t.PIT_DESCRICAO)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.PIT_CFOP)
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("PD_PEDIDO_ITEM_PIT");
            this.Property(t => t.PIT_ID).HasColumnName("PIT_ID");
            this.Property(t => t.PIT_PEDIDO).HasColumnName("PIT_PEDIDO");
            this.Property(t => t.PIT_PRODUTO).HasColumnName("PIT_PRODUTO");
            this.Property(t => t.PIT_DESCRICAO).HasColumnName("PIT_DESCRICAO");
            this.Property(t => t.PIT_QUANTIDADE).HasColumnName("PIT_QUANTIDADE");
            this.Property(t => t.PIT_PRECO_UNITARIO).HasColumnName("PIT_PRECO_UNITARIO");
            this.Property(t => t.PIT_PRECO_TOTAL).HasColumnName("PIT_PRECO_TOTAL");
            this.Property(t => t.PIT_CFOP).HasColumnName("PIT_CFOP");
            this.Property(t => t.PIT_FRETE).HasColumnName("PIT_FRETE");
            this.Property(t => t.PIT_OUTRAS_DESPESAS).HasColumnName("PIT_OUTRAS_DESPESAS");

            // Relationships
            this.HasRequired(t => t.ES_ITEM_ITE)
                .WithMany(t => t.PD_PEDIDO_ITEM_PIT)
                .HasForeignKey(d => d.PIT_PRODUTO);
            this.HasRequired(t => t.PD_PEDIDO_VENDA_PDV)
                .WithMany(t => t.PD_PEDIDO_ITEM_PIT)
                .HasForeignKey(d => d.PIT_PEDIDO);

        }
    }
}
