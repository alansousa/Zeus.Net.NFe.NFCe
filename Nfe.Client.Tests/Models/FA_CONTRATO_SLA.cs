using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_CONTRATO_SLA
    {
        public int SLA_ID { get; set; }
        public int CON_ID { get; set; }
        public int TSL_ID { get; set; }
        public virtual FA_CONTRATO_CON FA_CONTRATO_CON { get; set; }
        public virtual FA_CONTRATO_TIPOS_SLA_TSL FA_CONTRATO_TIPOS_SLA_TSL { get; set; }
    }
}
