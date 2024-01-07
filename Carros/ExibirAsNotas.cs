using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros_DUB
{
    public static class ExibirAsNotas
    {
        public static void ExibirNotas(Dictionary<string, List<int>> carrosRegistrados)
        {
            Console.Clear();
            ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Avaliações dos Carros");
            foreach (var elemento in carrosRegistrados)
            {
                Console.WriteLine($"\n- {elemento.Key}");
            }
            Console.Write("\nDigite o nome do carro: ");
            string nomeDoCarro = Console.ReadLine()!;
            Console.Clear();

            if (carrosRegistrados.ContainsKey(nomeDoCarro))
            {
                ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Avaliações dos Carros");
                List<int> notaDoCarro = carrosRegistrados[nomeDoCarro];
                Console.WriteLine($"\nAs notas do carro {nomeDoCarro} são: {notaDoCarro.Average()}");
                Console.WriteLine("\nDigite alguma tecla para voltar ao menu");
                Console.ReadKey();
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Avaliações dos Carros");
                Console.WriteLine("\nEsse carro não está na tabela de avaliações");
                Console.WriteLine("\nDigite alguma tecla para voltar ao menu");
                Console.ReadKey();
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

    }
}
