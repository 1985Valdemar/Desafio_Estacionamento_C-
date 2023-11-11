using DESAFIOFUNDAMENTOS.Models;

bool sair = true;

Console.WriteLine("Seja Bem Vindo no Sistema de Estacionamento!");
Console.WriteLine("Digite o preço inicial");
int precoInicial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora");
int precoHora = Convert.ToInt32(Console.ReadLine());

Estacionamento estacionamento1 = new Estacionamento(precoInicial, precoHora);

do
{
    Console.Clear();
    Console.WriteLine("Digite uma opção!");
    Console.WriteLine("\r\n1 - Cadastrar Transporte");
    Console.WriteLine("\r\n2 - Remover Transporte");
    Console.WriteLine("\r\n3 - Listar Transporte");
    Console.WriteLine("\r\n4 - Encerrar");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            estacionamento1.CadastrarTransporte();
            break;
        case 2:
            estacionamento1.RemoverTransporte();

            break;
        case 3:
            estacionamento1.ListarTransporte();
            break;
        case 4:
            sair = false;
            break;
        default:
            Console.WriteLine("Erro. Digite uma opção válida.");
            break;
    }
    Console.WriteLine("Pressione qualquer tecla para continuar:");
    string batata = Console.ReadLine();
    
} while (sair);

