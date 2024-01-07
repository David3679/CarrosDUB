using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros_DUB
{

public static class ExibicaoDeTitulo
    {
        public static void ExibirModulacaoDoTitulo(string titulo)
        {

            int quantidadeDeLetras = titulo.Length;
            string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '-');
            Console.WriteLine(asterisco);
            Console.WriteLine(titulo);
            Console.WriteLine(asterisco + "\n");
        }

            
        
    }
}
