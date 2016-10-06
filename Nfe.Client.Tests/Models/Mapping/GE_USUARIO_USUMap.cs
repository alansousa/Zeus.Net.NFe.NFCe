using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_USUARIO_USUMap : EntityTypeConfiguration<GE_USUARIO_USU>
    {
        public GE_USUARIO_USUMap()
        {
            // Primary Key
            this.HasKey(t => t.USU_ID);

            // Properties
            this.Property(t => t.USU_LOGIN)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.USU_SENHA)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.USU_NOME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.USU_EMAIL)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GE_USUARIO_USU");
            this.Property(t => t.USU_ID).HasColumnName("USU_ID");
            this.Property(t => t.USU_LOGIN).HasColumnName("USU_LOGIN");
            this.Property(t => t.USU_SENHA).HasColumnName("USU_SENHA");
            this.Property(t => t.USU_NOME).HasColumnName("USU_NOME");
            this.Property(t => t.USU_EMAIL).HasColumnName("USU_EMAIL");
            this.Property(t => t.USU_PRU_ID).HasColumnName("USU_PRU_ID");
            this.Property(t => t.USU_STU_ID).HasColumnName("USU_STU_ID");

            // Relationships
            this.HasRequired(t => t.GE_PERFIL_USUARIO_PRU)
                .WithMany(t => t.GE_USUARIO_USU)
                .HasForeignKey(d => d.USU_PRU_ID);
            this.HasRequired(t => t.GE_STATUS_USUARIO_STU)
                .WithMany(t => t.GE_USUARIO_USU)
                .HasForeignKey(d => d.USU_STU_ID);

        }
    }
}
