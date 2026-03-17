// Curso C#: dominando a Orientação a Objetos @ Alura
// Cândido da Nóbrega F. Neto
// Desafio 1:

// 1. Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace Alura.Filmes.
// 2. Criar um programa Program.cs, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.
// 3. Criar uma classe Artista, que representa uma pessoa que atua em filmes, no namespace Alura.Filmes.A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.
// 4. Modificar as classes Artista e Filme do namespace Alura.Filmes para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.


using Alura.Filmes;

Filme filme1 = new(
    "O Senhor dos Anéis: A Sociedade do Anel",
    "Peter Jackson",
    "2001",
    "Fantasia"
    );

Filme filme2 = new(
    "Se7en",
    "David Fincher",
    "1995",
    "Policial"
    );

Filme filme3 = new(
    "Homem-Aranha",
    "Sam Raimi",
    "2002",
    "Aventura"
    );

Filme filme4 = new(
    "Na Natureza Selvagem",
    "Sean Penn",
    "2007",
    "Aventura"
    );

Filme filme5 = new(
    "A Vida Secreta de Walter Mitty",
    "Ben Stiller",
    "2013",
    "Comédia"
    );

Filme filme6 = new(
    "O Senhor dos Anéis: As Duas Torres",
    "Peter Jackson",
    "2002",
    "Fantasia"
    );

Filme filme7 = new(
    "O Senhor dos Anéis: O Retorno do Rei",
    "Peter Jackson",
    "2003",
    "Fantasia"
    );


Artista elijah = new() { Nome = "Elijah Wood", Idade = 42 };
Artista ianmckellen = new() { Nome = "Ian McKellen", Idade = 82 };
Artista viggo = new() { Nome = "Viggo Mortensen", Idade = 63 };

Artista brad = new() { Nome = "Brad Pitt", Idade = 57 };
Artista morgan = new() { Nome = "Morgan Freeman", Idade = 86 };
Artista gwyneth = new() { Nome = "Gwyneth Paltrow", Idade = 51 };

Artista tobey = new() { Nome = "Tobey Maguire", Idade = 47 };
Artista kirsten = new() { Nome = "Kirsten Dunst", Idade = 41 };
Artista willem = new() { Nome = "Willem Dafoe", Idade = 67 };

Artista emile = new() { Nome = "Emile Hirsch", Idade = 40 };
Artista vince = new() { Nome = "Vince Vaughn", Idade = 54 };
Artista kristen = new() { Nome = "Kristen Stewart", Idade = 33 };

Artista ben = new() { Nome = "Ben Stiller", Idade = 57 };
Artista kristenwiig = new() { Nome = "Kristen Wiig", Idade = 41 };
Artista sean = new() { Nome = "Sean Penn", Idade = 62 };


List<Filme> filmesFavoritos = new List<Filme> { filme1, filme2, filme3, filme4, filme5 };

filme1.AdicionarArtista(elijah);
filme1.AdicionarArtista(ianmckellen);
filme1.AdicionarArtista(viggo);
Console.WriteLine(filme1.Descricao);

filme6.AdicionarArtista(elijah);
filme6.AdicionarArtista(ianmckellen);
filme6.AdicionarArtista(viggo);
Console.WriteLine(filme6.Descricao);

filme7.AdicionarArtista(elijah);
filme7.AdicionarArtista(ianmckellen);
filme7.AdicionarArtista(viggo);
Console.WriteLine(filme7.Descricao);

elijah.ExibirFilmes();
