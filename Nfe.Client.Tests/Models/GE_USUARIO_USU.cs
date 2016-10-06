using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_USUARIO_USU
    {
        public GE_USUARIO_USU()
        {
            this.CP_CONTA_A_PAGAR_CPA = new List<CP_CONTA_A_PAGAR_CPA>();
            this.GE_AVISOS_AVI = new List<GE_AVISOS_AVI>();
            this.PD_PEDIDO_VENDA_PDV = new List<PD_PEDIDO_VENDA_PDV>();
            this.PD_PEDIDO_VENDA_PDV1 = new List<PD_PEDIDO_VENDA_PDV>();
        }

        public int USU_ID { get; set; }
        public string USU_LOGIN { get; set; }
        public string USU_SENHA { get; set; }
        public string USU_NOME { get; set; }
        public string USU_EMAIL { get; set; }
        public int USU_PRU_ID { get; set; }
        public int USU_STU_ID { get; set; }
        public virtual ICollection<CP_CONTA_A_PAGAR_CPA> CP_CONTA_A_PAGAR_CPA { get; set; }
        public virtual ICollection<GE_AVISOS_AVI> GE_AVISOS_AVI { get; set; }
        public virtual GE_PERFIL_USUARIO_PRU GE_PERFIL_USUARIO_PRU { get; set; }
        public virtual GE_STATUS_USUARIO_STU GE_STATUS_USUARIO_STU { get; set; }
        public virtual ICollection<PD_PEDIDO_VENDA_PDV> PD_PEDIDO_VENDA_PDV { get; set; }
        public virtual ICollection<PD_PEDIDO_VENDA_PDV> PD_PEDIDO_VENDA_PDV1 { get; set; }
    }
}
