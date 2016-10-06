using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_PROJETO_PJOMap : EntityTypeConfiguration<GE_PROJETO_PJO>
    {
        public GE_PROJETO_PJOMap()
        {
            // Primary Key
            this.HasKey(t => t.PJO_ID);

            // Properties
            this.Property(t => t.PJO_DESCRICAO)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("GE_PROJETO_PJO");
            this.Property(t => t.PJO_ID).HasColumnName("PJO_ID");
            this.Property(t => t.PJO_DESCRICAO).HasColumnName("PJO_DESCRICAO");
        }
    }
}
