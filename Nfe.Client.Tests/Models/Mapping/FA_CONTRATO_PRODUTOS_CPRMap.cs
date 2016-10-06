using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_CONTRATO_PRODUTOS_CPRMap : EntityTypeConfiguration<FA_CONTRATO_PRODUTOS_CPR>
    {
        public FA_CONTRATO_PRODUTOS_CPRMap()
        {
            // Primary Key
            this.HasKey(t => t.CPR_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("FA_CONTRATO_PRODUTOS_CPR");
            this.Property(t => t.CPR_ID).HasColumnName("CPR_ID");
            this.Property(t => t.CPR_QTDE).HasColumnName("CPR_QTDE");
            this.Property(t => t.CPR_QTDE_PEDIDO_GERADO).HasColumnName("CPR_QTDE_PEDIDO_GERADO");
            this.Property(t => t.CON_ID).HasColumnName("CON_ID");
            this.Property(t => t.ITE_ID).HasColumnName("ITE_ID");

            // Relationships
            this.HasRequired(t => t.ES_ITEM_ITE)
                .WithMany(t => t.FA_CONTRATO_PRODUTOS_CPR)
                .HasForeignKey(d => d.ITE_ID);
            this.HasRequired(t => t.FA_CONTRATO_CON)
                .WithMany(t => t.FA_CONTRATO_PRODUTOS_CPR)
                .HasForeignKey(d => d.CON_ID);

        }
    }
}
