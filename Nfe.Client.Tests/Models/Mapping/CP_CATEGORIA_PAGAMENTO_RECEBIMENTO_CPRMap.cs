using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPRMap : EntityTypeConfiguration<CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR>
    {
        public CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPRMap()
        {
            // Primary Key
            this.HasKey(t => t.CPR_ID);

            // Properties
            this.Property(t => t.CPR_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CPR_TIPO)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR");
            this.Property(t => t.CPR_ID).HasColumnName("CPR_ID");
            this.Property(t => t.CPR_DESCRICAO).HasColumnName("CPR_DESCRICAO");
            this.Property(t => t.CPR_TIPO).HasColumnName("CPR_TIPO");
            this.Property(t => t.CPR_ENDIVIDAMENTO).HasColumnName("CPR_ENDIVIDAMENTO");
        }
    }
}
