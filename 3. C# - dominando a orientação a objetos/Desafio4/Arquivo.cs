namespace Alura.Data;


public interface IArmazenavel
{
    void Salvar();
    void Recuperar();
}

internal class Arquivo : IArmazenavel
{
    public void Salvar()
    {
        Console.WriteLine("Salvando dados no arquivo.");
    }
    public void Recuperar()
    {
        Console.WriteLine("Recuperando dados do arquivo.");
    }
}

internal class BancoDeDados : IArmazenavel
{
    public void Salvar()
    {
        Console.WriteLine("Salvando dados no banco de dados.");
    }
    public void Recuperar()
    {
        Console.WriteLine("Recuperando dados do banco de dados.");
    }
}