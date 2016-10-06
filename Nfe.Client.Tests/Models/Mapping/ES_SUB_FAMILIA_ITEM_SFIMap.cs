using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class ES_SUB_FAMILIA_ITEM_SFIMap : EntityTypeConfiguration<ES_SUB_FAMILIA_ITEM_SFI>
    {
        public ES_SUB_FAMILIA_ITEM_SFIMap()
        {
            // Primary Key
            this.HasKey(t => t.SFI_ID);

            // Properties
            this.Property(t => t.SFI_CODIGO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.SFI_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ES_SUB_FAMILIA_ITEM_SFI");
            this.Property(t => t.SFI_ID).HasColumnName("SFI_ID");
            this.Property(t => t.FAI_ID).HasColumnName("FAI_ID");
            this.Property(t => t.SFI_CODIGO).HasColumnName("SFI_CODIGO");
            this.Property(t => t.SFI_DESCRICAO).HasColumnName("SFI_DESCRICAO");
            this.Property(t => t.SFI_DESCONTO_MAX).HasColumnName("SFI_DESCONTO_MAX");
            this.Property(t => t.SFI_DESCONTO_MAX_REVENDA).HasColumnName("SFI_DESCONTO_MAX_REVENDA");
            this.Property(t => t.SFI_ULTIMO_SEQUENCIAL).HasColumnName("SFI_ULTIMO_SEQUENCIAL");

            // Relationships
            this.HasRequired(t => t.ES_FAMILIA_ITEM_FAI)
                .WithMany(t => t.ES_SUB_FAMILIA_ITEM_SFI)
                .HasForeignKey(d => d.FAI_ID);

        }
    }
}
