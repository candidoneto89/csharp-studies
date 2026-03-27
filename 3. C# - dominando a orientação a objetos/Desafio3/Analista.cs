namespace Alura.Empresa;

internal class Analista : Funcionario
{
    public string AreaDeAtuacao { get; set; }
    
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine("Cargo: Analista");
        Console.WriteLine($"Área de Atuação: {AreaDeAtuacao}");
    }
}
