// Curso C#: dominando a Orientação a Objetos @ Alura
// Cândido da Nóbrega F. Neto
// Desafio 2:

// 1. Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

using Alura.PetShop;

Dono cliente1 = new Dono("João", "1234-5678");
Pet pet1 = new Pet("Rex", "Cachorro", 5);
Pet pet2 = new Pet("Miau", "Gato", 3);

cliente1.RegistrarPet(pet1);
cliente1.RegistrarPet(pet2);

Console.WriteLine(cliente1.Descricao);

Console.WriteLine(pet1.Descricao);
Console.WriteLine(pet2.Descricao);

// 2. Modelar o funcionamento de uma oficina automobilistica.
// 3. Criar um programa Program.cs e simular o funcionamento do programa.

using Alura.Oficina;

Cliente cliente1 = new Cliente("João", "1234-5678");
Veiculo veiculo1 = new Veiculo("Fusca", "Volkswagen", "Azul", "ABC-1234");
Mecanico mecanico1 = new Mecanico("Carlos");
OrdemServico ordem1 = new OrdemServico(1, cliente1, veiculo1, 500.00);

ordem1.AbrirOrdem(mecanico1);


// 4. Escrever um programa que funcione como uma calculadora, que pode
// realizar as 4 operações básicas, além de calcular raiz quadrada e potências.
// O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.

using Alura.Calculadora;

Console.WriteLine("Bem-vindo à calculadora!");
Console.Write("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine()!);
Console.Write("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine()!);
Console.Write("Escolha a operação (+,-,/,*,sqrt,pow): ");
string operacao = Console.ReadLine()!;
Calculadora calc = new Calculadora();

double resultado = calc.Calcular(num1, num2, operacao);
Console.WriteLine($"O resultado da operação {num1}{operacao}{num2}={resultado}");