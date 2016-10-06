using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_CODIGO_SERVICO_CSV
    {
        public int CSV_ID { get; set; }
        public string CSV_CODIGO_SERVICO { get; set; }
        public string CSV_IBG_CODIGO_CIDADE { get; set; }
        public decimal CSV_ISS { get; set; }
        public int CSV_ISENTO { get; set; }
        public string CSV_DESCRICAO { get; set; }
        public int CSV_TIPO_SERVICO { get; set; }
        public virtual GE_TIPO_SERVICO_TSV GE_TIPO_SERVICO_TSV { get; set; }
    }
}
