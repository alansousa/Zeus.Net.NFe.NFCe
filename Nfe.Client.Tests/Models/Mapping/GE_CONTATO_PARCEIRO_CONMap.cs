using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_CONTATO_PARCEIRO_CONMap : EntityTypeConfiguration<GE_CONTATO_PARCEIRO_CON>
    {
        public GE_CONTATO_PARCEIRO_CONMap()
        {
            // Primary Key
            this.HasKey(t => t.CON_ID);

            // Properties
            this.Property(t => t.CON_NOME)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.CON_CARGO)
                .HasMaxLength(150);

            this.Property(t => t.CON_DDD1)
                .HasMaxLength(5);

            this.Property(t => t.CON_TEL1)
                .HasMaxLength(15);

            this.Property(t => t.CON_RAMAL1)
                .HasMaxLength(15);

            this.Property(t => t.CON_DDD2)
                .HasMaxLength(5);

            this.Property(t => t.CON_TEL2)
                .HasMaxLength(15);

            this.Property(t => t.CON_RAMAL2)
                .HasMaxLength(15);

            this.Property(t => t.CON_CEL_DDD)
                .HasMaxLength(5);

            this.Property(t => t.CON_CEL)
                .HasMaxLength(15);

            this.Property(t => t.CON_EMAIL)
                .HasMaxLength(150);

            this.Property(t => t.CON_END_LOGRADOURO)
                .HasMaxLength(150);

            this.Property(t => t.CON_END_NUMERO)
                .HasMaxLength(50);

            this.Property(t => t.CON_END_COMPLEMENTO)
                .HasMaxLength(50);

            this.Property(t => t.CON_END_CEP)
                .HasMaxLength(10);

            this.Property(t => t.CON_END_BAIRRO)
                .HasMaxLength(50);

            this.Property(t => t.CON_END_UF)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.CON_END_MUNICIPIO)
                .HasMaxLength(40);

            this.Property(t => t.IBG_CODCID)
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("GE_CONTATO_PARCEIRO_CON");
            this.Property(t => t.CON_ID).HasColumnName("CON_ID");
            this.Property(t => t.PNE_ID).HasColumnName("PNE_ID");
            this.Property(t => t.TCO_ID).HasColumnName("TCO_ID");
            this.Property(t => t.CON_NOME).HasColumnName("CON_NOME");
            this.Property(t => t.CON_CARGO).HasColumnName("CON_CARGO");
            this.Property(t => t.CON_DDD1).HasColumnName("CON_DDD1");
            this.Property(t => t.CON_TEL1).HasColumnName("CON_TEL1");
            this.Property(t => t.CON_RAMAL1).HasColumnName("CON_RAMAL1");
            this.Property(t => t.CON_DDD2).HasColumnName("CON_DDD2");
            this.Property(t => t.CON_TEL2).HasColumnName("CON_TEL2");
            this.Property(t => t.CON_RAMAL2).HasColumnName("CON_RAMAL2");
            this.Property(t => t.CON_CEL_DDD).HasColumnName("CON_CEL_DDD");
            this.Property(t => t.CON_CEL).HasColumnName("CON_CEL");
            this.Property(t => t.CON_RECEBE_NFE).HasColumnName("CON_RECEBE_NFE");
            this.Property(t => t.CON_EMAIL).HasColumnName("CON_EMAIL");
            this.Property(t => t.CON_END_LOGRADOURO).HasColumnName("CON_END_LOGRADOURO");
            this.Property(t => t.CON_END_NUMERO).HasColumnName("CON_END_NUMERO");
            this.Property(t => t.CON_END_COMPLEMENTO).HasColumnName("CON_END_COMPLEMENTO");
            this.Property(t => t.CON_END_CEP).HasColumnName("CON_END_CEP");
            this.Property(t => t.CON_END_BAIRRO).HasColumnName("CON_END_BAIRRO");
            this.Property(t => t.PAI_ID).HasColumnName("PAI_ID");
            this.Property(t => t.CON_END_UF).HasColumnName("CON_END_UF");
            this.Property(t => t.CON_END_MUNICIPIO).HasColumnName("CON_END_MUNICIPIO");
            this.Property(t => t.IBG_CODCID).HasColumnName("IBG_CODCID");

            // Relationships
            //this.HasOptional(t => t.GE_IBGE_IBG)
            //    .WithMany(t => t.GE_CONTATO_PARCEIRO_CON)
            //    .HasForeignKey(d => d.IBG_CODCID);
            this.HasOptional(t => t.GE_PAIS_PAI)
                .WithMany(t => t.GE_CONTATO_PARCEIRO_CON)
                .HasForeignKey(d => d.PAI_ID);
            this.HasRequired(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .WithMany(t => t.GE_CONTATO_PARCEIRO_CON)
                .HasForeignKey(d => d.PNE_ID);
            this.HasRequired(t => t.GE_TIPO_CONTATO_TCO)
                .WithMany(t => t.GE_CONTATO_PARCEIRO_CON)
                .HasForeignKey(d => d.TCO_ID);

        }
    }
}
