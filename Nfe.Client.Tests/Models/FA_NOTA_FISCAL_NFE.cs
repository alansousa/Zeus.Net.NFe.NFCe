using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_NOTA_FISCAL_NFE
    {
        public FA_NOTA_FISCAL_NFE()
        {
            this.FA_NOTA_FISCAL_ITENS_NFI = new List<FA_NOTA_FISCAL_ITENS_NFI>();
        }

        public int NFE_ID { get; set; }
        public int PDV_ID { get; set; }
        public int TTR_ID { get; set; }
        public Nullable<int> TRA_ID { get; set; }
        public decimal NFE_NUMERO { get; set; }
        public Nullable<decimal> NFE_VALOR_FRETE { get; set; }
        public Nullable<decimal> NFE_VALOR_DESPESAS { get; set; }
        public Nullable<int> TVO_ID { get; set; }
        public Nullable<decimal> NFE_QTD_VOLUMES { get; set; }
        public Nullable<decimal> NFE_PESO_LIQUIDO { get; set; }
        public Nullable<decimal> NFE_PESO_BRUTO { get; set; }
        public string NFE_OBSERVACAO { get; set; }
        public Nullable<decimal> NFE_VALOR_TOTAL { get; set; }
        public Nullable<decimal> NFE_VALOR_RETENCOES { get; set; }
        public Nullable<decimal> NFE_VALOR_LIQUIDO { get; set; }
        public Nullable<decimal> NFE_BC_ICMS { get; set; }
        public Nullable<decimal> NFE_VALOR_ICMS { get; set; }
        public Nullable<decimal> NFE_BC_ICMS_ST { get; set; }
        public Nullable<decimal> NFE_VALOR_ICMS_ST { get; set; }
        public Nullable<decimal> NFE_VALOR_TOTAL_PRODUTOS { get; set; }
        public Nullable<decimal> NFE_VALOR_IPI { get; set; }
        public Nullable<int> NFE_STATUS { get; set; }
        public string NFE_ARQUIVO_XML { get; set; }
        public Nullable<int> NFE_MODALIDADE_FRETE { get; set; }
        public string NFE_DI_NUMERO { get; set; }
        public Nullable<decimal> NFE_VALOR_II { get; set; }
        public Nullable<System.DateTime> NFE_DATA_REGISTRO { get; set; }
        public string NFE_LOCAL_DESEMBARQUE { get; set; }
        public string NFE_UF_DESEMBARQUE { get; set; }
        public Nullable<int> NFE_TP_VIA_TRANSP { get; set; }
        public Nullable<decimal> NFE_VALOR_AFRMM { get; set; }
        public Nullable<System.DateTime> NFE_DATA_EMISSAO { get; set; }
        public Nullable<int> NFE_CANCELADO_USU_ID { get; set; }
        public Nullable<System.DateTime> NFE_CANCELADO_DATA { get; set; }
        public string NFE_CANCELADO_MOTIVO { get; set; }
        public Nullable<int> NFE_ALTERACAO_OBS_USU_ID { get; set; }
        public Nullable<System.DateTime> NFE_ALTERACAO_OBS_DATA { get; set; }
        public Nullable<decimal> NFE_VALOR_RETENCOES_PCC { get; set; }
        public Nullable<decimal> NFE_VALOR_RETENCOES_IRRF { get; set; }
        public Nullable<decimal> NFE_VALOR_RETENCOES_INSS { get; set; }
        public virtual ICollection<FA_NOTA_FISCAL_ITENS_NFI> FA_NOTA_FISCAL_ITENS_NFI { get; set; }
        public virtual PD_PEDIDO_VENDA_PDV PD_PEDIDO_VENDA_PDV { get; set; }
        public virtual FA_TRANSPORTADORA_TRA FA_TRANSPORTADORA_TRA { get; set; }
        public virtual FA_TIPO_TRANSPORTE_TTR FA_TIPO_TRANSPORTE_TTR { get; set; }
        public virtual FA_TIPO_VOLUME_TVO FA_TIPO_VOLUME_TVO { get; set; }
    }
}
