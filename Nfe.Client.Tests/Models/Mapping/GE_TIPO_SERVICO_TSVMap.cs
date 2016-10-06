using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_TIPO_SERVICO_TSVMap : EntityTypeConfiguration<GE_TIPO_SERVICO_TSV>
    {
        public GE_TIPO_SERVICO_TSVMap()
        {
            // Primary Key
            this.HasKey(t => t.TSV_ID);

            // Properties
            this.Property(t => t.TSV_DESCRICAO)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("GE_TIPO_SERVICO_TSV");
            this.Property(t => t.TSV_ID).HasColumnName("TSV_ID");
            this.Property(t => t.TSV_DESCRICAO).HasColumnName("TSV_DESCRICAO");
        }
    }
}
