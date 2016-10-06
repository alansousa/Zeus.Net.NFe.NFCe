using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class ES_ITEM_CUSTO_MEDIO_ICM
    {
        public int ICM_ID { get; set; }
        public System.DateTime ICM_DATA { get; set; }
        public decimal ICM_VALOR { get; set; }
        public int ICM_STATUS { get; set; }
        public int ITE_ID { get; set; }
        public int PNE_ID { get; set; }
        public int EMP_ID { get; set; }
        public virtual ES_ITEM_ITE ES_ITEM_ITE { get; set; }
        public virtual GE_EMPRESA_EMP GE_EMPRESA_EMP { get; set; }
        public virtual GE_PARCEIRO_NEGOCIO_PNE GE_PARCEIRO_NEGOCIO_PNE { get; set; }
    }
}
