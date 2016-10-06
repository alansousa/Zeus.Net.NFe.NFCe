using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class ES_ESTOQUE_ESTMap : EntityTypeConfiguration<ES_ESTOQUE_EST>
    {
        public ES_ESTOQUE_ESTMap()
        {
            // Primary Key
            this.HasKey(t => t.EST_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ES_ESTOQUE_EST");
            this.Property(t => t.EST_ID).HasColumnName("EST_ID");
            this.Property(t => t.EST_QTDE).HasColumnName("EST_QTDE");
            this.Property(t => t.ITE_ID).HasColumnName("ITE_ID");
            this.Property(t => t.DPT_ID).HasColumnName("DPT_ID");

            // Relationships
            this.HasRequired(t => t.ES_DEPOSITO_DPT)
                .WithMany(t => t.ES_ESTOQUE_EST)
                .HasForeignKey(d => d.DPT_ID);
            this.HasRequired(t => t.ES_ITEM_ITE)
                .WithMany(t => t.ES_ESTOQUE_EST)
                .HasForeignKey(d => d.ITE_ID);

        }
    }
}
