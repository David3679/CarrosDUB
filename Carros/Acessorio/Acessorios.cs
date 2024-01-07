using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros_DUB.Acessorio
{
    class Acessorios
    {
        public Acessorios(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public double Preço { get; set; }
        
        public string Marca { get; set;}
        public bool Disponivel { get; }

        public string DescricaoDaPeca =>
            $"O acessorio {Nome} pertence á marca {Marca}";

        public void ExibirInformacoesAcessorios()
        {

            if (Disponivel)
            {
                Console.WriteLine($"Temos o acessorio {Nome}");
                Console.WriteLine($"O preço dele é de {Preço}");
            }

        }

    }

}
