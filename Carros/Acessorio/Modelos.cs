using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros_DUB.Acessorio
{
    class Modelos
    {
        private List<Descricao> descricoes = new List<Descricao>();
        public string Nome { get; set; }

        public void AdicionarModelos(Descricao descricao) 
        {
            descricoes.Add(descricao);
        }

        public void ExibirMarcas()
        {
            foreach (Descricao descricao in descricoes)
            {
                Console.WriteLine($"temos{descricao.Nome}");
            }
        }
    }
}
