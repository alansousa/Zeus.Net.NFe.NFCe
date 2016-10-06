using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_CNAE_CNA
    {
        public GE_CNAE_CNA()
        {
            this.GE_EMPRESA_EMP = new List<GE_EMPRESA_EMP>();
        }

        public int CNA_ID { get; set; }
        public string CNA_NUM { get; set; }
        public string CNA_DESCRICAO { get; set; }
        public virtual ICollection<GE_EMPRESA_EMP> GE_EMPRESA_EMP { get; set; }
    }
}
