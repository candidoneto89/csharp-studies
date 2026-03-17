namespace Alura.Filmes;

class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> Filmes { get; set; } = new List<Filme>();
    public string ListaFilmes => Filmes.Count > 0 ? string.Join(", ", Filmes.Select(f => f.Titulo)) : "Nenhum filme cadastrado";

    public void ExibirFilmes()
    {
        Console.WriteLine($"Filmes de {Nome}:");
        Console.WriteLine(ListaFilmes);
    }

}