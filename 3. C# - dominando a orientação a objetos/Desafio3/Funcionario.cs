namespace Alura.Empresa;

internal class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; set; }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário: {Salario:C}");
    }
}
