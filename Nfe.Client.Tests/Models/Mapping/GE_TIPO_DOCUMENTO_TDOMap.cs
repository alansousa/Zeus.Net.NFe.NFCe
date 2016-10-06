using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_TIPO_DOCUMENTO_TDOMap : EntityTypeConfiguration<GE_TIPO_DOCUMENTO_TDO>
    {
        public GE_TIPO_DOCUMENTO_TDOMap()
        {
            // Primary Key
            this.HasKey(t => t.TDO_ID);

            // Properties
            this.Property(t => t.TDO_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TDO_CODIGO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("GE_TIPO_DOCUMENTO_TDO");
            this.Property(t => t.TDO_ID).HasColumnName("TDO_ID");
            this.Property(t => t.TDO_DESCRICAO).HasColumnName("TDO_DESCRICAO");
            this.Property(t => t.TDO_CODIGO).HasColumnName("TDO_CODIGO");
        }
    }
}
