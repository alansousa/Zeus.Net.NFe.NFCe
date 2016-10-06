using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_POSICAO_TITULO_POT
    {
        public GE_POSICAO_TITULO_POT()
        {
            this.CP_CONTA_A_RECEBER_CRE = new List<CP_CONTA_A_RECEBER_CRE>();
        }

        public int POT_ID { get; set; }
        public string POT_DESCRICAO { get; set; }
        public virtual ICollection<CP_CONTA_A_RECEBER_CRE> CP_CONTA_A_RECEBER_CRE { get; set; }
    }
}
