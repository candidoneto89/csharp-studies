// Curso C#: aplicando a Orientação a Objetos @ Alura
// Cândido da Nóbrega F. Neto
// Desafio 2:

// 1. Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
class ContaBancaria
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Saldo { get; set; }
    public string Senha { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Saldo: {Saldo:F2}");
    }
}

// 2. Reescrever os atributos da classe Carro, de modo que eles sejam properties,
// e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
// 3. Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
class Carro
{
    public string Nome { get; set; }
    private int _ano;
    public int Ano
    {
        get => _ano;
        set
        {
            if (value < 1960 || value > 2023)
            {
                Console.WriteLine("O ano deve ser entre 1960 e 2023.");
            }
            else _ano = value;
        }
    }
    public string Fabricante { get; set; }

    public int acelerar(int accel)
    {
        Console.WriteLine("Acelerando");
        return accel;
    }

    public void frear()
    {
        Console.WriteLine("Freando");
    }

    public void buzinar()
    {
        Console.WriteLine("Buzina");
    }
}

// 4. Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque.
// Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma
// propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.

class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    private double _preco;
    public double Preco
    {
        get => _preco;
        set {             
            if (value < 0)
            {
                Console.WriteLine("O preço deve ser um valor positivo.");
            }
            else _preco = value;
        }
    }

    private int _estoque;
    public int Estoque
    {
        get => _estoque;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("O estoque deve ser um valor positivo.");
            }
            else _estoque = value;
        }
    }

    public string Detalhes
    {
        get
        {
            return $"Produto: {Nome}, Marca: {Marca}, Preço: {Preco:F2}, Estoque: {Estoque}";
        }
    }
}

