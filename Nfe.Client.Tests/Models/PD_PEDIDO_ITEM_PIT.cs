using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class PD_PEDIDO_ITEM_PIT
    {
        public int PIT_ID { get; set; }
        public int PIT_PEDIDO { get; set; }
        public int PIT_PRODUTO { get; set; }
        public string PIT_DESCRICAO { get; set; }
        public int PIT_QUANTIDADE { get; set; }
        public decimal PIT_PRECO_UNITARIO { get; set; }
        public decimal PIT_PRECO_TOTAL { get; set; }
        public string PIT_CFOP { get; set; }
        public Nullable<decimal> PIT_FRETE { get; set; }
        public Nullable<decimal> PIT_OUTRAS_DESPESAS { get; set; }
        public virtual ES_ITEM_ITE ES_ITEM_ITE { get; set; }
        public virtual PD_PEDIDO_VENDA_PDV PD_PEDIDO_VENDA_PDV { get; set; }
    }
}
