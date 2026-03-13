// Curso C#: criando sua primeira aplicação @ Alura
// Cândido da Nóbrega F. Neto
// Desafio 4:

// 1. Criar um dicionário que represente um aluno, com uma lista de notas,
// e mostre a média de suas notas na tela.

Dictionary<string, List<double>> aluno = new Dictionary<string, List<double>>();
aluno["João"] = new List<double> { 7.5, 8.0, 6.5 };
double media = aluno["João"].Average();
Console.WriteLine($"Média de notas do aluno João: {media:F2}");
//Console.WriteLine($"Média de notas do aluno João: {CalcularMedia(aluno["João"]):F2}");
static double CalcularMedia(List<double> notas)
{
    double soma = 0;
    foreach (double nota in notas) soma += nota;
    return soma / notas.Count;
}

////////////////////////////////////////////////////////////////////////////////////////////////////

// 2. Criar um programa que gerencie o estoque de uma loja.
// Utilize um dicionário para armazenar produtos e suas quantidades
// em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.  

Dictionary<string, int> produtos = new Dictionary<string, int> {
    {"Arroz", 50},
    {"Feijão", 30},
    {"Macarrão", 20},
    {"Óleo", 15},
    {"Açúcar", 25},
    {"Sal", 10  }
};

Console.WriteLine("Digite o nome do produto para verificar o estoque:");
string produto = Console.ReadLine();
int quantidade = produtos.ContainsKey(produto) ? produtos[produto] : 0;

Console.WriteLine($"Quantidade em estoque do produto {produto}: {quantidade}");

////////////////////////////////////////////////////////////////////////////////////////////////////

// 3. Crie um programa que implemente um quiz simples de perguntas e respostas.
// Utilize um dicionário para armazenar as perguntas e as respostas corretas.

Dictionary<string, string> quiz = new Dictionary<string, string> {
    {"1. Qual é a capital da França?", "Paris"},
    {"2. Qual é a capital da Itália?", "Roma" },
    {"3. Quantos estados tem o Brasil", "26" }
};

Console.WriteLine("Bem-vindo ao Quiz! Responda as perguntas abaixo:");
int respostasCorretas = 0;

foreach (var pergunta in quiz.Keys)
{
    Console.WriteLine(pergunta);
    string resposta = Console.ReadLine();
    if (resposta.Equals(quiz[pergunta], StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Resposta correta!");
        respostasCorretas++;
    }
    else
    {
        Console.WriteLine("Resposta incorreta. A resposta correta é: " + quiz[pergunta]);
    }
}

Console.WriteLine($"Você acertou {respostasCorretas} de {quiz.Count} perguntas!");


////////////////////////////////////////////////////////////////////////////////////////////////////

// 4. Criar um programa que simule um sistema de login utilizando um
// dicionário para armazenar nomes de usuário e senhas.

Dictionary<string, string> usuarios = new Dictionary<string, string> {
    {"usuario1", "senha1"},
    {"usuario2", "senha2"},
    {"usuario3", "senha3"}
};

Console.Write("Digite seu nome de usuário: ");
string inputUsuario = Console.ReadLine(); 
Console.Write("Digite sua senha: ");
string inputSenha = Console.ReadLine();

if (usuarios.ContainsKey(inputUsuario) && usuarios[inputUsuario] == inputSenha)
{
    Console.WriteLine("Login bem-sucedido! Bem-vindo, " + inputUsuario + "!");
}
else
{
    Console.WriteLine("Login falhou! Nome de usuário ou senha incorretos.");
}