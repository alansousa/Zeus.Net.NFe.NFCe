using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_CONTATO_PARCEIRO_CON
    {
        public GE_CONTATO_PARCEIRO_CON()
        {
            this.ES_PEDIDO_DE_COMPRA_PDC = new List<ES_PEDIDO_DE_COMPRA_PDC>();
        }

        public int CON_ID { get; set; }
        public int PNE_ID { get; set; }
        public int TCO_ID { get; set; }
        public string CON_NOME { get; set; }
        public string CON_CARGO { get; set; }
        public string CON_DDD1 { get; set; }
        public string CON_TEL1 { get; set; }
        public string CON_RAMAL1 { get; set; }
        public string CON_DDD2 { get; set; }
        public string CON_TEL2 { get; set; }
        public string CON_RAMAL2 { get; set; }
        public string CON_CEL_DDD { get; set; }
        public string CON_CEL { get; set; }
        public Nullable<bool> CON_RECEBE_NFE { get; set; }
        public string CON_EMAIL { get; set; }
        public string CON_END_LOGRADOURO { get; set; }
        public string CON_END_NUMERO { get; set; }
        public string CON_END_COMPLEMENTO { get; set; }
        public string CON_END_CEP { get; set; }
        public string CON_END_BAIRRO { get; set; }
        public Nullable<int> PAI_ID { get; set; }
        public string CON_END_UF { get; set; }
        public string CON_END_MUNICIPIO { get; set; }
        public string IBG_CODCID { get; set; }
        public virtual ICollection<ES_PEDIDO_DE_COMPRA_PDC> ES_PEDIDO_DE_COMPRA_PDC { get; set; }
        public virtual GE_IBGE_IBG GE_IBGE_IBG { get; set; }
        public virtual GE_PAIS_PAI GE_PAIS_PAI { get; set; }
        public virtual GE_PARCEIRO_NEGOCIO_PNE GE_PARCEIRO_NEGOCIO_PNE { get; set; }
        public virtual GE_TIPO_CONTATO_TCO GE_TIPO_CONTATO_TCO { get; set; }
    }
}
