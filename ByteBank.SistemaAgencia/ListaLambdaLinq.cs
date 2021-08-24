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
{                       /*========================> Curso 8: List, Lambda e Linq <==========================*/
   partial class Program
    {
        static void LidandoComListas()
        {
            var nomes = new List<string>()
            {
                "Wellington",
                "Guilherme",
                "Luana",
                "Ana"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>();

            idades.Add(1);      /*Add::::Adicionar*/
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            ListExtensoes.AdicionarVarios(idades, 12, 21, 34, 425);

            idades.AdicionarVarios(99, -1);

            idades.Sort();

            idades.Remove(5);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente (342, 98763943),
                new ContaCorrente (345, 98763957),
                null,
                new ContaCorrente (343, 1),
                null,
                null,
                new ContaCorrente (375, 98763943),
                null
            };


            //contas.Sort(); =====> Chamar a implementação dada em IComparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia());


            var contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                if (conta != null)
                {
                    Console.WriteLine($"Conta número {conta.Numero}, ag {conta.Agencia}");
                }
            }

            Console.ReadLine();
        }
    }
}
