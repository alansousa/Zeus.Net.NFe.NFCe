using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nfe.Client.Tests.Models;
using Nfe.Client.Configuracao;
using NFe.Classes;
using NFe.Classes.Informacoes.Emitente;
using NFe.Classes.Informacoes.Identificacao.Tipos;
using NFe.Classes.Servicos.Tipos;
using NFe.Servicos;
using NFe.Utils;
using NFe.Utils.NFe;

namespace Nfe.Client.Tests
{
    [TestClass]
    public class EnviarUmaNotaComSucessoEmHomologacao
    {
        PlexosContext db = new PlexosContext();
        private emit _empresaEmitente;
        private ConfiguracaoCertificado _certificado;
        private ConfiguracaoServico _servico;
        private ConfiguracaoApp _configuracao;

        [TestInitialize]
        public void Start()
        {
            var empresa = db.Set<GE_EMPRESA_EMP>()
                .Where(x => x.EMP_NOME_CURTO == "3CORP")
                .Include(x => x.GE_EMPRESA_ENDERECO_EEN)
                .ToList();

            _empresaEmitente = empresa
                .Select(y => new emit
                {
                    CRT = CRT.RegimeNormal,
                    CNPJ = y.EMP_CPNJ_CPF,
                    IE = y.EMP_IE,
                    xFant = y.EMP_NOME_FANTASIA,
                    xNome = y.EMP_RAZAO_SOCIAL,
                    enderEmit = new enderEmit
                    {
                        CEP = y.GE_EMPRESA_ENDERECO_EEN.FirstOrDefault().EEN_CEP,
                        UF = y.GE_EMPRESA_ENDERECO_EEN.FirstOrDefault().EEN_UF,
                        cMun = Convert.ToInt64(y.GE_EMPRESA_ENDERECO_EEN.FirstOrDefault().IBG_CODCID),
                        cPais = 1058,
                        fone = 33883422,
                        nro = y.GE_EMPRESA_ENDERECO_EEN.FirstOrDefault().EEN_NUMERO,
                        xBairro = y.GE_EMPRESA_ENDERECO_EEN.FirstOrDefault().EEN_BAIRRO,
                        xCpl = y.GE_EMPRESA_ENDERECO_EEN.FirstOrDefault().EEN_COMPLEMENTO,
                        xLgr = y.GE_EMPRESA_ENDERECO_EEN.FirstOrDefault().EEN_LOGRADOURO,
                        xMun = y.GE_EMPRESA_ENDERECO_EEN.FirstOrDefault().EEN_MUNICIPIO,
                        xPais = "Brasil"
                    }
                }).FirstOrDefault();

            _certificado = new ConfiguracaoCertificado();
            _servico = new ConfiguracaoServico(_certificado, TipoAmbiente.taHomologacao, TipoEmissao.teNormal, Estado.RJ);
            _configuracao = new ConfiguracaoApp(_servico, _empresaEmitente);
        }

        [TestMethod]
        public void EnviarNota()
        {
            var nota = "14539";
            var lote = 1;

            NFe.Classes.NFe _nfe = new NFe.Classes.NFe().CarregarDeArquivoXml("C:\\Users\\jonatas Landim\\Documents\\XMLs\\PRODUTOS_20160920_14539.xml");

            if (_empresaEmitente == null) throw new NullReferenceException("porrra consulta");


            _nfe.Assina(_servico);

            var servicoNFe = new ServicosNFe(_configuracao.CfgServico);
            var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(lote), IndicadorSincronizacao.Assincrono, new List<NFe.Classes.NFe> { _nfe }, true);

            Assert.AreEqual(retornoEnvio.RetornoCompletoStr, "bulbasauro");
        }

        [TestMethod]
        public void RetornoDoLote()
        {
            var recibo = "333002167559089";
            var servicoNFe = new ServicosNFe(_configuracao.CfgServico);
            var retornoRecibo = servicoNFe.NFeRetAutorizacao(recibo);

            Assert.AreEqual(retornoRecibo.RetornoCompletoStr, "");
        }
    }
}
