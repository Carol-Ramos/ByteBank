using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

namespace ByteBank.SistemaAgencia
{                       /*========================> Curso 8: List, Lambda e Linq <==========================*/
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(1);      /*Add::::Adicionar*/
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            ListExtensoes.AdicionarVarios(idades, 12, 21, 34, 425);

            idades.AdicionarVarios(5, 28, 23, 78);



            idades.Remove(5);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
            Console.ReadLine();
        }
    }
}















//Curso 7: Arrays e tipos genéricos

//Array de inteiros com 5 posições

//int[] idades = new int[5];

//idades[0] = 15;
//idades[1] = 28;
//idades[2] = 35;
//idades[3] = 50;
//idades[4] = 28;

//Console.WriteLine(idades[4]);
//---------------------Parte 1

//ContaCorrente[] contas = new ContaCorrente[]
//   {
//        new ContaCorrente(874, 5679787),
//        new ContaCorrente(874, 4456668),
//        new ContaCorrente(874, 7781438)
//   };

//for (int indice = 0; indice < contas.Length; indice++)
//{
//    ContaCorrente contaAtual = contas[indice];
//    Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
//}

//---------------- Parte 2- curso 7

//class Program
//{
//    static void Main(string[] args)
//    {

//        //Console.WriteLine(SomarVarios(1, 2, 3, 5, 2453, 45));
//        //Console.WriteLine(SomarVarios(1, 2, 45));

//        //static int SomarVarios(params int[] numeros)
//        //{
//        //    int acumulador = 0;
//        //    foreach (int numero in numeros)
//        //    {
//        //        acumulador += numero;
//        //    }
//        //    return acumulador;
//        //}

//        //static void TestaListaDeContaCorrente()

//        ListaDeObject listaDeIdades = new ListaDeObject();

//        listaDeIdades.Adicionar(10);
//        listaDeIdades.Adicionar(5);
//        listaDeIdades.Adicionar(4);
//        listaDeIdades.AdicionarVarios(16, 23, 60);

//        for (int i = 0; i < listaDeIdades.Tamanho; i++)
//        {
//            int idade = (int)listaDeIdades[i];
//            Console.WriteLine($"Idade no indice{i}:{idade}");
//        }

//{
//    ListaDeContaCorrente lista = new ListaDeContaCorrente();

//    ContaCorrente contaDoGui = new ContaCorrente(333, 33333333);

//    ContaCorrente[] contas = new ContaCorrente[]
//    {
//    contaDoGui,
//    new ContaCorrente(111, 2222222),
//    new ContaCorrente(874, 5679754)

//    };

//    lista.AdicionarVarios(contas);
//    lista.AdicionarVarios
//        (
//        contaDoGui,
//        new ContaCorrente(874, 5679754),
//        new ContaCorrente(874, 5679754),
//        new ContaCorrente(874, 5679754),
//        new ContaCorrente(874, 5679754)
//       );

//    for (int i = 0; i < lista.Tamanho; i++)
//    {
//        ContaCorrente itemAtual = lista.GetItemIndice(i);
//        Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero} / {itemAtual.Agencia} ");
//    }
//    Console.ReadLine();
//}

//            Lista<int> idades = new Lista<int>();
//            idades.Adicionar(5);
//            idades.AdicionarVarios(1, 5, 78);

//            int idadeSoma = 0;
//            for (int i = 0; i < idades.Tamanho; i++)
//            {
//                int idadeAtual = idades[i];
//            }


//            //lista.Remover(contaDoGui);
//            //Console.WriteLine("Após remover o item.");


//Curso 6 conhecendo strings e substrings

//class Program
//{
//    public static void Main(string[] args)
//    {
//        
//Olá, meu nome é Guilherme e você pode entrar em contato comigo
//através do número 8457-4456!

//Meu nome é Guilherme, me ligue em 8457 - 4456

// "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
// "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
// "[0-9]{4}[-][0-9]{4}";         {{{{{ quatidade de vezes que o padrão se repete}}}}}
// "[0-9]{4,5}[-][0-9]{4}";--------------> 4,5 aceita 4 ou 5 números no telefone
// "[0-9]{4,5}[-]{0,1}[0-9]{4}";
// "[0-9]{4,5}-{0,1}[0-9]{4}";

//string padrao = "[0-9]{4,5}-?[0-9]{4}";
//string textoDeTeste = "Meu nome é Guilherme, me ligue em 8457-4457";

//Match resultado = Regex.Match(textoDeTeste, padrao);
//Console.WriteLine(resultado.Value);

////Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

//Console.ReadLine();



//string urlTeste = "https://www.bytebank.com/cambio";
//int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

//urlTeste.StartsWith("https://www.bytebank.com");
//urlTeste.EndsWith("https://www.bytebank.com");

//Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));             /*StartWith: começa com*/
//Console.WriteLine(urlTeste.EndsWith("cambio"));                                 /*EndsWith: termina com*/
//Console.WriteLine(urlTeste.Contains("ByteBank"));                               /*Contains: contém*/

////Console.WriteLine(indiceByteBank == 0);

//Console.ReadLine();


//pagina? argumentos
//0123456789

//moedaOrigem = real & moedaDestino = dolar


//Testando ToLower

//string mensagemOrigem = "PALAVRA";
//string termoBusca = "ra";

//Console.WriteLine(mensagemOrigem.ToUpper());
//Console.WriteLine(mensagemOrigem.ToLower());

////Testando Replace

//termoBusca = termoBusca.Replace('r', 'R');
//Console.WriteLine(termoBusca);

//termoBusca = termoBusca.Replace('a', 'A');
//Console.WriteLine(termoBusca);

//Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
//Console.ReadLine();

//string urlParametros = "https://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
//ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);


//string valor = extratorDeValores.GetValor("moedaDestino");
//Console.WriteLine("Valor de moedaDestino: " + valor);

//string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
//Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

//Console.ReadLine();

////Testando o método Remove

//string testeRemocao = "primeiraParte&parteParaRemover";
//int indiceEComercial = testeRemocao.IndexOf('&');
//Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));

//Console.ReadLine();


//string palavra = "moedaOrigem=IReadOnlyList&moedaDestino=dolar";
//string nomeArgumento = "moedaDestino=";

//int indice = palavra.IndexOf(nomeArgumento);

//Console.WriteLine(indice);

//Console.WriteLine("Tamanho da string " + nomeArgumento.Length);
//Console.WriteLine(palavra.Substring(indice));
//Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));

//Console.ReadLine();



//Testando o IsNullOrEmpty

//string textoVazio = "";
//string textoNulo = null;
//string textoQualquer = "lkshfo";


//Console.WriteLine(string.IsNullOrEmpty(textoVazio));
//Console.WriteLine(string.IsNullOrEmpty(textoNulo));
//Console.WriteLine(string.IsNullOrEmpty(textoQualquer));

//ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL("");

//string url = "pagina?argumentos";

//int indiceInterrogacao = url.IndexOf('?');

//Console.WriteLine(indiceInterrogacao);

//Console.WriteLine(url);
//string argumentos = url.Substring(indiceInterrogacao + 1);
//Console.WriteLine(argumentos);

//Console.ReadLine();



