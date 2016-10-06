using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_EMPRESA_ENDERECO_EENMap : EntityTypeConfiguration<GE_EMPRESA_ENDERECO_EEN>
    {
        public GE_EMPRESA_ENDERECO_EENMap()
        {
            // Primary Key
            this.HasKey(t => t.EEN_ID);

            // Properties
            this.Property(t => t.EEN_LOGRADOURO)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.EEN_NUMERO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EEN_COMPLEMENTO)
                .HasMaxLength(50);

            this.Property(t => t.EEN_CEP)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.EEN_BAIRRO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EEN_UF)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.EEN_MUNICIPIO)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.IBG_CODCID);

            // Table & Column Mappings
            this.ToTable("GE_EMPRESA_ENDERECO_EEN");
            this.Property(t => t.EEN_ID).HasColumnName("EEN_ID");
            this.Property(t => t.EEN_LOGRADOURO).HasColumnName("EEN_LOGRADOURO");
            this.Property(t => t.EEN_NUMERO).HasColumnName("EEN_NUMERO");
            this.Property(t => t.EEN_COMPLEMENTO).HasColumnName("EEN_COMPLEMENTO");
            this.Property(t => t.EEN_CEP).HasColumnName("EEN_CEP");
            this.Property(t => t.EEN_BAIRRO).HasColumnName("EEN_BAIRRO");
            this.Property(t => t.EEN_UF).HasColumnName("EEN_UF");
            this.Property(t => t.EEN_MUNICIPIO).HasColumnName("EEN_MUNICIPIO");
            this.Property(t => t.EMP_ID).HasColumnName("EMP_ID");
            this.Property(t => t.TEN_ID).HasColumnName("TEN_ID");
            this.Property(t => t.PAI_ID).HasColumnName("PAI_ID");
            this.Property(t => t.IBG_CODCID).HasColumnName("IBG_CODCID");

            // Relationships
            this.HasRequired(t => t.GE_EMPRESA_EMP)
                .WithMany(t => t.GE_EMPRESA_ENDERECO_EEN)
                .HasForeignKey(d => d.EMP_ID);
            //this.HasRequired(t => t.GE_IBGE_IBG)
            //    .WithMany(t => t.GE_EMPRESA_ENDERECO_EEN)
            //    .HasForeignKey(d => d.IBG_CODCID);
            this.HasRequired(t => t.GE_PAIS_PAI)
                .WithMany(t => t.GE_EMPRESA_ENDERECO_EEN)
                .HasForeignKey(d => d.PAI_ID);
            this.HasRequired(t => t.GE_TIPO_ENDERECO_TEN)
                .WithMany(t => t.GE_EMPRESA_ENDERECO_EEN)
                .HasForeignKey(d => d.TEN_ID);

        }
    }
}
