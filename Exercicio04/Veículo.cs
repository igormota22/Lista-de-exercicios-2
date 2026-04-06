namespace Exercicio04;



/*
4) Crie um programa para calcular o consumo de combustível por Km. Deverá ser
informado a kilometragem Inicial e Final do Percurso do Veículo. Deverá ser
informado o Consumo de Combustível
*/

public class Veiculo
{
    public double quilometragemInicial;
    public double quilometragemFinal;
    public double quantidadeDecombustivel;

    double distancia;



    public double CalcularDistancia()
    {
        System.Console.Write("Informe a quilometragem inicial:");
        quilometragemInicial = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Informe a quilometragem final:");
        quilometragemFinal = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Informe a quantidade de combustivel:");
        quantidadeDecombustivel = Convert.ToDouble(Console.ReadLine());

        distancia = quilometragemFinal - quilometragemInicial;

        return distancia;

    }

    public void CalcularConsumoDeCombustivel()
    {
        double consumoCombustivel = distancia / quantidadeDecombustivel;

        System.Console.WriteLine($"O combustivel consumido foi de: {consumoCombustivel}km");
    }

}

