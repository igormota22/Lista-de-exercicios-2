namespace Exercicio03;

//3) Crie um programa para calcular o volume de um Cilindro
public class Cilindro
{
    public double raioDaBase;
    public double altura;

    public void CalcularVolume()
    {
        System.Console.WriteLine($"Raio da base: {raioDaBase}");
        System.Console.WriteLine($"Altura: {altura}");

        double volume = Math.PI * Math.Pow(raioDaBase, 2) * altura;

        System.Console.WriteLine($"O volume do cilindro é de: {volume:F2}");
    }
}
