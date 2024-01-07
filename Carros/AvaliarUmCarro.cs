using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros_DUB
{
    public static class AvaliarUmCarro
    {
        public static Dictionary<string, List<int>> AvaliarOCarro(Dictionary<string, List<int>> carrosRegistrados)
        {
            Console.Clear();
            ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Carros para avaliação");
            foreach (var elemento in carrosRegistrados)
            {
                Console.WriteLine($"\n- {elemento.Key}");
            }
            Console.Write("\nDigite o nome do carro que quer avaliar: ");
            string nomeDoCarro = Console.ReadLine()!;
            Console.Clear();
            Thread.Sleep(1000);

            if (carrosRegistrados.ContainsKey(nomeDoCarro))
            {
                ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Carros para avaliação");
                Console.Write($"Qual nota voce da ao carro {nomeDoCarro}: ");
                int notasDosCarros = int.Parse(Console.ReadLine()!);
                carrosRegistrados[nomeDoCarro].Add(notasDosCarros);
                Console.WriteLine($"\nVoce deu a nota {notasDosCarros} para o carro {nomeDoCarro}");

                Console.WriteLine("\nDigite alguma tecla para voltar ao menu");
                Console.ReadKey();
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Carros para avaliação");
                Console.WriteLine($"Este carro {nomeDoCarro} não está na lista para ser avaliado\n");
                Console.WriteLine("\nDigite alguma tecla para voltar ao menu");
                Console.ReadKey();
                Thread.Sleep(1000);
                Console.Clear();
            }
            return carrosRegistrados;
        }

    }
}
