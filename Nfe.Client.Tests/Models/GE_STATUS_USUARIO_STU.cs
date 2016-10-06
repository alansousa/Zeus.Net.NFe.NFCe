using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_STATUS_USUARIO_STU
    {
        public GE_STATUS_USUARIO_STU()
        {
            this.GE_USUARIO_USU = new List<GE_USUARIO_USU>();
        }

        public int STU_ID { get; set; }
        public string STU_NOME { get; set; }
        public virtual ICollection<GE_USUARIO_USU> GE_USUARIO_USU { get; set; }
    }
}
