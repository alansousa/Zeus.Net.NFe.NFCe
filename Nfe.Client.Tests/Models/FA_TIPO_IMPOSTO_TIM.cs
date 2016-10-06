using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_TIPO_IMPOSTO_TIM
    {
        public FA_TIPO_IMPOSTO_TIM()
        {
            this.PD_TIPO_VENDA_TPV = new List<PD_TIPO_VENDA_TPV>();
        }

        public int TIM_ID { get; set; }
        public string TIM_DESCRICAO { get; set; }
        public bool TIM_ICMS { get; set; }
        public bool TIM_IPI { get; set; }
        public bool TIM_PIS { get; set; }
        public bool TIM_COFINS { get; set; }
        public bool TIM_CSLL { get; set; }
        public bool TIM_IRRF { get; set; }
        public bool TIM_INSS { get; set; }
        public string TIM_NF_OBS { get; set; }
        public virtual ICollection<PD_TIPO_VENDA_TPV> PD_TIPO_VENDA_TPV { get; set; }
    }
}
