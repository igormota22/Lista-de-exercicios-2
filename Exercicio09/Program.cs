namespace Exercicio09;

class Program
{

    //9) Crie um programa para calcular a média harmônica das notas de um aluno

    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.nota1 = 6;
        aluno1.nota2 = 8;
        aluno1.nota3 = 10;

        aluno1.CalcularMediaHarmonica();
    }
}
