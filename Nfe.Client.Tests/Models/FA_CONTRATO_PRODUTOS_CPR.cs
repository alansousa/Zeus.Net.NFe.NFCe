using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_CONTRATO_PRODUTOS_CPR
    {
        public int CPR_ID { get; set; }
        public int CPR_QTDE { get; set; }
        public Nullable<int> CPR_QTDE_PEDIDO_GERADO { get; set; }
        public int CON_ID { get; set; }
        public int ITE_ID { get; set; }
        public virtual ES_ITEM_ITE ES_ITEM_ITE { get; set; }
        public virtual FA_CONTRATO_CON FA_CONTRATO_CON { get; set; }
    }
}
