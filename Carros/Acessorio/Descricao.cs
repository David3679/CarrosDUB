using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros_DUB.Acessorio
{
    class Descricao
    {

        private List<Acessorios> acessorio = new List<Acessorios>();
        public string Nome { get; set; }

        public double ValorDaPeca => acessorio.Sum(m => m.Preço);


        public void AdicionarAcessorio(Acessorios acessorios)
        {
            acessorio.Add(acessorios);
        }

        public void ExibirAcessorios()
        {
            Console.WriteLine("Lista de todos os acessorios");
            foreach (var acessorios in acessorio)
            {
                Console.WriteLine(acessorios.Nome);
            }

        }

    }
}
