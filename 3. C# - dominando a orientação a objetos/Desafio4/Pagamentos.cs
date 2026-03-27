// 3. Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa
// interface em duas classes, Produto e Servico. O método CalcularPagamento deve retornar o
// valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.

namespace Alura.Pagamentos;

internal class Produto : IPagavel
{
    public string Nome { get; set; }
    public double PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
    public double CalcularPagamento()
    {
        return PrecoUnitario * Quantidade;
    }
}

internal class Servico : IPagavel
{
    public string Descricao { get; set; }
    public double TaxaHoraria { get; set; }
    public int HorasTrabalhadas { get; set; }
    public double CalcularPagamento()
    {
        return TaxaHoraria * HorasTrabalhadas;
    }
}

public interface IPagavel
{
    double CalcularPagamento();
}
