using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class ES_COMPONENTE_KITMap : EntityTypeConfiguration<ES_COMPONENTE_KIT>
    {
        public ES_COMPONENTE_KITMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ITE_ID, t.ITE_ID_COMPONENTE });

            // Properties
            this.Property(t => t.ITE_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ITE_ID_COMPONENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ES_COMPONENTE_KIT");
            this.Property(t => t.ITE_ID).HasColumnName("ITE_ID");
            this.Property(t => t.ITE_ID_COMPONENTE).HasColumnName("ITE_ID_COMPONENTE");
            this.Property(t => t.KIT_QUANTIDADE).HasColumnName("KIT_QUANTIDADE");

            // Relationships
            this.HasRequired(t => t.ES_ITEM_ITE)
                .WithMany(t => t.ES_COMPONENTE_KIT)
                .HasForeignKey(d => d.ITE_ID);
            this.HasRequired(t => t.ES_ITEM_ITE1)
                .WithMany(t => t.ES_COMPONENTE_KIT1)
                .HasForeignKey(d => d.ITE_ID_COMPONENTE);

        }
    }
}
