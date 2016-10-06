using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_VENDEDOR_VEN
    {
        public FA_VENDEDOR_VEN()
        {
            this.PD_PEDIDO_VENDA_PDV = new List<PD_PEDIDO_VENDA_PDV>();
        }

        public int VEN_ID { get; set; }
        public string VEN_NOME { get; set; }
        public Nullable<decimal> VEN_COMISSAO_PRODUTOS { get; set; }
        public Nullable<decimal> VEN_COMISSAO_SERVICOS { get; set; }
        public Nullable<decimal> VEN_COMISSAO_LICENCAS { get; set; }
        public virtual ICollection<PD_PEDIDO_VENDA_PDV> PD_PEDIDO_VENDA_PDV { get; set; }
    }
}
