
namespace Projeto_loja_virtual
{
    public abstract class Cartao : Pagamento
    {
        //PROPRIEDADES
        public string Bandeira { get; set; }

        public string NumeroCartao { get; set; }

        public string Titular { get; set; }

        public string Cvv { get; set; }

        //MÉTODOS

        public abstract void Pagar();

        public string SalvarCartao()
        {
            Console.WriteLine($"Informe a bandeira do cartão: ");
            this.Bandeira = Console.ReadLine();

            Console.WriteLine($"Informe o número do cartão: ");
            this.NumeroCartao = Console.ReadLine();

            Console.WriteLine($"Informe o nome do titular: ");
            this.Titular = Console.ReadLine();

            Console.WriteLine($"Informe o Cvv do cartão: ");
            this.Cvv = Console.ReadLine();

            return @$"A bandeira do cartão informado é: {this.Bandeira}

                O número do cartão informado é : {this.NumeroCartao}

                O nome do titular do cartão informado: {this.Titular}

                O Cvv do cartão informado: {this.Cvv}";
        }
                   
    }
}