using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_CONTRATO_TIPOS_SLA_TSL
    {
        public FA_CONTRATO_TIPOS_SLA_TSL()
        {
            this.FA_CONTRATO_SLA = new List<FA_CONTRATO_SLA>();
        }

        public int TSL_ID { get; set; }
        public string TSL_DESCRICAO { get; set; }
        public virtual ICollection<FA_CONTRATO_SLA> FA_CONTRATO_SLA { get; set; }
    }
}
