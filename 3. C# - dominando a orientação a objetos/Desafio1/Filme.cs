namespace Alura.Filmes;

class Filme
{

    public Filme(string titulo, string diretor, string ano, string genero)
    {
        Titulo = titulo;
        Diretor = diretor;
        AnoLancamento = ano;
        Genero = genero;
    }
    public string Titulo { get; }
    public string Diretor { get;}
    public string AnoLancamento { get; }
    public string Genero { get; }
    public List<Artista> Elenco { get; set; } = new List<Artista>();

    public string Descricao => $"Título: {Titulo}\nDiretor: {Diretor}\nAno de Lançamento: {AnoLancamento}\nGênero: {Genero}\nElenco: {string.Join(", ", Elenco.Select(a => a.Nome))}"; //

    public void AdicionarArtista(Artista artista)
    {
        if (!Elenco.Contains(artista))
        {
            Elenco.Add(artista);
            artista.Filmes ??= new List<Filme>();
            artista.Filmes.Add(this);
        }
    }
}
