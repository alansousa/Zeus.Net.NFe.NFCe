using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class ES_DEPOSITO_DPT
    {
        public ES_DEPOSITO_DPT()
        {
            this.ES_ESTOQUE_EST = new List<ES_ESTOQUE_EST>();
            this.ES_ESTOQUE_MOVIMENTACAO_EMV = new List<ES_ESTOQUE_MOVIMENTACAO_EMV>();
            this.PD_PEDIDO_VENDA_PDV = new List<PD_PEDIDO_VENDA_PDV>();
        }

        public int DPT_ID { get; set; }
        public string DPT_DESCRICAO { get; set; }
        public bool DPT_DESATIVADO { get; set; }
        public decimal DPT_VALOR_FRETE { get; set; }
        public bool DPT_MATERIAL_USADO { get; set; }
        public decimal DPT_DESPESAS_ACESSORIAS { get; set; }
        public bool DPT_MOVIMENTA_ESTOQUE { get; set; }
        public bool DPT_CALCULA_CUSTO_MEDIO { get; set; }
        public Nullable<bool> DPT_DISPONIVEL_PARA_VENDA { get; set; }
        public virtual ICollection<ES_ESTOQUE_EST> ES_ESTOQUE_EST { get; set; }
        public virtual ICollection<ES_ESTOQUE_MOVIMENTACAO_EMV> ES_ESTOQUE_MOVIMENTACAO_EMV { get; set; }
        public virtual ICollection<PD_PEDIDO_VENDA_PDV> PD_PEDIDO_VENDA_PDV { get; set; }
    }
}
