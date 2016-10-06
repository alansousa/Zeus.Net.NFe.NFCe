using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_LANCAMENTOS_CONTA_CORRENTE_LCCMap : EntityTypeConfiguration<GE_LANCAMENTOS_CONTA_CORRENTE_LCC>
    {
        public GE_LANCAMENTOS_CONTA_CORRENTE_LCCMap()
        {
            // Primary Key
            this.HasKey(t => t.LCC_ID);

            // Properties
            this.Property(t => t.LCC_HISTORICO)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GE_LANCAMENTOS_CONTA_CORRENTE_LCC");
            this.Property(t => t.LCC_ID).HasColumnName("LCC_ID");
            this.Property(t => t.CCE_ID).HasColumnName("CCE_ID");
            this.Property(t => t.LCC_HISTORICO).HasColumnName("LCC_HISTORICO");
            this.Property(t => t.LCC_VALOR).HasColumnName("LCC_VALOR");
            this.Property(t => t.LCC_CONCILIADO).HasColumnName("LCC_CONCILIADO");
            this.Property(t => t.LCC_ID_ESTORNADO).HasColumnName("LCC_ID_ESTORNADO");
            this.Property(t => t.LCC_ID_ORIGEM_TRANSFERENCIA).HasColumnName("LCC_ID_ORIGEM_TRANSFERENCIA");

            // Relationships
            this.HasRequired(t => t.GE_CONTA_CORRENTE_EXTRATO_CCE)
                .WithMany(t => t.GE_LANCAMENTOS_CONTA_CORRENTE_LCC)
                .HasForeignKey(d => d.CCE_ID);
            this.HasOptional(t => t.GE_LANCAMENTOS_CONTA_CORRENTE_LCC2)
                .WithMany(t => t.GE_LANCAMENTOS_CONTA_CORRENTE_LCC1)
                .HasForeignKey(d => d.LCC_ID_ESTORNADO);
            this.HasOptional(t => t.GE_LANCAMENTOS_CONTA_CORRENTE_LCC3)
                .WithMany(t => t.GE_LANCAMENTOS_CONTA_CORRENTE_LCC11)
                .HasForeignKey(d => d.LCC_ID_ORIGEM_TRANSFERENCIA);

        }
    }
}
