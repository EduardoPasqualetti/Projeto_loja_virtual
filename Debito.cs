namespace Projeto_loja_virtual
{
    public class Debito : Cartao
    {
        public float saldo = 5000;
        public override void Pagar()
        {
            if (valor <= saldo)
            {
                Console.WriteLine($"Pagamento aprovado, o valor da compra é: {this.valor}");
                
            }
            else{
                Console.WriteLine($"Compra recusada, saldo insuficiente");
                
            }
        }
    }
}