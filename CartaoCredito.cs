namespace Projeto_loja_virtual
{
    public class CartaoCredito : Cartao
    {
        public float limite = 5000;

        public double juros { get; set; }

        public float parcelamento;

        public override void Pagar()
        {



            if (valor > limite)
            {
                Console.WriteLine($"Transacao negada, limite insuficiente");

            }
            else
            {


                do
                {
                    Console.WriteLine($"Voce deseja parcelar em quantas vezes a sua compra?");
                    parcelamento = float.Parse(Console.ReadLine());

                    if (parcelamento > 1 && parcelamento <= 6)
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
                    Console.WriteLine($"Para tentar novamente digite enter");
                    
                    Console.ReadKey();
                } while (parcelamento > 12);

            }

        }


    }


}