using Projeto_loja_virtual;

Pagamento loja = new Pagamento();
Boleto bol = new Boleto();
Debito deb = new Debito();
CartaoCredito cred = new CartaoCredito();

string opcao;

Console.WriteLine($"Bem vindo a nossa loja virtual!");

Console.WriteLine($"Informe o valor da compra:");
float valorCompra = float.Parse(Console.ReadLine());


Console.WriteLine("Menu de Pagamentos");
Console.WriteLine("==================");
Console.WriteLine("1 - Pagamento em Boleto");
Console.WriteLine("2 - Pagamento em Cartão de Débito");
Console.WriteLine("3 - Pagamento em Cartão de Crédito");
Console.WriteLine("4 - Cancelar Operação");
Console.WriteLine("5 - Sair do Sistema");
Console.Write("Escolha uma opção: ");
opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        bol.valor = valorCompra;
        bol.Registrar();
        break;
    case "2":
        deb.valor = valorCompra;
        deb.Pagar();
        break;
    case "3":
        cred.valor = valorCompra;
        
        
        cred.Pagar();
        break;
    case "4":
        Console.WriteLine($"{loja.Cancelar()}");

        break;
    case "5":
        Console.WriteLine($"Saindo do sistema!");

        break;
    default:
        break;
}



