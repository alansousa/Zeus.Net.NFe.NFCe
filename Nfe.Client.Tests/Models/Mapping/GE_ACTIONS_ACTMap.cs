using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_ACTIONS_ACTMap : EntityTypeConfiguration<GE_ACTIONS_ACT>
    {
        public GE_ACTIONS_ACTMap()
        {
            // Primary Key
            this.HasKey(t => t.ACT_ID);

            // Properties
            this.Property(t => t.ACT_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ACT_DESCRICAO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ACT_CONTROLLER)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ACT_ACTION)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GE_ACTIONS_ACT");
            this.Property(t => t.ACT_ID).HasColumnName("ACT_ID");
            this.Property(t => t.ACT_DESCRICAO).HasColumnName("ACT_DESCRICAO");
            this.Property(t => t.ACT_CONTROLLER).HasColumnName("ACT_CONTROLLER");
            this.Property(t => t.ACT_ACTION).HasColumnName("ACT_ACTION");
            this.Property(t => t.ACT_PERMITE_TODOS).HasColumnName("ACT_PERMITE_TODOS");

            // Relationships
            this.HasMany(t => t.GE_PERFIL_USUARIO_PRU)
                .WithMany(t => t.GE_ACTIONS_ACT)
                .Map(m =>
                    {
                        m.ToTable("GE_PERMISSAO_PERFIL_PPE");
                        m.MapLeftKey("ACT_ID");
                        m.MapRightKey("PRU_ID");
                    });


        }
    }
}
