using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_TIPO_TRANSPORTE_TTR
    {
        public FA_TIPO_TRANSPORTE_TTR()
        {
            this.FA_NOTA_FISCAL_NFE = new List<FA_NOTA_FISCAL_NFE>();
            this.FA_TRANSPORTADORA_TRA = new List<FA_TRANSPORTADORA_TRA>();
        }

        public int TTR_ID { get; set; }
        public string TTR_DESCRICAO { get; set; }
        public virtual ICollection<FA_NOTA_FISCAL_NFE> FA_NOTA_FISCAL_NFE { get; set; }
        public virtual ICollection<FA_TRANSPORTADORA_TRA> FA_TRANSPORTADORA_TRA { get; set; }
    }
}
