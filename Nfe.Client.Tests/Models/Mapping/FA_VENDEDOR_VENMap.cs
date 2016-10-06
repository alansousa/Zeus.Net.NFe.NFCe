using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_VENDEDOR_VENMap : EntityTypeConfiguration<FA_VENDEDOR_VEN>
    {
        public FA_VENDEDOR_VENMap()
        {
            // Primary Key
            this.HasKey(t => t.VEN_ID);

            // Properties
            this.Property(t => t.VEN_NOME)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("FA_VENDEDOR_VEN");
            this.Property(t => t.VEN_ID).HasColumnName("VEN_ID");
            this.Property(t => t.VEN_NOME).HasColumnName("VEN_NOME");
            this.Property(t => t.VEN_COMISSAO_PRODUTOS).HasColumnName("VEN_COMISSAO_PRODUTOS");
            this.Property(t => t.VEN_COMISSAO_SERVICOS).HasColumnName("VEN_COMISSAO_SERVICOS");
            this.Property(t => t.VEN_COMISSAO_LICENCAS).HasColumnName("VEN_COMISSAO_LICENCAS");
        }
    }
}
