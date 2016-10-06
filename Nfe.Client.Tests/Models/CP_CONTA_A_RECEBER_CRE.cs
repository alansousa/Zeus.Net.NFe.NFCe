using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class CP_CONTA_A_RECEBER_CRE
    {
        public int CRE_ID { get; set; }
        public string CRE_TITULO { get; set; }
        public string CRE_FATURA_NUMERO_NOTA { get; set; }
        public string CRE_FATURA_NUMERO_PARCELA { get; set; }
        public int CRE_PARCELA_REFINANCIAMENTO { get; set; }
        public System.DateTime CRE_DATA_EMISSAO { get; set; }
        public System.DateTime CRE_DATA_VENCIMENTO { get; set; }
        public Nullable<System.DateTime> CRE_DATA_PAGAMENTO { get; set; }
        public System.DateTime CRE_DATA_PREVISAO_PAGAMENTO { get; set; }
        public decimal CRE_VALOR { get; set; }
        public Nullable<decimal> CRE_DESCONTO { get; set; }
        public Nullable<decimal> CRE_ACRESCIMO { get; set; }
        public Nullable<decimal> CRE_PIS { get; set; }
        public Nullable<decimal> CRE_IR { get; set; }
        public Nullable<decimal> CRE_INSS { get; set; }
        public Nullable<decimal> CRE_ISS { get; set; }
        public Nullable<decimal> CRE_VALOR_TOTAL_LIQUIDO { get; set; }
        public string CRE_CODIGO_BARRAS_PAGAMENTO { get; set; }
        public int CRE_RECORRENTE { get; set; }
        public string CRE_OBSERVACOES { get; set; }
        public string CRE_MOTIVO_BAIXA_MANUAL { get; set; }
        public int CRE_CLIENTE { get; set; }
        public int CRE_PROJETO { get; set; }
        public int CRE_TIPO_DOCUMENTO { get; set; }
        public int CRE_CENTRO_CUSTO_RECEITA { get; set; }
        public int CRE_CATEGORIA_PAGAMENTO { get; set; }
        public int CRE_TIPO_PAGAMENTO { get; set; }
        public int CRE_POSICAO_TITULO { get; set; }
        public Nullable<int> CRE_CONTA_CORRENTE { get; set; }
        public int CRE_EMPRESA { get; set; }
        public int CRE_STATUS { get; set; }
        public Nullable<int> LCC_ID { get; set; }
        public Nullable<System.DateTime> CRE_DATA_VENCIMENTO_ORIGINAL { get; set; }
        public Nullable<decimal> CRE_PENALIDADE { get; set; }
        public Nullable<decimal> CRE_COFINS { get; set; }
        public Nullable<decimal> CRE_CSLL { get; set; }
        public Nullable<int> NFE_ID { get; set; }
        public virtual CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR { get; set; }
        public virtual CP_TIPO_PAGAMENTO_TPG CP_TIPO_PAGAMENTO_TPG { get; set; }
        public virtual GE_CENTRO_CUSTO_RECEITAS_CCR GE_CENTRO_CUSTO_RECEITAS_CCR { get; set; }
        public virtual GE_CONTA_CORRENTE_CTC GE_CONTA_CORRENTE_CTC { get; set; }
        public virtual GE_EMPRESA_EMP GE_EMPRESA_EMP { get; set; }
        public virtual GE_PARCEIRO_NEGOCIO_PNE GE_PARCEIRO_NEGOCIO_PNE { get; set; }
        public virtual GE_POSICAO_TITULO_POT GE_POSICAO_TITULO_POT { get; set; }
        public virtual GE_PROJETO_PJO GE_PROJETO_PJO { get; set; }
        public virtual GE_TIPO_DOCUMENTO_TDO GE_TIPO_DOCUMENTO_TDO { get; set; }
        public virtual GE_LANCAMENTOS_CONTA_CORRENTE_LCC GE_LANCAMENTOS_CONTA_CORRENTE_LCC { get; set; }
    }
}
