using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_CONTRATO_ADITIVOS_ADI
    {
        public int ADI_ID { get; set; }
        public System.DateTime ADI_DATA { get; set; }
        public string ADI_DESCRICAO { get; set; }
        public int CON_ID { get; set; }
        public virtual FA_CONTRATO_CON FA_CONTRATO_CON { get; set; }
    }
}
