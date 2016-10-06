using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_PAIS_PAI
    {
        public GE_PAIS_PAI()
        {
            this.GE_CONTATO_PARCEIRO_CON = new List<GE_CONTATO_PARCEIRO_CON>();
            this.GE_EMPRESA_ENDERECO_EEN = new List<GE_EMPRESA_ENDERECO_EEN>();
            this.GE_ENDERECO_PARCEIRO_END = new List<GE_ENDERECO_PARCEIRO_END>();
        }

        public int PAI_ID { get; set; }
        public string PAI_ISO_2 { get; set; }
        public string PAI_ISO_3 { get; set; }
        public string PAI_NOME { get; set; }
        public virtual ICollection<GE_CONTATO_PARCEIRO_CON> GE_CONTATO_PARCEIRO_CON { get; set; }
        public virtual ICollection<GE_EMPRESA_ENDERECO_EEN> GE_EMPRESA_ENDERECO_EEN { get; set; }
        public virtual ICollection<GE_ENDERECO_PARCEIRO_END> GE_ENDERECO_PARCEIRO_END { get; set; }
    }
}
