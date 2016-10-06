using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_CNAE_CNAMap : EntityTypeConfiguration<GE_CNAE_CNA>
    {
        public GE_CNAE_CNAMap()
        {
            // Primary Key
            this.HasKey(t => t.CNA_ID);

            // Properties
            this.Property(t => t.CNA_NUM)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CNA_DESCRICAO)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("GE_CNAE_CNA");
            this.Property(t => t.CNA_ID).HasColumnName("CNA_ID");
            this.Property(t => t.CNA_NUM).HasColumnName("CNA_NUM");
            this.Property(t => t.CNA_DESCRICAO).HasColumnName("CNA_DESCRICAO");
        }
    }
}
