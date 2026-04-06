namespace Exercicio05;

//5) Crie um programa para calcular o volume de uma esfera

public class Esfera
{
    public double raioDaBase;

    public void CalcularVolume()
    {
        System.Console.WriteLine($"Raio da base: {raioDaBase}");

        double volume = (4d / 3d) * Math.PI * Math.Pow(raioDaBase, 3);

        System.Console.WriteLine($"O volume da esfera é de {volume}cm³");
    }
}
