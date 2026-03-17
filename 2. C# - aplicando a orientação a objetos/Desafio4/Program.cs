
// Curso C#: aplicando a Orientação a Objetos @ Alura
// Cândido da Nóbrega F. Neto
// Desafio 4:

// 1. Criar um construtor para a classe Titular, que inicialize todas suas propriedades:
// 2. Criar um construtor para a classe Conta, que inicialize todas suas propriedades:
// 3. Instanciar uma Conta e exibir suas informações na tela, utilizando construtores.

Titular usuario1 = new Titular("Cândido Neto", "123.456.789-00", "Rua Epitácio Pessoa, nº 100");
Conta conta1 = new Conta(usuario1, 1234, 56789, 100.00, 50.00);
Console.WriteLine(conta1.Informacoes);

class Titular
{
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
}

class Conta
{
    public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        Limite = limite;
    }
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; }
    public double Limite { get; set; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}

// 4. Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.

Jogo jogo1 = new Jogo("The Legend of Zelda: Breath of the Wild", "Ação/Aventura", "2017");
Jogo jogo2 = new Jogo("God of War", "Ação/Aventura", "2018");

CatalogoDeJogos catalogo = new CatalogoDeJogos();

catalogo.AdicionarJogo(jogo1);
catalogo.AdicionarJogo(jogo2);
catalogo.ExibirJogos();

class Jogo
{
    public Jogo(string nome, string genero, string ano)

    {
        Nome = nome;
        Genero = genero;
        Ano = ano;
    }
    public string Nome { get; set; }
    public string Genero { get; set; }
    public string Ano { get; set; }
}

class CatalogoDeJogos

{
    public CatalogoDeJogos()
    {
        Jogos = new List<Jogo>();
    }
    private List<Jogo> Jogos { get; set; }
    public void AdicionarJogo(Jogo jogo)
    {
        Jogos.Add(jogo);
    }
    public void RemoverJogo(Jogo jogo)
    {
        Jogos.Remove(jogo);
    }

    public void ExibirJogos()
    {
        foreach (var jogo in Jogos)
        {
            Console.WriteLine($"Nome: {jogo.Nome}, Gênero: {jogo.Genero}, Ano: {jogo.Ano}");
        }
    }
}

