using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class PD_PEDIDO_VENDA_PDV
    {
        public PD_PEDIDO_VENDA_PDV()
        {
            this.FA_NOTA_FISCAL_NFE = new List<FA_NOTA_FISCAL_NFE>();
            this.PD_PEDIDO_ITEM_PIT = new List<PD_PEDIDO_ITEM_PIT>();
        }

        public int PDV_ID { get; set; }
        public System.DateTime PDV_DATA_INCLUSAO { get; set; }
        public string PDV_TIPO_PEDIDO { get; set; }
        public int PDV_EMPRESA { get; set; }
        public int PDV_VENDEDOR { get; set; }
        public int PDV_PROJETO { get; set; }
        public int PDV_CENTRO_CUSTO { get; set; }
        public int PDV_CATEGORIA_PAGAMENTO { get; set; }
        public int PDV_TIPO_PAGAMENTO { get; set; }
        public int PDV_CLIENTE { get; set; }
        public int PDV_TIPO_VENDA { get; set; }
        public int PDV_FORMA_PAGTO { get; set; }
        public int PDV_DEPOSITO { get; set; }
        public string PDV_TIPO_FRETE { get; set; }
        public bool PDV_NOTA_IMPORTACAO { get; set; }
        public bool PDV_NOTA_COMPLEMENTAR_IMPOSTOS { get; set; }
        public Nullable<int> PDV_LIBERADO_PIKING_USU_ID { get; set; }
        public Nullable<System.DateTime> PDV_LIBERADO_PIKING_DATA { get; set; }
        public string PDV_OBSERVACAO_INTERNA { get; set; }
        public string PDV_OBSERVACAO_NOTA_FISCAL { get; set; }
        public int PDV_USUARIO_INCLUSAO { get; set; }
        public decimal PDV_VALOR_TOTAL { get; set; }
        public string PDV_STATUS { get; set; }
        public Nullable<decimal> PDV_VALOR_FRETE { get; set; }
        public Nullable<decimal> PDV_VALOR_DESPESAS { get; set; }
        public Nullable<int> PDV_ORIGEM { get; set; }
        public Nullable<int> PDV_LIBERADO_FATURAMENTO_USU_ID { get; set; }
        public Nullable<System.DateTime> PDV_LIBERADO_FATURAMENTO_DATA { get; set; }
        public Nullable<int> PDV_CANCELADO_USU_ID { get; set; }
        public Nullable<System.DateTime> PDV_CANCELADO_DATA { get; set; }
        public Nullable<int> PDV_NUMERO { get; set; }
        public Nullable<int> PDV_TIPO_GERACAO { get; set; }
        public Nullable<int> CON_ID { get; set; }
        public virtual CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR { get; set; }
        public virtual CP_CONDICOES_PAGTO_CPA CP_CONDICOES_PAGTO_CPA { get; set; }
        public virtual CP_TIPO_PAGAMENTO_TPG CP_TIPO_PAGAMENTO_TPG { get; set; }
        public virtual ES_DEPOSITO_DPT ES_DEPOSITO_DPT { get; set; }
        public virtual ICollection<FA_NOTA_FISCAL_NFE> FA_NOTA_FISCAL_NFE { get; set; }
        public virtual FA_VENDEDOR_VEN FA_VENDEDOR_VEN { get; set; }
        public virtual GE_CENTRO_CUSTO_RECEITAS_CCR GE_CENTRO_CUSTO_RECEITAS_CCR { get; set; }
        public virtual GE_EMPRESA_EMP GE_EMPRESA_EMP { get; set; }
        public virtual GE_PARCEIRO_NEGOCIO_PNE GE_PARCEIRO_NEGOCIO_PNE { get; set; }
        public virtual GE_PROJETO_PJO GE_PROJETO_PJO { get; set; }
        public virtual GE_USUARIO_USU GE_USUARIO_USU { get; set; }
        public virtual GE_USUARIO_USU GE_USUARIO_USU1 { get; set; }
        public virtual ICollection<PD_PEDIDO_ITEM_PIT> PD_PEDIDO_ITEM_PIT { get; set; }
        public virtual PD_TIPO_VENDA_TPV PD_TIPO_VENDA_TPV { get; set; }
    }
}
