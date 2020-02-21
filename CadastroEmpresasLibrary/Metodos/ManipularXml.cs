using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace CadastroEmpresaLibrary.Metodos
{
    
    public class ManipularXml
    {
        private readonly CookieContainer _cookies = new CookieContainer();
        private string urlBaseReceitaFederal = "http://www.rececita.fazenda.gov.br/pessoajuridica/cnpj/cnpjreva/";
        private string paginaValidacao = "Valida.asp";
        private string paginaPrincipal = "cnpjreva_solicitacao2.asp";
        private string paginaCaptcha = "captcha/gerarCaptcha.asp";

        public BitMap GetCaptcha()
        {
            string htmlResult;

            using( var wc = new CookieAwareWebClient())
            {
                wc.SetCookieContainer(_cookies);
                wc.Headers[HttpRequestHeader.UserAgent] = "Mozilla/4.0 (compatible; Synapse)";
                wc.Headers[HttpRequestHeader.KeepAlive] = "300";
                htmlResult = wc.DownloadString(urlBaseReceitaFederal + paginaPrincipal);
            }
            if(htmlResult.Length > 0)
            {
                var wc2 = new CookieAwareWebClient();
                wc2.SetCookieContainer(_cookies);
                wc2.Headers[HttpRequestHeader.UserAgent] = "Mozilla/4.0 (compatible; Synapse)";
                wc.Headers[HttpRequestHeader.KeepAlive] = "300";
                byte[] data = wc2.DownloadData(urlBaseReceitaFederal + paginaCaptcha);
                return new BitMap(new MemoryStream(data));
            }
            return null;
        }

        public String Consulta(string aCNPJ, string aCaptcha)
        {
            var request = (HttpWebRequest)WebRequest.Create(urlBaseReceitaFederal + paginaValidacao);
            request.ProtocolVersion = HttpVersion.Version10;
            request.CookieContainer = _cookies;
            request.Method = "POST";

            string postData = "";
            postData = postData + "origem=comprovante&";
            postData = postData + "cnpj=" + new Regex(@"[^\d]").Replace(aCNPJ, string.Empty) + "&";
            postData = postData + "txtTexto_captcha_serpro_gov_br=" + aCaptcha + "&";
            postData = postData + "submit1=consultar&";
            postData = postData + "search_type=cnpj";

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();
            StreamReader stHtml = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("ISO-8859-1"));
            String retorno = stHtml.ReadToEnd();

            if (retorno.Contains("Verifique se o mesmo foi digitado corretamente"))
                throw new System.InvalidOperationException("O numero do CNPJ nao foi digitado corretamente");
            if (retorno.Contains("Erro na consulta"))
                throw new System.InvalidOperationException("Os caracteres digitados não correspondem com a imagem");
            return retorno;

        }

    }
}
