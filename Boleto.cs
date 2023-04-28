
namespace Projeto_loja_virtual
{
    public class Boleto
    {

        public class PagamentoBoleto : Pagamento
        {
            public double valor;
        }
        
        public override double CalcularValor()
        {
            desconto = valor * 0.12;
            valorFinal = valor - desconto;
            Console.WriteLine($"Valor a ser pago: {valorFinal}.");
            Console.WriteLine(codigoDeBarras.Next(1000000000, 400000000));
               
        }

        Random codigoDeBarras = new Random();

        private string CodigoDeBarras;

        public double desconto {get; set;}
        public double valor {get; set;}

        public double valorFinal {get; set;}

        // Metodo
        public void Registrar()
        {

        }

        public void CalcularDesconto()
        {
            desconto = valor * 0.88;
        }









    }
}