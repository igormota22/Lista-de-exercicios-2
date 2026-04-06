namespace Exercicio03;

class Program
{
    static void Main(string[] args)
    {
        Cilindro cilindro1 = new Cilindro();
        cilindro1.raioDaBase = 4;
        cilindro1.altura = 10;

        cilindro1.CalcularVolume();
    }
}
