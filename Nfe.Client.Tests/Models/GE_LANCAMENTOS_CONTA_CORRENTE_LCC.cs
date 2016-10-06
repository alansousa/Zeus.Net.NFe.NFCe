using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_LANCAMENTOS_CONTA_CORRENTE_LCC
    {
        public GE_LANCAMENTOS_CONTA_CORRENTE_LCC()
        {
            this.CP_CONTA_A_PAGAR_CPA = new List<CP_CONTA_A_PAGAR_CPA>();
            this.CP_CONTA_A_RECEBER_CRE = new List<CP_CONTA_A_RECEBER_CRE>();
            this.GE_LANCAMENTOS_CONTA_CORRENTE_LCC1 = new List<GE_LANCAMENTOS_CONTA_CORRENTE_LCC>();
            this.GE_LANCAMENTOS_CONTA_CORRENTE_LCC11 = new List<GE_LANCAMENTOS_CONTA_CORRENTE_LCC>();
        }

        public int LCC_ID { get; set; }
        public int CCE_ID { get; set; }
        public string LCC_HISTORICO { get; set; }
        public decimal LCC_VALOR { get; set; }
        public bool LCC_CONCILIADO { get; set; }
        public Nullable<int> LCC_ID_ESTORNADO { get; set; }
        public Nullable<int> LCC_ID_ORIGEM_TRANSFERENCIA { get; set; }
        public virtual ICollection<CP_CONTA_A_PAGAR_CPA> CP_CONTA_A_PAGAR_CPA { get; set; }
        public virtual ICollection<CP_CONTA_A_RECEBER_CRE> CP_CONTA_A_RECEBER_CRE { get; set; }
        public virtual GE_CONTA_CORRENTE_EXTRATO_CCE GE_CONTA_CORRENTE_EXTRATO_CCE { get; set; }
        public virtual ICollection<GE_LANCAMENTOS_CONTA_CORRENTE_LCC> GE_LANCAMENTOS_CONTA_CORRENTE_LCC1 { get; set; }
        public virtual GE_LANCAMENTOS_CONTA_CORRENTE_LCC GE_LANCAMENTOS_CONTA_CORRENTE_LCC2 { get; set; }
        public virtual ICollection<GE_LANCAMENTOS_CONTA_CORRENTE_LCC> GE_LANCAMENTOS_CONTA_CORRENTE_LCC11 { get; set; }
        public virtual GE_LANCAMENTOS_CONTA_CORRENTE_LCC GE_LANCAMENTOS_CONTA_CORRENTE_LCC3 { get; set; }
    }
}
