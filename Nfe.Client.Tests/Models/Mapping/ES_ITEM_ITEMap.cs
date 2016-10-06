using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class ES_ITEM_ITEMap : EntityTypeConfiguration<ES_ITEM_ITE>
    {
        public ES_ITEM_ITEMap()
        {
            // Primary Key
            this.HasKey(t => t.ITE_ID);

            // Properties
            this.Property(t => t.ITE_TIPO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ITE_CODIGO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.ITE_DESCRICAO)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ITE_PART_NUMBER)
                .HasMaxLength(50);

            this.Property(t => t.ITE_UNID_MEDIDA)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.ITE_NCM)
                .HasMaxLength(15);

            this.Property(t => t.ITE_CST)
                .HasMaxLength(5);

            this.Property(t => t.ITE_ORIGEM)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("ES_ITEM_ITE");
            this.Property(t => t.ITE_ID).HasColumnName("ITE_ID");
            this.Property(t => t.ITE_TIPO).HasColumnName("ITE_TIPO");
            this.Property(t => t.ITE_CODIGO).HasColumnName("ITE_CODIGO");
            this.Property(t => t.SFI_ID).HasColumnName("SFI_ID");
            this.Property(t => t.ITE_DESCRICAO).HasColumnName("ITE_DESCRICAO");
            this.Property(t => t.ITE_PART_NUMBER).HasColumnName("ITE_PART_NUMBER");
            this.Property(t => t.ITE_PRECO_VENDA).HasColumnName("ITE_PRECO_VENDA");
            this.Property(t => t.ITE_UNID_MEDIDA).HasColumnName("ITE_UNID_MEDIDA");
            this.Property(t => t.ITE_CTRL_NR_SERIE).HasColumnName("ITE_CTRL_NR_SERIE");
            this.Property(t => t.ITE_INATIVO).HasColumnName("ITE_INATIVO");
            this.Property(t => t.ITE_NCM).HasColumnName("ITE_NCM");
            this.Property(t => t.ITE_CST).HasColumnName("ITE_CST");
            this.Property(t => t.ITE_KIT).HasColumnName("ITE_KIT");
            this.Property(t => t.ITE_PESO_BRUTO).HasColumnName("ITE_PESO_BRUTO");
            this.Property(t => t.ITE_PESO_LIQUIDO).HasColumnName("ITE_PESO_LIQUIDO");
            this.Property(t => t.ITE_ORIGEM).HasColumnName("ITE_ORIGEM");
            this.Property(t => t.ITE_MOVIMENTA_ESTOQUE).HasColumnName("ITE_MOVIMENTA_ESTOQUE");
            this.Property(t => t.TSV_ID).HasColumnName("TSV_ID");
            this.Property(t => t.ITE_VENDA_FRACIONADA).HasColumnName("ITE_VENDA_FRACIONADA");
            this.Property(t => t.ITE_ESTOQUE_MINIMO).HasColumnName("ITE_ESTOQUE_MINIMO");
            this.Property(t => t.ITE_CUSTO_MEDIO).HasColumnName("ITE_CUSTO_MEDIO");
            this.Property(t => t.ITE_CUSTO_FOB).HasColumnName("ITE_CUSTO_FOB");

            // Relationships
            this.HasRequired(t => t.ES_SUB_FAMILIA_ITEM_SFI)
                .WithMany(t => t.ES_ITEM_ITE)
                .HasForeignKey(d => d.SFI_ID);

        }
    }
}
