using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class CP_CATEGORIA_TIPO_CTP
    {
        public int CTP_ID { get; set; }
        public int CATEGORIA_ID { get; set; }
        public int TIPO_ID { get; set; }
        public virtual CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR CP_CATEGORIA_PAGAMENTO_RECEBIMENTO_CPR { get; set; }
        public virtual CP_TIPO_PAGAMENTO_TPG CP_TIPO_PAGAMENTO_TPG { get; set; }
    }
}
