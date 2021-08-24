using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;
using ByteBank.SistemaAgencia.Extensoes;
using ByteBank.SistemaAgencia.Comparadores;

namespace ByteBank.SistemaAgencia
{                 //===================> Curso 6 conhecendo strings e substrings <=========================\\
    partial class Program
    {
        public static void Main(string[] args)
        {
            //Olá, meu nome é Guilherme e você pode entrar em contato comigo
            //através do número 8457 - 4456!

            //Meu nome é Guilherme, me ligue em 8457 - 4456


            //"[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //"[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //"[0-9]{4}[-][0-9]{4}"; { { { { { quatidade de vezes que o padrão se repete} } } } }
            //"[0-9]{4,5}[-][0-9]{4}"; --------------> 4,5 aceita 4 ou 5 números no telefone
            //"[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //"[0-9]{4,5}-{0,1}[0-9]{4}";

            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Guilherme, me ligue em 8457-4457";

            Match resultado = Regex.Match(textoDeTeste, padrao);
            Console.WriteLine(resultado.Value);

            //Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Console.ReadLine();

            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            urlTeste.StartsWith("https://www.bytebank.com");
            urlTeste.EndsWith("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));             /*StartWith: começa com*/
            Console.WriteLine(urlTeste.EndsWith("cambio"));                                 /*EndsWith: termina com*/
            Console.WriteLine(urlTeste.Contains("ByteBank"));                               /*Contains: contém*/

            //Console.WriteLine(indiceByteBank == 0);

            Console.ReadLine();
            //pagina? argumentos
            //0123456789


            //moedaOrigem = real & moedaDestino = dolar

            //--------------------------------------------------------------------------------------Testando ToLower


            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToUpper());
            Console.WriteLine(mensagemOrigem.ToLower());

            //---------------------------------------------------------------------------------------Testando Replace

            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();

            string urlParametros = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);


            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.ReadLine();

            //-----------------------------------------------------------------------------Testando o método Remove

            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));

            Console.ReadLine();


            string palavra = "moedaOrigem=IReadOnlyList&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);

            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string " + nomeArgumento.Length);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));

            Console.ReadLine();

            //-------------------------------------------------------------------------------Testando o IsNullOrEmpty


            string textoVazio = "";
            string textoNulo = null;
            string textoQualquer = "lkshfo";


            Console.WriteLine(string.IsNullOrEmpty(textoVazio));
            Console.WriteLine(string.IsNullOrEmpty(textoNulo));
            Console.WriteLine(string.IsNullOrEmpty(textoQualquer));

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

            string url = "pagina?argumentos";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(indiceInterrogacao);

            Console.WriteLine(url);
            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);

            Console.ReadLine();
        }
    }
}

