using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class CP_CONTA_A_PAGAR_CPA__BACKUP
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
        public Nullable<decimal> CPA_JUROS { get; set; }
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
        public Nullable<decimal> CPA_MULTA { get; set; }
        public Nullable<decimal> CPA_COFINS { get; set; }
        public Nullable<decimal> CPA_CSLL { get; set; }
    }
}
