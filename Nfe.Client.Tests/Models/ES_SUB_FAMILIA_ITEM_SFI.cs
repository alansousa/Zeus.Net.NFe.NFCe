using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class ES_SUB_FAMILIA_ITEM_SFI
    {
        public ES_SUB_FAMILIA_ITEM_SFI()
        {
            this.ES_ITEM_ITE = new List<ES_ITEM_ITE>();
        }

        public int SFI_ID { get; set; }
        public int FAI_ID { get; set; }
        public string SFI_CODIGO { get; set; }
        public string SFI_DESCRICAO { get; set; }
        public Nullable<double> SFI_DESCONTO_MAX { get; set; }
        public Nullable<double> SFI_DESCONTO_MAX_REVENDA { get; set; }
        public int SFI_ULTIMO_SEQUENCIAL { get; set; }
        public virtual ES_FAMILIA_ITEM_FAI ES_FAMILIA_ITEM_FAI { get; set; }
        public virtual ICollection<ES_ITEM_ITE> ES_ITEM_ITE { get; set; }
    }
}
