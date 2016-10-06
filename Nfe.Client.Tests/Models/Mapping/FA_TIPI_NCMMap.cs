using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_TIPI_NCMMap : EntityTypeConfiguration<FA_TIPI_NCM>
    {
        public FA_TIPI_NCMMap()
        {
            // Primary Key
            this.HasKey(t => t.NCM_CODIGO);

            // Properties
            this.Property(t => t.NCM_CODIGO)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.NCM_DESCRICAO)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("FA_TIPI_NCM");
            this.Property(t => t.NCM_CODIGO).HasColumnName("NCM_CODIGO");
            this.Property(t => t.NCM_DESCRICAO).HasColumnName("NCM_DESCRICAO");
            this.Property(t => t.NCM_IPI).HasColumnName("NCM_IPI");
            this.Property(t => t.NCM_ST_AC).HasColumnName("NCM_ST_AC");
            this.Property(t => t.NCM_ST_AL).HasColumnName("NCM_ST_AL");
            this.Property(t => t.NCM_ST_AP).HasColumnName("NCM_ST_AP");
            this.Property(t => t.NCM_ST_AM).HasColumnName("NCM_ST_AM");
            this.Property(t => t.NCM_ST_BA).HasColumnName("NCM_ST_BA");
            this.Property(t => t.NCM_ST_CE).HasColumnName("NCM_ST_CE");
            this.Property(t => t.NCM_ST_DF).HasColumnName("NCM_ST_DF");
            this.Property(t => t.NCM_ST_ES).HasColumnName("NCM_ST_ES");
            this.Property(t => t.NCM_ST_GO).HasColumnName("NCM_ST_GO");
            this.Property(t => t.NCM_ST_MA).HasColumnName("NCM_ST_MA");
            this.Property(t => t.NCM_ST_MT).HasColumnName("NCM_ST_MT");
            this.Property(t => t.NCM_ST_MS).HasColumnName("NCM_ST_MS");
            this.Property(t => t.NCM_ST_MG).HasColumnName("NCM_ST_MG");
            this.Property(t => t.NCM_ST_PA).HasColumnName("NCM_ST_PA");
            this.Property(t => t.NCM_ST_PB).HasColumnName("NCM_ST_PB");
            this.Property(t => t.NCM_ST_PR).HasColumnName("NCM_ST_PR");
            this.Property(t => t.NCM_ST_PE).HasColumnName("NCM_ST_PE");
            this.Property(t => t.NCM_ST_PI).HasColumnName("NCM_ST_PI");
            this.Property(t => t.NCM_ST_RJ).HasColumnName("NCM_ST_RJ");
            this.Property(t => t.NCM_ST_RN).HasColumnName("NCM_ST_RN");
            this.Property(t => t.NCM_ST_RS).HasColumnName("NCM_ST_RS");
            this.Property(t => t.NCM_ST_RO).HasColumnName("NCM_ST_RO");
            this.Property(t => t.NCM_ST_RR).HasColumnName("NCM_ST_RR");
            this.Property(t => t.NCM_ST_SC).HasColumnName("NCM_ST_SC");
            this.Property(t => t.NCM_ST_SP).HasColumnName("NCM_ST_SP");
            this.Property(t => t.NCM_ST_SE).HasColumnName("NCM_ST_SE");
            this.Property(t => t.NCM_ST_TO).HasColumnName("NCM_ST_TO");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_AC).HasColumnName("NCM_ALIQUOTA_ICMS_AC");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_AL).HasColumnName("NCM_ALIQUOTA_ICMS_AL");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_AP).HasColumnName("NCM_ALIQUOTA_ICMS_AP");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_AM).HasColumnName("NCM_ALIQUOTA_ICMS_AM");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_BA).HasColumnName("NCM_ALIQUOTA_ICMS_BA");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_CE).HasColumnName("NCM_ALIQUOTA_ICMS_CE");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_DF).HasColumnName("NCM_ALIQUOTA_ICMS_DF");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_ES).HasColumnName("NCM_ALIQUOTA_ICMS_ES");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_GO).HasColumnName("NCM_ALIQUOTA_ICMS_GO");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_MA).HasColumnName("NCM_ALIQUOTA_ICMS_MA");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_MT).HasColumnName("NCM_ALIQUOTA_ICMS_MT");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_MS).HasColumnName("NCM_ALIQUOTA_ICMS_MS");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_MG).HasColumnName("NCM_ALIQUOTA_ICMS_MG");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_PA).HasColumnName("NCM_ALIQUOTA_ICMS_PA");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_PB).HasColumnName("NCM_ALIQUOTA_ICMS_PB");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_PR).HasColumnName("NCM_ALIQUOTA_ICMS_PR");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_PE).HasColumnName("NCM_ALIQUOTA_ICMS_PE");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_PI).HasColumnName("NCM_ALIQUOTA_ICMS_PI");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_RJ).HasColumnName("NCM_ALIQUOTA_ICMS_RJ");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_RN).HasColumnName("NCM_ALIQUOTA_ICMS_RN");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_RS).HasColumnName("NCM_ALIQUOTA_ICMS_RS");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_RO).HasColumnName("NCM_ALIQUOTA_ICMS_RO");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_RR).HasColumnName("NCM_ALIQUOTA_ICMS_RR");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_SC).HasColumnName("NCM_ALIQUOTA_ICMS_SC");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_SP).HasColumnName("NCM_ALIQUOTA_ICMS_SP");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_SE).HasColumnName("NCM_ALIQUOTA_ICMS_SE");
            this.Property(t => t.NCM_ALIQUOTA_ICMS_TO).HasColumnName("NCM_ALIQUOTA_ICMS_TO");
            this.Property(t => t.NCM_IVA_AC).HasColumnName("NCM_IVA_AC");
            this.Property(t => t.NCM_IVA_AL).HasColumnName("NCM_IVA_AL");
            this.Property(t => t.NCM_IVA_AP).HasColumnName("NCM_IVA_AP");
            this.Property(t => t.NCM_IVA_AM).HasColumnName("NCM_IVA_AM");
            this.Property(t => t.NCM_IVA_BA).HasColumnName("NCM_IVA_BA");
            this.Property(t => t.NCM_IVA_CE).HasColumnName("NCM_IVA_CE");
            this.Property(t => t.NCM_IVA_DF).HasColumnName("NCM_IVA_DF");
            this.Property(t => t.NCM_IVA_ES).HasColumnName("NCM_IVA_ES");
            this.Property(t => t.NCM_IVA_GO).HasColumnName("NCM_IVA_GO");
            this.Property(t => t.NCM_IVA_MA).HasColumnName("NCM_IVA_MA");
            this.Property(t => t.NCM_IVA_MT).HasColumnName("NCM_IVA_MT");
            this.Property(t => t.NCM_IVA_MS).HasColumnName("NCM_IVA_MS");
            this.Property(t => t.NCM_IVA_MG).HasColumnName("NCM_IVA_MG");
            this.Property(t => t.NCM_IVA_PA).HasColumnName("NCM_IVA_PA");
            this.Property(t => t.NCM_IVA_PB).HasColumnName("NCM_IVA_PB");
            this.Property(t => t.NCM_IVA_PR).HasColumnName("NCM_IVA_PR");
            this.Property(t => t.NCM_IVA_PE).HasColumnName("NCM_IVA_PE");
            this.Property(t => t.NCM_IVA_PI).HasColumnName("NCM_IVA_PI");
            this.Property(t => t.NCM_IVA_RJ).HasColumnName("NCM_IVA_RJ");
            this.Property(t => t.NCM_IVA_RN).HasColumnName("NCM_IVA_RN");
            this.Property(t => t.NCM_IVA_RS).HasColumnName("NCM_IVA_RS");
            this.Property(t => t.NCM_IVA_RO).HasColumnName("NCM_IVA_RO");
            this.Property(t => t.NCM_IVA_RR).HasColumnName("NCM_IVA_RR");
            this.Property(t => t.NCM_IVA_SC).HasColumnName("NCM_IVA_SC");
            this.Property(t => t.NCM_IVA_SP).HasColumnName("NCM_IVA_SP");
            this.Property(t => t.NCM_IVA_SE).HasColumnName("NCM_IVA_SE");
            this.Property(t => t.NCM_IVA_TO).HasColumnName("NCM_IVA_TO");
            this.Property(t => t.NCM_IVA_IMP_AC).HasColumnName("NCM_IVA_IMP_AC");
            this.Property(t => t.NCM_IVA_IMP_AL).HasColumnName("NCM_IVA_IMP_AL");
            this.Property(t => t.NCM_IVA_IMP_AP).HasColumnName("NCM_IVA_IMP_AP");
            this.Property(t => t.NCM_IVA_IMP_AM).HasColumnName("NCM_IVA_IMP_AM");
            this.Property(t => t.NCM_IVA_IMP_BA).HasColumnName("NCM_IVA_IMP_BA");
            this.Property(t => t.NCM_IVA_IMP_CE).HasColumnName("NCM_IVA_IMP_CE");
            this.Property(t => t.NCM_IVA_IMP_DF).HasColumnName("NCM_IVA_IMP_DF");
            this.Property(t => t.NCM_IVA_IMP_ES).HasColumnName("NCM_IVA_IMP_ES");
            this.Property(t => t.NCM_IVA_IMP_GO).HasColumnName("NCM_IVA_IMP_GO");
            this.Property(t => t.NCM_IVA_IMP_MA).HasColumnName("NCM_IVA_IMP_MA");
            this.Property(t => t.NCM_IVA_IMP_MT).HasColumnName("NCM_IVA_IMP_MT");
            this.Property(t => t.NCM_IVA_IMP_MS).HasColumnName("NCM_IVA_IMP_MS");
            this.Property(t => t.NCM_IVA_IMP_MG).HasColumnName("NCM_IVA_IMP_MG");
            this.Property(t => t.NCM_IVA_IMP_PA).HasColumnName("NCM_IVA_IMP_PA");
            this.Property(t => t.NCM_IVA_IMP_PB).HasColumnName("NCM_IVA_IMP_PB");
            this.Property(t => t.NCM_IVA_IMP_PR).HasColumnName("NCM_IVA_IMP_PR");
            this.Property(t => t.NCM_IVA_IMP_PE).HasColumnName("NCM_IVA_IMP_PE");
            this.Property(t => t.NCM_IVA_IMP_PI).HasColumnName("NCM_IVA_IMP_PI");
            this.Property(t => t.NCM_IVA_IMP_RJ).HasColumnName("NCM_IVA_IMP_RJ");
            this.Property(t => t.NCM_IVA_IMP_RN).HasColumnName("NCM_IVA_IMP_RN");
            this.Property(t => t.NCM_IVA_IMP_RS).HasColumnName("NCM_IVA_IMP_RS");
            this.Property(t => t.NCM_IVA_IMP_RO).HasColumnName("NCM_IVA_IMP_RO");
            this.Property(t => t.NCM_IVA_IMP_RR).HasColumnName("NCM_IVA_IMP_RR");
            this.Property(t => t.NCM_IVA_IMP_SC).HasColumnName("NCM_IVA_IMP_SC");
            this.Property(t => t.NCM_IVA_IMP_SP).HasColumnName("NCM_IVA_IMP_SP");
            this.Property(t => t.NCM_IVA_IMP_SE).HasColumnName("NCM_IVA_IMP_SE");
            this.Property(t => t.NCM_IVA_IMP_TO).HasColumnName("NCM_IVA_IMP_TO");
            this.Property(t => t.NCM_IPI_IMP).HasColumnName("NCM_IPI_IMP");
            this.Property(t => t.NCM_COFINS_IMP).HasColumnName("NCM_COFINS_IMP");
            this.Property(t => t.NCM_II).HasColumnName("NCM_II");
            this.Property(t => t.NCM_PIS_IMP).HasColumnName("NCM_PIS_IMP");
        }
    }
}
