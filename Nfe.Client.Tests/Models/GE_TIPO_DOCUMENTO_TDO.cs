using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_TIPO_DOCUMENTO_TDO
    {
        public GE_TIPO_DOCUMENTO_TDO()
        {
            this.CP_CONTA_A_RECEBER_CRE = new List<CP_CONTA_A_RECEBER_CRE>();
        }

        public int TDO_ID { get; set; }
        public string TDO_DESCRICAO { get; set; }
        public string TDO_CODIGO { get; set; }
        public virtual ICollection<CP_CONTA_A_RECEBER_CRE> CP_CONTA_A_RECEBER_CRE { get; set; }
    }
}
