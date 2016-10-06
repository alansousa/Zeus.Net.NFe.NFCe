using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_MENU_MENMap : EntityTypeConfiguration<GE_MENU_MEN>
    {
        public GE_MENU_MENMap()
        {
            // Primary Key
            this.HasKey(t => t.MEN_ID);

            // Properties
            this.Property(t => t.MEN_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MEN_CAPTION)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MEN_HINT)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("GE_MENU_MEN");
            this.Property(t => t.MEN_ID).HasColumnName("MEN_ID");
            this.Property(t => t.MEN_PAI_ID).HasColumnName("MEN_PAI_ID");
            this.Property(t => t.MEN_CAPTION).HasColumnName("MEN_CAPTION");
            this.Property(t => t.MEN_HINT).HasColumnName("MEN_HINT");
            this.Property(t => t.ACT_ID).HasColumnName("ACT_ID");
            this.Property(t => t.MEN_ORDEM).HasColumnName("MEN_ORDEM");

            // Relationships
            this.HasOptional(t => t.GE_ACTIONS_ACT)
                .WithMany(t => t.GE_MENU_MEN)
                .HasForeignKey(d => d.ACT_ID);

        }
    }
}
