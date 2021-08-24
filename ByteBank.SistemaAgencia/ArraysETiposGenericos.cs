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
{
    partial class Program
    {
        static void LidandoComArraysETiposGenericos()
        {                           //======================> Array de inteiros com 5 posições<==============\\

            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            Console.WriteLine(idades[4]);
            //========================================================================> PARTE I - curso 7

            ContaCorrente[] contas = new ContaCorrente[]
               {
                   new ContaCorrente(874, 5679787),
                   new ContaCorrente(874, 4456668),
                   new ContaCorrente(874, 7781438)
               };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        //=========================================================================> PARTE II - curso 7

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
        static void TestaListaDeContaCorrente()
        {

            Console.WriteLine(SomarVarios(1, 2, 3, 5, 2453, 45));
            Console.WriteLine(SomarVarios(1, 2, 45));

            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice{i}:{idade}");
            }

            {
                ListaDeContaCorrente lista = new ListaDeContaCorrente();

                ContaCorrente contaDoGui = new ContaCorrente(333, 33333333);

                ContaCorrente[] contas = new ContaCorrente[]
                {
                        contaDoGui,
                        new ContaCorrente(111, 2222222),
                        new ContaCorrente(874, 5679754)

                };

                lista.AdicionarVarios(contas);
                lista.AdicionarVarios
                    (
                    contaDoGui,
                    new ContaCorrente(874, 5679754),
                    new ContaCorrente(874, 5679754),
                    new ContaCorrente(874, 5679754),
                    new ContaCorrente(874, 5679754)
                    );

                for (int i = 0; i < lista.Tamanho; i++)
                {
                    ContaCorrente itemAtual = lista.GetItemIndice(i);
                    Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero} / {itemAtual.Agencia} ");
                }
                Console.ReadLine();
            }

            Lista<int> idades = new Lista<int>();
            idades.Adicionar(5);
            idades.AdicionarVarios(1, 5, 78);

            int idadeSoma = 0;
            for (int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }



            //lista.Remover(contaDoGui);
            Console.WriteLine("Após remover o item.");
        }
    }
}
