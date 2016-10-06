using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_TIPO_CONTATO_TCOMap : EntityTypeConfiguration<GE_TIPO_CONTATO_TCO>
    {
        public GE_TIPO_CONTATO_TCOMap()
        {
            // Primary Key
            this.HasKey(t => t.TCO_ID);

            // Properties
            this.Property(t => t.TCO_DESCRICAO)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("GE_TIPO_CONTATO_TCO");
            this.Property(t => t.TCO_ID).HasColumnName("TCO_ID");
            this.Property(t => t.TCO_DESCRICAO).HasColumnName("TCO_DESCRICAO");
        }
    }
}
