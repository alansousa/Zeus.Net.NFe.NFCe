using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_STATUS_USUARIO_STUMap : EntityTypeConfiguration<GE_STATUS_USUARIO_STU>
    {
        public GE_STATUS_USUARIO_STUMap()
        {
            // Primary Key
            this.HasKey(t => t.STU_ID);

            // Properties
            this.Property(t => t.STU_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STU_NOME)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GE_STATUS_USUARIO_STU");
            this.Property(t => t.STU_ID).HasColumnName("STU_ID");
            this.Property(t => t.STU_NOME).HasColumnName("STU_NOME");
        }
    }
}
