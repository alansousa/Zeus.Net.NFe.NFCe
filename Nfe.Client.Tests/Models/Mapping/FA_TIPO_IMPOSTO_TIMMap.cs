using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_TIPO_IMPOSTO_TIMMap : EntityTypeConfiguration<FA_TIPO_IMPOSTO_TIM>
    {
        public FA_TIPO_IMPOSTO_TIMMap()
        {
            // Primary Key
            this.HasKey(t => t.TIM_ID);

            // Properties
            this.Property(t => t.TIM_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("FA_TIPO_IMPOSTO_TIM");
            this.Property(t => t.TIM_ID).HasColumnName("TIM_ID");
            this.Property(t => t.TIM_DESCRICAO).HasColumnName("TIM_DESCRICAO");
            this.Property(t => t.TIM_ICMS).HasColumnName("TIM_ICMS");
            this.Property(t => t.TIM_IPI).HasColumnName("TIM_IPI");
            this.Property(t => t.TIM_PIS).HasColumnName("TIM_PIS");
            this.Property(t => t.TIM_COFINS).HasColumnName("TIM_COFINS");
            this.Property(t => t.TIM_CSLL).HasColumnName("TIM_CSLL");
            this.Property(t => t.TIM_IRRF).HasColumnName("TIM_IRRF");
            this.Property(t => t.TIM_INSS).HasColumnName("TIM_INSS");
            this.Property(t => t.TIM_NF_OBS).HasColumnName("TIM_NF_OBS");
        }
    }
}
