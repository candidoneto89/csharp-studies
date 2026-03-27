// Curso C#: dominando a Orientação a Objetos @ Alura
// Cândido da Nóbrega F. Neto
// Desafio 3:

// 1. Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo.
// Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a
// área e o perímetro de uma forma.

using Alura.Geometria;

Quadrado quadrado = new();
quadrado.Lado = 5;
quadrado.calcularArea();
quadrado.calcularPerimetro();

Triangulo triangulo = new();
triangulo.Base = 4;
triangulo.Altura = 3;
triangulo.Lado1 = 4;
triangulo.Lado2 = 3;
triangulo.Lado3 = 5;
triangulo.calcularArea();
triangulo.calcularPerimetro();

Circulo circulo = new();
circulo.Raio = 4;
circulo.calcularArea();
circulo.calcularPerimetro();

// 2. Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar
// classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das
// propriedades comuns a todos os funcionários, como Nome e Salário.

using Alura.Empresa;

Gerente gerente = new();
gerente.Nome = "João";
gerente.Salario = 5000;
gerente.Departamento = "Comercial";
gerente.ExibirInformacoes();

Programador programador = new();
programador.Nome = "Maria";
programador.Salario = 4000;
programador.AdicionarLinguagem("C#");
programador.AdicionarLinguagem("JavaScript");
programador.ExibirInformacoes();

Analista analista = new();
analista.Nome = "Carlos";
analista.Salario = 3500;
analista.AreaDeAtuacao = "Análise de Dados";
analista.ExibirInformacoes();

// 3. Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca.
// Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne
// o saldo atual da conta.

using Alura.Financa;

ContaCorrente contaCorrente = new();
ContaPoupanca contaPoupanca = new();

contaCorrente.Nome = "João";
contaCorrente.Depositar(1000);
contaCorrente.Depositar(500);
Console.WriteLine($"O saldo da conta é {contaCorrente.CalcularSaldo()}.");

contaPoupanca.Nome = "Maria";
contaPoupanca.Depositar(2000);
contaPoupanca.Depositar(1000);
Console.WriteLine($"O saldo da conta é {contaPoupanca.CalcularSaldo()}.");

// 4. Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e
// o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.

using Alura.Animais;

Mamifero mamifero = new();
Console.WriteLine($"{mamifero.EmitirSom()}");
Ave ave = new();
Console.WriteLine($"{ave.EmitirSom()}");
Peixe peixe = new();
Console.WriteLine($"{peixe.EmitirSom()}");

// 5. Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop.
// Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.

using Alura.Produtos;

Smartphone smartphone = new();
smartphone.Modelo = "Galaxy S21";
smartphone.Tipo = "Smartphone";
smartphone.Preco = 2999.99;
smartphone.Marca = "Samsung";
smartphone.SistemaOperacional = "Android";
smartphone.Armazenamento = 128;

Notebook notebook = new();
notebook.Modelo = "MacBook Pro";
notebook.Tipo = "Notebook";
notebook.Preco = 9999.99;
notebook.Marca = "Apple";   
notebook.Processador = "Apple M1";
notebook.MemoriaRAM = 16;

smartphone.ExibirInformacoes();
notebook.ExibirInformacoes();
