using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_TIPO_TRANSPORTE_TTRMap : EntityTypeConfiguration<FA_TIPO_TRANSPORTE_TTR>
    {
        public FA_TIPO_TRANSPORTE_TTRMap()
        {
            // Primary Key
            this.HasKey(t => t.TTR_ID);

            // Properties
            this.Property(t => t.TTR_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FA_TIPO_TRANSPORTE_TTR");
            this.Property(t => t.TTR_ID).HasColumnName("TTR_ID");
            this.Property(t => t.TTR_DESCRICAO).HasColumnName("TTR_DESCRICAO");
        }
    }
}
