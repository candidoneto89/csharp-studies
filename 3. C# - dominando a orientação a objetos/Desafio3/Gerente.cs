namespace Alura.Empresa;

internal class Gerente : Funcionario
{
    public string Departamento { get; set; }
    
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine("Cargo: Gerente");
        Console.WriteLine($"Departamento: {Departamento}");
    }
}
