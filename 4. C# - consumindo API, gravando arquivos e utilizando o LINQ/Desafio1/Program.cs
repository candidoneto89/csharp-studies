// Curso C#: consumindo API, gravando arquivos e utilizando o LINQ
// Cândido da Nóbrega F. Neto
// Desafio 1:

// 1. Escrever um programa que faça uma requisição para a API de games CheapShark
// e mostre na tela a lista de promoções cadastrada na ferramenta (Você pode utilizar
// o endpoint: https://www.cheapshark.com/api/1.0/deals).

using (HttpClient client = new HttpClient())
{
    try
    {
        client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36");

        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resposta);
    }

    catch (HttpRequestException ex)
    {
        Console.WriteLine($"Erro na requisição: {ex.Message}");
    }
}

// 2. Escrever um programa que solicite dois números a e b lidos do teclado e realize
// a divisão de a por b. Caso essa operação não seja possível, mostrar uma mensagem
// no console que deixe claro o erro ocorrido.

Console.WriteLine("Digite o primeiro número (a):");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número (b):");
int b = int.Parse(Console.ReadLine());

try
{
    int result = a / b;
    Console.WriteLine($"Resultado da divisão: {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Erro: Divisão por zero não é permitida.");
}

// 3. Declarar uma lista de inteiros e tente acessar um elemento em um índice
// inexistente. Tratar a exceção apropriada.

List<int> inteiros = new List<int> { 1, 2, 3, 4, 5 };

try
{
    Console.WriteLine(inteiros[10]);
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

// 4. Criar uma classe simples com um método e chame esse método em um objeto nulo.
// Tratar a exceção de método em objeto nulo.

try
{
    MinhaClasse obj = null;
    obj.MeuMetodo();
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

public class MinhaClasse
{
    public void MeuMetodo()
    {
        Console.WriteLine("Método chamado com sucesso!");
    }
}