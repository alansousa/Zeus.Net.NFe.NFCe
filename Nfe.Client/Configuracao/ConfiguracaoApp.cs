using NFe.Classes.Informacoes.Emitente;
using NFe.Utils;
using NFe.Utils.Email;

namespace Nfe.Client.Configuracao
{
    public class ConfiguracaoApp
    {
        public ConfiguracaoApp(ConfiguracaoServico servico, emit empresaEmitente)
        {
            CfgServico = servico;
            Emitente = empresaEmitente;
            EnderecoEmitente = empresaEmitente.enderEmit;
            ConfiguracaoEmail = new ConfiguracaoEmail("email@dominio.com", "senha", "Envio de NFE", "", "smtp.dominio.com", 587, true, true);
            ConfiguracaoCsc = new ConfiguracaoCsc("000001", "");
        }

        public ConfiguracaoServico CfgServico { get; set; }

        public emit Emitente { get; set; }
        public enderEmit EnderecoEmitente { get; set; }
        public ConfiguracaoEmail ConfiguracaoEmail { get; set; }
        public ConfiguracaoCsc ConfiguracaoCsc { get; set; }

        /// <summary>
        ///     Salva os dados de CfgServico em um arquivo XML
        /// </summary>
        /// <param name="arquivo">Arquivo XML onde será salvo os dados</param>
        //public void SalvarParaAqruivo(string arquivo)
        //{
        //    var camposEmBranco = Funcoes.ObterPropriedadesEmBranco(CfgServico);

        //    var propinfo = Funcoes.ObterPropriedadeInfo(CfgServico, c => c.DiretorioSalvarXml);
        //    camposEmBranco.Remove(propinfo.Name);

        //    if (camposEmBranco.Count > 0)
        //        throw new Exception("Informe os dados abaixo antes de salvar as Configurações:" + Environment.NewLine + string.Join(", ", camposEmBranco.ToArray()));

        //    var dir = Path.GetDirectoryName(arquivo);
        //    if (dir != null && !Directory.Exists(dir))
        //    {
        //        throw new DirectoryNotFoundException("Diretório " + dir + " não encontrado!");
        //    }

        //    FuncoesXml.ClasseParaArquivoXml(this, arquivo);
        //}
    }
}