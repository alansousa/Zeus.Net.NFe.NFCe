using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_TIPO_VOLUME_TVOMap : EntityTypeConfiguration<FA_TIPO_VOLUME_TVO>
    {
        public FA_TIPO_VOLUME_TVOMap()
        {
            // Primary Key
            this.HasKey(t => t.TVO_ID);

            // Properties
            this.Property(t => t.TVO_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FA_TIPO_VOLUME_TVO");
            this.Property(t => t.TVO_ID).HasColumnName("TVO_ID");
            this.Property(t => t.TVO_DESCRICAO).HasColumnName("TVO_DESCRICAO");
        }
    }
}
