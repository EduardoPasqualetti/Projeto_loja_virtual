
namespace Projeto_loja_virtual
{
    public class Boleto
    {

        public class PagamentoBoleto : Pagamento
        {
            public double valor;
        }
            
                Random codigoDeBarras = new Random();

        public double desconto {get; set;}
        public double valor {get; set;}

        public double valorFinal {get; set;}


        // Metodo
        public string Registrar()
        {
            desconto = valor * 0.12;
            valorFinal = valor - desconto; 

            return @$"Valor a ser pago, com desconto: {valorFinal}
            Codigo de barras: {codigoDeBarras.Next(1000000000, 400000000)}";
        }








    }
}