using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_IBGE_IBG
    {
        public GE_IBGE_IBG()
        {
            //this.FA_TRANSPORTADORA_TRA = new List<FA_TRANSPORTADORA_TRA>();
            //this.GE_CONTATO_PARCEIRO_CON = new List<GE_CONTATO_PARCEIRO_CON>();
            //this.GE_EMPRESA_ENDERECO_EEN = new List<GE_EMPRESA_ENDERECO_EEN>();
            //this.GE_ENDERECO_PARCEIRO_END = new List<GE_ENDERECO_PARCEIRO_END>();
        }

        public string IBG_CIDADE { get; set; }
        public string IBG_UF { get; set; }
        public string IBG_CODCID { get; set; }
        public string IBG_CODUF { get; set; }
        public string IBG_NOMEUF { get; set; }
        //public virtual ICollection<FA_TRANSPORTADORA_TRA> FA_TRANSPORTADORA_TRA { get; set; }
        //public virtual ICollection<GE_CONTATO_PARCEIRO_CON> GE_CONTATO_PARCEIRO_CON { get; set; }
        //public virtual ICollection<GE_EMPRESA_ENDERECO_EEN> GE_EMPRESA_ENDERECO_EEN { get; set; }
        //public virtual ICollection<GE_ENDERECO_PARCEIRO_END> GE_ENDERECO_PARCEIRO_END { get; set; }
    }
}
