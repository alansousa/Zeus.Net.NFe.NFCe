using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_CONTA_CORRENTE_CTC
    {
        public GE_CONTA_CORRENTE_CTC()
        {
            this.CP_CONTA_A_PAGAR_CPA = new List<CP_CONTA_A_PAGAR_CPA>();
            this.CP_CONTA_A_RECEBER_CRE = new List<CP_CONTA_A_RECEBER_CRE>();
            this.FA_CONTRATO_CON = new List<FA_CONTRATO_CON>();
            this.GE_CONTA_CORRENTE_EXTRATO_CCE = new List<GE_CONTA_CORRENTE_EXTRATO_CCE>();
        }

        public int CTC_ID { get; set; }
        public string CTC_NUMERO { get; set; }
        public string CTC_AGENCIA { get; set; }
        public bool CTC_ATIVO { get; set; }
        public int CTC_EMPRESA { get; set; }
        public string CTC_BANCO_NUMERO { get; set; }
        public string CTC_BANCO_NOME { get; set; }
        public string CTC_BANCO_NOME_GERENTE { get; set; }
        public string CTC_BANCO_ENDERECO { get; set; }
        public string CTC_BANCO_BAIRRO { get; set; }
        public string CTC_BANCO_CIDADE { get; set; }
        public string CTC_BANCO_UF { get; set; }
        public string CTC_BANCO_TELEFONE { get; set; }
        public string CTC_BANCO_EMAIL { get; set; }
        public decimal CTC_LIMITE { get; set; }
        public Nullable<int> CTC_LIMITE_TIPO { get; set; }
        public string CTC_TAXA { get; set; }
        public string CTC_GARANTIAS { get; set; }
        public virtual ICollection<CP_CONTA_A_PAGAR_CPA> CP_CONTA_A_PAGAR_CPA { get; set; }
        public virtual ICollection<CP_CONTA_A_RECEBER_CRE> CP_CONTA_A_RECEBER_CRE { get; set; }
        public virtual ICollection<FA_CONTRATO_CON> FA_CONTRATO_CON { get; set; }
        public virtual GE_EMPRESA_EMP GE_EMPRESA_EMP { get; set; }
        public virtual ICollection<GE_CONTA_CORRENTE_EXTRATO_CCE> GE_CONTA_CORRENTE_EXTRATO_CCE { get; set; }
    }
}
