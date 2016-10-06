using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_AVISOS_MODULOS_MODMap : EntityTypeConfiguration<GE_AVISOS_MODULOS_MOD>
    {
        public GE_AVISOS_MODULOS_MODMap()
        {
            // Primary Key
            this.HasKey(t => t.MOD_ID);

            // Properties
            this.Property(t => t.MOD_DESCRICAO)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("GE_AVISOS_MODULOS_MOD");
            this.Property(t => t.MOD_ID).HasColumnName("MOD_ID");
            this.Property(t => t.MOD_DESCRICAO).HasColumnName("MOD_DESCRICAO");
        }
    }
}
