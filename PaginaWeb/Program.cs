using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PaginaWeb
{
    internal class Program
    {
        public static string dadosIndex =>
            @"<!DOCTYPE html>
                <html lang=""en"">
                <head>
                    <meta charset=""UTF-8"">
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                    <title>C# Completo</title>
                </head>
                <body>
                    <h1>Olá, esta é a primeira pagina do servidor web</h1>
                    <h2>Testando minha aplicação</h2>
                </body>
                </html>";

        public static string dadosErro =>
            @"<!DOCTYPE html>
            <html lang=""en"">
            <head>
                <meta charset=""UTF-8"">
                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                <title>C# Completo</title>
            </head>
            <body>
                <h1>Página invalida</h1>
                <h2>Esta página não existe no servidor</h2>
            </body>
            </html>";

        public static string dadosFormPost =>
            "<!DOCTYPE html>" +
            "<html>" +
                "<head>" +
                    "<title>C#completo</title>" +
                    "<meta charset=\"utf-8\">" +
                "</head>" +
                "<body>" +
                    "<header>" +
                        "<h1>Aprenda tudo em C#</h1>" +
                        "<p>Essa é uma página em HTML</p>" +
                        "<br>" +
                    "</header>" +
                    "<section id = \"contato\">" +
                        "<h2> Meu primeiro formulário HTML</h1>" +
                        "<form method = \"post\" action= \"acao_post_login\">" +
                            "<label for=\"id_nome\">Digite o seu nome: </label>" +
                            "<input type = \"text\" id= \"id_nome\" name= \"nome\" ><br><br>" +
                            "<label for=\"id_senha\">Digite a sua senha: </label>" +
                            "<input type = \"text\" id= \"id_senha\" name= \"senha\" ><br><br>" +
                            "<input type= \"submit\" value= \"enviar login com post\">" +
                        "</form>" +
                    "</section>" +
                "</body>" +
            "</html>";

        public static string dadosFormGet =>
            "<!DOCTYPE html>" +
            "<html>" +
                "<head>" +
                    "<title>C#completo</title>" +
                    "<meta charset=\"utf-8\">" +
                "</head>" +
                "<body>" +
                    "<header>" +
                        "<h1>Aprenda tudo em C#</h1>" +
                        "<p>Essa é uma página em HTML</p>" +
                        "<br>" +
                    "</header>" +
                    "<section id = \"contato\">" +
                        "<h2> Meu primeiro formulário HTML</h1>" +
                        "<form method = \"get\" action= \"acao_get_login\">" +
                            "<label for=\"id_nome\">Digite o seu nome: </label>" +
                            "<input type = \"text\" id= \"id_nome\" name= \"nome\" ><br><br>" +
                            "<label for=\"id_senha\">Digite a sua senha: </label>" +
                            "<input type = \"text\" id= \"id_senha\" name= \"senha\" ><br><br>" +
                            "<input type= \"submit\" value= \"enviar login com get\">" +
                        "</form>" +
                    "</section>" +
                "</body>" +
            "</html>";

        public static string dadosPaginaLoginSucesso =
           "<!DOCTYPE html>" +
            "<html>" +
                "<head>" +
                    "<title>C# completo</title>" +
                    "<meta charset=\"utf-8\">" +
                "</head>" +
                "<body>" +
                    "<h1>Login sucesso!</h1>" +
                "</body>" +
            "</html>";

        public static string dadosPaginaLoginFalha =
           "<!DOCTYPE html>" +
            "<html>" +
                "<head>" +
                    "<title>C# completo</title>" +
                    "<meta charset=\"utf-8\">" +
                "</head>" +
                "<body>" +
                    "<h1>Login falhou!</h1>" +
                "</body>" +
            "</html>";

        static void Main(string[] args)
        {
            string url = "http://*:80/";
            byte[] dados;
            bool executando = true;

            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add(url);
            httpListener.Start();
            Console.WriteLine("Iniciando Servidor Web");
            Console.WriteLine("URL: " + url);

            while (executando)
            {
                Console.WriteLine("Aguardando conexões");
                HttpListenerContext conexao = httpListener.GetContext();
                Console.WriteLine("Conexão estabelecida");

                HttpListenerRequest request = conexao.Request;
                HttpListenerResponse response = conexao.Response;

                if(request.HttpMethod == "GET")
                {
                    switch (request.Url.AbsolutePath)
                    {
                        case "/favicon.ico":
                            dados = new byte[0];
                            break;
                        case "/MinhaPagina":
                            dados = Encoding.UTF8.GetBytes(dadosIndex);
                            break;
                        case "/login":
                            dados = Encoding.UTF8.GetBytes(dadosFormGet);
                            break;
                        case "/loginpost":
                            dados = Encoding.UTF8.GetBytes(dadosFormPost);
                            break;
                        case "/acao_get_login":
                            NameValueCollection parametros = HttpUtility.ParseQueryString(request.Url.Query);
                            if (parametros["nome"] == "Lucas" && parametros["senha"] == "2037")
                            {
                                dados = Encoding.UTF8.GetBytes(dadosPaginaLoginSucesso);
                            }
                            else
                            {
                                dados = Encoding.UTF8.GetBytes(dadosPaginaLoginFalha);
                            }
                            break;
                        default:
                            dados = Encoding.UTF8.GetBytes(dadosErro); 
                            break;
                    }
                }
                else if (request.HttpMethod == "POST")
                {
                    switch (request.Url.AbsolutePath)
                    {
                        case "/acao_post_login":
                            string dadosPost = new StreamReader(request.InputStream, request.ContentEncoding).ReadToEnd();
                            NameValueCollection parametros = HttpUtility.ParseQueryString(dadosPost);
                            if (parametros["nome"] == "Lucas" && parametros["senha"] == "2037")
                            {
                                dados = Encoding.UTF8.GetBytes(dadosPaginaLoginSucesso);
                            }
                            else
                            {
                                dados = Encoding.UTF8.GetBytes(dadosPaginaLoginFalha);
                            }
                            break;
                        default:
                            dados = Encoding.UTF8.GetBytes(dadosErro);
                            break;
                    }
                }
                else
                {
                    dados = Encoding.UTF8.GetBytes(dadosErro);
                }

                response.ContentType = "text/html";
                response.ContentEncoding = Encoding.UTF8;
                response.ContentLength64 = dados.LongLength;

                response.OutputStream.WriteAsync(dados, 0, dados.Length);
                response.Close();
            }
            httpListener.Close();
        }
    }
}
