using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class CP_CATEGORIA_TIPO_CTPMap : EntityTypeConfiguration<CP_CATEGORIA_TIPO_CTP>
    {
        public CP_CATEGORIA_TIPO_CTPMap()
        {
            // Primary Key
            this.HasKey(t => t.CTP_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CP_CATEGORIA_TIPO_CTP");
            this.Property(t => t.CTP_ID).HasColumnName("CTP_ID");
            this.Property(t => t.CATEGORIA_ID).HasColumnName("CATEGORIA_ID");
            this.Property(t => t.TIPO_ID).HasColumnName("TIPO_ID");

            // Relationships
            this.HasRequired(t => t.CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR)
                .WithMany(t => t.CP_CATEGORIA_TIPO_CTP)
                .HasForeignKey(d => d.CATEGORIA_ID);
            this.HasRequired(t => t.CP_TIPO_PAGAMENTO_TPG)
                .WithMany(t => t.CP_CATEGORIA_TIPO_CTP)
                .HasForeignKey(d => d.TIPO_ID);

        }
    }
}
