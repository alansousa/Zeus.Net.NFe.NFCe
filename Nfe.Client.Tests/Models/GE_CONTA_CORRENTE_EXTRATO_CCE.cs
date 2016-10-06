using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_CONTA_CORRENTE_EXTRATO_CCE
    {
        public GE_CONTA_CORRENTE_EXTRATO_CCE()
        {
            this.GE_LANCAMENTOS_CONTA_CORRENTE_LCC = new List<GE_LANCAMENTOS_CONTA_CORRENTE_LCC>();
        }

        public int CCE_ID { get; set; }
        public int CTC_ID { get; set; }
        public System.DateTime CCE_DATA { get; set; }
        public bool CCE_FECHADO { get; set; }
        public virtual GE_CONTA_CORRENTE_CTC GE_CONTA_CORRENTE_CTC { get; set; }
        public virtual ICollection<GE_LANCAMENTOS_CONTA_CORRENTE_LCC> GE_LANCAMENTOS_CONTA_CORRENTE_LCC { get; set; }
    }
}
