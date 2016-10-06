using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_GRUPO_PARCEIRO_NEGOCIO_GPNMap : EntityTypeConfiguration<GE_GRUPO_PARCEIRO_NEGOCIO_GPN>
    {
        public GE_GRUPO_PARCEIRO_NEGOCIO_GPNMap()
        {
            // Primary Key
            this.HasKey(t => t.GPN_ID);

            // Properties
            this.Property(t => t.GPN_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GE_GRUPO_PARCEIRO_NEGOCIO_GPN");
            this.Property(t => t.GPN_ID).HasColumnName("GPN_ID");
            this.Property(t => t.GPN_DESCRICAO).HasColumnName("GPN_DESCRICAO");
            this.Property(t => t.GPN_GOVERNO).HasColumnName("GPN_GOVERNO");
        }
    }
}
