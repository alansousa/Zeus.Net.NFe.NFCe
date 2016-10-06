using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class ES_ITEM_CUSTO_MEDIO_ICMMap : EntityTypeConfiguration<ES_ITEM_CUSTO_MEDIO_ICM>
    {
        public ES_ITEM_CUSTO_MEDIO_ICMMap()
        {
            // Primary Key
            this.HasKey(t => t.ICM_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ES_ITEM_CUSTO_MEDIO_ICM");
            this.Property(t => t.ICM_ID).HasColumnName("ICM_ID");
            this.Property(t => t.ICM_DATA).HasColumnName("ICM_DATA");
            this.Property(t => t.ICM_VALOR).HasColumnName("ICM_VALOR");
            this.Property(t => t.ICM_STATUS).HasColumnName("ICM_STATUS");
            this.Property(t => t.ITE_ID).HasColumnName("ITE_ID");
            this.Property(t => t.PNE_ID).HasColumnName("PNE_ID");
            this.Property(t => t.EMP_ID).HasColumnName("EMP_ID");

            // Relationships
            this.HasRequired(t => t.ES_ITEM_ITE)
                .WithMany(t => t.ES_ITEM_CUSTO_MEDIO_ICM)
                .HasForeignKey(d => d.ITE_ID);
            this.HasRequired(t => t.GE_EMPRESA_EMP)
                .WithMany(t => t.ES_ITEM_CUSTO_MEDIO_ICM)
                .HasForeignKey(d => d.EMP_ID);
            this.HasRequired(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .WithMany(t => t.ES_ITEM_CUSTO_MEDIO_ICM)
                .HasForeignKey(d => d.PNE_ID);

        }
    }
}
