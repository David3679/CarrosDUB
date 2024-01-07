using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros_DUB
{
    public static class ExibirOsCarros
    {
      
        
        
        public static void ExibirOCarro(Dictionary<string, List<int>> carrosRegistrados)
        {
            Console.Clear();
            ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Carros disponiveis para a venda");
            foreach (string carros in carrosRegistrados.Keys)
            {
                Console.WriteLine($"\n- {carros}");
            }
            Console.WriteLine("\nDigite alguma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
            Thread.Sleep(1000);

        }



    }
}
