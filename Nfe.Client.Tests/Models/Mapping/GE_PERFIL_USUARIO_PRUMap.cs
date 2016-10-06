using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_PERFIL_USUARIO_PRUMap : EntityTypeConfiguration<GE_PERFIL_USUARIO_PRU>
    {
        public GE_PERFIL_USUARIO_PRUMap()
        {
            // Primary Key
            this.HasKey(t => t.PRU_ID);

            // Properties
            this.Property(t => t.PRU_NOME)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GE_PERFIL_USUARIO_PRU");
            this.Property(t => t.PRU_ID).HasColumnName("PRU_ID");
            this.Property(t => t.PRU_NOME).HasColumnName("PRU_NOME");
        }
    }
}
