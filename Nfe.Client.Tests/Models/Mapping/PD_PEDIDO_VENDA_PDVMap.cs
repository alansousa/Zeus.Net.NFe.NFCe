using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nfe.Client.Tests.Models.Mapping
{
    public class PD_PEDIDO_VENDA_PDVMap : EntityTypeConfiguration<PD_PEDIDO_VENDA_PDV>
    {
        public PD_PEDIDO_VENDA_PDVMap()
        {
            // Primary Key
            this.HasKey(t => t.PDV_ID);

            // Properties
            this.Property(t => t.PDV_TIPO_PEDIDO)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PDV_TIPO_FRETE)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PDV_STATUS)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("PD_PEDIDO_VENDA_PDV");
            this.Property(t => t.PDV_ID).HasColumnName("PDV_ID");
            this.Property(t => t.PDV_DATA_INCLUSAO).HasColumnName("PDV_DATA_INCLUSAO");
            this.Property(t => t.PDV_TIPO_PEDIDO).HasColumnName("PDV_TIPO_PEDIDO");
            this.Property(t => t.PDV_EMPRESA).HasColumnName("PDV_EMPRESA");
            this.Property(t => t.PDV_VENDEDOR).HasColumnName("PDV_VENDEDOR");
            this.Property(t => t.PDV_PROJETO).HasColumnName("PDV_PROJETO");
            this.Property(t => t.PDV_CENTRO_CUSTO).HasColumnName("PDV_CENTRO_CUSTO");
            this.Property(t => t.PDV_CATEGORIA_PAGAMENTO).HasColumnName("PDV_CATEGORIA_PAGAMENTO");
            this.Property(t => t.PDV_TIPO_PAGAMENTO).HasColumnName("PDV_TIPO_PAGAMENTO");
            this.Property(t => t.PDV_CLIENTE).HasColumnName("PDV_CLIENTE");
            this.Property(t => t.PDV_TIPO_VENDA).HasColumnName("PDV_TIPO_VENDA");
            this.Property(t => t.PDV_FORMA_PAGTO).HasColumnName("PDV_FORMA_PAGTO");
            this.Property(t => t.PDV_DEPOSITO).HasColumnName("PDV_DEPOSITO");
            this.Property(t => t.PDV_TIPO_FRETE).HasColumnName("PDV_TIPO_FRETE");
            this.Property(t => t.PDV_NOTA_IMPORTACAO).HasColumnName("PDV_NOTA_IMPORTACAO");
            this.Property(t => t.PDV_NOTA_COMPLEMENTAR_IMPOSTOS).HasColumnName("PDV_NOTA_COMPLEMENTAR_IMPOSTOS");
            this.Property(t => t.PDV_LIBERADO_PIKING_USU_ID).HasColumnName("PDV_LIBERADO_PIKING_USU_ID");
            this.Property(t => t.PDV_LIBERADO_PIKING_DATA).HasColumnName("PDV_LIBERADO_PIKING_DATA");
            this.Property(t => t.PDV_OBSERVACAO_INTERNA).HasColumnName("PDV_OBSERVACAO_INTERNA");
            this.Property(t => t.PDV_OBSERVACAO_NOTA_FISCAL).HasColumnName("PDV_OBSERVACAO_NOTA_FISCAL");
            this.Property(t => t.PDV_USUARIO_INCLUSAO).HasColumnName("PDV_USUARIO_INCLUSAO");
            this.Property(t => t.PDV_VALOR_TOTAL).HasColumnName("PDV_VALOR_TOTAL");
            this.Property(t => t.PDV_STATUS).HasColumnName("PDV_STATUS");
            this.Property(t => t.PDV_VALOR_FRETE).HasColumnName("PDV_VALOR_FRETE");
            this.Property(t => t.PDV_VALOR_DESPESAS).HasColumnName("PDV_VALOR_DESPESAS");
            this.Property(t => t.PDV_ORIGEM).HasColumnName("PDV_ORIGEM");
            this.Property(t => t.PDV_LIBERADO_FATURAMENTO_USU_ID).HasColumnName("PDV_LIBERADO_FATURAMENTO_USU_ID");
            this.Property(t => t.PDV_LIBERADO_FATURAMENTO_DATA).HasColumnName("PDV_LIBERADO_FATURAMENTO_DATA");
            this.Property(t => t.PDV_CANCELADO_USU_ID).HasColumnName("PDV_CANCELADO_USU_ID");
            this.Property(t => t.PDV_CANCELADO_DATA).HasColumnName("PDV_CANCELADO_DATA");
            this.Property(t => t.PDV_NUMERO).HasColumnName("PDV_NUMERO");
            this.Property(t => t.PDV_TIPO_GERACAO).HasColumnName("PDV_TIPO_GERACAO");
            this.Property(t => t.CON_ID).HasColumnName("CON_ID");

            // Relationships
            this.HasRequired(t => t.CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_CATEGORIA_PAGAMENTO);
            this.HasRequired(t => t.CP_CONDICOES_PAGTO_CPA)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_FORMA_PAGTO);
            this.HasRequired(t => t.CP_TIPO_PAGAMENTO_TPG)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_TIPO_PAGAMENTO);
            this.HasRequired(t => t.ES_DEPOSITO_DPT)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_DEPOSITO);
            this.HasRequired(t => t.FA_VENDEDOR_VEN)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_VENDEDOR);
            this.HasRequired(t => t.GE_CENTRO_CUSTO_RECEITAS_CCR)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_CENTRO_CUSTO);
            this.HasRequired(t => t.GE_EMPRESA_EMP)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_EMPRESA);
            this.HasRequired(t => t.GE_PARCEIRO_NEGOCIO_PNE)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_CLIENTE);
            this.HasRequired(t => t.GE_PROJETO_PJO)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_PROJETO);
            this.HasRequired(t => t.GE_USUARIO_USU)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_USUARIO_INCLUSAO);
            this.HasOptional(t => t.GE_USUARIO_USU1)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV1)
                .HasForeignKey(d => d.PDV_LIBERADO_PIKING_USU_ID);
            this.HasRequired(t => t.PD_TIPO_VENDA_TPV)
                .WithMany(t => t.PD_PEDIDO_VENDA_PDV)
                .HasForeignKey(d => d.PDV_TIPO_VENDA);

        }
    }
}
