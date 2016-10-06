using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class ES_COMPONENTE_KIT
    {
        public int ITE_ID { get; set; }
        public int ITE_ID_COMPONENTE { get; set; }
        public decimal KIT_QUANTIDADE { get; set; }
        public virtual ES_ITEM_ITE ES_ITEM_ITE { get; set; }
        public virtual ES_ITEM_ITE ES_ITEM_ITE1 { get; set; }
    }
}
