
using Carros_DUB;
using Carros_DUB.Acessorio;
using System;
using System.Collections.Generic;
using System.Threading.Channels;

Dictionary<string, List<int>> carrosRegistrados = new Dictionary<string, List<int>>();
carrosRegistrados.Add("Golf Gti", new List<int> { 8 });
carrosRegistrados.Add("Porsche Cayenne", new List<int> { 10 });

ExibirOpcoesDoMenu();
void ExibirLogo()
{
    Console.WriteLine(@"
                        ░█▀▀█ █▀▀█ █▀▀█ █▀▀█ █▀▀█ █▀▀ 　 ░█▀▀▄ ░█─░█ ░█▀▀█ 
                        ░█─── █▄▄█ █▄▄▀ █▄▄▀ █──█ ▀▀█ 　 ░█─░█ ░█─░█ ░█▀▀▄ 
                        ░█▄▄█ ▀──▀ ▀─▀▀ ▀─▀▀ ▀▀▀▀ ▀▀▀ 　 ░█▄▄▀ ─▀▄▄▀ ░█▄▄█
");
    Console.WriteLine("Bem vindo ao Carros DUB!!\n");
}
ExibirOpcoesDoMenu();
void ExibirOpcoesDoMenu() {
    ExibirLogo();
    Console.WriteLine("Digite 1 para exibir os carros"); 
    Console.WriteLine("Digite 2 para registrar um carro");
    Console.WriteLine("Digite 3 para ver os acessorios");
    Console.WriteLine("Digite 4 para avaliar um carro"); 
    Console.WriteLine("Digite 5 para ver a avaliação de um carro");
    Console.WriteLine("Digite qualquer outra coisa para sair\n");
    Console.Write("Escolha uma opção: ");

    string opcaoEscolhida = Console.ReadLine()!;

    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            ExibirOsCarros.ExibirOCarro(carrosRegistrados);
            ExibirOpcoesDoMenu();
            break;
        case 2:
            carrosRegistrados.Add(RegistrarCarros.RegistrarCarro(), new List<int>());
            ExibirOpcoesDoMenu();
            break;
        case 3:
            ExibirAcessorios.ExibirAcessorio();
            ExibirOpcoesDoMenu();
            break;
        case 4:
            AvaliarUmCarro.AvaliarOCarro(carrosRegistrados);
            ExibirOpcoesDoMenu();
            break;
        case 5:
            ExibirAsNotas.ExibirNotas(carrosRegistrados);
            ExibirOpcoesDoMenu();
            break;
        default:
            Console.WriteLine("\nVoce digitou uma opção não existente na tabela!!");
            break;
    }

}






//Descricao pneusPirelli = new Descricao();
//pneusPirelli.Nome = "Pirelli";


//Acessorios acessorios1 = new Acessorios("Pneu Scorpion");
//acessorios1.Marca = "Pirelli";
//acessorios1.Preço = 370.50;
//Console.WriteLine(acessorios1.DescricaoDaPeca);


//Acessorios acessorios2 = new Acessorios("Pneu Cinturato");
//acessorios2.Marca = "Pirelli";
//acessorios2.Preço = 300.50;
//Console.WriteLine(acessorios2.DescricaoDaPeca);


//pneusPirelli.AdicionarAcessorio(acessorios1);
//pneusPirelli.AdicionarAcessorio(acessorios2);

//Modelos pirelli = new Modelos();
//pirelli.Nome = "Pirelli";
//pirelli.AdicionarModelos(pneusPirelli);
//pirelli.ExibirMarcas();
