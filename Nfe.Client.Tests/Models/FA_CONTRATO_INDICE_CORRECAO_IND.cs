using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_CONTRATO_INDICE_CORRECAO_IND
    {
        public FA_CONTRATO_INDICE_CORRECAO_IND()
        {
            this.FA_CONTRATO_CON = new List<FA_CONTRATO_CON>();
        }

        public int IND_ID { get; set; }
        public string IND_DESCRICAO { get; set; }
        public virtual ICollection<FA_CONTRATO_CON> FA_CONTRATO_CON { get; set; }
    }
}
