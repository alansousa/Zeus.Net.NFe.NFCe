using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_ENDERECO_PARCEIRO_ENDMap : EntityTypeConfiguration<GE_ENDERECO_PARCEIRO_END>
    {
        public GE_ENDERECO_PARCEIRO_ENDMap()
        {
            // Primary Key
            this.HasKey(t => t.END_ID);

            // Properties
            this.Property(t => t.END_LOGRADOURO)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.END_NUMERO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.END_COMPLEMENTO)
                .HasMaxLength(150);

            this.Property(t => t.END_CEP)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.END_BAIRRO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.END_UF)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.END_MUNICIPIO)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.IBG_CODCID)
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("GE_ENDERECO_PARCEIRO_END");
            this.Property(t => t.END_ID).HasColumnName("END_ID");
            this.Property(t => t.PNE_ID).HasColumnName("PNE_ID");
            this.Property(t => t.TEN_ID).HasColumnName("TEN_ID");
            this.Property(t => t.END_LOGRADOURO).HasColumnName("END_LOGRADOURO");
            this.Property(t => t.END_NUMERO).HasColumnName("END_NUMERO");
            this.Property(t => t.END_COMPLEMENTO).HasColumnName("END_COMPLEMENTO");
            this.Property(t => t.END_CEP).HasColumnName("END_CEP");
            this.Property(t => t.END_BAIRRO).HasColumnName("END_BAIRRO");
            this.Property(t => t.PAI_ID).HasColumnName("PAI_ID");
            this.Property(t => t.END_UF).HasColumnName("END_UF");
            this.Property(t => t.END_MUNICIPIO).HasColumnName("END_MUNICIPIO");
            this.Property(t => t.IBG_CODCID).HasColumnName("IBG_CODCID");

            // Relationships
            //this.HasOptional(t => t.GE_IBGE_IBG)
            //    .WithMany(t => t.GE_ENDERECO_PARCEIRO_END)
            //    .HasForeignKey(d => d.IBG_CODCID);
            this.HasOptional(t => t.GE_PAIS_PAI)
                .WithMany(t => t.GE_ENDERECO_PARCEIRO_END)
                .HasForeignKey(d => d.PAI_ID);
            this.HasRequired(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .WithMany(t => t.GE_ENDERECO_PARCEIRO_END)
                .HasForeignKey(d => d.PNE_ID);
            this.HasRequired(t => t.GE_TIPO_ENDERECO_TEN)
                .WithMany(t => t.GE_ENDERECO_PARCEIRO_END)
                .HasForeignKey(d => d.TEN_ID);

        }
    }
}
