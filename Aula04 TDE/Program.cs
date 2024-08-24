using System.Dynamic;

double totalPedido = 0;
bool pedidoAberto = true;
while (pedidoAberto)
{
    Console.WriteLine("Bem vindo ao sistema de gerenciamento de pedidos!");
    Console.WriteLine("1 - Adicionar item ao pedido: ");
    Console.WriteLine("2 - Exibir total do pedido");
    Console.WriteLine("3 - Finalizar e sair");
    Console.WriteLine("Escolha uma opção acima...");
    string opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
        Console.WriteLine("Escolha um item abaixo");
        Console.WriteLine(" 1 - pizza R$30,00");
        Console.WriteLine(" 1 - hamburguer R$15,00");
        Console.WriteLine(" 1 - refrigerante R$5,00");
        string escolha = Console.ReadLine();
        if(escolha == "1")
        {
            totalPedido = totalPedido + 30.00;
            Console.WriteLine("Pizza adicionada ao pedido");
        }
        else if(escolha == "2")
        {
            totalPedido += 15.00;
            Console.WriteLine("Hamburguereses adicionado ao pedido");
        }
        else if(escolha == "3")
        {
            totalPedido += 5.00;
            Console.WriteLine("Refrigerante adicionado ao pedido");
        }
        else
        {
            Console.WriteLine("Opção inválida");
        }
        break;
        case "2":
        Console.WriteLine($"O total do pedido é: {totalPedido}");
        break;
        case "3":
        Console.WriteLine("Obrigado por utilizar nosso sistma!");
        pedidoAberto = false;
        break;
        default:
        Console.WriteLine("Opção inválida...");
        break;
    }
} 