using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class ES_ESTOQUE_MOVIMENTACAO_EMV
    {
        public int EMV_ID { get; set; }
        public Nullable<decimal> EMV_QTDE { get; set; }
        public decimal EMV_PRECO_UNITARIO { get; set; }
        public System.DateTime EMV_DATA { get; set; }
        public string EMV_TIPO_OPERACAO { get; set; }
        public string EMV_NUMERO_NOTA { get; set; }
        public string EMV_OBSERVACOES { get; set; }
        public int PNE_ID { get; set; }
        public int EMP_ID { get; set; }
        public int ITE_ID { get; set; }
        public int DPT_ID { get; set; }
        public Nullable<int> USU_ID { get; set; }
        public Nullable<int> ENV_TIPO_MOVIMENTACAO { get; set; }
        public Nullable<int> NFE_ID { get; set; }
        public Nullable<decimal> EMV_SALDO { get; set; }
        public Nullable<decimal> EMV_CUSTO_MEDIO { get; set; }
        public virtual ES_DEPOSITO_DPT ES_DEPOSITO_DPT { get; set; }
        public virtual ES_ITEM_ITE ES_ITEM_ITE { get; set; }
        public virtual GE_EMPRESA_EMP GE_EMPRESA_EMP { get; set; }
        public virtual GE_PARCEIRO_NEGOCIO_PNE GE_PARCEIRO_NEGOCIO_PNE { get; set; }
    }
}
