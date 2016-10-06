using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_TIPO_CONTATO_TCO
    {
        public GE_TIPO_CONTATO_TCO()
        {
            this.GE_CONTATO_PARCEIRO_CON = new List<GE_CONTATO_PARCEIRO_CON>();
        }

        public int TCO_ID { get; set; }
        public string TCO_DESCRICAO { get; set; }
        public virtual ICollection<GE_CONTATO_PARCEIRO_CON> GE_CONTATO_PARCEIRO_CON { get; set; }
    }
}
