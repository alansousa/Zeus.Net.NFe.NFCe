using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_CONTA_CORRENTE_EXTRATO_CCEMap : EntityTypeConfiguration<GE_CONTA_CORRENTE_EXTRATO_CCE>
    {
        public GE_CONTA_CORRENTE_EXTRATO_CCEMap()
        {
            // Primary Key
            this.HasKey(t => t.CCE_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GE_CONTA_CORRENTE_EXTRATO_CCE");
            this.Property(t => t.CCE_ID).HasColumnName("CCE_ID");
            this.Property(t => t.CTC_ID).HasColumnName("CTC_ID");
            this.Property(t => t.CCE_DATA).HasColumnName("CCE_DATA");
            this.Property(t => t.CCE_FECHADO).HasColumnName("CCE_FECHADO");

            // Relationships
            this.HasRequired(t => t.GE_CONTA_CORRENTE_CTC)
                .WithMany(t => t.GE_CONTA_CORRENTE_EXTRATO_CCE)
                .HasForeignKey(d => d.CTC_ID);

        }
    }
}
