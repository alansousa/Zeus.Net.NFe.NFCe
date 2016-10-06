using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class ES_ESTOQUE_EST
    {
        public int EST_ID { get; set; }
        public Nullable<decimal> EST_QTDE { get; set; }
        public int ITE_ID { get; set; }
        public int DPT_ID { get; set; }
        public virtual ES_DEPOSITO_DPT ES_DEPOSITO_DPT { get; set; }
        public virtual ES_ITEM_ITE ES_ITEM_ITE { get; set; }
    }
}
