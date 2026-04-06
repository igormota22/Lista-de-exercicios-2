namespace Exercicio02;

//2) Crie um programa para converter a temperatura de graus Fahrenheit para graus
//Celsius

public class Temperatura
{
  public double Fahrenheit;

    public void ConverterParaCelcius()
    {
        System.Console.WriteLine($"Temperatura em Farenheit: {Fahrenheit}");

        double Celsius = (Fahrenheit - 32) * 5 / 9;

        System.Console.WriteLine($"Temperatura em celcius: {Celsius}");
    }
}
