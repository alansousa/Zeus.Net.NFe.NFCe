using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class CP_CONDICOES_PAGTO_CPA
    {
        public CP_CONDICOES_PAGTO_CPA()
        {
            this.ES_PEDIDO_DE_COMPRA_PDC = new List<ES_PEDIDO_DE_COMPRA_PDC>();
            this.PD_PEDIDO_VENDA_PDV = new List<PD_PEDIDO_VENDA_PDV>();
        }

        public int CPA_ID { get; set; }
        public string CPA_DESCRICAO { get; set; }
        public byte CPA_QTDE_PAGAMENTOS { get; set; }
        public Nullable<byte> CPA_QTDE_DIAS_VENC_PRIM_PAG { get; set; }
        public byte CPA_INTERVALO_DIAS_ENTRE_PARC { get; set; }
        public virtual ICollection<ES_PEDIDO_DE_COMPRA_PDC> ES_PEDIDO_DE_COMPRA_PDC { get; set; }
        public virtual ICollection<PD_PEDIDO_VENDA_PDV> PD_PEDIDO_VENDA_PDV { get; set; }
    }
}
