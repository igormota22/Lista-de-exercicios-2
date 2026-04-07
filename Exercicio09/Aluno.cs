using System.Runtime.ConstrainedExecution;

namespace Exercicio09;

public class Aluno
{
    public double nota1;
    public double nota2;
    public double nota3;

    public void CalcularMediaHarmonica()
    {
        System.Console.WriteLine($"Nota 1:{nota1}");
        System.Console.WriteLine($"Nota 2:{nota2}");
        System.Console.WriteLine($"Nota 3:{nota3}");

        double mediaHarmonica = 3 / (1 / nota1 + 1 / nota2 + 1 / nota3);

        System.Console.WriteLine($"A media harmonica foi de {mediaHarmonica:F2}");

    }

}
