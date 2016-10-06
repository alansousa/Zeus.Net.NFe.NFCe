using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_TRANSPORTADORA_TRA
    {
        public FA_TRANSPORTADORA_TRA()
        {
            this.FA_NOTA_FISCAL_NFE = new List<FA_NOTA_FISCAL_NFE>();
        }

        public int TRA_ID { get; set; }
        public string TRA_NOME { get; set; }
        public Nullable<short> TRA_TIPO_CONTRIBUINTE { get; set; }
        public string TRA_ENDERECO { get; set; }
        public string TRA_BAIRRO { get; set; }
        public string TRA_CEP { get; set; }
        public string TRA_UF { get; set; }
        public string TRA_MUNICIPIO { get; set; }
        public string IBG_COD_CID { get; set; }
        public string TRA_TELEFONE { get; set; }
        public string TRA_EMAIL { get; set; }
        public Nullable<decimal> TRA_CNPJ_CPF { get; set; }
        public string TRA_IE { get; set; }
        public Nullable<int> TTR_ID { get; set; }
        public virtual ICollection<FA_NOTA_FISCAL_NFE> FA_NOTA_FISCAL_NFE { get; set; }
        public virtual FA_TIPO_TRANSPORTE_TTR FA_TIPO_TRANSPORTE_TTR { get; set; }
        public virtual GE_IBGE_IBG GE_IBGE_IBG { get; set; }
    }
}
