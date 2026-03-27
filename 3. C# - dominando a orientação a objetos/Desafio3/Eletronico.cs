namespace Alura.Produtos;

internal class Eletronico
{
    public string Modelo { get; set; }
    public string Tipo { get; set; }
    public double Preco { get; set; }
    public string Marca { get; set; }
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Preço: {Preco:C}");
        Console.WriteLine($"Marca: {Marca}");
    }
}

internal class Smartphone : Eletronico
{
    public string SistemaOperacional { get; set; }
    public int Armazenamento { get; set; }
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Sistema Operacional: {SistemaOperacional}");
        Console.WriteLine($"Armazenamento: {Armazenamento} GB");
    }
}

internal class Notebook : Eletronico 
{
    public string Processador { get; set; }
    public int MemoriaRAM { get; set; }
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Processador: {Processador}");
        Console.WriteLine($"Memória RAM: {MemoriaRAM} GB");
    }
}
