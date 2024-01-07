using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Carros_DUB
{
    public static class ExibirAcessorios
    {
        public static void ExibirAcessorio()
        {
            Dictionary<string, List<string>> acessoriosRegistrados = new Dictionary<string, List<string>>();
            acessoriosRegistrados.Add("Pneu", new List<string> { "Pirelli", "Michelin", });
            acessoriosRegistrados.Add("Lanterna", new List<string> { "Lanterna traseira do Golf Gti", "Lanterna dianteira da Porsche Cayenne" });
            Dictionary<string, List<int>> marcaDosAcessorios = new Dictionary<string, List<int>>();
            marcaDosAcessorios.Add("Pirelli", new List<int> { 650 });


            Console.Clear();
            ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Acessorios");
            foreach (var elemento in acessoriosRegistrados)
            {
                Console.WriteLine($"\n- {elemento.Key}");
            }
            Console.WriteLine();
            Console.Write("Digite o nome do acessorio desejado: ");
            string acessorio = Console.ReadLine()!; 
            Console.Clear();

            if (acessoriosRegistrados.ContainsKey(acessorio))
            {
                ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Acessorios");

                Console.WriteLine("\nMarcas disponiveis");
                List<string> preco = acessoriosRegistrados[acessorio];
                foreach (var elemento in preco)
                {
                    Console.WriteLine($"\n- {elemento}");
                }
                Console.Write("\nDigite a marca do acessorio: ");
                string nomeDoAcessorio = Console.ReadLine()!;
                Console.Clear();

                if (marcaDosAcessorios.ContainsKey(nomeDoAcessorio))
                {
                    ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Acessorios");
                    List<int> marcas = marcaDosAcessorios[nomeDoAcessorio];
                    Console.WriteLine($"\nO pneu da marca {nomeDoAcessorio} custa {marcas.Average()}");
                }
                Console.WriteLine("\nDigite alguma tecla para voltar ao menu");
                Console.ReadKey();
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Acessorios");
                Console.WriteLine("\nEsse carro não está na tabela de avaliações");
                Console.ReadKey();
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
