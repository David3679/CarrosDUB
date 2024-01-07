using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros_DUB
{
    public static class RegistrarCarros
    {
        public static string RegistrarCarro()
        {
            Console.Clear();
            ExibicaoDeTitulo.ExibirModulacaoDoTitulo("Registro de Carros");
            Console.Write("Digite o nome do carro para registrar: ");
            string nomeDoCarro = Console.ReadLine()!;
            Console.WriteLine($"\nO carro {nomeDoCarro} foi adicionado com sucesso!");
            Console.WriteLine("\nDigite alguma tecla para voltar ao menu");
            Console.ReadKey();
            Thread.Sleep(1000);
            Console.Clear();
            return nomeDoCarro;
        }
    }
}
