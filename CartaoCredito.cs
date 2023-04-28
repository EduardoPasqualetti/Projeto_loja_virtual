namespace Projeto_loja_virtual
{
    public class CartaoCredito
    {
        public float limite = 5000;

        public double juros { get; set; }

        public double valor { get; set; }

        public float parcelamento = 0;

        
        public void CalcularJuros()
        {
            if (parcelamento <= 6)
            {
                juros = valor * 1.05;
            }
            else if (parcelamento > 6 && parcelamento < 12)
            {
                juros = valor * 1.08;
            }
            else
            {
                Console.WriteLine($"Parcelamos somente em ate 12x");

            }
        }
    }
}