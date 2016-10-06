using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class PD_TIPO_VENDA_TPV
    {
        public PD_TIPO_VENDA_TPV()
        {
            this.FA_CONTRATO_TIPO_TCO = new List<FA_CONTRATO_TIPO_TCO>();
            this.GE_PARCEIRO_NEGOCIO_PNE = new List<GE_PARCEIRO_NEGOCIO_PNE>();
            this.GE_PARCEIRO_NEGOCIO_PNE1 = new List<GE_PARCEIRO_NEGOCIO_PNE>();
            this.GE_PARCEIRO_NEGOCIO_PNE2 = new List<GE_PARCEIRO_NEGOCIO_PNE>();
            this.GE_PARCEIRO_NEGOCIO_PNE3 = new List<GE_PARCEIRO_NEGOCIO_PNE>();
            this.PD_PEDIDO_VENDA_PDV = new List<PD_PEDIDO_VENDA_PDV>();
        }

        public int TPV_ID { get; set; }
        public string TPV_NOME { get; set; }
        public bool TPV_MOVIMENTA_ESTOQUE { get; set; }
        public string TPV_ENTRADA_SAIDA { get; set; }
        public bool TPV_IMPORTACAO { get; set; }
        public bool TPV_EXPORTACAO { get; set; }
        public string TPV_CFOP_SAIDA_DENTRO_ESTADO { get; set; }
        public string TPV_CFOP_SAIDA_FORA_ESTADO { get; set; }
        public string TPV_CFOP_ENTRADA_DENTRO_ESTADO { get; set; }
        public string TPV_CFOP_ENTRADA_FORA_ESTADO { get; set; }
        public string TPV_CFOP_SAIDA_DENTRO_ESTADO_ST { get; set; }
        public string TPV_CFOP_SAIDA_FORA_ESTADO_ST { get; set; }
        public string TPV_CFOP_ENTRADA_DENTRO_ESTADO_ST { get; set; }
        public string TPV_CFOP_ENTRADA_FORA_ESTADO_ST { get; set; }
        public string TPV_CFOP_IMPORTACAO { get; set; }
        public string TPV_CFOP_EXPORTACAO { get; set; }
        public Nullable<int> TIM_ID { get; set; }
        public string TPV_OBSERVACAO_NOTA_FISCAL { get; set; }
        public Nullable<bool> TPV_SIMPLES_REMESSA { get; set; }
        public Nullable<bool> TPV_MOVIMENTACAO_FINANCEIRA { get; set; }
        public Nullable<bool> TPV_FATURA_LOCACAO { get; set; }
        public Nullable<bool> TPV_DEMONSTRACAO { get; set; }
        public bool TPV_NOTA_IMPORTACAO_AEREA { get; set; }
        public bool TPV_NOTA_IMPORTACAO_MARITIMA { get; set; }
        public bool TPV_TOTALIZA_IMPOSTOS_OBSERVACAO { get; set; }
        public string TPV_NOME_NF { get; set; }
        public virtual ICollection<FA_CONTRATO_TIPO_TCO> FA_CONTRATO_TIPO_TCO { get; set; }
        public virtual FA_TIPO_IMPOSTO_TIM FA_TIPO_IMPOSTO_TIM { get; set; }
        public virtual ICollection<GE_PARCEIRO_NEGOCIO_PNE> GE_PARCEIRO_NEGOCIO_PNE { get; set; }
        public virtual ICollection<GE_PARCEIRO_NEGOCIO_PNE> GE_PARCEIRO_NEGOCIO_PNE1 { get; set; }
        public virtual ICollection<GE_PARCEIRO_NEGOCIO_PNE> GE_PARCEIRO_NEGOCIO_PNE2 { get; set; }
        public virtual ICollection<GE_PARCEIRO_NEGOCIO_PNE> GE_PARCEIRO_NEGOCIO_PNE3 { get; set; }
        public virtual ICollection<PD_PEDIDO_VENDA_PDV> PD_PEDIDO_VENDA_PDV { get; set; }
    }
}
