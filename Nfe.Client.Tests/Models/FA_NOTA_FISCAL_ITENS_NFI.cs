using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_NOTA_FISCAL_ITENS_NFI
    {
        public int NFI_ID { get; set; }
        public int NFE_ID { get; set; }
        public int PIT_ID { get; set; }
        public Nullable<decimal> NFI_PIS_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_PIS_VALOR { get; set; }
        public Nullable<decimal> NFI_COFINS_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_COFINS_VALOR { get; set; }
        public Nullable<decimal> NFI_CSLL_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_CSLL_VALOR { get; set; }
        public Nullable<decimal> NFI_IRRF_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_IRRF_VALOR { get; set; }
        public Nullable<decimal> NFI_INSS_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_INSS_VALOR { get; set; }
        public Nullable<decimal> NFI_IPI_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_IPI_VALOR { get; set; }
        public Nullable<decimal> NFI_ICMS_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_ICMS_VALOR { get; set; }
        public Nullable<decimal> NFI_ISS_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_ISS_VALOR { get; set; }
        public string NFI_PRODUTO_DESCRICAO { get; set; }
        public Nullable<decimal> NFI_PRODUTO_QTDE { get; set; }
        public Nullable<decimal> NFI_PRODUTO_PRECO_UNITARIO { get; set; }
        public Nullable<decimal> NFI_PRODUTO_PRECO_TOTAL { get; set; }
        public Nullable<decimal> NFI_ICMS_ST_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_ICMS_ST_VALOR { get; set; }
        public Nullable<decimal> NFI_BC_ICMS { get; set; }
        public Nullable<decimal> NFI_BC_ICMS_ST { get; set; }
        public string NFI_CST_ICMS { get; set; }
        public string NFI_CST_IPI { get; set; }
        public Nullable<decimal> NFI_DIFAL_PORCENTAGEM { get; set; }
        public Nullable<decimal> NFI_BC { get; set; }
        public Nullable<decimal> NFI_II_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_II_VALOR { get; set; }
        public Nullable<int> NFI_NUMERO_SEQ_ADIC { get; set; }
        public Nullable<decimal> NFI_PIS_VALOR_RETENCAO { get; set; }
        public Nullable<decimal> NFI_COFINS_VALOR_RETENCAO { get; set; }
        public Nullable<decimal> NFI_CSLL_VALOR_RETENCAO { get; set; }
        public Nullable<decimal> NFI_IRRF_VALOR_RETENCAO { get; set; }
        public Nullable<decimal> NFI_INSS_VALOR_RETENCAO { get; set; }
        public Nullable<decimal> NFI_FRETE { get; set; }
        public Nullable<decimal> NFI_OUTRAS_DESPESAS { get; set; }
        public Nullable<decimal> NFI_ISS_RETENCAO_ALIQUOTA { get; set; }
        public Nullable<decimal> NFI_ISS_RETENCAO_VALOR { get; set; }
        public virtual FA_NOTA_FISCAL_NFE FA_NOTA_FISCAL_NFE { get; set; }
    }
}
