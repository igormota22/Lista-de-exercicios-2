namespace Exercicio01;

partial class Program
{
    //1) Crie um programa para calcular o volume de uma caixa retangular

    public class CaixaRetangular
    {
        public double comprimento;

        public double largura;

        public double altura;

        public void CalcularVolume()
        {
            System.Console.WriteLine($"Comprimento: {comprimento}cm");
            System.Console.WriteLine($"Largura: {largura}cm");
            System.Console.WriteLine($"Altura: {altura}cm");


            double volume = comprimento * largura * altura;

            System.Console.WriteLine($"O volume da caixa retangular é de {volume}cm³");
        }
    }
}
