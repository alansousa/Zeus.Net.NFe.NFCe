using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class GE_AVISOS_AVIMap : EntityTypeConfiguration<GE_AVISOS_AVI>
    {
        public GE_AVISOS_AVIMap()
        {
            // Primary Key
            this.HasKey(t => t.AVI_ID);

            // Properties
            this.Property(t => t.AVI_CAMPO_ALTERADO)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.AVI_CONTEUDO_ANTERIOR)
                .IsRequired();

            this.Property(t => t.AVI_CONTEUDO_ATUAL)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("GE_AVISOS_AVI");
            this.Property(t => t.AVI_ID).HasColumnName("AVI_ID");
            this.Property(t => t.AVI_DATA).HasColumnName("AVI_DATA");
            this.Property(t => t.AVI_CAMPO_ALTERADO).HasColumnName("AVI_CAMPO_ALTERADO");
            this.Property(t => t.AVI_CONTEUDO_ANTERIOR).HasColumnName("AVI_CONTEUDO_ANTERIOR");
            this.Property(t => t.AVI_CONTEUDO_ATUAL).HasColumnName("AVI_CONTEUDO_ATUAL");
            this.Property(t => t.AVI_ENVIOU_EMAIL).HasColumnName("AVI_ENVIOU_EMAIL");
            this.Property(t => t.MOD_ID).HasColumnName("MOD_ID");
            this.Property(t => t.REGISTRO_ID).HasColumnName("REGISTRO_ID");
            this.Property(t => t.PNE_ID).HasColumnName("PNE_ID");
            this.Property(t => t.USU_ID).HasColumnName("USU_ID");
            this.Property(t => t.EMP_ID).HasColumnName("EMP_ID");

            // Relationships
            this.HasRequired(t => t.GE_AVISOS_MODULOS_MOD)
                .WithMany(t => t.GE_AVISOS_AVI)
                .HasForeignKey(d => d.MOD_ID);
            this.HasRequired(t => t.GE_EMPRESA_EMP)
                .WithMany(t => t.GE_AVISOS_AVI)
                .HasForeignKey(d => d.EMP_ID);
            this.HasRequired(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .WithMany(t => t.GE_AVISOS_AVI)
                .HasForeignKey(d => d.PNE_ID);
            this.HasRequired(t => t.GE_USUARIO_USU)
                .WithMany(t => t.GE_AVISOS_AVI)
                .HasForeignKey(d => d.USU_ID);

        }
    }
}
