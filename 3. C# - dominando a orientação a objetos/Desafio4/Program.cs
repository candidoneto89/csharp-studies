// Curso C#: dominando a Orientação a Objetos @ Alura
// Cândido da Nóbrega F. Neto
// Desafio 4:

// 1. Criar uma interface chamada IForma que declare métodos para calcular a área e o
// perímetro de uma forma geométrica. Implemente esta interface em duas classes: Circulo e Retangulo.

using Alura.Geometria;

Circulo circulo = new Circulo { Raio = 5 };
Console.WriteLine($"Área do círculo: {circulo.CalcularArea()}.");
Console.WriteLine($"Perímetro do círculo: {circulo.CalcularPerimetro()}.");

Retangulo retangulo = new Retangulo { Largura = 4, Altura = 6 };
Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea()}");
Console.WriteLine($"Perímetro do retângulo: {retangulo.CalcularPerimetro()}.");

// 2. Criar duas interfaces adicionais, IPilotavel e IVoavel. Implemente essas interfaces
// na classe Veiculo.

using Alura.Veiculos;

Veiculo veiculo = new Veiculo();
veiculo.Pilotar();
veiculo.Voar();

// 3. Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa
// interface em duas classes, Produto e Servico. O método CalcularPagamento deve retornar o
// valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.

using Alura.Pagamentos;

Produto produto = new Produto { Nome = "Notebook", PrecoUnitario = 2500, Quantidade = 2 };
Servico servico = new Servico { Descricao = "Consultoria", TaxaHoraria = 150, HorasTrabalhadas = 10 };

Console.WriteLine($"O pagamento do produto {produto.Nome} será no valor de {produto.CalcularPagamento():C}");
Console.WriteLine($"O pagamento do serviço {servico.Descricao} será no valor de {servico.CalcularPagamento():C}");

// 4. Criar uma interface chamada INotificavel com um método EnviarNotificacao. Implemente
// essa interface em duas classes, Email e SMS. O método EnviarNotificacao deve exibir mensagens
// diferentes para cada tipo de notificação.

using Alura.Notification;

Email email = new Email();
SMS sms = new SMS();

email.EnviarNotificacao();
sms.EnviarNotificacao();

// 5. Criar uma interface chamada IArmazenavel com métodos Salvar e Recuperar. Implemente essa
// interface em duas classes, Arquivo e BancoDeDados. Os métodos Salvar e Recuperar devem exibir
// mensagens simulando a ação de salvar e recuperar dados.

using Alura.Data;

Arquivo arquivo = new Arquivo();
BancoDeDados bancoDeDados = new BancoDeDados();

arquivo.Salvar();
arquivo.Recuperar();
bancoDeDados.Salvar();
bancoDeDados.Recuperar();