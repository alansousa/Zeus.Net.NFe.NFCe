using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_PARAMETROS_IMPOSTOS_PIMMap : EntityTypeConfiguration<FA_PARAMETROS_IMPOSTOS_PIM>
    {
        public FA_PARAMETROS_IMPOSTOS_PIMMap()
        {
            // Primary Key
            this.HasKey(t => t.PIM_ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("FA_PARAMETROS_IMPOSTOS_PIM");
            this.Property(t => t.PIM_ID).HasColumnName("PIM_ID");
            this.Property(t => t.PIM_PIS).HasColumnName("PIM_PIS");
            this.Property(t => t.PIM_COFINS).HasColumnName("PIM_COFINS");
            this.Property(t => t.PIM_CSLL).HasColumnName("PIM_CSLL");
            this.Property(t => t.PIM_IRRF).HasColumnName("PIM_IRRF");
            this.Property(t => t.PIM_INSS).HasColumnName("PIM_INSS");
            this.Property(t => t.PIM_VALOR_MIN_RETENCAO).HasColumnName("PIM_VALOR_MIN_RETENCAO");
            this.Property(t => t.PIM_TIPO).HasColumnName("PIM_TIPO");
        }
    }
}
