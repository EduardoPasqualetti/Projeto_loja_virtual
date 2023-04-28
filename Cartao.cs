
namespace Projeto_loja_virtual
{
    public class Cartao
    {
        public abstract class CartaoClasseMae
        {
            //PROPRIEDADES
            public string Bandeira {get; set;}

            public string NumeroCartao {get; set;}

            public string Titular {get; set;}

            public string Cvv {get; set;}

            //MÉTODOS

            public abstract void Pagar();

            public string SalvarCartao()
            {
                return "0";
            }



            public class Cartao : Pagamento
            {
               
            }
            


        }
    }
}