using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_ACTIONS_ACT
    {
        public GE_ACTIONS_ACT()
        {
            this.GE_MENU_MEN = new List<GE_MENU_MEN>();
            this.GE_PERFIL_USUARIO_PRU = new List<GE_PERFIL_USUARIO_PRU>();
        }

        public int ACT_ID { get; set; }
        public string ACT_DESCRICAO { get; set; }
        public string ACT_CONTROLLER { get; set; }
        public string ACT_ACTION { get; set; }
        public Nullable<bool> ACT_PERMITE_TODOS { get; set; }
        public virtual ICollection<GE_MENU_MEN> GE_MENU_MEN { get; set; }
        public virtual ICollection<GE_PERFIL_USUARIO_PRU> GE_PERFIL_USUARIO_PRU { get; set; }
    }
}
