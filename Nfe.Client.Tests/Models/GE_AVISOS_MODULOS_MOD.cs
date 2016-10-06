using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_AVISOS_MODULOS_MOD
    {
        public GE_AVISOS_MODULOS_MOD()
        {
            this.GE_AVISOS_AVI = new List<GE_AVISOS_AVI>();
        }

        public int MOD_ID { get; set; }
        public string MOD_DESCRICAO { get; set; }
        public virtual ICollection<GE_AVISOS_AVI> GE_AVISOS_AVI { get; set; }
    }
}
