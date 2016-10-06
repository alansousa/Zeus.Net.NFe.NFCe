using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_EMPRESA_ENDERECO_EEN
    {
        public int EEN_ID { get; set; }
        public string EEN_LOGRADOURO { get; set; }
        public string EEN_NUMERO { get; set; }
        public string EEN_COMPLEMENTO { get; set; }
        public string EEN_CEP { get; set; }
        public string EEN_BAIRRO { get; set; }
        public string EEN_UF { get; set; }
        public string EEN_MUNICIPIO { get; set; }
        public int EMP_ID { get; set; }
        public int TEN_ID { get; set; }
        public int PAI_ID { get; set; }
        public string IBG_CODCID { get; set; }
        public virtual GE_EMPRESA_EMP GE_EMPRESA_EMP { get; set; }
        public virtual GE_IBGE_IBG GE_IBGE_IBG { get; set; }
        public virtual GE_PAIS_PAI GE_PAIS_PAI { get; set; }
        public virtual GE_TIPO_ENDERECO_TEN GE_TIPO_ENDERECO_TEN { get; set; }
    }
}
