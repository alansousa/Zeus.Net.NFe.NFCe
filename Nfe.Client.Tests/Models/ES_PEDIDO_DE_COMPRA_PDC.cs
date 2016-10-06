using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class ES_PEDIDO_DE_COMPRA_PDC
    {
        public int PDC_ID { get; set; }
        public System.DateTime PDC_DATA_EMISSAO { get; set; }
        public System.DateTime PDC_DATA_PREVISAO_ENTREGA { get; set; }
        public string PDC_NUMERO_NOTA_FISCAL { get; set; }
        public string PDC_NUMERO_PDV_FORNECEDOR { get; set; }
        public decimal PDC_VALOR { get; set; }
        public Nullable<decimal> PDC_ACRESCIMO { get; set; }
        public Nullable<decimal> PDC_ABATIMENTO { get; set; }
        public Nullable<decimal> PDC_VALOR_TOTAL_LIQUIDO { get; set; }
        public Nullable<int> PDC_INCLUSAO_USUARIO { get; set; }
        public Nullable<System.DateTime> PDC_INCLUSAO_DATA { get; set; }
        public Nullable<int> PDC_LIBERACAO_USUARIO { get; set; }
        public Nullable<System.DateTime> PDC_LIBERACAO_DATA { get; set; }
        public Nullable<int> PDC_RECEBIMENTO_USUARIO { get; set; }
        public Nullable<System.DateTime> PDC_RECEBIMENTO_DATA { get; set; }
        public Nullable<int> PDC_FATURAMENTO_USUARIO { get; set; }
        public Nullable<System.DateTime> PDC_FATURAMENTO_DATA { get; set; }
        public int PDC_TIPO { get; set; }
        public int PDC_STATUS { get; set; }
        public string PDC_OBSERVACOES { get; set; }
        public int PDC_FORNECEDOR { get; set; }
        public int PDC_PROJETO { get; set; }
        public int PDC_CENTRO_CUSTO_RECEITA { get; set; }
        public int PDC_CATEGORIA_PAGAMENTO { get; set; }
        public int PDC_TIPO_PAGAMENTO { get; set; }
        public int PDC_EMPRESA { get; set; }
        public int PDC_CONTATO { get; set; }
        public int PDC_FORMA_PAGAMENTO { get; set; }
        public virtual CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR { get; set; }
        public virtual CP_CONDICOES_PAGTO_CPA CP_CONDICOES_PAGTO_CPA { get; set; }
        public virtual CP_TIPO_PAGAMENTO_TPG CP_TIPO_PAGAMENTO_TPG { get; set; }
        public virtual GE_CENTRO_CUSTO_RECEITAS_CCR GE_CENTRO_CUSTO_RECEITAS_CCR { get; set; }
        public virtual GE_CONTATO_PARCEIRO_CON GE_CONTATO_PARCEIRO_CON { get; set; }
        public virtual GE_EMPRESA_EMP GE_EMPRESA_EMP { get; set; }
        public virtual GE_PARCEIRO_NEGOCIO_PNE GE_PARCEIRO_NEGOCIO_PNE { get; set; }
        public virtual GE_PROJETO_PJO GE_PROJETO_PJO { get; set; }
    }
}
