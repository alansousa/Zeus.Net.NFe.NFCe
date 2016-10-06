using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_CODIGO_SERVICO_CSVMap : EntityTypeConfiguration<GE_CODIGO_SERVICO_CSV>
    {
        public GE_CODIGO_SERVICO_CSVMap()
        {
            // Primary Key
            this.HasKey(t => t.CSV_ID);

            // Properties
            this.Property(t => t.CSV_CODIGO_SERVICO)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CSV_IBG_CODIGO_CIDADE)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.CSV_DESCRICAO)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("GE_CODIGO_SERVICO_CSV");
            this.Property(t => t.CSV_ID).HasColumnName("CSV_ID");
            this.Property(t => t.CSV_CODIGO_SERVICO).HasColumnName("CSV_CODIGO_SERVICO");
            this.Property(t => t.CSV_IBG_CODIGO_CIDADE).HasColumnName("CSV_IBG_CODIGO_CIDADE");
            this.Property(t => t.CSV_ISS).HasColumnName("CSV_ISS");
            this.Property(t => t.CSV_ISENTO).HasColumnName("CSV_ISENTO");
            this.Property(t => t.CSV_DESCRICAO).HasColumnName("CSV_DESCRICAO");
            this.Property(t => t.CSV_TIPO_SERVICO).HasColumnName("CSV_TIPO_SERVICO");

            // Relationships
            this.HasRequired(t => t.GE_TIPO_SERVICO_TSV)
                .WithMany(t => t.GE_CODIGO_SERVICO_CSV)
                .HasForeignKey(d => d.CSV_TIPO_SERVICO);

        }
    }
}
