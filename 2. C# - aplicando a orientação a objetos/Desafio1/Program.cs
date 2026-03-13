// Curso C#: aplicando a Orientação a Objetos @ Alura
// Cândido da Nóbrega F. Neto
// Desafio 1:

// 1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
// 2. Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
// 3. Desenvolver um método da classe Conta que exibe suas informações.

ContaBancaria conta1 = new ContaBancaria();
conta1.id = 1;
conta1.nome = "Cândido";
conta1.saldo = 195.90;
conta1.senha = "12346";

Console.WriteLine($"Nome: {conta1.nome}");
Console.WriteLine($"Saldo: {conta1.saldo:F2}");



conta1.ExibirInformacoes();

class ContaBancaria
{
    public int id;
    public string nome;
    public double saldo;
    public string senha;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Saldo: {saldo:F2}");
    }
}

// 4. Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

class Carro
{
    public string nome;

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