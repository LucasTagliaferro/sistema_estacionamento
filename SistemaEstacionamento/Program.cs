using SistemaEstacionamento.Models;

// Configura o encoding para UTF8 para garantir que acentos sejam exibidos corretamente no terminal
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial (Ex: 5,00):");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora (Ex: 2,00):");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento com os valores configurados
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

// O laço while garante que o programa continue rodando até o usuário escolher a opção de encerrar
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("=================================");
    Console.WriteLine("      MENU DO ESTACIONAMENTO     ");
    Console.WriteLine("=================================");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.WriteLine("=================================");
    Console.Write("Digite a sua opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo(); // Descomentaremos quando o método estiver pronto
            Console.WriteLine("Módulo de adicionar em construção...");
            break;

        case "2":
            es.RemoverVeiculo(); // Descomentaremos quando o método estiver pronto
            Console.WriteLine("Módulo de remover em construção...");
            break;

        case "3":
            es.ListarVeiculos(); // Descomentaremos quando o método estiver pronto
            Console.WriteLine("Módulo de listar em construção...");
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    // Pausa a tela antes de limpar e mostrar o menu novamente
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou. Até logo!");