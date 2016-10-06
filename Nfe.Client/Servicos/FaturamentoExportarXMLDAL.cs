using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Xml;
using Plexos.DAL.Faturamento;
using Plexos.DAL.Geral;
using Plexos.DAL.Venda;
using Plexos.DTO.Entidades;
using Plexos.DTO.Faturamento;
using Plexos.DTO.Geral;
using Plexos.DAL;

namespace Nfe.Client.Servicos
{
    public class FaturamentoExportarXMLDAL : BaseDAL<FaturamentoExportarXMLDAL>
    {

        public static string msgLog;


        public List<FaturamentoExportarXMLDTO> Pesquisar(int? Id_Pesquisa, int? Empresa_Pesquisa,
            int? Cliente_Pesquisa, int? NumeroNFE_Pesquisa, int? Status_Pesquisa, string Tipo_Pesquisa,
            out bool existeProximaPagina, int pagina)
        {
            int itensPagina = 20;
            Int32.TryParse(ConfigurationManager.AppSettings["PesquisaItensPorPagina"], out itensPagina);

            int pular = (pagina <= 1) ? 0 : ((pagina - 1) * itensPagina);

            // traz um registro a mais para identificar se existe próxima página
            itensPagina = itensPagina + 1;


            using (ERPModel model = new ERPModel())
            {
                string qryFaturamentoExportarXML = "";



                qryFaturamentoExportarXML += "SELECT NFE_ID, CONVERT(VARCHAR, CONVERT(DATE, NFE_DATA_EMISSAO)) AS NFE_DATA_EMISSAO, ";
                qryFaturamentoExportarXML += "NFE.PDV_ID, NFE.TTR_ID, NFE.TRA_ID, EMP.EMP_ID, ";
                qryFaturamentoExportarXML += "NFE_NUMERO, NFE_VALOR_FRETE, NFE_VALOR_DESPESAS, ";
                qryFaturamentoExportarXML += "NFE.TVO_ID, NFE_QTD_VOLUMES, NFE_PESO_LIQUIDO, ";
                qryFaturamentoExportarXML += "NFE_PESO_BRUTO, NFE_OBSERVACAO, NFE_VALOR_TOTAL, ";
                qryFaturamentoExportarXML += "NFE_VALOR_RETENCOES, NFE_VALOR_LIQUIDO, NFE_STATUS, NFE_ARQUIVO_XML, ";
                qryFaturamentoExportarXML += "PNE.PNE_NOME_FANTASIA, PNE.PNE_RAZAO_SOCIAL, PNE.PNE_CPNJ_CPF, TTR.TTR_DESCRICAO, ";
                qryFaturamentoExportarXML += "TRA.TRA_NOME, TVO.TVO_DESCRICAO, EMP.EMP_NOME_FANTASIA, EMP.EMP_NOME_CURTO, TPV.TPV_NOME_NF AS TPV_NOME,  ";
                qryFaturamentoExportarXML += "TPV.TPV_ENTRADA_SAIDA, PDV_FORMA_PAGTO, PDV.PDV_CLIENTE, ";
                qryFaturamentoExportarXML += "NFE_BC_ICMS, NFE_VALOR_ICMS, NFE_BC_ICMS_ST, NFE_VALOR_ICMS_ST, NFE_VALOR_TOTAL_PRODUTOS, NFE_VALOR_IPI, ";
                qryFaturamentoExportarXML += "(SELECT SUM(NFI_PIS_VALOR) FROM FA_NOTA_FISCAL_ITENS_NFI NFI WHERE NFI.NFE_ID = NFE.NFE_ID) as vPIS, ";
                qryFaturamentoExportarXML += "(SELECT SUM(NFI_COFINS_VALOR) FROM FA_NOTA_FISCAL_ITENS_NFI NFI WHERE NFI.NFE_ID = NFE.NFE_ID) as vCOFINS, ";
                qryFaturamentoExportarXML += "NFE_MODALIDADE_FRETE, TRA.TRA_UF, TRA.TRA_MUNICIPIO, TRA.TRA_CNPJ_CPF, TRA.TRA_IE, PDV.PDV_DEPOSITO, ";
                qryFaturamentoExportarXML += "PDV.PDV_TIPO_PEDIDO, TPV_IMPORTACAO, ";
                qryFaturamentoExportarXML += "NFE_DI_NUMERO, NFE_VALOR_II, CONVERT(VARCHAR, CONVERT(DATE, NFE_DATA_REGISTRO)) AS NFE_DATA_REGISTRO, ";
                qryFaturamentoExportarXML += "NFE_LOCAL_DESEMBARQUE, NFE_UF_DESEMBARQUE, NFE_TP_VIA_TRANSP, NFE_VALOR_AFRMM, ";
                qryFaturamentoExportarXML += "TPV.TPV_FATURA_LOCACAO, ";
                qryFaturamentoExportarXML += "(CASE WHEN (PDV_TIPO_PEDIDO = 'P') THEN 'NF Produto' WHEN (PDV_TIPO_PEDIDO = 'L') THEN 'NF Licença' WHEN (PDV_TIPO_PEDIDO = 'S' AND TPV_FATURA_LOCACAO = 1) THEN 'FAT' WHEN (PDV_TIPO_PEDIDO = 'S' AND TPV_FATURA_LOCACAO = 0) THEN 'NF Serviço' END) AS TIPO_NOTA, ";

                qryFaturamentoExportarXML += "(SELECT USU_NOME FROM GE_USUARIO_USU USU WHERE USU.USU_ID = NFE.NFE_CANCELADO_USU_ID) AS CANCELADO_USUARIO, ";
                qryFaturamentoExportarXML += "CONVERT(CHAR, NFE_CANCELADO_DATA, 103) AS NFE_CANCELADO_DATA, ";
                qryFaturamentoExportarXML += "NFE_CANCELADO_MOTIVO, PDV.PDV_NUMERO ";

                qryFaturamentoExportarXML += "FROM FA_NOTA_FISCAL_NFE NFE INNER JOIN PD_PEDIDO_VENDA_PDV PDV ON PDV.PDV_ID = NFE.PDV_ID ";
                qryFaturamentoExportarXML += "INNER JOIN PD_TIPO_VENDA_TPV TPV ON TPV.TPV_ID = PDV.PDV_TIPO_VENDA ";
                qryFaturamentoExportarXML += "INNER JOIN GE_PARCEIRO_NEGOCIO_PNE PNE ON PNE.PNE_ID = PDV.PDV_CLIENTE ";
                qryFaturamentoExportarXML += "INNER JOIN FA_TIPO_TRANSPORTE_TTR TTR ON TTR.TTR_ID = NFE.TTR_ID ";
                qryFaturamentoExportarXML += "INNER JOIN FA_TRANSPORTADORA_TRA TRA ON TRA.TRA_ID = NFE.TRA_ID ";
                qryFaturamentoExportarXML += "INNER JOIN FA_TIPO_VOLUME_TVO TVO ON TVO.TVO_ID = NFE.TVO_ID ";
                qryFaturamentoExportarXML += "INNER JOIN GE_EMPRESA_EMP EMP ON EMP.EMP_ID = PDV.PDV_EMPRESA ";
                qryFaturamentoExportarXML += "WHERE NFE_NUMERO IS NOT NULL ";


                if (Id_Pesquisa != 0)
                    qryFaturamentoExportarXML += String.Format(" AND NFE_ID = '{0}' ", Id_Pesquisa);

                if (Empresa_Pesquisa != null)
                    qryFaturamentoExportarXML += String.Format(" AND PDV.PDV_EMPRESA = '{0}' ", Empresa_Pesquisa);

                if (Cliente_Pesquisa != null)
                    qryFaturamentoExportarXML += String.Format(" AND PDV.PDV_CLIENTE = '{0}' ", Cliente_Pesquisa);

                if (NumeroNFE_Pesquisa != null)
                    qryFaturamentoExportarXML += String.Format(" AND NFE_NUMERO = '{0}' ", NumeroNFE_Pesquisa);

                if (Status_Pesquisa != 3)
                    qryFaturamentoExportarXML += String.Format(" AND NFE_STATUS = '{0}' ", Status_Pesquisa);

                if (Tipo_Pesquisa != null)
                    qryFaturamentoExportarXML += String.Format(" AND (CASE WHEN (PDV_TIPO_PEDIDO = 'P') THEN 'NF Produto' WHEN (PDV_TIPO_PEDIDO = 'L') THEN 'NF Licença' WHEN (PDV_TIPO_PEDIDO = 'S' AND TPV_FATURA_LOCACAO = 1) THEN 'FAT' WHEN (PDV_TIPO_PEDIDO = 'S' AND TPV_FATURA_LOCACAO = 0) THEN 'NF Serviço' END) = '{0}' ", Tipo_Pesquisa);

                /*
                .Skip(pular)
                .Take(itensPagina)
                 * */

                //qryFaturamentoExportarXML.Skip(pular).Take(itensPagina);


                qryFaturamentoExportarXML += "ORDER BY NFE_ID DESC ";




                List<FaturamentoExportarXMLDTO> resultFaturamentoExportarXML = model.Database.SqlQuery<FaturamentoExportarXMLDTO>(qryFaturamentoExportarXML).Skip(pular).Take(itensPagina).ToList();
                //existeProximaPagina = false; //Pra resolver



                if (resultFaturamentoExportarXML.Count() == itensPagina)
                {
                    existeProximaPagina = true;
                    resultFaturamentoExportarXML.Remove(resultFaturamentoExportarXML.Last());
                }
                else
                {
                    existeProximaPagina = false;
                }



                return resultFaturamentoExportarXML;
            }
        }


        /// <summary>
        /// Método que altera o Status dos Títulos em Lote
        /// </summary>
        /// <param name="lstNFEsStatus">
        /// Código e Status Atual do Titulo  
        /// </param>
        /// <param name="codigoUsuario">
        /// Código do usuário que está fazendo a alteração (não é obrigatório)
        /// </param>
        /// <param name="dataStatus">
        /// Data em que o status está sendo alterado (não é obrigatório)
        /// </param>
        /// <param name="acao">
        /// GERAR
        /// REMOVER
        /// </param>
        /// <param name="ambiente">tipo de ambiente de envio da nota</param>
        /// <param name="xml">xml gerada</param>
        /// <returns>Verdadeiro ou Falso</returns>
        public string GerarXmlNFe(List<string> lstNFEsStatus, int? codigoUsuario, DateTime? dataStatus,
            int ambiente, out string xml)
        {
            using (ERPModel model = new ERPModel())
            {

                string retornoUpdate = "";

                string acao = lstNFEsStatus[0];


                XmlTextWriter writer;



                
                AuxiliaryLibrary lib = new AuxiliaryLibrary();

                lib.OpenConnection();


                //Cria todas as DTs
                DataTable dtNFE             = new DataTable();
                DataTable dtEmitente        = new DataTable();
                DataTable dtDestinatario    = new DataTable();
                DataTable dtItens           = new DataTable();


                foreach (string item in lstNFEsStatus)
                {

                    //Limpa as DTs
                    dtNFE.Clear();
                    dtEmitente.Clear();
                    dtDestinatario.Clear();
                    dtItens.Clear();
                        
                        
                    string[] arrNFEsStatus = item.Split('|');

                    if (arrNFEsStatus.Length < 2)
                        continue;


                    bool existeProximaPagina                    = false;
                    List<FaturamentoExportarXMLDTO> dadosNFe    = Instance
                        .Pesquisar(Convert.ToInt32(arrNFEsStatus[0]), null, null, null, 3, null, out existeProximaPagina, 0);


                    string diretorioXMLTemp     = "";
                    string diretorioXMLFinal    = "";




                    string versao = "3.10";
                    string verProc = "3.10.79";
                    string tpAmb = ambiente.ToString();// "1";
                    string tpImp = "1";
                    string cUF = "";
                    string AAMM = DateTime.Now.ToString("yyMM");
                    string mod = "55";
                    string serie = "1";
                    string nNF = "";
                    string nNF_Simples = "";
                    string tpEmis = "1";
                    string cNF = "";
                    string chaveNFe43 = "";
                    string chaveNFe = "";
                    string cDV = "";
                    string id = "";
                    string cMunFG = "";
                    string natOp = dadosNFe[0].TPV_NOME;
                    string tpNF = dadosNFe[0].TPV_ENTRADA_SAIDA;
                    string idDest = "1";



                    //Nota de Importacao
                    //bool NotaImportacao = (dadosNFe[0].TPV_IMPORTACAO == 1) ? true : false;
                    bool NotaImportacao = dadosNFe[0].TPV_IMPORTACAO;
                        




                    //Dados do Emitente
                    string qryEmitente = " SELECT EMP.EMP_ID, EMP_NOME_FANTASIA, EMP_UF, EMP_NUM_NF_VENDA, EMP_NUM_NF_SERVICO, ";
                    qryEmitente += " EMP_RAZAO_SOCIAL, EMP_TELEFONE, EMP_CELULAR, EMP_EMAIL, EMP_URL, EMP_CPNJ_CPF, EMP_IE, ";
                    qryEmitente += " EMP_IE_SUBSTITUICAO_TRIBUTARIA, EMP_IM, EMP_INSS, EMP_SUFRAMA, EMP_SIMPLES, EMP_REGIME_TRIBUTARIO, ";
                    qryEmitente += " EMP_CERTIFICADO_NFE, EMP_CERTIFICADO_NFE_SENHA, EMP_DIRETORIO_XML, EMP_DIRETORIO_XML_TEMP, ";
                    qryEmitente += " CNA.CNA_NUM, EEN_LOGRADOURO, EEN_NUMERO, EEN_COMPLEMENTO, EEN_CEP, EEN_BAIRRO, EEN_UF, EEN_MUNICIPIO, ";
                    qryEmitente += " EEN.IBG_CODCID, EEN.PAI_ID, PAI.PAI_NOME, ";
                    qryEmitente += " (SELECT TOP 1 IBG_CODUF FROM GE_IBGE_IBG IBG WHERE IBG.IBG_UF = EEN.EEN_UF) AS IBG_CODUF ";
                    qryEmitente += " FROM GE_EMPRESA_EMP EMP LEFT JOIN GE_CNAE_CNA CNA ON CNA.CNA_ID = EMP.CNA_ID ";
                    qryEmitente += " INNER JOIN GE_EMPRESA_ENDERECO_EEN EEN ON EEN.EMP_ID = EMP.EMP_ID ";
                    qryEmitente += " INNER JOIN GE_PAIS_PAI PAI ON PAI.PAI_ID = EEN.PAI_ID  ";
                    qryEmitente += " WHERE EEN.TEN_ID = 1 ";
                    qryEmitente += String.Format("AND EMP.EMP_ID = '{0}' ", dadosNFe[0].EMP_ID);

                    lib.CreateDT(dtEmitente, qryEmitente);

                    //Variáveis do Emitente
                    string emit_CNPJ = "";
                    string emit_xNome = "";
                    string emit_xFant = "";
                    string emit_xLgr = "";
                    string emit_nro = "";
                    string emit_xBairro = "";
                    string emit_cMun = "";
                    string emit_xMun = "";
                    string emit_UF = "";
                    string emit_CEP = "";
                    string emit_cPais = "";
                    string emit_xPais = "";
                    string emit_IE = "";
                    string emit_IM = "";
                    string emit_CNAE = "";
                    string emit_CRT = "";
                    string emit_Certificado = "";
                    string emit_CertificadoSenha = "";



                    if (dtEmitente.Rows.Count > 0)
                    {
                        try
                        {
                            emit_CNPJ = lib.AcertaCpfCnpj(Convert.ToDecimal(dtEmitente.Rows[0]["EMP_CPNJ_CPF"]), 1);
                            emit_xNome = ambiente ==1 ?  dtEmitente.Rows[0]["EMP_RAZAO_SOCIAL"].ToString().Trim() : "NF-E EMITIDA EM AMBIENTE DE HOMOLOGACAO - SEM VALOR FISCAL";
                            emit_xFant = dtEmitente.Rows[0]["EMP_NOME_FANTASIA"].ToString().Trim();
                            emit_xLgr = dtEmitente.Rows[0]["EEN_LOGRADOURO"].ToString().Trim();
                            emit_nro = dtEmitente.Rows[0]["EEN_NUMERO"].ToString().Trim();
                            emit_xBairro = dtEmitente.Rows[0]["EEN_BAIRRO"].ToString().Trim();
                            emit_cMun = dtEmitente.Rows[0]["IBG_CODCID"].ToString().Trim();
                            emit_xMun = dtEmitente.Rows[0]["EEN_MUNICIPIO"].ToString().Trim();
                            emit_UF = dtEmitente.Rows[0]["EEN_UF"].ToString();
                            emit_CEP = lib.RemoveCaracteresEspeciais(dtEmitente.Rows[0]["EEN_CEP"].ToString().Trim());
                            emit_cPais = "1058";
                            emit_xPais = dtEmitente.Rows[0]["PAI_NOME"].ToString().Trim();
                            emit_IE = lib.RemoveCaracteresEspeciais(dtEmitente.Rows[0]["EMP_IE"].ToString().Trim());
                            emit_IM = lib.RemoveCaracteresEspeciais(dtEmitente.Rows[0]["EMP_IM"].ToString().Trim());
                            emit_CNAE = lib.RemoveCaracteresEspeciais(dtEmitente.Rows[0]["CNA_NUM"].ToString().Trim());
                            emit_CRT = dtEmitente.Rows[0]["EMP_REGIME_TRIBUTARIO"].ToString().Trim();
                            emit_Certificado = dtEmitente.Rows[0]["EMP_CERTIFICADO_NFE"].ToString().Trim();
                            emit_CertificadoSenha = dtEmitente.Rows[0]["EMP_CERTIFICADO_NFE_SENHA"].ToString().Trim();
                            diretorioXMLTemp = dtEmitente.Rows[0]["EMP_DIRETORIO_XML_TEMP"].ToString().Trim();
                            diretorioXMLFinal = dtEmitente.Rows[0]["EMP_DIRETORIO_XML"].ToString().Trim();
                            cUF = dtEmitente.Rows[0]["IBG_CODUF"].ToString().Trim();
                            cMunFG = dtEmitente.Rows[0]["IBG_CODCID"].ToString().Trim();
                        }
                        catch (Exception ex)
                        {
                            //LOG
                            msgLog = "";
                            msgLog = string.Format("ERRO|Verifique os dados do Emitente.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                            msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                            msgLog += "\n" + "EMP_ID: " + dadosNFe[0].EMP_ID.ToString();
                            msgLog += "\n" + "SQL: " + qryEmitente;
                            msgLog += "\n" + ex.Message;
                            AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);
                            
                            
                            retornoUpdate = "ERRO|Verifique os dados do Emitente";

                            //return retornoUpdate;
                            continue;
                        }
                    }
                    else
                    {
                        //LOG
                        msgLog = "";
                        msgLog = string.Format("ERRO|Emitente não localizado.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                        msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                        msgLog += "\n" + "EMP_ID: " + dadosNFe[0].EMP_ID.ToString();
                        msgLog += "\n" + "SQL: " + qryEmitente;
                        AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);
                        
                        
                        retornoUpdate = "ERRO|Emitente não localizado";
                        continue;
                    }




                    if ((acao == "GERAR") && (arrNFEsStatus[1] == "0"))
                    {
                        //Campos "Chaves" na NFe
                        nNF = dadosNFe[0].NFE_NUMERO.ToString();
                        nNF_Simples = dadosNFe[0].NFE_NUMERO.ToString();
                        cNF = dadosNFe[0].NFE_NUMERO.ToString().PadLeft(8, '0');
                        chaveNFe43 = cUF + AAMM + emit_CNPJ + mod + (serie.PadLeft(3, '0')) + (nNF.PadLeft(9, '0')) + tpEmis + cNF;
                        cDV = lib.NFe_Modulo11(chaveNFe43);
                        chaveNFe = cUF + AAMM + emit_CNPJ + mod + (serie.PadLeft(3, '0')) + (nNF.PadLeft(9, '0')) + tpEmis + cNF + cDV;
                        id = "NFe" + chaveNFe; //Chave de Acesso
                            

                            
                        string indPag;

                        if(dadosNFe[0].PDV_FORMA_PAGTO == 4)
                            indPag = "0";
                        else if(dadosNFe[0].PDV_FORMA_PAGTO == 2 || dadosNFe[0].PDV_FORMA_PAGTO == 3)
                            indPag = "1";
                        else
                            indPag = "2";
                            
                    
                        

                        
                        //string dhEmi        = DateTime.Now.ToString("yyyy-MM-dd") + "T" + DateTime.Now.ToString("HH:mm:ss") + "-02:00";
                        string dhEmi        = dadosNFe[0].NFE_DATA_EMISSAO + "T" + DateTime.Now.ToString("HH:mm:ss") + "-02:00";
                        string dhSaiEnt     = dhEmi;

                


                        string finNFe;

                        if(dadosNFe[0].TPV_NOME.Contains("COMPLEMENTO"))
                            finNFe = "2";
                        else if(dadosNFe[0].TPV_NOME.Contains("CONSERTO"))
                            finNFe = "3";
                        else
                            finNFe = "1";




                        string indPres = "9"; //Operação não presencial, OUTROS
                        string procEmi = "3";




                        //Dados do Destinatario
                        string qryDestinatario = " SELECT PNE.PNE_ID, PNE.PNE_TIPO_CONTRIBUINTE, PNE_RAZAO_SOCIAL, PNE_CPNJ_CPF, PNE_IE, PNE_TELEFONE, ";
                        qryDestinatario += " CNA.CNA_NUM, END_LOGRADOURO, END_NUMERO, END_COMPLEMENTO, END_CEP, END_BAIRRO, END_UF, END_MUNICIPIO, ENDPARC.IBG_CODCID, ";
                        //qryDestinatario += " PAI_ID = CASE WHEN (SELECT PAI.PAI_ID FROM GE_PAIS_PAI PAI WHERE PAI.PAI_ID = ENDPARC.PAI_ID) IS NOT NULL THEN (SELECT PAI.PAI_ID FROM GE_PAIS_PAI PAI WHERE PAI.PAI_ID = ENDPARC.PAI_ID) WHEN (SELECT PAI.PAI_ID FROM GE_PAIS_PAI PAI WHERE PAI.PAI_ID = ENDPARC.PAI_ID) = 76 THEN '1058' ELSE '1058' END, ";
                        qryDestinatario += " '1058' AS PAI_ID, ";
                        qryDestinatario += " PAI_NOME = CASE WHEN (SELECT PAI.PAI_NOME FROM GE_PAIS_PAI PAI WHERE PAI.PAI_ID = ENDPARC.PAI_ID) IS NOT NULL THEN (SELECT PAI.PAI_NOME FROM GE_PAIS_PAI PAI WHERE PAI.PAI_ID = ENDPARC.PAI_ID) ELSE 'BRASIL' END, ";
                        qryDestinatario += " (SELECT TOP 1 IBG_CODUF FROM GE_IBGE_IBG IBG WHERE IBG.IBG_UF = ENDPARC.END_UF) AS IBG_CODUF, ";
                        qryDestinatario += " PNE.PNE_CATEGORIA_PARCEIRO ";
                        qryDestinatario += " FROM GE_PARCEIRO_NEGOCIO_PNE PNE LEFT JOIN GE_CNAE_CNA CNA ON CNA.CNA_ID = PNE.CNA_ID ";
                        qryDestinatario += " INNER JOIN GE_ENDERECO_PARCEIRO_END ENDPARC ON ENDPARC.PNE_ID = PNE.PNE_ID ";
                        qryDestinatario += " WHERE ENDPARC.TEN_ID = 1 ";
                        qryDestinatario += String.Format(" AND PNE.PNE_ID = '{0}' ", dadosNFe[0].PDV_CLIENTE);

                        lib.CreateDT(dtDestinatario, qryDestinatario);

                        //Variáveis do Destinatário
                        string dest_CNPJ = "";
                        string dest_xNome = "";
                        string dest_xLgr = "";
                        string dest_nro = "";
                        string dest_xBairro = "";
                        string dest_cMun = "";
                        string dest_xMun = "";
                        string dest_UF = "";
                        string dest_CEP = "";
                        string dest_cPais = "";
                        string dest_xPais = "";
                        string dest_fone = "";
                        string dest_indIEDest = "2";
                        string dest_IE = "";
                        string indFinal = "0";

                        if (dtDestinatario.Rows.Count > 0)
                        {

                            try
                            {
                                dest_CNPJ = lib.AcertaCpfCnpj(Convert.ToDecimal(dtDestinatario.Rows[0]["PNE_CPNJ_CPF"]), Convert.ToInt32(dtDestinatario.Rows[0]["PNE_TIPO_CONTRIBUINTE"]));
                                dest_xNome = dtDestinatario.Rows[0]["PNE_RAZAO_SOCIAL"].ToString().Trim();
                                dest_xLgr = dtDestinatario.Rows[0]["END_LOGRADOURO"].ToString().Trim();
                                dest_nro = dtDestinatario.Rows[0]["END_NUMERO"].ToString().Trim();
                                dest_xBairro = dtDestinatario.Rows[0]["END_BAIRRO"].ToString().Trim();
                                dest_cMun = dtDestinatario.Rows[0]["IBG_CODCID"].ToString().Trim();




                                if (dtDestinatario.Rows[0]["PAI_NOME"].ToString().Trim() == "França" || dtDestinatario.Rows[0]["PAI_NOME"].ToString().Trim() == "China")
                                {
                                    dest_xMun   = "Exterior";
                                    dest_UF     = "EX";
                                }
                                else
                                {
                                    dest_xMun   = dtDestinatario.Rows[0]["END_MUNICIPIO"].ToString().Trim();
                                    dest_UF     = dtDestinatario.Rows[0]["END_UF"].ToString().Trim();
                                }

                                




                                dest_fone = lib.RemoveCaracteresEspeciais(lib.RemoveEspaco(dtDestinatario.Rows[0]["PNE_TELEFONE"].ToString().Trim()));
                                dest_CEP = lib.RemoveCaracteresEspeciais(lib.RemoveEspaco(dtDestinatario.Rows[0]["END_CEP"].ToString().Trim()));
                                
                                

                                if(dtDestinatario.Rows[0]["PAI_NOME"].ToString().Trim() == "França")
                                    dest_cPais = "2755";
                                else if (dtDestinatario.Rows[0]["PAI_NOME"].ToString().Trim() == "China")
                                    dest_cPais = "1600";
                                else
                                    dest_cPais = dtDestinatario.Rows[0]["PAI_ID"].ToString().Trim();



                                if (dtDestinatario.Rows[0]["PAI_NOME"].ToString().Trim() == "França")
                                    dest_xPais = "Franca";
                                else if (dtDestinatario.Rows[0]["PAI_NOME"].ToString().Trim() == "China")
                                    dest_xPais = "CHINA, REPUBLICA POPULAR";
                                else
                                    dest_xPais = dtDestinatario.Rows[0]["PAI_NOME"].ToString().Trim();

                                


                                if(NotaImportacao)
                                {
                                    dest_indIEDest = "9";
                                }
                                else
                                { 
                                    if (dtDestinatario.Rows[0]["PNE_IE"].ToString() == "Isento" || dtDestinatario.Rows[0]["PNE_IE"].ToString() == "ISENTO")
                                    {
                                        dest_IE = "";
                                        dest_indIEDest = "2";
                                    }
                                    else if (dtDestinatario.Rows[0]["PNE_IE"].ToString() != "")
                                    {
                                        dest_IE = lib.RemoveCaracteresEspeciais(dtDestinatario.Rows[0]["PNE_IE"].ToString().Trim());
                                        dest_indIEDest = "1";
                                    }
                                }
                                /*
                                dest_indIEDest
                                    * Indicador da IE do Destinatário, informar:
                                1 - Contribuinte ICMS (informar a IE do destinatário);
                                2 - Contribuinte isento de Inscrição no cadastro de Contribuintes do ICMS;
                                9 - Não Contribuinte, que pode ou não possuir Inscrição Estadual no Cadastro de Contribuintes do ICMS.
                                Nota 1: No caso de NFC-e informar indIEDest=9 e não informar a tag IE do destinatário;
                                Nota 2: No caso de operação com o Exterior informar indIEDest=9 e não informar a tag IE do destinatário;
                                Nota 3: No caso de Contribuinte Isento de Inscrição (indIEDest=2), não informar a tag IE do destinatário.
                                (campo novo) [23-12-13]
                                    */


                                //PNE.PNE_CATEGORIA_PARCEIRO == 1) // Consumidor Final
                                indFinal = (dtDestinatario.Rows[0]["PNE_CATEGORIA_PARCEIRO"].ToString() == "1") ? "1" : "0";


                            }
                            catch (Exception ex)
                            {
                                //LOG
                                msgLog = "";
                                msgLog = string.Format("ERRO|Verifique os dados do Destinatário.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                                msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                                msgLog += "\n" + "PNE_ID: " + dadosNFe[0].PDV_CLIENTE.ToString();
                                msgLog += "\n" + "SQL: " + qryDestinatario;
                                msgLog += "\n" + ex.Message;
                                AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);
                                

                                retornoUpdate = "ERRO|Verifique os dados do Destinatário";
                                continue;
                            }
                        }
                        else
                        {
                            //LOG
                            msgLog = "";
                            msgLog = string.Format("ERRO|Destinatário não localizado.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                            msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                            msgLog += "\n" + "PNE_ID: " + dadosNFe[0].PDV_CLIENTE.ToString();
                            msgLog += "\n" + "SQL: " + qryDestinatario;
                            AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);
                            
                            
                            retornoUpdate = "ERRO|Destinatário não localizado";
                            continue;
                        }


                            

                        /*
                            * idDest e ela deve assumir um dos seguintes valores:
                            * 1 - Operação interna;
                            * 2 - Operação interestadual;
                            * 3 - Operação com exterior.
                            */
                        string listaSiglasUFs = "AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI, RJ, RN, RS, RO, RR, SC, SP, SE, TO";

                        if (NotaImportacao)
                        {
                            idDest = "3";
                        }
                        else
                        {
                            if (emit_UF == dest_UF)
                                idDest = "1";
                            else if (emit_UF != dest_UF)
                                idDest = "2";
                        }




                        //Criar o Arquivo XML
                            
                            
                        string nomeArquivoXMLTemp   = "PRODUTOS_" + DateTime.Now.ToString("yyyyMMdd") + "_" + dadosNFe[0].NFE_NUMERO + ".xml";
                        string xmlFinal             = diretorioXMLFinal + nomeArquivoXMLTemp;

                        writer = new XmlTextWriter(diretorioXMLTemp + nomeArquivoXMLTemp, null);

                        try
                        {
                            writer.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");
                        }
                        catch (Exception ex)
                        {
                            writer.Flush();
                            writer.Close();
                            writer.Dispose();



                            //LOG
                            msgLog = "";
                            msgLog = string.Format("ERRO|Erro ao gerar o arquivo XML, verifique manualmente dentro dos diretórios: '{0}' e {1}.....Hora: {2}.", diretorioXMLTemp, diretorioXMLFinal, DateTime.Now.ToString("HH:mm:ss"));
                            msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                            msgLog += "\n" + ex.Message;
                            AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);


                            retornoUpdate = lib.ApagarXML(diretorioXMLTemp, diretorioXMLFinal, dadosNFe[0].NFE_ARQUIVO_XML.ToString());
                                
                            retornoUpdate = String.Format(" ERRO|Erro ao gerar o arquivo XML, verifique manualmente dentro dos diretórios: '{0}' e {1} ", diretorioXMLTemp, diretorioXMLFinal);

                            //return retornoUpdate;
                            continue;
                        }






                        try
                        {
                            writer.WriteRaw("<NFe xmlns=\"http://www.portalfiscal.inf.br/nfe\">");
                            writer.WriteRaw("<infNFe Id=\"" + id + "\" versao=\"3.10\">");


                            //NÓ <IDE>
                            writer.WriteStartElement("ide");
                            writer.WriteElementString("cUF", cUF);
                            writer.WriteElementString("cNF", cNF);
                            writer.WriteElementString("natOp", natOp);
                            writer.WriteElementString("indPag", indPag);
                            writer.WriteElementString("mod", mod);
                            writer.WriteElementString("serie", serie);
                            writer.WriteElementString("nNF", nNF);
                            writer.WriteElementString("dhEmi", dhEmi);
                            writer.WriteElementString("dhSaiEnt", dhSaiEnt);
                            writer.WriteElementString("tpNF", tpNF);
                            writer.WriteElementString("idDest", idDest);
                            writer.WriteElementString("cMunFG", cMunFG);
                            writer.WriteElementString("tpImp", tpImp);
                            writer.WriteElementString("tpEmis", tpEmis);
                            writer.WriteElementString("cDV", cDV);
                            writer.WriteElementString("tpAmb", tpAmb);
                            writer.WriteElementString("finNFe", finNFe);
                            writer.WriteElementString("indFinal", indFinal);
                            writer.WriteElementString("indPres", indPres);
                            writer.WriteElementString("procEmi", procEmi);
                            writer.WriteElementString("verProc", verProc);
                            writer.WriteEndElement();





                            //NÓ <EMIT>
                            writer.WriteStartElement("emit");
                            writer.WriteElementString("CNPJ", emit_CNPJ);
                            writer.WriteElementString("xNome", emit_xNome);
                            writer.WriteElementString("xFant", emit_xFant);

                            writer.WriteStartElement("enderEmit");
                            writer.WriteElementString("xLgr", emit_xLgr);
                            writer.WriteElementString("nro", emit_nro);
                            writer.WriteElementString("xBairro", emit_xBairro);
                            writer.WriteElementString("cMun", emit_cMun);
                            writer.WriteElementString("xMun", emit_xMun);
                            writer.WriteElementString("UF", emit_UF);
                            writer.WriteElementString("CEP", emit_CEP);
                            writer.WriteElementString("cPais", emit_cPais);
                            writer.WriteElementString("xPais", emit_xPais);
                            writer.WriteEndElement();


                            if (emit_IE != "Isento" || emit_IE != "ISENTO" || emit_IE != "")
                                writer.WriteElementString("IE", emit_IE);

                            if (emit_IM != "")
                                writer.WriteElementString("IM", emit_IM);

                            if (emit_CNAE != "")
                                writer.WriteElementString("CNAE", emit_CNAE);


                            writer.WriteElementString("CRT", emit_CRT);

                            writer.WriteEndElement();






                            //NÓ <DEST>
                            writer.WriteStartElement("dest");

                            if(NotaImportacao)
                            {
                                writer.WriteElementString("idEstrangeiro", "");
                            }
                            else
                            {
                                if (Convert.ToInt32(dtDestinatario.Rows[0]["PNE_TIPO_CONTRIBUINTE"]) == 1)
                                    writer.WriteElementString("CNPJ", dest_CNPJ);
                                else if (Convert.ToInt32(dtDestinatario.Rows[0]["PNE_TIPO_CONTRIBUINTE"]) == 2)
                                    writer.WriteElementString("CPF", dest_CNPJ);
                            }


                            writer.WriteElementString("xNome", dest_xNome);

                            writer.WriteStartElement("enderDest");
                            writer.WriteElementString("xLgr", dest_xLgr);
                            writer.WriteElementString("nro", dest_nro);
                            writer.WriteElementString("xBairro", dest_xBairro);
                            
                            
                            if (NotaImportacao)
                            {
                                writer.WriteElementString("cMun", "9999999");
                                writer.WriteElementString("xMun", "Exterior");
                                writer.WriteElementString("UF", "EX");
                            }
                            else
                            {
                                writer.WriteElementString("cMun", dest_cMun);
                                writer.WriteElementString("xMun", dest_xMun);
                                writer.WriteElementString("UF", dest_UF);
                            }

                            writer.WriteElementString("CEP", dest_CEP);
                            writer.WriteElementString("cPais", dest_cPais);
                            writer.WriteElementString("xPais", dest_xPais);
                            writer.WriteElementString("fone", dest_fone);
                            writer.WriteEndElement();

                            writer.WriteElementString("indIEDest", dest_indIEDest);

                            if(!NotaImportacao)
                            { 
                                if (Convert.ToInt32(dest_indIEDest) == 1)
                                    writer.WriteElementString("IE", dest_IE);
                            }
                            writer.WriteEndElement();






                            //Dados dos Itens (produtos)
                            string qryItens = " SELECT NFI_ID, NFE_ID, NFI.PIT_ID, NFI_PIS_ALIQUOTA, NFI_PIS_VALOR, NFI_COFINS_ALIQUOTA, NFI_COFINS_VALOR, ";
                            qryItens += " NFI_CSLL_ALIQUOTA, NFI_CSLL_VALOR, NFI_IRRF_ALIQUOTA, NFI_IRRF_VALOR, NFI_INSS_ALIQUOTA, NFI_INSS_VALOR, ";
                            qryItens += " NFI_IPI_ALIQUOTA, NFI_IPI_VALOR, NFI_ICMS_ALIQUOTA, NFI_ICMS_VALOR, NFI_ISS_ALIQUOTA, NFI_ISS_VALOR, ";
                            qryItens += " NFI_PRODUTO_DESCRICAO, NFI_PRODUTO_QTDE, NFI_PRODUTO_PRECO_UNITARIO, NFI_PRODUTO_PRECO_TOTAL, ";
                            qryItens += " NFI_ICMS_ST_ALIQUOTA, NFI_ICMS_ST_VALOR, NFI_BC, NFI_BC_ICMS, NFI_BC_ICMS_ST, NFI_CST_ICMS, NFI_CST_IPI, ";
                            qryItens += " NFI_DIFAL_PORCENTAGEM, ITE.ITE_ID, ITE.ITE_UNID_MEDIDA, ITE.ITE_CODIGO, NCM.NCM_CODIGO, PIT.PIT_CFOP, ";
                            qryItens += " NFI_II_ALIQUOTA, NFI_II_VALOR, NFI_NUMERO_SEQ_ADIC, NFI_FRETE, NFI_OUTRAS_DESPESAS ";
                            qryItens += " FROM FA_NOTA_FISCAL_ITENS_NFI NFI INNER JOIN PD_PEDIDO_ITEM_PIT PIT ON PIT.PIT_ID = NFI.PIT_ID ";
                            qryItens += " INNER JOIN ES_ITEM_ITE ITE ON ITE.ITE_ID = PIT.PIT_PRODUTO ";
                            qryItens += " INNER JOIN FA_TIPI_NCM NCM ON NCM.NCM_CODIGO = ITE.ITE_NCM ";
                            qryItens += String.Format(" WHERE NFI.NFE_ID = '{0}' ", dadosNFe[0].NFE_ID);
                            qryItens += " ORDER BY NFI_ID ASC ";

                            lib.CreateDT(dtItens, qryItens);

                            if (dtItens.Rows.Count > 0)
                            {

                                try
                                {
                                    for (int i = 0; i <= dtItens.Rows.Count - 1; i++)
                                    {
                                        decimal? vBC_II = 0;

                                        if (dtItens.Rows[i]["NFI_PRODUTO_PRECO_TOTAL"].ToString() != "" && dtItens.Rows[i]["NFI_II_VALOR"].ToString() != "")
                                            vBC_II = Convert.ToDecimal(dtItens.Rows[i]["NFI_PRODUTO_PRECO_TOTAL"]) - Convert.ToDecimal(dtItens.Rows[i]["NFI_II_VALOR"]);
                                        
                                        
                                        writer.WriteRaw("<det nItem=\"" + (i + 1) + "\">");

                                        //SUB NÓ <prod>
                                        writer.WriteStartElement("prod");
                                        writer.WriteElementString("cProd", dtItens.Rows[i]["ITE_CODIGO"].ToString().Trim());
                                        writer.WriteElementString("cEAN", "");
                                        writer.WriteElementString("xProd", dtItens.Rows[i]["NFI_PRODUTO_DESCRICAO"].ToString().Trim());
                                        writer.WriteElementString("NCM", lib.RemoveCaracteresEspeciais(dtItens.Rows[i]["NCM_CODIGO"].ToString().Trim()));
                                        writer.WriteElementString("CFOP", dtItens.Rows[i]["PIT_CFOP"].ToString().Trim());
                                        writer.WriteElementString("uCom", dtItens.Rows[i]["ITE_UNID_MEDIDA"].ToString().Trim());
                                        writer.WriteElementString("qCom", lib.FormataValor(dtItens.Rows[i]["NFI_PRODUTO_QTDE"].ToString(), 4));
                                        writer.WriteElementString("vUnCom", lib.FormataValor(dtItens.Rows[i]["NFI_PRODUTO_PRECO_UNITARIO"].ToString(), 10));
                                        writer.WriteElementString("vProd", lib.FormataValor(dtItens.Rows[i]["NFI_PRODUTO_PRECO_TOTAL"].ToString(), 2));
                                        writer.WriteElementString("cEANTrib", "");
                                        writer.WriteElementString("uTrib", dtItens.Rows[i]["ITE_UNID_MEDIDA"].ToString());
                                        writer.WriteElementString("qTrib", lib.FormataValor(dtItens.Rows[i]["NFI_PRODUTO_QTDE"].ToString(), 4));
                                        writer.WriteElementString("vUnTrib", lib.FormataValor(dtItens.Rows[i]["NFI_PRODUTO_PRECO_UNITARIO"].ToString(), 10));


                                        ////Coloquei o frete no primeiro produto pra não ter que me preocupar com a divisão caso dê dízima
                                        //if ((i == 0) & (dadosNFe[0].NFE_VALOR_FRETE.ToString() != "0,000000" & dadosNFe[0].NFE_VALOR_DESPESAS.ToString() != "0,000000"))
                                        //{ 
                                        //    writer.WriteElementString("vFrete", lib.FormataValor(dadosNFe[0].NFE_VALOR_FRETE.ToString(), 2));
                                        //    writer.WriteElementString("vOutro", lib.FormataValor(dadosNFe[0].NFE_VALOR_DESPESAS.ToString(), 2));
                                        //}



                                        if (dtItens.Rows[i]["NFI_FRETE"].ToString() != "0,00")
                                            writer.WriteElementString("vFrete", lib.FormataValor(dtItens.Rows[i]["NFI_FRETE"].ToString(), 2));


                                        if (dtItens.Rows[i]["NFI_OUTRAS_DESPESAS"].ToString() != "0,00")
                                            writer.WriteElementString("vOutro", lib.FormataValor(dtItens.Rows[i]["NFI_OUTRAS_DESPESAS"].ToString(), 2));



                                        writer.WriteElementString("indTot", "1");



                                        if (NotaImportacao)
                                        {
                                            //SUB NÓ <DI>
                                            writer.WriteStartElement("DI");

                                            writer.WriteElementString("nDI", dadosNFe[0].NFE_DI_NUMERO.ToString().Trim());
                                            writer.WriteElementString("dDI", dadosNFe[0].NFE_DATA_REGISTRO.ToString().Trim());
                                            writer.WriteElementString("xLocDesemb", dadosNFe[0].NFE_LOCAL_DESEMBARQUE.ToString().Trim());
                                            writer.WriteElementString("UFDesemb", dadosNFe[0].NFE_UF_DESEMBARQUE.ToString().Trim());
                                            writer.WriteElementString("dDesemb", dadosNFe[0].NFE_DATA_REGISTRO.ToString().Trim());
                                            writer.WriteElementString("tpViaTransp", dadosNFe[0].NFE_TP_VIA_TRANSP.ToString().Trim());
                                            writer.WriteElementString("vAFRMM", lib.FormataValor(dadosNFe[0].NFE_VALOR_AFRMM.ToString(), 2));





                                            /*
                                            1=Importação por conta própria;
                                            2=Importação por conta e ordem;
                                            3=Importação por encomenda;
                                            */
                                            
                                            writer.WriteElementString("tpIntermedio", "1");
                                            writer.WriteElementString("cExportador", dadosNFe[0].PDV_CLIENTE.ToString().Trim());

                                            writer.WriteStartElement("adi"); //SUB NÓ <adi>
                                            writer.WriteElementString("nAdicao", (i + 1).ToString().Trim());
                                            writer.WriteElementString("nSeqAdic", dtItens.Rows[i]["NFI_NUMERO_SEQ_ADIC"].ToString().Trim());
                                            writer.WriteElementString("cFabricante", "-1");
                                            writer.WriteEndElement(); //FECHA SUB NÓ </adi>

                                            writer.WriteEndElement(); //FECHA SUB NÓ </DI>
                                        }
                                        


                                        writer.WriteEndElement(); //FECHA SUB NÓ <prod>


                                        
                                        //NÓ <imposto>
                                        writer.WriteStartElement("imposto");


                                        //SUB NÓ <ICMS>
                                        writer.WriteStartElement("ICMS");


                                        string icms_orig = "";
                                        icms_orig = dtItens.Rows[i]["NFI_CST_ICMS"].ToString().Substring(0, 1);

                                        string icms_cst = "";
                                        icms_cst = dtItens.Rows[i]["NFI_CST_ICMS"].ToString();




                                        //if (icms_cst == "000" || icms_cst == "100") //Tributado Integralmente
                                        if (dtItens.Rows[i]["NFI_ICMS_VALOR"].ToString() != "0,000000" && dtItens.Rows[i]["NFI_ICMS_ST_VALOR"].ToString() == "0,000000") //Tributado Integralmente
                                        {
                                            writer.WriteStartElement("ICMS00");
                                            writer.WriteElementString("orig", icms_orig);
                                            writer.WriteElementString("CST", "00");
                                            writer.WriteElementString("modBC", "3");
                                            writer.WriteElementString("vBC", lib.FormataValor(dtItens.Rows[i]["NFI_BC_ICMS"].ToString(), 2));
                                            writer.WriteElementString("pICMS", lib.FormataValor(dtItens.Rows[i]["NFI_ICMS_ALIQUOTA"].ToString(), 4));
                                            writer.WriteElementString("vICMS", lib.FormataValor(dtItens.Rows[i]["NFI_ICMS_VALOR"].ToString(), 2));
                                            writer.WriteEndElement();
                                        }
                                        //else if (icms_cst == "060" || icms_cst == "160") //Tributado por ST
                                        else if (dtItens.Rows[i]["NFI_ICMS_VALOR"].ToString() != "0,000000" && dtItens.Rows[i]["NFI_ICMS_ST_VALOR"].ToString() != "0,000000") //Tributado por ST
                                        {
                                            writer.WriteStartElement("ICMS10");
                                            writer.WriteElementString("orig", icms_orig);
                                            writer.WriteElementString("CST", "10");
                                            writer.WriteElementString("modBC", "3");
                                            writer.WriteElementString("vBC", lib.FormataValor(dtItens.Rows[i]["NFI_BC"].ToString(), 2));
                                            writer.WriteElementString("pICMS", lib.FormataValor(dtItens.Rows[i]["NFI_ICMS_ALIQUOTA"].ToString(), 4));
                                            writer.WriteElementString("vICMS", lib.FormataValor(dtItens.Rows[i]["NFI_ICMS_VALOR"].ToString(), 2));
                                            writer.WriteElementString("modBCST", "4");
                                            writer.WriteElementString("vBCST", lib.FormataValor(dtItens.Rows[i]["NFI_BC_ICMS_ST"].ToString(), 2));
                                            writer.WriteElementString("pICMSST", lib.FormataValor(dtItens.Rows[i]["NFI_ICMS_ST_ALIQUOTA"].ToString(), 4));
                                            writer.WriteElementString("vICMSST", lib.FormataValor(dtItens.Rows[i]["NFI_ICMS_ST_VALOR"].ToString(), 2));
                                            writer.WriteEndElement();
                                        }
                                        //else if (icms_cst == "041" || icms_cst == "141") //Não Tributado
                                        else if (dtItens.Rows[i]["NFI_ICMS_VALOR"].ToString() == "0,000000" && dtItens.Rows[i]["NFI_ICMS_ST_VALOR"].ToString() == "0,000000") //Não Tributado
                                        {
                                            writer.WriteStartElement("ICMS40");
                                            writer.WriteElementString("orig", icms_orig);
                                            writer.WriteElementString("CST", "50");
                                            writer.WriteEndElement();
                                        }
                                        else
                                        {
                                            writer.WriteStartElement("ICMS40");
                                            writer.WriteElementString("orig", icms_orig);
                                            writer.WriteElementString("CST", "41");
                                            writer.WriteEndElement();
                                        }

                                        writer.WriteEndElement();
                                        //FECHA SUB NÓ </ICMS>






                                        string BaseCalculoIpiCofinsPis = "";

                                        //Tributado por ST
                                        if (icms_cst == "060" || icms_cst == "160" || icms_cst == "100")
                                            BaseCalculoIpiCofinsPis = lib.FormataValor(dtItens.Rows[i]["NFI_PRODUTO_PRECO_TOTAL"].ToString(), 2);
                                        else if (icms_cst == "041" || icms_cst == "141")
                                            BaseCalculoIpiCofinsPis = lib.FormataValor(dtItens.Rows[i]["NFI_BC"].ToString(), 2);
                                        else
                                            BaseCalculoIpiCofinsPis = lib.FormataValor(dtItens.Rows[i]["NFI_BC_ICMS"].ToString(), 2);
                                            
                                            



                                        


                                        //SUB NÓ <IPI>
                                        writer.WriteStartElement("IPI");
                                        writer.WriteElementString("cEnq", "999");

                                        if (dtItens.Rows[i]["NFI_IPI_ALIQUOTA"].ToString() == "0,000000" && dtItens.Rows[i]["NFI_IPI_VALOR"].ToString() == "0,000000")
                                        {
                                            writer.WriteStartElement("IPINT");
                                            writer.WriteElementString("CST", "53");
                                            writer.WriteEndElement();
                                        }
                                        else
                                        {
                                            writer.WriteStartElement("IPITrib");
                                            
                                            if(!NotaImportacao)
                                                writer.WriteElementString("CST", "50");
                                            else
                                                writer.WriteElementString("CST", "00");


                                            writer.WriteElementString("vBC", BaseCalculoIpiCofinsPis);
                                            writer.WriteElementString("pIPI", lib.FormataValor(dtItens.Rows[i]["NFI_IPI_ALIQUOTA"].ToString(), 4));
                                            writer.WriteElementString("vIPI", lib.FormataValor(dtItens.Rows[i]["NFI_IPI_VALOR"].ToString(), 2));
                                            writer.WriteEndElement();
                                        }

                                        writer.WriteEndElement();
                                        //FECHA SUB NÓ </IPI>




                                        if (NotaImportacao)
                                        {
                                            //SUB NÓ <II>
                                            writer.WriteStartElement("II");
                                            writer.WriteElementString("vBC", lib.FormataValor(vBC_II.ToString(), 2));
                                            writer.WriteElementString("vDespAdu", "0.00");
                                            writer.WriteElementString("vII", lib.FormataValor(dtItens.Rows[i]["NFI_II_VALOR"].ToString(), 2));
                                            writer.WriteElementString("vIOF", "0.00");
                                            writer.WriteEndElement();
                                            //FECHA SUB NÓ </II>
                                        }
                                        





                                        //SUB NÓ <PIS>
                                        writer.WriteStartElement("PIS");

                                        string ipi_orig = "";
                                        ipi_orig = dtItens.Rows[i]["NFI_CST_IPI"].ToString().Substring(0, 1);

                                        string ipi_cst = "";
                                        ipi_cst = dtItens.Rows[i]["NFI_CST_IPI"].ToString();

                                        if (!NotaImportacao)
                                        {
                                            //if ((ipi_cst == "003" || ipi_cst == "103") && (dtItens.Rows[i]["NFI_PIS_VALOR"].ToString() == "")) //Não Tributado
                                            if (dtItens.Rows[i]["NFI_PIS_VALOR"].ToString() == "0,000000") //Não Tributado
                                            {
                                                writer.WriteStartElement("PISNT");
                                                writer.WriteElementString("CST", "07");
                                                writer.WriteEndElement();
                                            }
                                            //else if ((ipi_cst == "001" || ipi_cst == "101") && (dtItens.Rows[i]["NFI_PIS_VALOR"].ToString() != "")) //Tributado
                                            else if (dtItens.Rows[i]["NFI_PIS_VALOR"].ToString() != "0,000000") //Tributado
                                            {
                                                writer.WriteStartElement("PISAliq");
                                                writer.WriteElementString("CST", "01");
                                                writer.WriteElementString("vBC", BaseCalculoIpiCofinsPis);
                                                writer.WriteElementString("pPIS", lib.FormataValor(dtItens.Rows[i]["NFI_PIS_ALIQUOTA"].ToString(), 4));
                                                writer.WriteElementString("vPIS", lib.FormataValor(dtItens.Rows[i]["NFI_PIS_VALOR"].ToString(), 2));
                                                writer.WriteEndElement();
                                            }
                                            else
                                            {
                                                writer.WriteStartElement("PISOutr");
                                                writer.WriteElementString("CST", "99");
                                                writer.WriteElementString("vBC", "0.00");
                                                writer.WriteElementString("pPIS", "0.0000");
                                                writer.WriteElementString("vPIS", "0.00");
                                                writer.WriteEndElement();
                                            }
                                        }
                                        else
                                        {
                                            writer.WriteStartElement("PISOutr");
                                            writer.WriteElementString("CST", "50");
                                            writer.WriteElementString("vBC", lib.FormataValor(vBC_II.ToString(), 2));
                                            writer.WriteElementString("pPIS", lib.FormataValor(dtItens.Rows[i]["NFI_PIS_ALIQUOTA"].ToString(), 4));
                                            writer.WriteElementString("vPIS", lib.FormataValor(dtItens.Rows[i]["NFI_PIS_VALOR"].ToString(), 2));
                                            writer.WriteEndElement();
                                        }

                                        writer.WriteEndElement();
                                        //FECHA SUB NÓ </PIS>






                                        //SUB NÓ <COFINS>
                                        writer.WriteStartElement("COFINS");

                                        if (!NotaImportacao)
                                        {
                                            if (dtItens.Rows[i]["NFI_COFINS_ALIQUOTA"].ToString() == "0,000000" && dtItens.Rows[i]["NFI_COFINS_VALOR"].ToString() == "0,000000")
                                            {
                                                writer.WriteStartElement("COFINSNT");
                                                writer.WriteElementString("CST", "07");
                                                writer.WriteEndElement();
                                            }
                                            else
                                            {
                                                writer.WriteStartElement("COFINSAliq");
                                                writer.WriteElementString("CST", "01");
                                                writer.WriteElementString("vBC", BaseCalculoIpiCofinsPis);
                                                writer.WriteElementString("pCOFINS", lib.FormataValor(dtItens.Rows[i]["NFI_COFINS_ALIQUOTA"].ToString(), 4));
                                                writer.WriteElementString("vCOFINS", lib.FormataValor(dtItens.Rows[i]["NFI_COFINS_VALOR"].ToString(), 2));
                                                writer.WriteEndElement();
                                            }
                                        }
                                        else
                                        {
                                            writer.WriteStartElement("COFINSOutr");
                                            writer.WriteElementString("CST", "50");
                                            writer.WriteElementString("vBC", lib.FormataValor(vBC_II.ToString(), 2));
                                            writer.WriteElementString("pCOFINS", lib.FormataValor(dtItens.Rows[i]["NFI_COFINS_ALIQUOTA"].ToString(), 4));
                                            writer.WriteElementString("vCOFINS", lib.FormataValor(dtItens.Rows[i]["NFI_COFINS_VALOR"].ToString(), 2));
                                            writer.WriteEndElement();
                                        }

                                        writer.WriteEndElement();
                                        //FECHA SUB NÓ </COFINS>
                                        

                                        writer.WriteEndElement(); //Fecha </imposto>



                                        writer.WriteRaw("</det>");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    //LOG
                                    msgLog = "";
                                    msgLog = string.Format("ERRO|Verifique os dados dos Produtoso.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                                    msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                                    msgLog += "\n" + "SQL: " + qryItens;
                                    msgLog += "\n" + ex.Message;
                                    AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);
                                    
                                    
                                    retornoUpdate = "ERRO|Verifique os dados dos Produtos";

                                    //return retornoUpdate;
                                    continue;
                                }

                            }
                            else
                            {
                                //LOG
                                msgLog = "";
                                msgLog = string.Format("ERRO|Produtos não localizados.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                                msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                                msgLog += "\n" + "SQL: " + qryItens;
                                AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);
                                
                                
                                retornoUpdate = "ERRO|Produtos não localizados";
                                continue;
                            }






                            
                            //NÓ <total>
                            writer.WriteStartElement("total");
                            writer.WriteStartElement("ICMSTot");


                            writer.WriteElementString("vBC", lib.FormataValor(dadosNFe[0].NFE_BC_ICMS.ToString(), 2));
                            writer.WriteElementString("vICMS", lib.FormataValor(dadosNFe[0].NFE_VALOR_ICMS.ToString(), 2));
                            
                            //writer.WriteElementString("vBC", lib.FormataValor(lib.ConverterZeroOuDecimal(dadosNFe[0].NFE_BC_ICMS), 2));
                            //writer.WriteElementString("vICMS", lib.FormataValor(lib.ConverterZeroOuDecimal(dadosNFe[0].NFE_VALOR_ICMS), 2));
                            
                            writer.WriteElementString("vICMSDeson", "0.00");

                            if (dadosNFe[0].NFE_BC_ICMS_ST.ToString() == "")
                                writer.WriteElementString("vBCST", "0.00");
                            else
                                writer.WriteElementString("vBCST", lib.FormataValor(dadosNFe[0].NFE_BC_ICMS_ST.ToString(), 2));


                            writer.WriteElementString("vST", lib.FormataValor(dadosNFe[0].NFE_VALOR_ICMS_ST.ToString(), 2));
                            writer.WriteElementString("vProd", lib.FormataValor(dadosNFe[0].NFE_VALOR_TOTAL_PRODUTOS.ToString(), 2));
                            writer.WriteElementString("vFrete", lib.FormataValor(dadosNFe[0].NFE_VALOR_FRETE.ToString(), 2));
                            writer.WriteElementString("vSeg", "0.00");
                            writer.WriteElementString("vDesc", "0.00");


                            if (NotaImportacao)
                                writer.WriteElementString("vII", lib.FormataValor(dadosNFe[0].NFE_VALOR_II.ToString(), 2));
                            else
                                writer.WriteElementString("vII", "0.00");


                            writer.WriteElementString("vIPI", lib.FormataValor(dadosNFe[0].NFE_VALOR_IPI.ToString(), 2));
                            writer.WriteElementString("vPIS", lib.FormataValor(dadosNFe[0].vPIS.ToString(), 2));
                            writer.WriteElementString("vCOFINS", lib.FormataValor(dadosNFe[0].vCOFINS.ToString(), 2));
                            writer.WriteElementString("vOutro", lib.FormataValor(dadosNFe[0].NFE_VALOR_DESPESAS.ToString(), 2));
                            writer.WriteElementString("vNF", lib.FormataValor(dadosNFe[0].NFE_VALOR_TOTAL.ToString(), 2));
                            writer.WriteElementString("vTotTrib", lib.FormataValor(dadosNFe[0].NFE_VALOR_RETENCOES.ToString(), 2));

                            writer.WriteEndElement();
                            writer.WriteEndElement();

                            


                            //NÓ <transp>
                            writer.WriteStartElement("transp");

                            writer.WriteElementString("modFrete", dadosNFe[0].NFE_MODALIDADE_FRETE.ToString());


                            //SUB NÓ <transporta>
                            if (dadosNFe[0].TRA_ID > 1)
                            {
                                if (dadosNFe[0].NFE_MODALIDADE_FRETE == 0)
                                {
                                    writer.WriteStartElement("transporta");
                                    writer.WriteElementString("xNome", dadosNFe[0].TRA_NOME.ToString());
                                    writer.WriteEndElement();
                                }
                                else
                                {
                                    writer.WriteStartElement("transporta");
                                    writer.WriteElementString("CNPJ", dadosNFe[0].TRA_CNPJ_CPF.ToString());
                                    writer.WriteElementString("xNome", dadosNFe[0].TRA_NOME.ToString());
                                    writer.WriteElementString("IE", dadosNFe[0].TRA_IE.ToString());
                                    writer.WriteElementString("xMun", dadosNFe[0].TRA_MUNICIPIO.ToString());
                                    writer.WriteElementString("UF", dadosNFe[0].TRA_UF.ToString());
                                    writer.WriteEndElement();
                                }
                            }



                            //SUB NÓ <vol>
                            if (dadosNFe[0].TVO_ID > 1)
                            {
                                writer.WriteStartElement("vol");
                                writer.WriteElementString("qVol", Convert.ToInt32(dadosNFe[0].NFE_QTD_VOLUMES).ToString());


                                if (dadosNFe[0].TVO_ID > 1)
                                    writer.WriteElementString("esp", dadosNFe[0].TVO_DESCRICAO.ToString());

                                writer.WriteElementString("pesoL", lib.FormataValor(dadosNFe[0].NFE_PESO_LIQUIDO.ToString(), 3));
                                writer.WriteElementString("pesoB", lib.FormataValor(dadosNFe[0].NFE_PESO_BRUTO.ToString(), 3));


                                writer.WriteEndElement();
                            }

                            writer.WriteEndElement(); //FIM NÓ <transp>


                            string observacaoNota = dadosNFe[0].NFE_OBSERVACAO.ToString().Replace("\r\n", "").Trim();

                            //NÓ <infAdic>
                            if (!string.IsNullOrEmpty(observacaoNota))
                            { 
                                writer.WriteStartElement("infAdic");
                                //writer.WriteElementString("infAdFisco", string.Format("<![CDATA[{0}]]>", observacaoNota));
                                writer.WriteElementString("infAdFisco", observacaoNota);
                                writer.WriteEndElement();
                            }



                            writer.WriteRaw("</infNFe>");
                            writer.WriteRaw("</NFe>");


                            writer.Flush();
                            writer.Close(); //Escreve o XML para o arquivo e fecha o objeto escritor
                            writer.Dispose();

                        }
                        catch (Exception ex)
                        {
                            writer.Flush();
                            writer.Close();
                            writer.Dispose();


                            //LOG
                            msgLog = "";
                            msgLog = string.Format("ERRO|Erro ao gerar o arquivo XML.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                            msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                            msgLog += "\n" + ex.Message;
                            AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);



                            retornoUpdate = lib.ApagarXML(diretorioXMLTemp, diretorioXMLFinal, nomeArquivoXMLTemp);
                            retornoUpdate = "ERRO|Erro ao gerar o arquivo XML";

                            //return retornoUpdate;
                            continue;
                        }

                        //writer.WriteRaw("</nfeProc>");





                            
                        //Assina o XML aqui
                        string xmlOrigemTemp = diretorioXMLTemp + nomeArquivoXMLTemp;
                        string[] arrRetornoAssinatura = NFeXMLAssinatura.AssinaXML(xmlOrigemTemp, xmlFinal, id, emit_Certificado, emit_CertificadoSenha).Split('|');


                        //if (arrRetornoAssinatura[0] == "OK")
                        //{
                        //    string digestValue = NFeXMLAssinatura.PegaValorDeNode(xmlFinal, "DigestValue");
                        //    string protNFe = NFeXMLAssinatura.GerarNode_protNFe(versao, "Id333150178438865", tpAmb, chaveNFe, "333150178438865", digestValue);


                        //    //Altera o "NFe", acrescentando o nó "protNFe"
                        //    NFeXMLAssinatura.ReplaceDeNodes(xmlFinal, "</NFe>", protNFe, "ANTES");



                        //    //Altera o XML, acrescentando a declaração do mesmo e o nó "nfeProc"
                        //    string nfeBusca = "<NFe xmlns=\"http://www.portalfiscal.inf.br/nfe\">";
                        //    string nfeBuscaSubstituir = "<?xml version=\"1.0\" encoding=\"utf-8\"?><nfeProc xmlns=\"http://www.portalfiscal.inf.br/nfe\" versao=\"3.10\">";
                        //    NFeXMLAssinatura.ReplaceDeNodes(xmlFinal, nfeBusca, nfeBuscaSubstituir, "DEPOIS");


                        //    //Altera o "NFe", acrescentando o fechamento do nó "nfeProc"
                        //    NFeXMLAssinatura.ReplaceDeNodes(xmlFinal, "</protNFe>", "</nfeProc>", "ANTES");
                        //}
                        //else
                        //{
                        //    retornoUpdate = "ERRO|" + arrRetornoAssinatura[1];
                        //    continue;
                        //}
                            


                        //Finaliza NFE e Seta nome do arquivo XML
                        string qryNomeArquivoXML = String.Format(" UPDATE FA_NOTA_FISCAL_NFE SET NFE_STATUS = 1, NFE_ARQUIVO_XML = '{0}' WHERE NFE_ID = '{1}'", nomeArquivoXMLTemp, dadosNFe[0].NFE_ID);
                        model.Database.ExecuteSqlCommand(qryNomeArquivoXML);


                        ////////////Excluir o temporario
                        //////////retornoUpdate = lib.ApagarXML(diretorioXMLTemp, "", nomeArquivoXMLTemp);

                        //////////if (retornoUpdate == "OK|OK")
                        //////////{
                        //////////    retornoUpdate = String.Format(" ERRO|Erro ao excluir o arquivo XML temporário, verifique manualmente dentro do diretório: '{0}'", diretorioXMLTemp);
                        //////////}




                        retornoUpdate = "OK|OK";
                    }


                }//Fim FOREACH


                lib.CloseConnection();


                return retornoUpdate;
            }
        }







        /// <summary>
        /// Método que altera o Status dos Títulos em Lote
        /// </summary>
        /// <param name="lstNFEsStatus">
        /// Código e Status Atual do Titulo  
        /// </param>
        /// <param name="codigoUsuario">
        /// Código do usuário que está fazendo a alteração (não é obrigatório)
        /// </param>
        /// <param name="dataStatus">
        /// Data em que o status está sendo alterado (não é obrigatório)
        /// </param>
        /// <param name="acao">
        /// GERAR
        /// REMOVER
        /// </param>
        /// <returns>Verdadeiro ou Falso</returns>
        public string GerarXmlNFSe(List<string> lstNFEsStatus, int? codigoUsuario, DateTime? dataStatus)
        {
            using (ERPModel model = new ERPModel())
            {

                string retornoUpdate = "";

                string acao = lstNFEsStatus[0];


                XmlTextWriter writer;


                AuxiliaryLibrary lib = new AuxiliaryLibrary();

                lib.OpenConnection();


                //Cria todas as DTs
                DataTable dtNFE = new DataTable();
                DataTable dtEmitente = new DataTable();
                DataTable dtDestinatario = new DataTable();
                DataTable dtItens = new DataTable();


                foreach (string item in lstNFEsStatus)
                {

                    //Limpa as DTs
                    dtNFE.Clear();
                    dtEmitente.Clear();
                    dtDestinatario.Clear();
                    dtItens.Clear();


                    string[] arrNFEsStatus = item.Split('|');

                    if (arrNFEsStatus.Length < 2)
                        continue;


                    bool existeProximaPagina = false;
                    List<FaturamentoExportarXMLDTO> dadosNFe = FaturamentoExportarXMLDAL.Instance.Pesquisar(Convert.ToInt32(arrNFEsStatus[0]), null, null, null, 3, null, out existeProximaPagina, 0);


                    string diretorioXMLTemp = "";
                    string diretorioXMLFinal = "";
                    string serie = "A";
                    string nNF = "";
                    string LoteRpsId = "";
                    string InfRpsId = "";


                    /*
                    Código de natureza da operação
                    1 – Tributação no município
                    2 - Tributação fora do município
                    3 - Isenção
                    4 - Imune
                    5 – Exigibilidade suspensa por decisão judicial
                    6 – Exigibilidade suspensa por procedimento administrativo 
                    */
                    string natOp = "1";


                    /*
                    Código de tipo de RPS
                    1 - RPS
                    2 – Nota Fiscal Conjugada (Mista)
                    3 – Cupom
                    */
                    string TsTipoRps = "1";


                    string tpNF = dadosNFe[0].TPV_ENTRADA_SAIDA.ToString();
                    string idDest;




                    //Dados do Emitente
                    string qryEmitente = " SELECT EMP.EMP_ID, EMP_NOME_FANTASIA, EMP_UF, EMP_NUM_NF_VENDA, EMP_NUM_NF_SERVICO, ";
                    qryEmitente += " EMP_RAZAO_SOCIAL, EMP_TELEFONE, EMP_CELULAR, EMP_EMAIL, EMP_URL, EMP_CPNJ_CPF, EMP_IE, ";
                    qryEmitente += " EMP_IE_SUBSTITUICAO_TRIBUTARIA, EMP_IM, EMP_INSS, EMP_SUFRAMA, EMP_SIMPLES, EMP_REGIME_TRIBUTARIO, ";
                    qryEmitente += " EMP_CERTIFICADO_NFE, EMP_CERTIFICADO_NFE_SENHA, EMP_DIRETORIO_XML, EMP_DIRETORIO_XML_TEMP, ";
                    qryEmitente += " CNA.CNA_NUM, EEN_LOGRADOURO, EEN_NUMERO, EEN_COMPLEMENTO, EEN_CEP, EEN_BAIRRO, EEN_UF, EEN_MUNICIPIO, ";
                    qryEmitente += " EEN.IBG_CODCID, EEN.PAI_ID, PAI.PAI_NOME, ";
                    qryEmitente += " (SELECT TOP 1 IBG_CODUF FROM GE_IBGE_IBG IBG WHERE IBG.IBG_UF = EEN.EEN_UF) AS IBG_CODUF ";
                    qryEmitente += " FROM GE_EMPRESA_EMP EMP LEFT JOIN GE_CNAE_CNA CNA ON CNA.CNA_ID = EMP.CNA_ID ";
                    qryEmitente += " INNER JOIN GE_EMPRESA_ENDERECO_EEN EEN ON EEN.EMP_ID = EMP.EMP_ID ";
                    qryEmitente += " INNER JOIN GE_PAIS_PAI PAI ON PAI.PAI_ID = EEN.PAI_ID  ";
                    qryEmitente += " WHERE EEN.TEN_ID = 1 ";
                    qryEmitente += String.Format("AND EMP.EMP_ID = '{0}' ", dadosNFe[0].EMP_ID);

                    lib.CreateDT(dtEmitente, qryEmitente);

                    //Variáveis do Emitente
                    string emit_CNPJ = "";
                    string emit_xNome = "";
                    string emit_xFant = "";
                    string emit_xLgr = "";
                    string emit_nro = "";
                    string emit_xComplemento = "";
                    string emit_xBairro = "";
                    string emit_cMun = "";
                    string emit_xMun = "";
                    string emit_UF = "";
                    string emit_CEP = "";
                    string emit_cPais = "";
                    string emit_xPais = "";
                    string emit_IE = "";
                    string emit_IM = "";
                    string emit_CNAE = "";
                    string emit_CRT = "";
                    string emit_Certificado = "";
                    string emit_CertificadoSenha = "";
                    string emit_Telefone = "(00)0000-0000";
                    string emit_Email = "leiliane.silva@3corp.com.br";


                    if (dtEmitente.Rows.Count > 0)
                    {
                        try
                        {
                            emit_CNPJ = lib.AcertaCpfCnpj(Convert.ToDecimal(dtEmitente.Rows[0]["EMP_CPNJ_CPF"]), 1);
                            emit_xNome = dtEmitente.Rows[0]["EMP_RAZAO_SOCIAL"].ToString().Trim();
                            emit_xFant = dtEmitente.Rows[0]["EMP_NOME_FANTASIA"].ToString().Trim();
                            emit_xLgr = dtEmitente.Rows[0]["EEN_LOGRADOURO"].ToString().Trim();
                            emit_nro = dtEmitente.Rows[0]["EEN_NUMERO"].ToString().Trim();
                            emit_xComplemento = dtEmitente.Rows[0]["EEN_COMPLEMENTO"].ToString().Trim();
                            emit_xBairro = dtEmitente.Rows[0]["EEN_BAIRRO"].ToString().Trim();
                            emit_cMun = dtEmitente.Rows[0]["IBG_CODCID"].ToString().Trim();
                            emit_xMun = dtEmitente.Rows[0]["EEN_MUNICIPIO"].ToString().Trim();
                            emit_UF = dtEmitente.Rows[0]["EEN_UF"].ToString();
                            emit_CEP = lib.RemoveCaracteresEspeciais(dtEmitente.Rows[0]["EEN_CEP"].ToString().Trim());
                            emit_cPais = "1058";
                            emit_xPais = dtEmitente.Rows[0]["PAI_NOME"].ToString().Trim();
                            emit_IE = lib.RemoveCaracteresEspeciais(dtEmitente.Rows[0]["EMP_IE"].ToString().Trim());
                            emit_IM = lib.RemoveCaracteresEspeciais(dtEmitente.Rows[0]["EMP_IM"].ToString().Trim());
                            emit_CNAE = lib.RemoveCaracteresEspeciais(dtEmitente.Rows[0]["CNA_NUM"].ToString().Trim());
                            emit_CRT = dtEmitente.Rows[0]["EMP_REGIME_TRIBUTARIO"].ToString().Trim();
                            emit_Certificado = dtEmitente.Rows[0]["EMP_CERTIFICADO_NFE"].ToString().Trim();
                            emit_CertificadoSenha = dtEmitente.Rows[0]["EMP_CERTIFICADO_NFE_SENHA"].ToString().Trim();
                            diretorioXMLTemp = dtEmitente.Rows[0]["EMP_DIRETORIO_XML_TEMP"].ToString().Trim();
                            diretorioXMLFinal = dtEmitente.Rows[0]["EMP_DIRETORIO_XML"].ToString().Trim();

                            if (dtEmitente.Rows[0]["EMP_TELEFONE"].ToString() != "")
                                emit_Telefone = dtEmitente.Rows[0]["EMP_TELEFONE"].ToString().Trim();
                        }
                        catch (Exception ex)
                        {
                            //LOG
                            msgLog = "";
                            msgLog = string.Format("ERRO|Verifique os dados do Emitente.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                            msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                            msgLog += "\n" + "EMP_ID: " + dadosNFe[0].EMP_ID.ToString();
                            msgLog += "\n" + "SQL: " + qryEmitente;
                            msgLog += "\n" + ex.Message;
                            AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);


                            retornoUpdate = "ERRO|Verifique os dados do Emitente";

                            //return retornoUpdate;
                            continue;
                        }
                    }
                    else
                    {
                        //LOG
                        msgLog = "";
                        msgLog = string.Format("ERRO|Emitente não localizado.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                        msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                        msgLog += "\n" + "EMP_ID: " + dadosNFe[0].EMP_ID.ToString();
                        msgLog += "\n" + "SQL: " + qryEmitente;
                        AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);


                        retornoUpdate = "ERRO|Emitente não localizado";
                        continue;
                    }




                    if ((acao == "GERAR") && (arrNFEsStatus[1] == "0"))
                    {
                        nNF = dadosNFe[0].NFE_NUMERO.ToString();
                        LoteRpsId = "L1";
                        //InfRpsId    = "rps:" + dadosNFe[0].NFE_NUMERO.ToString() + serie;
                        InfRpsId = "rps:" + dadosNFe[0].NFE_NUMERO.ToString();


                        string indPag;

                        if (dadosNFe[0].PDV_FORMA_PAGTO == 4)
                            indPag = "0";
                        else if (dadosNFe[0].PDV_FORMA_PAGTO == 2 || dadosNFe[0].PDV_FORMA_PAGTO == 3)
                            indPag = "1";
                        else
                            indPag = "2";



                        string dhEmi = dadosNFe[0].NFE_DATA_EMISSAO + "T" + DateTime.Now.ToString("HH:mm:ss") + ".01";
                        string dhEmiRps = dadosNFe[0].NFE_DATA_EMISSAO + "T" + DateTime.Now.ToString("HH:mm:ss");
                        string dataCompetencia = dadosNFe[0].NFE_DATA_EMISSAO + "T" + "00:00:00";
                        string dhSaiEnt = dhEmi;




                        //Dados do Destinatario
                        string qryDestinatario = " SELECT PNE.PNE_ID, PNE.PNE_TIPO_CONTRIBUINTE, PNE_RAZAO_SOCIAL, PNE_CPNJ_CPF, PNE_IE, PNE_TELEFONE, PNE_EMAIL,  ";
                        qryDestinatario += " CNA.CNA_NUM, END_LOGRADOURO, END_NUMERO, END_COMPLEMENTO, END_CEP, END_BAIRRO, END_UF, END_MUNICIPIO, ENDPARC.IBG_CODCID, ";
                        //qryDestinatario += " PAI_ID = CASE WHEN (SELECT PAI.PAI_ID FROM GE_PAIS_PAI PAI WHERE PAI.PAI_ID = ENDPARC.PAI_ID) IS NOT NULL THEN (SELECT PAI.PAI_ID FROM GE_PAIS_PAI PAI WHERE PAI.PAI_ID = ENDPARC.PAI_ID) WHEN (SELECT PAI.PAI_ID FROM GE_PAIS_PAI PAI WHERE PAI.PAI_ID = ENDPARC.PAI_ID) = 76 THEN '1058' ELSE '1058' END, ";
                        qryDestinatario += " '1058' AS PAI_ID, ";
                        qryDestinatario += " PAI_NOME = CASE WHEN (SELECT PAI.PAI_NOME FROM GE_PAIS_PAI PAI WHERE PAI.PAI_ID = ENDPARC.PAI_ID) IS NOT NULL THEN (SELECT PAI.PAI_NOME FROM GE_PAIS_PAI PAI WHERE PAI.PAI_ID = ENDPARC.PAI_ID) ELSE 'BRASIL' END, ";
                        qryDestinatario += " (SELECT TOP 1 IBG_CODUF FROM GE_IBGE_IBG IBG WHERE IBG.IBG_UF = ENDPARC.END_UF) AS IBG_CODUF ";
                        qryDestinatario += " FROM GE_PARCEIRO_NEGOCIO_PNE PNE LEFT JOIN GE_CNAE_CNA CNA ON CNA.CNA_ID = PNE.CNA_ID ";
                        qryDestinatario += " INNER JOIN GE_ENDERECO_PARCEIRO_END ENDPARC ON ENDPARC.PNE_ID = PNE.PNE_ID ";
                        qryDestinatario += " WHERE ENDPARC.TEN_ID = 1 ";
                        qryDestinatario += String.Format(" AND PNE.PNE_ID = '{0}' ", dadosNFe[0].PDV_CLIENTE);

                        lib.CreateDT(dtDestinatario, qryDestinatario);

                        //Variáveis do Destinatário
                        string dest_CNPJ = "";
                        string dest_xNome = "";
                        string dest_xLgr = "";
                        string dest_nro = "";
                        string dest_xComplemento = "";
                        string dest_xBairro = "";
                        string dest_cMun = "";
                        string dest_xMun = "";
                        string dest_UF = "";
                        string dest_CEP = "";
                        string dest_cPais = "";
                        string dest_xPais = "";
                        string dest_fone = "";
                        string dest_indIEDest = "0";
                        string dest_IE = "";
                        string dest_Telefone = "(00)0000-0000";
                        string dest_Email = "naoinformado";

                        if (dtDestinatario.Rows.Count > 0)
                        {

                            try
                            {
                                dest_CNPJ = lib.AcertaCpfCnpj(Convert.ToDecimal(dtDestinatario.Rows[0]["PNE_CPNJ_CPF"]), Convert.ToInt32(dtDestinatario.Rows[0]["PNE_TIPO_CONTRIBUINTE"]));
                                dest_xNome = dtDestinatario.Rows[0]["PNE_RAZAO_SOCIAL"].ToString().Trim();
                                dest_xLgr = dtDestinatario.Rows[0]["END_LOGRADOURO"].ToString().Trim();
                                dest_nro = dtDestinatario.Rows[0]["END_NUMERO"].ToString().Trim();
                                dest_xComplemento = dtDestinatario.Rows[0]["END_COMPLEMENTO"].ToString().Trim();
                                dest_xBairro = dtDestinatario.Rows[0]["END_BAIRRO"].ToString().Trim();
                                dest_cMun = dtDestinatario.Rows[0]["IBG_CODCID"].ToString().Trim();
                                dest_xMun = dtDestinatario.Rows[0]["END_MUNICIPIO"].ToString().Trim();
                                dest_UF = dtDestinatario.Rows[0]["END_UF"].ToString().Trim();
                                dest_fone = lib.RemoveCaracteresEspeciais(lib.RemoveEspaco(dtDestinatario.Rows[0]["PNE_TELEFONE"].ToString().Trim()));
                                dest_CEP = lib.RemoveCaracteresEspeciais(lib.RemoveEspaco(dtDestinatario.Rows[0]["END_CEP"].ToString().Trim()));
                                dest_cPais = dtDestinatario.Rows[0]["PAI_ID"].ToString().Trim();
                                dest_xPais = dtDestinatario.Rows[0]["PAI_NOME"].ToString().Trim();

                                if (dtDestinatario.Rows[0]["PNE_TELEFONE"].ToString() != "")
                                    dest_Telefone = lib.RemoveCaracteresEspeciais(dtDestinatario.Rows[0]["PNE_TELEFONE"].ToString().Trim());


                                if (dtDestinatario.Rows[0]["PNE_EMAIL"].ToString() != "")
                                    dest_Email = dtDestinatario.Rows[0]["PNE_EMAIL"].ToString().Trim();


                                if (dtDestinatario.Rows[0]["PNE_IE"].ToString() == "Isento" || dtDestinatario.Rows[0]["PNE_IE"].ToString() == "ISENTO")
                                {
                                    dest_IE = "";
                                    dest_indIEDest = "2";
                                }
                                else if (dtDestinatario.Rows[0]["PNE_IE"].ToString() != "")
                                {
                                    dest_IE = lib.RemoveCaracteresEspeciais(dtDestinatario.Rows[0]["PNE_IE"].ToString().Trim());
                                    dest_indIEDest = "1";
                                }

                                /*
                                dest_indIEDest
                                    * Indicador da IE do Destinatário, informar:
                                1 - Contribuinte ICMS (informar a IE do destinatário);
                                2 - Contribuinte isento de Inscrição no cadastro de Contribuintes do ICMS;
                                9 - Não Contribuinte, que pode ou não possuir Inscrição Estadual no Cadastro de Contribuintes do ICMS.
                                Nota 1: No caso de NFC-e informar indIEDest=9 e não informar a tag IE do destinatário;
                                Nota 2: No caso de operação com o Exterior informar indIEDest=9 e não informar a tag IE do destinatário;
                                Nota 3: No caso de Contribuinte Isento de Inscrição (indIEDest=2), não informar a tag IE do destinatário.
                                (campo novo) [23-12-13]
                                    */
                            }
                            catch (Exception ex)
                            {
                                //LOG
                                msgLog = "";
                                msgLog = string.Format("ERRO|Verifique os dados do Destinatário.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                                msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                                msgLog += "\n" + "PNE_ID: " + dadosNFe[0].PDV_CLIENTE.ToString();
                                msgLog += "\n" + "SQL: " + qryDestinatario;
                                msgLog += "\n" + ex.Message;
                                AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);


                                retornoUpdate = "ERRO|Verifique os dados do Destinatário";
                                continue;
                            }
                        }
                        else
                        {
                            //LOG
                            msgLog = "";
                            msgLog = string.Format("ERRO|Destinatário não localizado.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                            msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                            msgLog += "\n" + "PNE_ID: " + dadosNFe[0].PDV_CLIENTE.ToString();
                            msgLog += "\n" + "SQL: " + qryDestinatario;
                            AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);


                            retornoUpdate = "ERRO|Destinatário não localizado";
                            continue;
                        }




                        /*
                            * idDest e ela deve assumir um dos seguintes valores:
                            * 1 - Operação interna;
                            * 2 - Operação interestadual;
                            * 3 - Operação com exterior.
                            */
                        string listaSiglasUFs = "AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MT, MS, MG, PA, PB, PR, PE, PI, RJ, RN, RS, RO, RR, SC, SP, SE, TO";

                        if (emit_UF == dest_UF)
                            idDest = "1";
                        else if (emit_UF != dest_UF)
                            idDest = "2";
                        else if (listaSiglasUFs.Contains(dest_UF))
                            idDest = "3";
                        else
                            idDest = "3";




                        //Criar o Arquivo XML

                        string subNomeArquivo = "";

                        if (dadosNFe[0].TIPO_NOTA.ToString() == "NF Serviço")
                            subNomeArquivo = "SERVICOS_";
                        else if (dadosNFe[0].TIPO_NOTA.ToString() == "NF Licença")
                            subNomeArquivo = "LICENCAS_";


                        string nomeArquivoXMLTemp = subNomeArquivo + DateTime.Now.ToString("yyyyMMdd") + "_" + dadosNFe[0].NFE_NUMERO + ".xml";
                        string xmlFinal = diretorioXMLFinal + nomeArquivoXMLTemp;

                        writer = new XmlTextWriter(diretorioXMLTemp + nomeArquivoXMLTemp, null);





                        try
                        {
                            ////define a indentação do arquivo
                            //writer.Formatting = Formatting.Indented;


                            ////inicia o documento xml
                            //writer.WriteStartDocument();





                            writer.WriteRaw("<Rps>");
                            writer.WriteRaw("<InfRps Id=\"" + InfRpsId + "\" >");

                            writer.WriteStartElement("IdentificacaoRps");
                            writer.WriteElementString("Numero", nNF);
                            writer.WriteElementString("Serie", serie);
                            writer.WriteElementString("Tipo", TsTipoRps);
                            writer.WriteEndElement(); //FIM NÓ <IdentificacaoRps>


                            writer.WriteElementString("DataEmissao", dhEmiRps);
                            writer.WriteElementString("NaturezaOperacao", natOp);
                            //writer.WriteElementString("RegimeEspecialTributacao", "1");
                            writer.WriteElementString("OptanteSimplesNacional", "2");
                            writer.WriteElementString("IncentivadorCultural", "2");
                            //writer.WriteElementString("Competencia", dataCompetencia);
                            writer.WriteElementString("Status", "1");




                            //Dados dos Itens (produtos)
                            string qryItens = " SELECT NFI_ID, NFE_ID, NFI.PIT_ID, NFI_PIS_ALIQUOTA, NFI_PIS_VALOR, NFI_COFINS_ALIQUOTA, NFI_COFINS_VALOR, ";
                            qryItens += " NFI_CSLL_ALIQUOTA, NFI_CSLL_VALOR, NFI_IRRF_ALIQUOTA, NFI_IRRF_VALOR, NFI_INSS_ALIQUOTA, NFI_INSS_VALOR, ";
                            qryItens += " NFI_IPI_ALIQUOTA, NFI_IPI_VALOR, NFI_ICMS_ALIQUOTA, NFI_ICMS_VALOR, NFI_ISS_ALIQUOTA, NFI_ISS_VALOR, ";
                            qryItens += " NFI_PRODUTO_DESCRICAO, NFI_PRODUTO_QTDE, NFI_PRODUTO_PRECO_UNITARIO, NFI_PRODUTO_PRECO_TOTAL, ";
                            qryItens += " NFI_ICMS_ST_ALIQUOTA, NFI_ICMS_ST_VALOR, NFI_BC, NFI_BC_ICMS, NFI_BC_ICMS_ST, NFI_CST_ICMS, NFI_CST_IPI, ";
                            qryItens += " NFI_DIFAL_PORCENTAGEM, ITE.ITE_ID, ITE.ITE_UNID_MEDIDA, ITE.ITE_CODIGO, PIT.PIT_CFOP, ";
                            qryItens += " NFI_II_ALIQUOTA, NFI_II_VALOR, NFI_NUMERO_SEQ_ADIC, ITE.ITE_TIPO ";
                            qryItens += " FROM FA_NOTA_FISCAL_ITENS_NFI NFI INNER JOIN PD_PEDIDO_ITEM_PIT PIT ON PIT.PIT_ID = NFI.PIT_ID ";
                            qryItens += " INNER JOIN ES_ITEM_ITE ITE ON ITE.ITE_ID = PIT.PIT_PRODUTO ";
                            qryItens += String.Format(" WHERE NFI.NFE_ID = '{0}' ", dadosNFe[0].NFE_ID);
                            qryItens += " ORDER BY NFI_ID ASC ";

                            lib.CreateDT(dtItens, qryItens);

                            if (dtItens.Rows.Count > 0)
                            {

                                try
                                {
                                    string IssRetido = "";
                                    string ItemListaServico = "";
                                    string CodigoTributacaoMunicipio = "";
                                    string descricaoServico = "";
                                    decimal? IssAliquota = 0;
                                    decimal? ValorServicos = 0;
                                    //decimal? ValorDeducoes              = 0;
                                    decimal? ValorPis = 0;
                                    decimal? ValorCofins = 0;
                                    decimal? ValorInss = 0;
                                    decimal? ValorIr = 0;
                                    decimal? ValorCsll = 0;
                                    decimal? ValorIss = 0;
                                    //decimal? OutrasRetencoes            = 0;




                                    for (int i = 0; i <= dtItens.Rows.Count - 1; i++)
                                    {
                                        if (dtItens.Rows[i]["ITE_TIPO"].ToString() == "S")
                                        {
                                            ItemListaServico = "0107";
                                        }
                                        else if (dtItens.Rows[i]["ITE_TIPO"].ToString() == "L")
                                        {
                                            ItemListaServico = "0105";
                                            descricaoServico += dtItens.Rows[i]["NFI_PRODUTO_DESCRICAO"].ToString().Trim() + "\r\n"; //Quando "Licença" pega os itens
                                        }


                                        if (dtItens.Rows[i]["ITE_TIPO"].ToString() == "S")
                                            CodigoTributacaoMunicipio = "01.07";
                                        else if (dtItens.Rows[i]["ITE_TIPO"].ToString() == "L")
                                            CodigoTributacaoMunicipio = "01.05";



                                        /*
                                        Utilize um dos tipos: 
                                        1 - para ISS Retido 
                                        2 - para ISS não Retido.
                                        */



                                        //IssRetido           = (dtItens.Rows[i]["NFI_ISS_VALOR"].ToString() != "0,000000") ? "1" : "2"; 
                                        IssRetido = "2";

                                        IssAliquota = (Convert.ToDecimal(dtItens.Rows[i]["NFI_ISS_ALIQUOTA"]) / 100);
                                        ValorServicos += Convert.ToDecimal(dtItens.Rows[i]["NFI_PRODUTO_PRECO_TOTAL"]);
                                        //ValorDeducoes       += Convert.ToDecimal(dtItens.Rows[i]["NFI_PRODUTO_PRECO_TOTAL"]); //***************
                                        ValorPis += Convert.ToDecimal(dtItens.Rows[i]["NFI_PIS_VALOR"]);
                                        ValorCofins += Convert.ToDecimal(dtItens.Rows[i]["NFI_COFINS_VALOR"]);
                                        ValorInss += Convert.ToDecimal(dtItens.Rows[i]["NFI_INSS_VALOR"]);
                                        ValorIr += Convert.ToDecimal(dtItens.Rows[i]["NFI_IRRF_VALOR"]);
                                        ValorCsll += Convert.ToDecimal(dtItens.Rows[i]["NFI_CSLL_VALOR"]);
                                        ValorIss += Convert.ToDecimal(dtItens.Rows[i]["NFI_ISS_VALOR"]);
                                        //OutrasRetencoes     += Convert.ToDecimal(dtItens.Rows[i]["NFI_PRODUTO_PRECO_TOTAL"]); //****************





                                    }



                                    descricaoServico += dadosNFe[0].NFE_OBSERVACAO.ToString().Replace("\r\n", "").Trim(); //Quando "serviço" pegar observação da nota


                                    //NÓ <Servico>
                                    writer.WriteRaw("<Servico>");
                                    writer.WriteStartElement("Valores");
                                    writer.WriteElementString("ValorServicos", lib.FormataValor(ValorServicos.ToString(), 2));
                                    writer.WriteElementString("ValorDeducoes", "0.00");
                                    writer.WriteElementString("ValorPis", lib.FormataValor(ValorPis.ToString(), 2));
                                    writer.WriteElementString("ValorCofins", lib.FormataValor(ValorCofins.ToString(), 2));
                                    writer.WriteElementString("ValorInss", lib.FormataValor(ValorInss.ToString(), 2));
                                    writer.WriteElementString("ValorIr", lib.FormataValor(ValorIr.ToString(), 2));
                                    writer.WriteElementString("ValorCsll", lib.FormataValor(ValorCsll.ToString(), 2));

                                    writer.WriteElementString("IssRetido", IssRetido);

                                    if (IssRetido == "1")
                                        writer.WriteElementString("ValorIss", lib.FormataValor(ValorIss.ToString(), 2));

                                    writer.WriteElementString("OutrasRetencoes", "0.00");


                                    if (IssRetido == "1")
                                        writer.WriteElementString("Aliquota", lib.FormataValor(IssAliquota.ToString(), 2));


                                    writer.WriteEndElement(); //FIM NÓ <Valores>


                                    writer.WriteElementString("ItemListaServico", ItemListaServico);
                                    //writer.WriteElementString("CodigoCnae", "2631100"); 
                                    writer.WriteElementString("CodigoTributacaoMunicipio", CodigoTributacaoMunicipio);
                                    writer.WriteElementString("Discriminacao", descricaoServico);
                                    writer.WriteElementString("CodigoMunicipio", emit_cMun);

                                    writer.WriteRaw("</Servico>"); //FIM NÓ <Servico>
                                }
                                catch (Exception ex)
                                {
                                    //LOG
                                    msgLog = "";
                                    msgLog = string.Format("ERRO|Verifique os dados dos Produtoso.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                                    msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                                    msgLog += "\n" + "SQL: " + qryItens;
                                    msgLog += "\n" + ex.Message;
                                    AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);


                                    retornoUpdate = "ERRO|Verifique os dados dos Produtos";

                                    //return retornoUpdate;
                                    continue;
                                }
                            }
                            else
                            {
                                //LOG
                                msgLog = "";
                                msgLog = string.Format("ERRO|Produtos não localizados.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                                msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                                msgLog += "\n" + "SQL: " + qryItens;
                                AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);


                                retornoUpdate = "ERRO|Produtos não localizados";
                                continue;
                            }



                            //NÓ <PrestadorServico>
                            writer.WriteStartElement("Prestador");
                            writer.WriteElementString("Cnpj", emit_CNPJ);
                            writer.WriteElementString("InscricaoMunicipal", emit_IM);
                            writer.WriteEndElement(); //FIM NÓ <Prestador>



                            //NÓ <TomadorServico>
                            writer.WriteStartElement("Tomador");

                            writer.WriteStartElement("IdentificacaoTomador");
                            writer.WriteStartElement("CpfCnpj");

                            if (Convert.ToInt32(dtDestinatario.Rows[0]["PNE_TIPO_CONTRIBUINTE"]) == 1)
                                writer.WriteElementString("Cnpj", dest_CNPJ);
                            else if (Convert.ToInt32(dtDestinatario.Rows[0]["PNE_TIPO_CONTRIBUINTE"]) == 2)
                                writer.WriteElementString("CPF", dest_CNPJ);

                            writer.WriteEndElement(); //FIM NÓ <CpfCnpj>
                            writer.WriteEndElement(); //FIM NÓ <IdentificacaoTomador>


                            writer.WriteElementString("RazaoSocial", dest_xNome);

                            writer.WriteStartElement("Endereco");
                            writer.WriteElementString("Endereco", dest_xLgr);
                            writer.WriteElementString("Numero", dest_nro);


                            if (dest_xComplemento != "")
                                writer.WriteElementString("Complemento", dest_xComplemento);



                            writer.WriteElementString("Bairro", dest_xBairro);
                            writer.WriteElementString("CodigoMunicipio", dest_cMun);
                            writer.WriteElementString("Uf", dest_UF);
                            writer.WriteElementString("Cep", dest_CEP);
                            writer.WriteEndElement(); //FIM NÓ <Endereco>

                            writer.WriteStartElement("Contato");
                            writer.WriteElementString("Telefone", dest_Telefone);
                            writer.WriteElementString("Email", dest_Email);
                            writer.WriteEndElement(); //FIM NÓ <Contato>

                            writer.WriteEndElement(); //FIM NÓ <Tomador>


                            writer.WriteRaw("</InfRps>");
                            writer.WriteRaw("</Rps>");

                            //writer.WriteEndDocument(); //Fecha o documento

                            writer.Flush();
                            writer.Close(); //Escreve o XML para o arquivo e fecha o objeto escritor
                            writer.Dispose();

                        }
                        catch (Exception ex)
                        {
                            writer.Flush();
                            writer.Close();
                            writer.Dispose();


                            //LOG
                            msgLog = "";
                            msgLog = string.Format("ERRO|Erro ao gerar o arquivo XML.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                            msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                            msgLog += "\n" + ex.Message;
                            AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);



                            retornoUpdate = lib.ApagarXML(diretorioXMLTemp, diretorioXMLFinal, nomeArquivoXMLTemp);
                            retornoUpdate = "ERRO|Erro ao gerar o arquivo XML";

                            //return retornoUpdate;
                            continue;
                        }




                        //Assina o XML das tags de RPS
                        string xmlOrigemTemp = diretorioXMLTemp + nomeArquivoXMLTemp;
                        string[] arrRetornoAssinatura = NFeXMLAssinatura.AssinaXML(xmlOrigemTemp, xmlFinal, InfRpsId, emit_Certificado, emit_CertificadoSenha, false).Split('|');


                        if (arrRetornoAssinatura[0] == "OK")
                        {
                            string tagBusca = "";
                            string tagBuscaSubstituir = "";



                            //Altera o XML, acrescentando a declaração do mesmo
                            tagBusca = "<Rps>";
                            //tagBuscaSubstituir = "<EnviarLoteRpsEnvio xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"http://www.abrasf.org.br/ABRASF/arquivos/nfse.xsd\"><LoteRps Id=\"" + LoteRpsId + "\"><NumeroLote>\"" + nNF + "\"</NumeroLote><Cnpj>\"" + emit_CNPJ + "\"</Cnpj><InscricaoMunicipal>\"" + emit_IM + "\"</InscricaoMunicipal><QuantidadeRps>1</QuantidadeRps><ListaRps>";
                            //tagBuscaSubstituir = "<EnviarLoteRpsEnvio xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"http://www.abrasf.org.br/ABRASF/arquivos/nfse.xsd\"><LoteRps Id=\"" + LoteRpsId + "\"><NumeroLote>" + nNF + "</NumeroLote><Cnpj>" + emit_CNPJ + "</Cnpj><InscricaoMunicipal>" + emit_IM + "</InscricaoMunicipal><QuantidadeRps>1</QuantidadeRps><ListaRps>";
                            tagBuscaSubstituir = "<EnviarLoteRpsEnvio xmlns=\"http://www.abrasf.org.br/ABRASF/arquivos/nfse.xsd\"><LoteRps Id=\"" + LoteRpsId + "\"><NumeroLote>" + nNF + "</NumeroLote><Cnpj>" + emit_CNPJ + "</Cnpj><InscricaoMunicipal>" + emit_IM + "</InscricaoMunicipal><QuantidadeRps>1</QuantidadeRps><ListaRps>";


                            NFeXMLAssinatura.ReplaceDeNodes(xmlFinal, tagBusca, tagBuscaSubstituir, "DEPOIS");

                            //Altera o "NFe", acrescentando o fechamento do nó
                            NFeXMLAssinatura.ReplaceDeNodes(xmlFinal, "</Rps>", "</ListaRps></LoteRps>", "ANTES");
                            NFeXMLAssinatura.ReplaceDeNodes(xmlFinal, "</LoteRps>", "</EnviarLoteRpsEnvio>", "ANTES");


                            //Altera o XML, acrescentando a declaração do mesmo e o nó "NoForcaGerarSegundaAssinaturaNoLugarCerto"
                            tagBusca = "<LoteRps";
                            tagBuscaSubstituir = "<NoForcaGerarSegundaAssinaturaNoLugarCerto>";
                            NFeXMLAssinatura.ReplaceDeNodes(xmlFinal, tagBusca, tagBuscaSubstituir, "DEPOIS");

                            //Altera o "NFe", acrescentando o fechamento do nó "NoForcaGerarSegundaAssinaturaNoLugarCerto"
                            NFeXMLAssinatura.ReplaceDeNodes(xmlFinal, "</LoteRps>", "</NoForcaGerarSegundaAssinaturaNoLugarCerto>", "ANTES");


                            //Assina o XML das tags de LOTE
                            xmlOrigemTemp = diretorioXMLFinal + nomeArquivoXMLTemp;
                            arrRetornoAssinatura = NFeXMLAssinatura.AssinaXML(xmlOrigemTemp, xmlFinal, LoteRpsId, emit_Certificado, emit_CertificadoSenha, true).Split('|');


                            //Remover o NÓ "NoForcaGerarSegundaAssinaturaNoLugarCerto"
                            NFeXMLAssinatura.ReplaceDeNodes(xmlFinal, "<NoForcaGerarSegundaAssinaturaNoLugarCerto>", "", "REMOVER");
                            NFeXMLAssinatura.ReplaceDeNodes(xmlFinal, "</NoForcaGerarSegundaAssinaturaNoLugarCerto>", "", "REMOVER");
                        }
                        else
                        {
                            retornoUpdate = "ERRO|" + arrRetornoAssinatura[1];
                            continue;
                        }




                        //Finaliza NFE e Seta nome do arquivo XML
                        string qryNomeArquivoXML = String.Format(" UPDATE FA_NOTA_FISCAL_NFE SET NFE_STATUS = 1, NFE_ARQUIVO_XML = '{0}' WHERE NFE_ID = '{1}'", nomeArquivoXMLTemp, dadosNFe[0].NFE_ID);
                        model.Database.ExecuteSqlCommand(qryNomeArquivoXML);


                        retornoUpdate = "OK|OK";
                    }



                }//Fim FOREACH


                lib.CloseConnection();


                return retornoUpdate;
            }
        }







        public string ExcluirUltimaNota(List<string> lstNFEsStatus, int? codigoUsuario, DateTime? dataStatus)
        {
            using (ERPModel model = new ERPModel())
            {

                string retornoUpdate = "";

                string acao = lstNFEsStatus[0];


                XmlTextWriter writer;




                AuxiliaryLibrary lib = new AuxiliaryLibrary();

                lib.OpenConnection();


                //Cria todas as DTs
                DataTable dtNFE = new DataTable();
                DataTable dtItens = new DataTable();


                foreach (string item in lstNFEsStatus)
                {

                    //Limpa as DTs
                    dtNFE.Clear();
                    dtItens.Clear();


                    string[] arrNFEsStatus = item.Split('|');

                    if (arrNFEsStatus.Length < 3)
                        continue;


                    bool existeProximaPagina = false;
                    List<FaturamentoExportarXMLDTO> dadosNFe = FaturamentoExportarXMLDAL.Instance.Pesquisar(Convert.ToInt32(arrNFEsStatus[0]), null, null, null, 3, null, out existeProximaPagina, 0);


                    string diretorioXMLTemp = "";
                    string diretorioXMLFinal = "";



                    if ((acao == "GERAR") && (arrNFEsStatus[1] != "0"))
                    {
                        retornoUpdate = "ERRO|Só é possível gerar XML para NFe em aberto";
                    }
                    else if (acao == "EXCLUIR" || acao == "CANCELAR")
                    {
                        /*
                        0 = "NF Produto";
                        1 = "NF Licença";
                        2 = "NF Serviço";
                        3 = "FAT";
                        */
                        int TipoNota = Convert.ToInt32(arrNFEsStatus[2]);



                        //Para voltar a numeração
                        string TipoNotaNumerecao = "";

                        switch (TipoNota)
                        {
                            case 0:
                                TipoNotaNumerecao = "P";
                                break;
                            case 1:
                                TipoNotaNumerecao = "L";
                                break;
                            case 2:
                                TipoNotaNumerecao = "S";
                                break;
                            case 3:
                                TipoNotaNumerecao = "FAT_LOC";
                                break;
                        }


                        try
                        {
                            decimal NumNF = 0;

                            //Verifica se é a Últmoa NFe
                            if (acao == "EXCLUIR")
                            {
                                FiscalDAL fiscal = new FiscalDAL();
                                int UltimaNumeracao = fiscal.UltimaNumeracao(TipoNota, Convert.ToInt32(dadosNFe[0].EMP_ID));

                                if (Convert.ToInt32(dadosNFe[0].NFE_NUMERO) != UltimaNumeracao)
                                {
                                    retornoUpdate = "ERRO|Só é possível excluir a última NFe";
                                    break;
                                }
                                else
                                {
                                    NumNF = Convert.ToDecimal(dadosNFe[0].NFE_NUMERO) - 1;
                                }
                            }




                            int PdVID = Convert.ToInt32(dadosNFe[0].PDV_ID);
                            int DepositoID = Convert.ToInt32(dadosNFe[0].PDV_DEPOSITO);


                            TransactionOptions option = new TransactionOptions();
                            option.IsolationLevel = System.Transactions.IsolationLevel.RepeatableRead;
                            option.Timeout = TimeSpan.FromMinutes(5);
                            using (TransactionScope tran = new TransactionScope(TransactionScopeOption.RequiresNew, option))
                            {
                                retornoUpdate = ContasReceberDAL.ExcluirPorNFe(Convert.ToInt32(arrNFEsStatus[0]));

                                if (retornoUpdate != "OK|OK")
                                    break;



                                dtItens.Clear();

                                string qryItens = " SELECT ITE_ID, NFI_PRODUTO_QTDE, NFI_PRODUTO_PRECO_UNITARIO ";
                                qryItens += " FROM FA_NOTA_FISCAL_ITENS_NFI NFI INNER JOIN PD_PEDIDO_ITEM_PIT PIT ON PIT.PIT_ID = NFI.PIT_ID ";
                                qryItens += " INNER JOIN ES_ITEM_ITE ITE ON ITE.ITE_ID = PIT.PIT_PRODUTO ";
                                qryItens += String.Format(" WHERE NFI.NFE_ID = '{0}' ", dadosNFe[0].NFE_ID);

                                lib.CreateDT(dtItens, qryItens);

                                if (dtItens.Rows.Count > 0)
                                {
                                    for (int i = 0; i <= dtItens.Rows.Count - 1; i++)
                                    {
                                        SessaoDTO session = (SessaoDTO)System.Web.HttpContext.Current.Session["Sessao"];

                                        //Tem que inverter
                                        string EntradaSaida = (dadosNFe[0].TPV_ENTRADA_SAIDA.ToString() == "0") ? "S" : "E";

                                        //Baixa do Estoque
                                        string[] arrGravarEstoque = EstoqueDAL.Instance.GravarEstoque(Convert.ToInt32(dtItens.Rows[i]["ITE_ID"]), Convert.ToDecimal(dtItens.Rows[i]["NFI_PRODUTO_QTDE"]), Convert.ToDecimal(dtItens.Rows[i]["NFI_PRODUTO_PRECO_UNITARIO"]), EntradaSaida, "", Convert.ToInt32(dadosNFe[0].PDV_CLIENTE), Convert.ToInt32(dadosNFe[0].EMP_ID), DepositoID, dadosNFe[0].NFE_NUMERO.ToString(), Convert.ToInt32(dadosNFe[0].NFE_ID), session.Usuario.USU_ID, 1, false, false, false).Split('|');

                                        if (arrGravarEstoque[0] == "ERROR")
                                            break;
                                    }
                                }
                                else
                                {
                                    retornoUpdate = "ERRO|Produtos não localizados";
                                    continue;
                                }

                                dtItens.Clear();




                                //Exclui a Movimentação de Estoque
                                EstoqueDAL.ExcluirMovimentacaoEstoquePorNFe_Produto(Convert.ToInt32(arrNFEsStatus[0]));


                                if (acao == "EXCLUIR")
                                {
                                    //Exclui Itens da NFe
                                    FiscalDAL.ExcluirNFe_Itens(Convert.ToInt32(arrNFEsStatus[0]));

                                    //Exclui a NFe
                                    FiscalDAL.ExcluirNFe(Convert.ToInt32(arrNFEsStatus[0]));

                                    //Grava na tabela GE_EMPRESA_EMP a nova numeração
                                    EmpresaDAL.Instance.GravarNumeracaoNotaFisca(Convert.ToInt32(dadosNFe[0].EMP_ID), NumNF, TipoNotaNumerecao);
                                }
                                else if (acao == "CANCELAR")
                                {
                                    //Seta o Status da NFe para "Cancelado"
                                    FiscalDAL.Instance.GravaStatusNF(Convert.ToInt32(dadosNFe[0].NFE_ID), 2, arrNFEsStatus[3]);



                                    string StatusNFe = "";
                                    switch (dadosNFe[0].NFE_STATUS)
                                    {
                                        case 1:
                                            StatusNFe = "FINALIZADO";
                                            break;
                                        case 2:
                                            StatusNFe = "CANCELADO";
                                            break;
                                        default:
                                            StatusNFe = "ABERTO";
                                            break;
                                    }


                                    var ConteudoAtualValorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "R$ {0:#,###.##}", dadosNFe[0].NFE_VALOR_TOTAL);


                                    //AvisoDAL.Instance.GravarAviso("Status", StatusNFe, "CANCELADO", 3, dadosNFe[0].NFE_ID, dadosNFe[0].PDV_CLIENTE, dadosNFe[0].EMP_ID);
                                    AvisoDAL.Instance.GravarAviso("Status", StatusNFe, ConteudoAtualValorFormatado.ToString(), 3, dadosNFe[0].NFE_ID, dadosNFe[0].PDV_CLIENTE, dadosNFe[0].EMP_ID);
                                }





                                PD_PEDIDO_VENDA_PDV dadosPedido = PedidoVendaDAL.Instance.BuscaPorID(PdVID, false);

                                if (dadosPedido.CON_ID.HasValue && dadosPedido.CON_ID.Value > 0)
                                {
                                    //Cancela o Pedido
                                    dadosPedido.PDV_CANCELADO_USU_ID = codigoUsuario;
                                    dadosPedido.PDV_CANCELADO_DATA = dataStatus;
                                    dadosPedido.PDV_STATUS = "4"; // 0 = Aberto | 1 = Piking | 2 = Liberado | 3 = Faturado | 4 = Faturado

                                    model.PD_PEDIDO_VENDA_PDV.Attach(dadosPedido);
                                    model.Entry(dadosPedido).State = EntityState.Modified;
                                    model.SaveChanges();
                                }
                                else
                                {
                                    //Seta no PDV Status de Liberado
                                    PedidoVendaDAL.Instance.GravaEmissaoNF(PdVID, "2"); //Liberado
                                }



                                retornoUpdate = "OK|OK";
                                tran.Complete();



                                string retornoExclusao = "";

                                try
                                {
                                    retornoExclusao = lib.ApagarXML(diretorioXMLTemp, diretorioXMLFinal, dadosNFe[0].NFE_ARQUIVO_XML.ToString());
                                }
                                catch (Exception ex)
                                {
                                    //LOG
                                    msgLog = "";
                                    msgLog = string.Format("ERRO|Erro ao Excluir o arquivo Físico de XML.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                                    msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                                    msgLog += "\n" + "Erro Informado: " + retornoExclusao;
                                    msgLog += "\n" + ex.Message;
                                    AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);
                                }


                            }//Fechar a Transação
                        }
                        catch (Exception ex)
                        {
                            //LOG
                            msgLog = "";
                            msgLog = string.Format("ERRO|Erro ao Excluir/Cancelar.....Hora: {0}.", DateTime.Now.ToString("HH:mm:ss"));
                            msgLog += "\n" + "NFE_ID: " + arrNFEsStatus[0] + " | NFE_NUMERO: " + dadosNFe[0].NFE_NUMERO.ToString();
                            msgLog += "\n" + ex.Message;
                            AuxiliaryLibrary.GerarLog("Erro de Sistema", msgLog);
                        }

                    }


                }//Fim FOREACH


                lib.CloseConnection();


                return retornoUpdate;
            }
        }






        public FA_NOTA_FISCAL_NFE BuscaPeloID(int id)
        {
            using (ERPModel context = new ERPModel())
            {
                return context.FA_NOTA_FISCAL_NFE.Where(n => n.NFE_ID.Equals(id)).SingleOrDefault();
            }
        }





        public bool AlterarObservacao(int NFE_ID, string NFE_OBSERVACAO, int? codigoUsuario, DateTime? dataStatus)
        {
            using (ERPModel model = new ERPModel())
            {

                bool retornoUpdate = false;



                try
                {
                    if ((NFE_ID > 0) && (NFE_OBSERVACAO != ""))
                    {
                        FA_NOTA_FISCAL_NFE dadosNFe = FaturamentoExportarXMLDAL.Instance.BuscaPeloID(NFE_ID);

                        dadosNFe.NFE_ALTERACAO_OBS_USU_ID = codigoUsuario;
                        dadosNFe.NFE_ALTERACAO_OBS_DATA = dataStatus;
                        dadosNFe.NFE_OBSERVACAO = NFE_OBSERVACAO;

                        model.FA_NOTA_FISCAL_NFE.Attach(dadosNFe);
                        model.Entry(dadosNFe).State = EntityState.Modified;
                        model.SaveChanges();


                        retornoUpdate = true;
                    }
                    else
                    {
                        retornoUpdate = false;
                    }
                }
                catch
                {
                    retornoUpdate = false;
                }



                return retornoUpdate;
            }
        }




    }
}
