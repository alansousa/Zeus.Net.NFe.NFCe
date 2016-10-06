using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_PARAMETROS_IMPOSTOS_PIM
    {
        public FA_PARAMETROS_IMPOSTOS_PIM()
        {
            this.GE_PARCEIRO_NEGOCIO_PNE = new List<GE_PARCEIRO_NEGOCIO_PNE>();
            this.GE_PARCEIRO_NEGOCIO_PNE1 = new List<GE_PARCEIRO_NEGOCIO_PNE>();
            this.GE_PARCEIRO_NEGOCIO_PNE2 = new List<GE_PARCEIRO_NEGOCIO_PNE>();
            this.GE_PARCEIRO_NEGOCIO_PNE3 = new List<GE_PARCEIRO_NEGOCIO_PNE>();
        }

        public int PIM_ID { get; set; }
        public decimal PIM_PIS { get; set; }
        public decimal PIM_COFINS { get; set; }
        public decimal PIM_CSLL { get; set; }
        public decimal PIM_IRRF { get; set; }
        public decimal PIM_INSS { get; set; }
        public decimal PIM_VALOR_MIN_RETENCAO { get; set; }
        public int PIM_TIPO { get; set; }
        public virtual ICollection<GE_PARCEIRO_NEGOCIO_PNE> GE_PARCEIRO_NEGOCIO_PNE { get; set; }
        public virtual ICollection<GE_PARCEIRO_NEGOCIO_PNE> GE_PARCEIRO_NEGOCIO_PNE1 { get; set; }
        public virtual ICollection<GE_PARCEIRO_NEGOCIO_PNE> GE_PARCEIRO_NEGOCIO_PNE2 { get; set; }
        public virtual ICollection<GE_PARCEIRO_NEGOCIO_PNE> GE_PARCEIRO_NEGOCIO_PNE3 { get; set; }
    }
}
