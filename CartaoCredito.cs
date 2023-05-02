namespace Projeto_loja_virtual
{
    public class CartaoCredito : Cartao
    {
        public float limite = 5000;

        public double juros { get; set; }

        public float parcelamento;

        public override void Pagar()
        {
            if (parcelamento <= 6)
            {
                juros = valor * 1.05 / parcelamento;
                Console.WriteLine($"O valor a ser pago é {parcelamento} parcelas de R${juros}");
                
            }
            else if (parcelamento > 6 && parcelamento <= 12)
            {
                juros = valor * 1.08 / parcelamento;
                Console.WriteLine($"O valor a ser pago é {parcelamento} parcelas de R${juros}");
            }
            else
            {
                Console.WriteLine($"Parcelamos somente em ate 12x");

            }

            if (valor > limite)
            {
                Console.WriteLine($"Transacao negada, saldo insuficiente");

            }

        }


    }


}