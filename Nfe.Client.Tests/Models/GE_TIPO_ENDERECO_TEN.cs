using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_TIPO_ENDERECO_TEN
    {
        public GE_TIPO_ENDERECO_TEN()
        {
            this.GE_EMPRESA_ENDERECO_EEN = new List<GE_EMPRESA_ENDERECO_EEN>();
            this.GE_ENDERECO_PARCEIRO_END = new List<GE_ENDERECO_PARCEIRO_END>();
        }

        public int TEN_ID { get; set; }
        public string TEN_DESCRICAO { get; set; }
        public virtual ICollection<GE_EMPRESA_ENDERECO_EEN> GE_EMPRESA_ENDERECO_EEN { get; set; }
        public virtual ICollection<GE_ENDERECO_PARCEIRO_END> GE_ENDERECO_PARCEIRO_END { get; set; }
    }
}
