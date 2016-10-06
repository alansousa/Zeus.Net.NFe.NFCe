using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_PARCEIRO_NEGOCIO_PNE
    {
        public GE_PARCEIRO_NEGOCIO_PNE()
        {
            this.CP_CONTA_A_PAGAR_CPA = new List<CP_CONTA_A_PAGAR_CPA>();
            this.CP_CONTA_A_RECEBER_CRE = new List<CP_CONTA_A_RECEBER_CRE>();
            this.ES_ESTOQUE_MOVIMENTACAO_EMV = new List<ES_ESTOQUE_MOVIMENTACAO_EMV>();
            this.ES_ITEM_CUSTO_MEDIO_ICM = new List<ES_ITEM_CUSTO_MEDIO_ICM>();
            this.ES_PEDIDO_DE_COMPRA_PDC = new List<ES_PEDIDO_DE_COMPRA_PDC>();
            this.FA_CONTRATO_CON = new List<FA_CONTRATO_CON>();
            this.GE_AVISOS_AVI = new List<GE_AVISOS_AVI>();
            this.GE_CONTATO_PARCEIRO_CON = new List<GE_CONTATO_PARCEIRO_CON>();
            this.GE_ENDERECO_PARCEIRO_END = new List<GE_ENDERECO_PARCEIRO_END>();
            this.PD_PEDIDO_VENDA_PDV = new List<PD_PEDIDO_VENDA_PDV>();
        }

        public int PNE_ID { get; set; }
        public int TPN_ID { get; set; }
        public int GPN_ID { get; set; }
        public short PNE_TIPO_CONTRIBUINTE { get; set; }
        public short PNE_CATEGORIA_PARCEIRO { get; set; }
        public string PNE_RAZAO_SOCIAL { get; set; }
        public string PNE_NOME_FANTASIA { get; set; }
        public Nullable<int> CNA_ID { get; set; }
        public Nullable<decimal> PNE_CPNJ_CPF { get; set; }
        public string PNE_IE { get; set; }
        public string PNE_IM { get; set; }
        public string PNE_IE_SUBSTITUICAO_TRIBUTARIA { get; set; }
        public Nullable<int> PAI_ID { get; set; }
        public string PNE_INSS { get; set; }
        public string PNE_SUFRAMA { get; set; }
        public Nullable<bool> PNE_SIMPLES { get; set; }
        public Nullable<int> PNE_ASSOCIADO_PNE_ID { get; set; }
        public Nullable<System.DateTime> PNE_DATA_ULTIMA_ATUALIZACAO { get; set; }
        public bool PNE_BLOQUEIO { get; set; }
        public Nullable<System.DateTime> PNE_DATA_BLOQUEIO { get; set; }
        public Nullable<int> PNE_USUARIO_BLOQUEIO { get; set; }
        public Nullable<int> VEN_ID { get; set; }
        public Nullable<int> CPA_ID { get; set; }
        public string PNE_OBS { get; set; }
        public string PNE_TELEFONE { get; set; }
        public string PNE_CELULAR { get; set; }
        public string PNE_EMAIL { get; set; }
        public string PNE_URL { get; set; }
        public Nullable<decimal> PNE_LIMITE_DESCONTO { get; set; }
        public Nullable<decimal> PNE_LIMITE_CREDITO { get; set; }
        public string PNE_NUM_BANCO { get; set; }
        public string PNE_NOME_BANCO { get; set; }
        public string PNE_AGENCIA { get; set; }
        public string PNE_AGENCIA_DIGITO { get; set; }
        public string PNE_CONTA_CORRENTE { get; set; }
        public string PNE_CONTA_CORRENTE_DIGITO { get; set; }
        public string CardCode { get; set; }
        public Nullable<int> TPV_ID_NF_VENDA { get; set; }
        public Nullable<int> PIM_ID_NF_VENDA { get; set; }
        public Nullable<int> TPV_ID_NF_SERVICO { get; set; }
        public Nullable<int> PIM_ID_NF_SERVICO { get; set; }
        public Nullable<int> TPV_ID_NF_LICENCA { get; set; }
        public Nullable<int> PIM_ID_NF_LICENCA { get; set; }
        public Nullable<int> TPV_ID_NF_FATURA_LOCACAO { get; set; }
        public Nullable<int> PIM_ID_NF_FATURA_LOCACAO { get; set; }
        public Nullable<decimal> ISS_SERVICO { get; set; }
        public Nullable<decimal> ISS_LICENCA { get; set; }
        public virtual ICollection<CP_CONTA_A_PAGAR_CPA> CP_CONTA_A_PAGAR_CPA { get; set; }
        public virtual ICollection<CP_CONTA_A_RECEBER_CRE> CP_CONTA_A_RECEBER_CRE { get; set; }
        public virtual ICollection<ES_ESTOQUE_MOVIMENTACAO_EMV> ES_ESTOQUE_MOVIMENTACAO_EMV { get; set; }
        public virtual ICollection<ES_ITEM_CUSTO_MEDIO_ICM> ES_ITEM_CUSTO_MEDIO_ICM { get; set; }
        public virtual ICollection<ES_PEDIDO_DE_COMPRA_PDC> ES_PEDIDO_DE_COMPRA_PDC { get; set; }
        public virtual ICollection<FA_CONTRATO_CON> FA_CONTRATO_CON { get; set; }
        public virtual FA_PARAMETROS_IMPOSTOS_PIM FA_PARAMETROS_IMPOSTOS_PIM { get; set; }
        public virtual FA_PARAMETROS_IMPOSTOS_PIM FA_PARAMETROS_IMPOSTOS_PIM1 { get; set; }
        public virtual FA_PARAMETROS_IMPOSTOS_PIM FA_PARAMETROS_IMPOSTOS_PIM2 { get; set; }
        public virtual FA_PARAMETROS_IMPOSTOS_PIM FA_PARAMETROS_IMPOSTOS_PIM3 { get; set; }
        public virtual ICollection<GE_AVISOS_AVI> GE_AVISOS_AVI { get; set; }
        public virtual ICollection<GE_CONTATO_PARCEIRO_CON> GE_CONTATO_PARCEIRO_CON { get; set; }
        public virtual ICollection<GE_ENDERECO_PARCEIRO_END> GE_ENDERECO_PARCEIRO_END { get; set; }
        public virtual PD_TIPO_VENDA_TPV PD_TIPO_VENDA_TPV { get; set; }
        public virtual PD_TIPO_VENDA_TPV PD_TIPO_VENDA_TPV1 { get; set; }
        public virtual PD_TIPO_VENDA_TPV PD_TIPO_VENDA_TPV2 { get; set; }
        public virtual PD_TIPO_VENDA_TPV PD_TIPO_VENDA_TPV3 { get; set; }
        public virtual ICollection<PD_PEDIDO_VENDA_PDV> PD_PEDIDO_VENDA_PDV { get; set; }
    }
}
