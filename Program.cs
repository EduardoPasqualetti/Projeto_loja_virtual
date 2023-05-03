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

    0 - Sair do Sistema
    
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
            Console.WriteLine($"Digite o nome do titular do cartao:");
            deb.Titular = Console.ReadLine();
            Console.WriteLine($"Informe a Bandeira do cartao:");
            deb.Bandeira = Console.ReadLine();
            Console.WriteLine($"Informe o numero do cartao:");
            deb.NumeroCartao = Console.ReadLine();
            Console.WriteLine($"Informe o CVV do cartao:");
            deb.Cvv = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"As informacoes do cartao foram salvas!");
            Console.ResetColor();
            
            deb.valor = valorCompra;
            Console.WriteLine($"");
            deb.Pagar();
            Console.WriteLine($"");
            break;
        case "3":
                    Console.WriteLine($"Digite o nome do titular do cartao:");
            cred.Titular = Console.ReadLine();
            Console.WriteLine($"Informe a Bandeira do cartao:");
            cred.Bandeira = Console.ReadLine();
            Console.WriteLine($"Informe o numero do cartao:");
            cred.NumeroCartao = Console.ReadLine();
            Console.WriteLine($"Informe o CVV do cartao:");
            cred.Cvv = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"As informacoes do cartao foram salvas!");
            Console.ResetColor();

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
        case "0":
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


} while (opcao != "0");




