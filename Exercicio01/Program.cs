namespace Exercicio01;

partial class Program
{
    static void Main(string[] args)
    {
        CaixaRetangular caixa1 = new CaixaRetangular();

        caixa1.comprimento = 5;
        caixa1.largura = 3;
        caixa1.altura = 2;

        caixa1.CalcularVolume();
    }
}
