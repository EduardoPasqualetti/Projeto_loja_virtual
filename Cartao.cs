
namespace Projeto_loja_virtual
{
    public class Cartao
    {
        public abstract class CartaoClasseMae
        {
            //PROPRIEDADES
            public string Bandeira;

            public string NumeroCartao;

            public string Titular;

            public string Cvv;

            //MÉTODOS

            public void Pagar()
            {
                
            }

            public string SalvarCartao()
            {
                return "0";
            }
        }
    }
}