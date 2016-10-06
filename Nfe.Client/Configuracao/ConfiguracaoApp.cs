using System.IO;
using NFe.AppTeste;
using NFe.AppTeste.Properties;
using NFe.Classes.Informacoes.Emitente;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Utils;
using NFe.Utils.Email;

namespace Nfe.Client.Configuracao
{
    public class ConfiguracaoApp
    {
        private ConfiguracaoServico _cfgServico;

        public ConfiguracaoApp()
        {
            CfgServico = ConfiguracaoServico.Instancia;
            CfgServico.tpAmb = TipoAmbiente.taHomologacao;
            CfgServico.tpEmis = TipoEmissao.teNormal;
            Emitente = new emit
            {
                CNPJ = "04238297000189",
                IE = "79278777",
                xNome = "3CORP TECHNOLOGY S.A",
                xFant = "3CORP TECHNOLOGY S/A INFRAESTRUTURA DE TELECOM",
                CRT = CRT.RegimeNormal,
            };
            EnderecoEmitente = new enderEmit
            {
                CEP = "27536025",
                cMun = 3304201,
                cPais = 1058,
                fone = 33883422,
                nro = "300",
                UF = "RJ",
                xBairro = "PARAISO",
                xCpl = "GALPÃO C D",
                xLgr = "AVENIDA DOUTOR TACITO VIANNA RODRIGUES",
                xMun = "RESENDE",
                xPais = "Brasil"
            };
            ConfiguracaoEmail = new ConfiguracaoEmail("email@dominio.com", "senha", "Envio de NFE", Resources.MensagemHtml, "smtp.dominio.com", 587, true, true);
            ConfiguracaoCsc = new ConfiguracaoCsc("000001", "");
        }

        public ConfiguracaoServico CfgServico
        {
            get
            {
                Funcoes.CopiarPropriedades(_cfgServico, ConfiguracaoServico.Instancia);
                return _cfgServico;
            }
            set
            {
                _cfgServico = value;
                Funcoes.CopiarPropriedades(value, ConfiguracaoServico.Instancia);
            }
        }

        public emit Emitente { get; set; }
        public enderEmit EnderecoEmitente { get; set; }
        public ConfiguracaoEmail ConfiguracaoEmail { get; set; }
        public ConfiguracaoCsc ConfiguracaoCsc { get; set; }

        /// <summary>
        ///     Salva os dados de CfgServico em um arquivo XML
        /// </summary>
        /// <param name="arquivo">Arquivo XML onde será salvo os dados</param>
        public void SalvarParaAqruivo(string arquivo)
        {
            var camposEmBranco = Funcoes.ObterPropriedadesEmBranco(CfgServico);

            var propinfo = Funcoes.ObterPropriedadeInfo(_cfgServico, c => c.DiretorioSalvarXml);
            camposEmBranco.Remove(propinfo.Name);

            if (camposEmBranco.Count > 0)
                throw new Exception("Informe os dados abaixo antes de salvar as Configurações:" + Environment.NewLine + string.Join(", ", camposEmBranco.ToArray()));

            var dir = Path.GetDirectoryName(arquivo);
            if (dir != null && !Directory.Exists(dir))
            {
                throw new DirectoryNotFoundException("Diretório " + dir + " não encontrado!");
            }

            FuncoesXml.ClasseParaArquivoXml(this, arquivo);
        }
    }
}