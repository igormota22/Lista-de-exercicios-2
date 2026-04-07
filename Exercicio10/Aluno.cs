namespace Exercicio10;

public class Aluno
{
    public double prova1;
    public double prova2;
    public double pesoProva1;
    public double pesoProva2;

    public void CalcularMediaPonderada()
    {
        System.Console.WriteLine($"Nota da prova 1: {prova1}");
        System.Console.WriteLine($"Nota da prova 2: {prova2}");
        System.Console.WriteLine($"Peso da prova 1: {pesoProva1}");
        System.Console.WriteLine($"Peso da prova 2: {pesoProva2}");


        double somaDosPesos = pesoProva1 + pesoProva2;

        double mediaPonderada = (prova1 * pesoProva1) + (prova2 * pesoProva2) / somaDosPesos;

        System.Console.WriteLine($"A media ponderada foi de {mediaPonderada:F2}");
    }
}
