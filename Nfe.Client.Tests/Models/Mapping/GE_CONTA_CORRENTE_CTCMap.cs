using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_CONTA_CORRENTE_CTCMap : EntityTypeConfiguration<GE_CONTA_CORRENTE_CTC>
    {
        public GE_CONTA_CORRENTE_CTCMap()
        {
            // Primary Key
            this.HasKey(t => t.CTC_ID);

            // Properties
            this.Property(t => t.CTC_NUMERO)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CTC_AGENCIA)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CTC_BANCO_NUMERO)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.CTC_BANCO_NOME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CTC_BANCO_NOME_GERENTE)
                .HasMaxLength(50);

            this.Property(t => t.CTC_BANCO_ENDERECO)
                .HasMaxLength(100);

            this.Property(t => t.CTC_BANCO_BAIRRO)
                .HasMaxLength(50);

            this.Property(t => t.CTC_BANCO_CIDADE)
                .HasMaxLength(50);

            this.Property(t => t.CTC_BANCO_UF)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.CTC_BANCO_TELEFONE)
                .IsFixedLength()
                .HasMaxLength(11);

            this.Property(t => t.CTC_BANCO_EMAIL)
                .HasMaxLength(100);

            this.Property(t => t.CTC_TAXA)
                .HasMaxLength(50);

            this.Property(t => t.CTC_GARANTIAS)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GE_CONTA_CORRENTE_CTC");
            this.Property(t => t.CTC_ID).HasColumnName("CTC_ID");
            this.Property(t => t.CTC_NUMERO).HasColumnName("CTC_NUMERO");
            this.Property(t => t.CTC_AGENCIA).HasColumnName("CTC_AGENCIA");
            this.Property(t => t.CTC_ATIVO).HasColumnName("CTC_ATIVO");
            this.Property(t => t.CTC_EMPRESA).HasColumnName("CTC_EMPRESA");
            this.Property(t => t.CTC_BANCO_NUMERO).HasColumnName("CTC_BANCO_NUMERO");
            this.Property(t => t.CTC_BANCO_NOME).HasColumnName("CTC_BANCO_NOME");
            this.Property(t => t.CTC_BANCO_NOME_GERENTE).HasColumnName("CTC_BANCO_NOME_GERENTE");
            this.Property(t => t.CTC_BANCO_ENDERECO).HasColumnName("CTC_BANCO_ENDERECO");
            this.Property(t => t.CTC_BANCO_BAIRRO).HasColumnName("CTC_BANCO_BAIRRO");
            this.Property(t => t.CTC_BANCO_CIDADE).HasColumnName("CTC_BANCO_CIDADE");
            this.Property(t => t.CTC_BANCO_UF).HasColumnName("CTC_BANCO_UF");
            this.Property(t => t.CTC_BANCO_TELEFONE).HasColumnName("CTC_BANCO_TELEFONE");
            this.Property(t => t.CTC_BANCO_EMAIL).HasColumnName("CTC_BANCO_EMAIL");
            this.Property(t => t.CTC_LIMITE).HasColumnName("CTC_LIMITE");
            this.Property(t => t.CTC_LIMITE_TIPO).HasColumnName("CTC_LIMITE_TIPO");
            this.Property(t => t.CTC_TAXA).HasColumnName("CTC_TAXA");
            this.Property(t => t.CTC_GARANTIAS).HasColumnName("CTC_GARANTIAS");

            // Relationships
            this.HasRequired(t => t.GE_EMPRESA_EMP)
                .WithMany(t => t.GE_CONTA_CORRENTE_CTC)
                .HasForeignKey(d => d.CTC_EMPRESA);

        }
    }
}
