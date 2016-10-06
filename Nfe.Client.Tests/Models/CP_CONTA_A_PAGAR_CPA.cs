using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class CP_CONTA_A_PAGAR_CPA
    {
        public int CPA_ID { get; set; }
        public int CPA_EMPRESA { get; set; }
        public string CPA_TITULO { get; set; }
        public int CPA_PEDIDO_DE_COMPRA { get; set; }
        public Nullable<int> CPA_PARCELA { get; set; }
        public Nullable<int> CPA_PARCELA_REFINANCIAMENTO { get; set; }
        public Nullable<int> CPA_LIBERADO_PAGAMENTO_USU_ID { get; set; }
        public Nullable<System.DateTime> CPA_LIBERADO_PAGAMENTO_DATA { get; set; }
        public decimal CPA_VALOR { get; set; }
        public System.DateTime CPA_DATA_EMISSAO { get; set; }
        public System.DateTime CPA_DATA_VENCIMENTO { get; set; }
        public Nullable<System.DateTime> CPA_DATA_PAGAMENTO { get; set; }
        public System.DateTime CPA_DATA_PREVISAO_PAGAMENTO { get; set; }
        public Nullable<decimal> CPA_DESCONTO { get; set; }
        public Nullable<decimal> CPA_ACRESCIMO { get; set; }
        public Nullable<decimal> CPA_PIS { get; set; }
        public Nullable<decimal> CPA_IR { get; set; }
        public Nullable<decimal> CPA_INSS { get; set; }
        public Nullable<decimal> CPA_ISS { get; set; }
        public Nullable<decimal> CPA_VALOR_TOTAL_LIQUIDO { get; set; }
        public string CPA_CODIGO_BARRAS_PAGAMENTO { get; set; }
        public int CPA_FORNECEDOR { get; set; }
        public int CPA_PROJETO { get; set; }
        public int CPA_CENTRO_CUSTO_RECEITA { get; set; }
        public int CPA_CATEGORIA_PAGAMENTO { get; set; }
        public int CPA_TIPO_PAGAMENTO { get; set; }
        public string CPA_OBSERVACOES { get; set; }
        public string CPA_MOTIVO_BAIXA_MANUAL { get; set; }
        public int CPA_STATUS { get; set; }
        public Nullable<int> LCC_ID { get; set; }
        public Nullable<System.DateTime> CPA_DATA_VENCIMENTO_ORIGINAL { get; set; }
        public Nullable<int> CPA_CONTA_CORRENTE { get; set; }
        public Nullable<decimal> CPA_COFINS { get; set; }
        public Nullable<decimal> CPA_CSLL { get; set; }
        public Nullable<int> CPA_TAXA_BANCARIA { get; set; }
        public Nullable<int> CPA_RECORRENTE { get; set; }
        public Nullable<int> CPA_RECORRENTE_FINALIZADO { get; set; }
        public string CPA_VINCULO_PARCELAS { get; set; }
        public string CPA_ENDIVIDAMENTO_CONTRATO { get; set; }
        public Nullable<System.DateTime> CPA_ENDIVIDAMENTO_DATA_CONTRATACAO { get; set; }
        public Nullable<System.DateTime> CPA_ENDIVIDAMENTO_DATA_VENCIMENTO { get; set; }
        public Nullable<decimal> CPA_ENDIVIDAMENTO_VALOR_CONTRATADO { get; set; }
        public string CPA_ENDIVIDAMENTO_TAXA { get; set; }
        public string CPA_ENDIVIDAMENTO_GARANTIAS { get; set; }
        public virtual CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR { get; set; }
        public virtual CP_TIPO_PAGAMENTO_TPG CP_TIPO_PAGAMENTO_TPG { get; set; }
        public virtual GE_CENTRO_CUSTO_RECEITAS_CCR GE_CENTRO_CUSTO_RECEITAS_CCR { get; set; }
        public virtual GE_EMPRESA_EMP GE_EMPRESA_EMP { get; set; }
        public virtual GE_PARCEIRO_NEGOCIO_PNE GE_PARCEIRO_NEGOCIO_PNE { get; set; }
        public virtual GE_PROJETO_PJO GE_PROJETO_PJO { get; set; }
        public virtual GE_USUARIO_USU GE_USUARIO_USU { get; set; }
        public virtual GE_CONTA_CORRENTE_CTC GE_CONTA_CORRENTE_CTC { get; set; }
        public virtual GE_LANCAMENTOS_CONTA_CORRENTE_LCC GE_LANCAMENTOS_CONTA_CORRENTE_LCC { get; set; }
    }
}
