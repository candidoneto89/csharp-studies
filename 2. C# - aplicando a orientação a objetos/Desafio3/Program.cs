// Curso C#: aplicando a Orientação a Objetos @ Alura
// Cândido da Nóbrega F. Neto
// Desafio 3:

// 1. Modelar uma classe Conta, que tenha como atributos uma classe Titular,
// além de informações da conta, como agência, número da conta, saldo e limite,
// bem como um método que devolva as informações da conta de forma detalhada.

// 2. Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as
// informações de Titular, a partir da Conta.

Conta conta1 = new Conta
{
Agencia = "1234",
Numero = "56789-0",
Saldo = 1500.00m,
Limite = 500.00m,
Titular = new Titular
{
Nome = "João Silva",
CPF = "123.456.789-00"
}
};

Console.WriteLine(conta1.ObterInformacoes());

class Conta
{
    public string Agencia { get; set; }
    public string Numero { get; set; }
    public decimal Saldo { get; set; }
    public decimal Limite { get; set; }
    public Titular Titular { get; set; }
    public string ObterInformacoes()
    {
        return $"Titular: {Titular.Nome}\nAgência: {Agencia}, Número: {Numero}, Saldo: {Saldo:C}, Limite: {Limite:C}\n";
    }
}

class Titular
{
    public string Nome { get; set; }
    public string CPF { get; set; }
}

// 3. Desenvolver uma classe que represente um estoque de produtos, e que tenha
// as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.

Produto produto1 = new Produto { Nome = "Camiseta", Preco = 49.90m };
Produto produto2 = new Produto { Nome = "Calça Jeans", Preco = 99.90m };

ProdutosEstoque estoque = new ProdutosEstoque();

estoque.AdicionarProduto(produto1);
estoque.AdicionarProduto(produto2);
estoque.ExibirProdutos();

class Produto {
    public string Nome { get; set; }
    private decimal _preco;
    public decimal Preco { 
        get => _preco; 
        set
        {
            if (value > 0)
                _preco = value;
            else
                throw new ArgumentException("O preço deve ser maior que zero.");
        } 
    }
    private int _estoque;
    private int Estoque
    {
        get => _estoque;
        set
        {
            _estoque = value > 0 ? value : 0;
        }
    }

}

class ProdutosEstoque {
    private List<Produto> produtos = new List<Produto>();
    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }
    public void ExibirProdutos()
    {
        Console.WriteLine("Produtos no estoque:");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco:C}");
        }
    }
}


// 4. Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina.
// A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve
// ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar
// o nome da disciplina e a lista de alunos matriculados.

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; } = new List<double>();
}

class Professor
{
    public string Nome { get; set; }
    public List<Disciplina> DisciplinasLecionadas { get; set; } = new List<Disciplina>();
}

class Disciplina
{
    public string Nome { get; set; }
    public List<Aluno> AlunosMatriculados { get; set; } = new List<Aluno>();
}

// 5. Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e
// Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com
// itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.

class Restaurante
{
    public List<Mesa> Mesas { get; set; } = new List<Mesa>();
    public Cardapio Cardapio { get; set; } = new Cardapio();
}

class Pedido
{
    public Mesa Mesa { get; set; }
    public List<ItemCardapio> Itens { get; set; } = new List<ItemCardapio>();
}

class Mesa
{
    public int Numero { get; set; }
    public bool Reservada { get; set; }
}

class Cardapio
{
    public List<ItemCardapio> Itens { get; set; } = new List<ItemCardapio>();
}

class ItemCardapio
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
}