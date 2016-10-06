using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class CP_TIPO_PAGAMENTO_TPGMap : EntityTypeConfiguration<CP_TIPO_PAGAMENTO_TPG>
    {
        public CP_TIPO_PAGAMENTO_TPGMap()
        {
            // Primary Key
            this.HasKey(t => t.TPG_ID);

            // Properties
            this.Property(t => t.TPG_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TPG_TIPO)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CP_TIPO_PAGAMENTO_TPG");
            this.Property(t => t.TPG_ID).HasColumnName("TPG_ID");
            this.Property(t => t.TPG_DESCRICAO).HasColumnName("TPG_DESCRICAO");
            this.Property(t => t.TPG_TIPO).HasColumnName("TPG_TIPO");
            this.Property(t => t.TPG_CATEGORIA).HasColumnName("TPG_CATEGORIA");

            // Relationships
            this.HasOptional(t => t.CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR)
                .WithMany(t => t.CP_TIPO_PAGAMENTO_TPG)
                .HasForeignKey(d => d.TPG_CATEGORIA);

        }
    }
}
