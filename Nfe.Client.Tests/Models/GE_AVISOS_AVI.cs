using System;
using System.Collections.Generic;

namespace Nfe.Client.Tests.Models
{
    public partial class GE_AVISOS_AVI
    {
        public int AVI_ID { get; set; }
        public System.DateTime AVI_DATA { get; set; }
        public string AVI_CAMPO_ALTERADO { get; set; }
        public string AVI_CONTEUDO_ANTERIOR { get; set; }
        public string AVI_CONTEUDO_ATUAL { get; set; }
        public int AVI_ENVIOU_EMAIL { get; set; }
        public int MOD_ID { get; set; }
        public int REGISTRO_ID { get; set; }
        public int PNE_ID { get; set; }
        public int USU_ID { get; set; }
        public int EMP_ID { get; set; }
        public virtual GE_AVISOS_MODULOS_MOD GE_AVISOS_MODULOS_MOD { get; set; }
        public virtual GE_EMPRESA_EMP GE_EMPRESA_EMP { get; set; }
        public virtual GE_PARCEIRO_NEGOCIO_PNE GE_PARCEIRO_NEGOCIO_PNE { get; set; }
        public virtual GE_USUARIO_USU GE_USUARIO_USU { get; set; }
    }
}
