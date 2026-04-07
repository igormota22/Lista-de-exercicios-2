namespace Exercicio08;

class LataDeOleo
{
    public double raioDaBase;
    public double altura;

    public void CalcularVolume()
    {
        System.Console.WriteLine($"Raio da base: {raioDaBase}");
        System.Console.WriteLine($"Altura: {altura}");

        double volume = Math.PI * Math.Pow(raioDaBase, 2) * altura;

        System.Console.WriteLine($"O volume do lata de oleo é de: {volume:F2}");
    }
}
