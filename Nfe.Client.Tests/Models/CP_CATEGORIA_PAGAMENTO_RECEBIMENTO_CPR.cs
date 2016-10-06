using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR
    {
        public CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR()
        {
            this.CP_CATEGORIA_TIPO_CTP = new List<CP_CATEGORIA_TIPO_CTP>();
            this.CP_CONTA_A_PAGAR_CPA = new List<CP_CONTA_A_PAGAR_CPA>();
            this.CP_CONTA_A_RECEBER_CRE = new List<CP_CONTA_A_RECEBER_CRE>();
            this.CP_TIPO_PAGAMENTO_TPG = new List<CP_TIPO_PAGAMENTO_TPG>();
            this.ES_PEDIDO_DE_COMPRA_PDC = new List<ES_PEDIDO_DE_COMPRA_PDC>();
            this.FA_CONTRATO_TIPO_TCO = new List<FA_CONTRATO_TIPO_TCO>();
            this.PD_PEDIDO_VENDA_PDV = new List<PD_PEDIDO_VENDA_PDV>();
        }

        public int CPR_ID { get; set; }
        public string CPR_DESCRICAO { get; set; }
        public string CPR_TIPO { get; set; }
        public Nullable<int> CPR_ENDIVIDAMENTO { get; set; }
        public virtual ICollection<CP_CATEGORIA_TIPO_CTP> CP_CATEGORIA_TIPO_CTP { get; set; }
        public virtual ICollection<CP_CONTA_A_PAGAR_CPA> CP_CONTA_A_PAGAR_CPA { get; set; }
        public virtual ICollection<CP_CONTA_A_RECEBER_CRE> CP_CONTA_A_RECEBER_CRE { get; set; }
        public virtual ICollection<CP_TIPO_PAGAMENTO_TPG> CP_TIPO_PAGAMENTO_TPG { get; set; }
        public virtual ICollection<ES_PEDIDO_DE_COMPRA_PDC> ES_PEDIDO_DE_COMPRA_PDC { get; set; }
        public virtual ICollection<FA_CONTRATO_TIPO_TCO> FA_CONTRATO_TIPO_TCO { get; set; }
        public virtual ICollection<PD_PEDIDO_VENDA_PDV> PD_PEDIDO_VENDA_PDV { get; set; }
    }
}
