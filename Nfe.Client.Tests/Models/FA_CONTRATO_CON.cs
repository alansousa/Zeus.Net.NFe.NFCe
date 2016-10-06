using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class FA_CONTRATO_CON
    {
        public FA_CONTRATO_CON()
        {
            this.FA_CONTRATO_ADITIVOS_ADI = new List<FA_CONTRATO_ADITIVOS_ADI>();
            this.FA_CONTRATO_ALTERACOES_ALT = new List<FA_CONTRATO_ALTERACOES_ALT>();
            this.FA_CONTRATO_PRODUTOS_CPR = new List<FA_CONTRATO_PRODUTOS_CPR>();
            this.FA_CONTRATO_SLA = new List<FA_CONTRATO_SLA>();
        }

        public int CON_ID { get; set; }
        public string CON_NUMERO { get; set; }
        public string CON_NUMERO_CLIENTE { get; set; }
        public Nullable<decimal> CON_VALOR { get; set; }
        public System.DateTime CON_DATA_INICIO { get; set; }
        public int CON_DURACAO { get; set; }
        public Nullable<System.DateTime> CON_DATA_ULTIMA_RENOVACAO { get; set; }
        public Nullable<System.DateTime> CON_DATA_ULTIMO_VENCIMENTO { get; set; }
        public Nullable<System.DateTime> CON_DATA_ULTIMA_EMISSAO { get; set; }
        public int CON_BASE_INTERVALO { get; set; }
        public int CON_DIA_VENCIMENTO { get; set; }
        public int CON_INTERVALO_GERAR_BOLETO_DIAS { get; set; }
        public int CON_INTERVALO_GERAR_BOLETO_MESES { get; set; }
        public int CON_MESES_REJUSTAR { get; set; }
        public string CON_OBSERVACAO { get; set; }
        public string CON_OBSERVACAO_NOTA { get; set; }
        public string CON_CAMINHO_ARQUIVO_SERVIDOR { get; set; }
        public int CON_STATUS { get; set; }
        public int CON_CRIACAO_USU_ID { get; set; }
        public Nullable<System.DateTime> CON_CRIACAO_DATA { get; set; }
        public Nullable<int> CON_LIBERADO_REMESSA_ATENDIMENTO_USU_ID { get; set; }
        public Nullable<System.DateTime> CON_LIBERADO_REMESSA_ATENDIMENTO_DATA { get; set; }
        public Nullable<int> CON_LIBERADO_FATURAMENTO_USU_ID { get; set; }
        public Nullable<System.DateTime> CON_LIBERADO_FATURAMENTO_DATA { get; set; }
        public Nullable<int> CON_CANCELADO_USU_ID { get; set; }
        public Nullable<System.DateTime> CON_CANCELADO_DATA { get; set; }
        public string CON_CANCELADO_MOTIVO { get; set; }
        public int PNE_ID { get; set; }
        public int TCO_ID { get; set; }
        public int IND_ID { get; set; }
        public int CTC_ID { get; set; }
        public int EMP_ID { get; set; }
        public Nullable<int> CON_MESES { get; set; }
        public Nullable<int> CON_DIAS { get; set; }
        public virtual ICollection<FA_CONTRATO_ADITIVOS_ADI> FA_CONTRATO_ADITIVOS_ADI { get; set; }
        public virtual ICollection<FA_CONTRATO_ALTERACOES_ALT> FA_CONTRATO_ALTERACOES_ALT { get; set; }
        public virtual FA_CONTRATO_INDICE_CORRECAO_IND FA_CONTRATO_INDICE_CORRECAO_IND { get; set; }
        public virtual FA_CONTRATO_TIPO_TCO FA_CONTRATO_TIPO_TCO { get; set; }
        public virtual GE_CONTA_CORRENTE_CTC GE_CONTA_CORRENTE_CTC { get; set; }
        public virtual GE_EMPRESA_EMP GE_EMPRESA_EMP { get; set; }
        public virtual GE_PARCEIRO_NEGOCIO_PNE GE_PARCEIRO_NEGOCIO_PNE { get; set; }
        public virtual ICollection<FA_CONTRATO_PRODUTOS_CPR> FA_CONTRATO_PRODUTOS_CPR { get; set; }
        public virtual ICollection<FA_CONTRATO_SLA> FA_CONTRATO_SLA { get; set; }
    }
}
