namespace Exercicio10;

class Program
{

    /*
    10) Crie um programa para calcular a média ponderada de duas provas realizadas
    por um aluno
    */

    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.prova1 = 8;
        aluno1.pesoProva1 = 1;
        aluno1.prova2 = 5;
        aluno1.pesoProva2 = 3;

        aluno1.CalcularMediaPonderada();
    }
}
