namespace Exercicio07;

class Program
{
    /*
    7) Crie um programa para calcular o salário total de um vendedor. Deverá ser
    informado o salário base e o total de vendas. A comissão é calculada com um
    percentual (informado pelo usuário) sobre o total de vendas.
    */
    static void Main(string[] args)
    {
        Vendedor vendedor1 = new Vendedor();

        vendedor1.CalcularSalarioFinal();
    }
}
