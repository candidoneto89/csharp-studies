namespace Alura.Empresa;

internal class Programador : Funcionario
{
    public List<string> Linguagens { get; } = new List<string>();
    
    public void AdicionarLinguagem(string linguagem)
    {
        Linguagens.Add(linguagem);
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine("Cargo: Programador");
        Console.WriteLine($"Linguagens de Programação: {string.Join(", ", Linguagens)}");
    }
}
