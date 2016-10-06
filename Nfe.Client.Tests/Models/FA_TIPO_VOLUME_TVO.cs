using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_TIPO_VOLUME_TVO
    {
        public FA_TIPO_VOLUME_TVO()
        {
            this.FA_NOTA_FISCAL_NFE = new List<FA_NOTA_FISCAL_NFE>();
        }

        public int TVO_ID { get; set; }
        public string TVO_DESCRICAO { get; set; }
        public virtual ICollection<FA_NOTA_FISCAL_NFE> FA_NOTA_FISCAL_NFE { get; set; }
    }
}
