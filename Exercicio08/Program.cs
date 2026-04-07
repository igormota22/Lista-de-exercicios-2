namespace Exercicio08;

class Program
{

    //8) Crie um programa para calcular o volume de uma lata de óleo

    static void Main(string[] args)
    {
        LataDeOleo lata1 = new LataDeOleo();
        lata1.raioDaBase = 3.7;
        lata1.altura = 13.2;

        lata1.CalcularVolume();
    }
}
