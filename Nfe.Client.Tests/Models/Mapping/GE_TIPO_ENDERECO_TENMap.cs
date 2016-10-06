using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_TIPO_ENDERECO_TENMap : EntityTypeConfiguration<GE_TIPO_ENDERECO_TEN>
    {
        public GE_TIPO_ENDERECO_TENMap()
        {
            // Primary Key
            this.HasKey(t => t.TEN_ID);

            // Properties
            this.Property(t => t.TEN_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TEN_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GE_TIPO_ENDERECO_TEN");
            this.Property(t => t.TEN_ID).HasColumnName("TEN_ID");
            this.Property(t => t.TEN_DESCRICAO).HasColumnName("TEN_DESCRICAO");
        }
    }
}
