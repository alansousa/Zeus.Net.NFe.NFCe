using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class FA_TRANSPORTADORA_TRAMap : EntityTypeConfiguration<FA_TRANSPORTADORA_TRA>
    {
        public FA_TRANSPORTADORA_TRAMap()
        {
            // Primary Key
            this.HasKey(t => t.TRA_ID);

            // Properties
            this.Property(t => t.TRA_NOME)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.TRA_ENDERECO)
                .HasMaxLength(150);

            this.Property(t => t.TRA_BAIRRO)
                .HasMaxLength(50);

            this.Property(t => t.TRA_CEP)
                .HasMaxLength(10);

            this.Property(t => t.TRA_UF)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.TRA_MUNICIPIO)
                .HasMaxLength(40);

            this.Property(t => t.IBG_COD_CID)
                .HasMaxLength(7);

            this.Property(t => t.TRA_TELEFONE)
                .HasMaxLength(40);

            this.Property(t => t.TRA_EMAIL)
                .HasMaxLength(150);

            this.Property(t => t.TRA_IE)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("FA_TRANSPORTADORA_TRA");
            this.Property(t => t.TRA_ID).HasColumnName("TRA_ID");
            this.Property(t => t.TRA_NOME).HasColumnName("TRA_NOME");
            this.Property(t => t.TRA_TIPO_CONTRIBUINTE).HasColumnName("TRA_TIPO_CONTRIBUINTE");
            this.Property(t => t.TRA_ENDERECO).HasColumnName("TRA_ENDERECO");
            this.Property(t => t.TRA_BAIRRO).HasColumnName("TRA_BAIRRO");
            this.Property(t => t.TRA_CEP).HasColumnName("TRA_CEP");
            this.Property(t => t.TRA_UF).HasColumnName("TRA_UF");
            this.Property(t => t.TRA_MUNICIPIO).HasColumnName("TRA_MUNICIPIO");
            this.Property(t => t.IBG_COD_CID).HasColumnName("IBG_COD_CID");
            this.Property(t => t.TRA_TELEFONE).HasColumnName("TRA_TELEFONE");
            this.Property(t => t.TRA_EMAIL).HasColumnName("TRA_EMAIL");
            this.Property(t => t.TRA_CNPJ_CPF).HasColumnName("TRA_CNPJ_CPF");
            this.Property(t => t.TRA_IE).HasColumnName("TRA_IE");
            this.Property(t => t.TTR_ID).HasColumnName("TTR_ID");

            // Relationships
            this.HasOptional(t => t.FA_TIPO_TRANSPORTE_TTR)
                .WithMany(t => t.FA_TRANSPORTADORA_TRA)
                .HasForeignKey(d => d.TTR_ID);
            //this.HasOptional(t => t.GE_IBGE_IBG)
            //    .WithMany(t => t.FA_TRANSPORTADORA_TRA)
            //    .HasForeignKey(d => d.IBG_COD_CID);

        }
    }
}
