namespace Projeto_loja_virtual
{
    public class Debito : Cartao
    {
        public override void Pagar()
        {
            if (valor <= 5000)
            {
                Console.WriteLine($"Pagamento aprovado, o valor da compra é: {this.valor}");
                
            }
            else{
                Console.WriteLine($"cartao recusado, saldo insuficiente");
                
            }
        }
    }
}