
namespace Projeto_loja_virtual
{
    public class Boleto
    {


        //propriedade
        private string CodigoDeBarras;

        public double desconto {get; set;}
        public double valor {get; set;}

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