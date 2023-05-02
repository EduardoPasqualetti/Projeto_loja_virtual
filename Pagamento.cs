
namespace Projeto_loja_virtual
{
    public class Pagamento
    {
        private DateTime data {get; set;}

        public float valor {get; set;}
        public string Cancelar()
        {
            return $"A compra foi cancelada !";
        }
    }
}