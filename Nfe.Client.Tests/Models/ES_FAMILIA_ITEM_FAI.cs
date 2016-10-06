using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class ES_FAMILIA_ITEM_FAI
    {
        public ES_FAMILIA_ITEM_FAI()
        {
            this.ES_SUB_FAMILIA_ITEM_SFI = new List<ES_SUB_FAMILIA_ITEM_SFI>();
        }

        public int FAI_ID { get; set; }
        public string FAI_CODIGO { get; set; }
        public string FAI_DESCRICAO { get; set; }
        public virtual ICollection<ES_SUB_FAMILIA_ITEM_SFI> ES_SUB_FAMILIA_ITEM_SFI { get; set; }
    }
}
