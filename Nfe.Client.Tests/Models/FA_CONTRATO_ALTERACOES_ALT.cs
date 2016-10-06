using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_CONTRATO_ALTERACOES_ALT
    {
        public int ALT_ID { get; set; }
        public System.DateTime ALT_DATA { get; set; }
        public string ALT_DESCRICAO { get; set; }
        public int CON_ID { get; set; }
        public virtual FA_CONTRATO_CON FA_CONTRATO_CON { get; set; }
    }
}
