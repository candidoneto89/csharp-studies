// Curso C#: criando sua primeira aplicação @ Alura
// Cândido da Nóbrega F. Neto
// Desafio 3:

// 1. Escrever uma função que a partir de dois números de ponto flutuante a e b exiba
// no console o resultado de suas quatro operações básicas (adição, subtração, divisão
// e multiplicação), utilizando interpolação de strings.

float a = 2.5f;
float b = 4.0f;

Console.WriteLine($"A soma de {a} e {b} é: {a + b}");
Console.WriteLine($"A subtração de {a} e {b} é: {a - b}");
Console.WriteLine($"A multiplicação de {a} por {b} é: {a * b}");
Console.WriteLine($"A divisão de {a} por {b} é: {a / b}");

// 2. Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

List<string> bandas = new List<string>();
bandas.Add("Guns N' Roses");
bandas.Add("Muse");
bandas.Add("Audioslave");

// 3. Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

for (int i = 0; i < bandas.Count; i++)
{
    Console.WriteLine(bandas[i]);
}

// 4. Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

int soma = 0;
//for (int i = 0; i < numeros.Count; i++) soma += numeros[i];
foreach (int numero in numeros) soma += numero;

Console.WriteLine($"A soma dos números é: {soma}");