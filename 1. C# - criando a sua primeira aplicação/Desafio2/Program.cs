// Curso C#: Criando sua primeira aplicação @ Alura
// Cândido da Nóbrega Ferreira Neto
// Desafio 2:

// 1. Criar uma variável chamada notaMedia e atribua um valor inteiro a ela.
// Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
int notaMedia = 7;
if (notaMedia >= 5) Console.WriteLine("Nota suficiente para aprovação");

// 2. Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };

// 3. Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
Console.WriteLine($"\n{linguagens[0]}");

// 4. Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
Console.WriteLine("\nDigite um número inteiro:");
int posicao = int.Parse(Console.ReadLine());
if (posicao>=0) Console.WriteLine($"A posição {posicao} da lista é: {linguagens[posicao]}");
else Console.WriteLine("Número inválido. Digite um número inteiro positivo.");