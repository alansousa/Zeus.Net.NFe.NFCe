using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_PERFIL_USUARIO_PRU
    {
        public GE_PERFIL_USUARIO_PRU()
        {
            this.GE_USUARIO_USU = new List<GE_USUARIO_USU>();
            this.GE_ACTIONS_ACT = new List<GE_ACTIONS_ACT>();
        }

        public int PRU_ID { get; set; }
        public string PRU_NOME { get; set; }
        public virtual ICollection<GE_USUARIO_USU> GE_USUARIO_USU { get; set; }
        public virtual ICollection<GE_ACTIONS_ACT> GE_ACTIONS_ACT { get; set; }
    }
}
