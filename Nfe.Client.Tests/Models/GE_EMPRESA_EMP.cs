using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_EMPRESA_EMP
    {
        public GE_EMPRESA_EMP()
        {
            this.CP_CONTA_A_PAGAR_CPA = new List<CP_CONTA_A_PAGAR_CPA>();
            this.CP_CONTA_A_RECEBER_CRE = new List<CP_CONTA_A_RECEBER_CRE>();
            this.ES_ESTOQUE_MOVIMENTACAO_EMV = new List<ES_ESTOQUE_MOVIMENTACAO_EMV>();
            this.ES_ITEM_CUSTO_MEDIO_ICM = new List<ES_ITEM_CUSTO_MEDIO_ICM>();
            this.ES_PEDIDO_DE_COMPRA_PDC = new List<ES_PEDIDO_DE_COMPRA_PDC>();
            this.FA_CONTRATO_CON = new List<FA_CONTRATO_CON>();
            this.GE_AVISOS_AVI = new List<GE_AVISOS_AVI>();
            this.GE_CONTA_CORRENTE_CTC = new List<GE_CONTA_CORRENTE_CTC>();
            this.GE_EMPRESA_ENDERECO_EEN = new List<GE_EMPRESA_ENDERECO_EEN>();
            this.PD_PEDIDO_VENDA_PDV = new List<PD_PEDIDO_VENDA_PDV>();
        }

        public int EMP_ID { get; set; }
        public string EMP_NOME_FANTASIA { get; set; }
        public string EMP_UF { get; set; }
        public Nullable<decimal> EMP_NUM_NF_VENDA { get; set; }
        public Nullable<decimal> EMP_NUM_NF_SERVICO { get; set; }
        public Nullable<decimal> EMP_NUM_NF_FATURA_LOCACAO { get; set; }
        public string EMP_IBG_CODIGO_CIDADE { get; set; }
        public string EMP_CERTIFICADO_NFE { get; set; }
        public string EMP_CERTIFICADO_NFE_SENHA { get; set; }
        public string EMP_DIRETORIO_XML { get; set; }
        public string EMP_DIRETORIO_XML_TEMP { get; set; }
        public string EMP_RAZAO_SOCIAL { get; set; }
        public string EMP_TELEFONE { get; set; }
        public string EMP_CELULAR { get; set; }
        public string EMP_EMAIL { get; set; }
        public string EMP_URL { get; set; }
        public string EMP_CPNJ_CPF { get; set; }
        public string EMP_IE { get; set; }
        public string EMP_IE_SUBSTITUICAO_TRIBUTARIA { get; set; }
        public string EMP_IM { get; set; }
        public string EMP_INSS { get; set; }
        public string EMP_SUFRAMA { get; set; }
        public Nullable<bool> EMP_SIMPLES { get; set; }
        public Nullable<int> EMP_REGIME_TRIBUTARIO { get; set; }
        public Nullable<int> CNA_ID { get; set; }
        public string EMP_NOME_CURTO { get; set; }
        public virtual ICollection<CP_CONTA_A_PAGAR_CPA> CP_CONTA_A_PAGAR_CPA { get; set; }
        public virtual ICollection<CP_CONTA_A_RECEBER_CRE> CP_CONTA_A_RECEBER_CRE { get; set; }
        public virtual ICollection<ES_ESTOQUE_MOVIMENTACAO_EMV> ES_ESTOQUE_MOVIMENTACAO_EMV { get; set; }
        public virtual ICollection<ES_ITEM_CUSTO_MEDIO_ICM> ES_ITEM_CUSTO_MEDIO_ICM { get; set; }
        public virtual ICollection<ES_PEDIDO_DE_COMPRA_PDC> ES_PEDIDO_DE_COMPRA_PDC { get; set; }
        public virtual ICollection<FA_CONTRATO_CON> FA_CONTRATO_CON { get; set; }
        public virtual ICollection<GE_AVISOS_AVI> GE_AVISOS_AVI { get; set; }
        public virtual GE_CNAE_CNA GE_CNAE_CNA { get; set; }
        public virtual ICollection<GE_CONTA_CORRENTE_CTC> GE_CONTA_CORRENTE_CTC { get; set; }
        public virtual ICollection<GE_EMPRESA_ENDERECO_EEN> GE_EMPRESA_ENDERECO_EEN { get; set; }
        public virtual ICollection<PD_PEDIDO_VENDA_PDV> PD_PEDIDO_VENDA_PDV { get; set; }
    }
}
