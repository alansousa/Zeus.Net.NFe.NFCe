using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class ES_FAMILIA_ITEM_FAIMap : EntityTypeConfiguration<ES_FAMILIA_ITEM_FAI>
    {
        public ES_FAMILIA_ITEM_FAIMap()
        {
            // Primary Key
            this.HasKey(t => t.FAI_ID);

            // Properties
            this.Property(t => t.FAI_CODIGO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.FAI_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ES_FAMILIA_ITEM_FAI");
            this.Property(t => t.FAI_ID).HasColumnName("FAI_ID");
            this.Property(t => t.FAI_CODIGO).HasColumnName("FAI_CODIGO");
            this.Property(t => t.FAI_DESCRICAO).HasColumnName("FAI_DESCRICAO");
        }
    }
}
