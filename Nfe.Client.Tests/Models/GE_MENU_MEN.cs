using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_MENU_MEN
    {
        public int MEN_ID { get; set; }
        public Nullable<int> MEN_PAI_ID { get; set; }
        public string MEN_CAPTION { get; set; }
        public string MEN_HINT { get; set; }
        public Nullable<int> ACT_ID { get; set; }
        public int MEN_ORDEM { get; set; }
        public virtual GE_ACTIONS_ACT GE_ACTIONS_ACT { get; set; }
    }
}
