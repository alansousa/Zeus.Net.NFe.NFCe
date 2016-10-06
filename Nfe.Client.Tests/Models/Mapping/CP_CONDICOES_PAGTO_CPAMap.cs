using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class CP_CONDICOES_PAGTO_CPAMap : EntityTypeConfiguration<CP_CONDICOES_PAGTO_CPA>
    {
        public CP_CONDICOES_PAGTO_CPAMap()
        {
            // Primary Key
            this.HasKey(t => t.CPA_ID);

            // Properties
            this.Property(t => t.CPA_DESCRICAO)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CP_CONDICOES_PAGTO_CPA");
            this.Property(t => t.CPA_ID).HasColumnName("CPA_ID");
            this.Property(t => t.CPA_DESCRICAO).HasColumnName("CPA_DESCRICAO");
            this.Property(t => t.CPA_QTDE_PAGAMENTOS).HasColumnName("CPA_QTDE_PAGAMENTOS");
            this.Property(t => t.CPA_QTDE_DIAS_VENC_PRIM_PAG).HasColumnName("CPA_QTDE_DIAS_VENC_PRIM_PAG");
            this.Property(t => t.CPA_INTERVALO_DIAS_ENTRE_PARC).HasColumnName("CPA_INTERVALO_DIAS_ENTRE_PARC");
        }
    }
}
