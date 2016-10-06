using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_TIPO_SERVICO_TSV
    {
        public GE_TIPO_SERVICO_TSV()
        {
            this.GE_CODIGO_SERVICO_CSV = new List<GE_CODIGO_SERVICO_CSV>();
        }

        public int TSV_ID { get; set; }
        public string TSV_DESCRICAO { get; set; }
        public virtual ICollection<GE_CODIGO_SERVICO_CSV> GE_CODIGO_SERVICO_CSV { get; set; }
    }
}
