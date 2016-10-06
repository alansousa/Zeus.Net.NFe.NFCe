using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_CONTRATO_TIPO_TCO
    {
        public FA_CONTRATO_TIPO_TCO()
        {
            this.FA_CONTRATO_CON = new List<FA_CONTRATO_CON>();
        }

        public int TCO_ID { get; set; }
        public string TCO_DESCRICAO { get; set; }
        public int PJO_ID { get; set; }
        public int CCR_ID { get; set; }
        public int CPR_ID { get; set; }
        public int TPG_ID { get; set; }
        public int TPV_ID { get; set; }
        public int ITE_ID { get; set; }
        public virtual CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR { get; set; }
        public virtual CP_TIPO_PAGAMENTO_TPG CP_TIPO_PAGAMENTO_TPG { get; set; }
        public virtual ES_ITEM_ITE ES_ITEM_ITE { get; set; }
        public virtual ICollection<FA_CONTRATO_CON> FA_CONTRATO_CON { get; set; }
        public virtual GE_CENTRO_CUSTO_RECEITAS_CCR GE_CENTRO_CUSTO_RECEITAS_CCR { get; set; }
        public virtual GE_PROJETO_PJO GE_PROJETO_PJO { get; set; }
        public virtual PD_TIPO_VENDA_TPV PD_TIPO_VENDA_TPV { get; set; }
    }
}
