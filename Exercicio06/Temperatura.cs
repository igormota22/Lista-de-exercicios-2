namespace Exercicio06;

class Temperatura
{
    public double Celsius;

    public void ConverterParaFarenheit()
    {
        System.Console.WriteLine($"Temperatura em celsius: {Celsius}");

        double Fahrenheit = (Celsius * 9 / 5) + 32;

        System.Console.WriteLine($"Temperatura em Farenheit: {Fahrenheit}");
    }
}
