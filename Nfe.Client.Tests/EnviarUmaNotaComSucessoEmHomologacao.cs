using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nfe.Client.Tests
{
    [TestClass]
    public class EnviarUmaNotaComSucessoEmHomologacao
    {


        [TestMethod]
        public void EnviarNota()
        {
            var nota = "";



            try
            {
                #region Cria e Envia NFe

            //    var numero = Funcoes.InpuBox(this, "Criar e Enviar NFe", "Número da Nota:");
            //    if (string.IsNullOrEmpty(numero)) throw new Exception("O Número deve ser informado!");

            //    var lote = Funcoes.InpuBox(this, "Criar e Enviar NFe", "Id do Lote:");
            //    if (string.IsNullOrEmpty(lote)) throw new Exception("A Id do lote deve ser informada!");

            //    //_nfe = GetNf(Convert.ToInt32(numero), _configuracoes.CfgServico.ModeloDocumento,_configuracoes.CfgServico.VersaoNFeAutorizacao);
            //    _nfe.Assina(); //não precisa validar aqui, pois o lote será validado em ServicosNFe.NFeAutorizacao
            //    //A URL do QR-Code deve ser gerada em um objeto nfe já assinado, pois na URL vai o DigestValue que é gerado por ocasião da assinatura
            //    //_nfe.infNFeSupl = new infNFeSupl() { qrCode = _nfe.infNFeSupl.ObterUrlQrCode(_nfe, _configuracoes.ConfiguracaoCsc.CIdToken, _configuracoes.ConfiguracaoCsc.Csc) }; //Define a URL do QR-Code.
            //    var servicoNFe = new ServicosNFe(_configuracoes.CfgServico);
            //    var retornoEnvio = servicoNFe.NFeAutorizacao(Convert.ToInt32(lote), IndicadorSincronizacao.Assincrono, new List<Classes.NFe> { _nfe }, true/*Envia a mensagem compactada para a SEFAZ*/);

            //    TrataRetorno(retornoEnvio);

            //    #endregion
            //}
            //catch (Exception ex)
            //{
            //    if (!string.IsNullOrEmpty(ex.Message))
            //        Funcoes.Mensagem(ex.Message, "Erro", MessageBoxButton.OK);
            //}

        }
    }
}
