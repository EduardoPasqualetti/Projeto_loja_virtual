namespace Projeto_loja_virtual
{
    public class Debito : Cartao
    {

        private DateTime data = DateTime.Now ;
        public float saldo = 5000;
        public override void Pagar()
        {
            if (valor <= saldo)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Pagamento aprovado, o valor da compra é: {this.valor:C2}");
                Console.WriteLine($"Data do Pagamento: {data:d}");
                
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Seu Cartão foi recusado, o seu saldo é insuficiente");
                
            }
        }
    }
}