
namespace Projeto_loja_virtual

{

    public class Boleto : Pagamento
    {
        public void Registrar()
        {


            Console.WriteLine(@$"Valor a ser pago, com desconto: {this.valor * 0.88f}");

        }

    }


}