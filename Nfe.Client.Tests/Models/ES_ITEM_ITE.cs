using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class ES_ITEM_ITE
    {
        public ES_ITEM_ITE()
        {
            this.ES_COMPONENTE_KIT = new List<ES_COMPONENTE_KIT>();
            this.ES_COMPONENTE_KIT1 = new List<ES_COMPONENTE_KIT>();
            this.ES_ESTOQUE_EST = new List<ES_ESTOQUE_EST>();
            this.ES_ESTOQUE_MOVIMENTACAO_EMV = new List<ES_ESTOQUE_MOVIMENTACAO_EMV>();
            this.ES_ITEM_CUSTO_MEDIO_ICM = new List<ES_ITEM_CUSTO_MEDIO_ICM>();
            this.FA_CONTRATO_PRODUTOS_CPR = new List<FA_CONTRATO_PRODUTOS_CPR>();
            this.FA_CONTRATO_TIPO_TCO = new List<FA_CONTRATO_TIPO_TCO>();
            this.PD_PEDIDO_ITEM_PIT = new List<PD_PEDIDO_ITEM_PIT>();
        }

        public int ITE_ID { get; set; }
        public string ITE_TIPO { get; set; }
        public string ITE_CODIGO { get; set; }
        public int SFI_ID { get; set; }
        public string ITE_DESCRICAO { get; set; }
        public string ITE_PART_NUMBER { get; set; }
        public Nullable<decimal> ITE_PRECO_VENDA { get; set; }
        public string ITE_UNID_MEDIDA { get; set; }
        public bool ITE_CTRL_NR_SERIE { get; set; }
        public Nullable<bool> ITE_INATIVO { get; set; }
        public string ITE_NCM { get; set; }
        public string ITE_CST { get; set; }
        public bool ITE_KIT { get; set; }
        public Nullable<decimal> ITE_PESO_BRUTO { get; set; }
        public Nullable<decimal> ITE_PESO_LIQUIDO { get; set; }
        public string ITE_ORIGEM { get; set; }
        public Nullable<bool> ITE_MOVIMENTA_ESTOQUE { get; set; }
        public Nullable<int> TSV_ID { get; set; }
        public Nullable<bool> ITE_VENDA_FRACIONADA { get; set; }
        public Nullable<int> ITE_ESTOQUE_MINIMO { get; set; }
        public Nullable<decimal> ITE_CUSTO_MEDIO { get; set; }
        public Nullable<decimal> ITE_CUSTO_FOB { get; set; }
        public virtual ICollection<ES_COMPONENTE_KIT> ES_COMPONENTE_KIT { get; set; }
        public virtual ICollection<ES_COMPONENTE_KIT> ES_COMPONENTE_KIT1 { get; set; }
        public virtual ICollection<ES_ESTOQUE_EST> ES_ESTOQUE_EST { get; set; }
        public virtual ICollection<ES_ESTOQUE_MOVIMENTACAO_EMV> ES_ESTOQUE_MOVIMENTACAO_EMV { get; set; }
        public virtual ICollection<ES_ITEM_CUSTO_MEDIO_ICM> ES_ITEM_CUSTO_MEDIO_ICM { get; set; }
        public virtual ES_SUB_FAMILIA_ITEM_SFI ES_SUB_FAMILIA_ITEM_SFI { get; set; }
        public virtual ICollection<FA_CONTRATO_PRODUTOS_CPR> FA_CONTRATO_PRODUTOS_CPR { get; set; }
        public virtual ICollection<FA_CONTRATO_TIPO_TCO> FA_CONTRATO_TIPO_TCO { get; set; }
        public virtual ICollection<PD_PEDIDO_ITEM_PIT> PD_PEDIDO_ITEM_PIT { get; set; }
    }
}
