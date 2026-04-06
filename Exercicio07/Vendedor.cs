namespace Exercicio07;

public class Vendedor
{
    decimal salarioBase;
    decimal totalDeVendas;
    decimal percentual;

    public void CalcularSalarioFinal()
    {
        System.Console.Write("Informe o salrio base:");
        salarioBase = Convert.ToDecimal(Console.ReadLine());

        System.Console.Write("Informe o total de vendas:");
        totalDeVendas = Convert.ToDecimal(Console.ReadLine());

        System.Console.Write("Informe o percentual a ser aplicado na comissao (%):");
        percentual = Convert.ToDecimal(Console.ReadLine());

        decimal comissao = totalDeVendas * (percentual / 100);

        decimal salarioFinal = salarioBase + comissao;

        System.Console.WriteLine($"Seu salario total é de {salarioFinal}R$");


    }


}
