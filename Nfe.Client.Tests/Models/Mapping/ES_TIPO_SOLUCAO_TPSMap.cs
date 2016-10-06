using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class ES_TIPO_SOLUCAO_TPSMap : EntityTypeConfiguration<ES_TIPO_SOLUCAO_TPS>
    {
        public ES_TIPO_SOLUCAO_TPSMap()
        {
            // Primary Key
            this.HasKey(t => t.TPS_ID);

            // Properties
            this.Property(t => t.TPS_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ES_TIPO_SOLUCAO_TPS");
            this.Property(t => t.TPS_ID).HasColumnName("TPS_ID");
            this.Property(t => t.TPS_DESCRICAO).HasColumnName("TPS_DESCRICAO");
        }
    }
}
