using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_ENDERECO_PARCEIRO_END
    {
        public int END_ID { get; set; }
        public int PNE_ID { get; set; }
        public int TEN_ID { get; set; }
        public string END_LOGRADOURO { get; set; }
        public string END_NUMERO { get; set; }
        public string END_COMPLEMENTO { get; set; }
        public string END_CEP { get; set; }
        public string END_BAIRRO { get; set; }
        public Nullable<int> PAI_ID { get; set; }
        public string END_UF { get; set; }
        public string END_MUNICIPIO { get; set; }
        public string IBG_CODCID { get; set; }
        public virtual GE_IBGE_IBG GE_IBGE_IBG { get; set; }
        public virtual GE_PAIS_PAI GE_PAIS_PAI { get; set; }
        public virtual GE_PARCEIRO_NEGOCIO_PNE GE_PARCEIRO_NEGOCIO_PNE { get; set; }
        public virtual GE_TIPO_ENDERECO_TEN GE_TIPO_ENDERECO_TEN { get; set; }
    }
}
