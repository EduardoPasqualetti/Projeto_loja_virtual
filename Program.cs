using Projeto_loja_virtual;

Pagamento loja = new Pagamento();
Boleto bol = new Boleto();
Debito deb = new Debito();
CartaoCredito cred = new CartaoCredito();

string opcao;
string denovo;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(@$"
--------------------------------------
|   Bem vindo a nossa loja virtual!  |
--------------------------------------
"); Console.ResetColor();
do
{
  
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Informe o valor da compra:");
    float valorCompra = float.Parse(Console.ReadLine());

    Console.WriteLine(@$"
       Escolha a forma de Pagamento:
    ====================================

    1 - Pagamento em Boleto
    2 - Pagamento em Cartão de Débito
    3 - Pagamento em Cartão de Crédito
    4 - Cancelar Operação
    5 - Sair do Sistema
    
            Escolha uma Opcão: 
    ");
    opcao = Console.ReadLine();

    Console.ResetColor();

    switch (opcao)
    {
        case "1":
        
            bol.valor = valorCompra;
            Console.WriteLine($"");
            bol.Registrar();
            Console.WriteLine($"");
        
            break;
        case "2":
            deb.valor = valorCompra;
            Console.WriteLine($"");
            deb.Pagar();
            Console.WriteLine($"");
            break;
        case "3":
            cred.valor = valorCompra;
            Console.WriteLine($"");
            cred.Pagar();
            Console.WriteLine($"");
            break;
        case "4":
            Console.WriteLine($"");
            Console.WriteLine($"{loja.Cancelar()}");
            Console.WriteLine($"");
            break;
        case "5":
            Console.WriteLine($"");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Saindo do sistema!");
            Console.WriteLine($"");
            Console.ResetColor();
            break;
        default:
            Console.WriteLine($"");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opao Invalida, Tente novamente e escolha uma opcao valida!");
            Console.WriteLine($"");
            Console.ResetColor();
            break;
    }


} while (opcao != "5");




