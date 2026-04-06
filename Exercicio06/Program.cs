namespace Exercicio06;

class Program
{

    //6) Crie um programa para converter a temperatura da escala Celsius para a escala
    //Fahrenheit

    static void Main(string[] args)
    {
        Temperatura temperatura1 = new Temperatura();
        temperatura1.Celsius = 30;

        temperatura1.ConverterParaFarenheit();

    }
}
