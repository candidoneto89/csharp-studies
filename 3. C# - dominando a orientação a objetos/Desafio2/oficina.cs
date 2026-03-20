using System.Globalization;

namespace Alura.Oficina;

public class Cliente
{
	public Cliente(string nome, string telefone)
	{
		Nome = nome;
		Telefone = telefone;
    }
	public string Nome { get; }
	public string Telefone { get; }
}

class Veiculo	{
	public Veiculo(string modelo, string fabricante, string cor, string placa)
	{
		Modelo = modelo;
		Fabricante = fabricante;
		Cor = cor;
		Placa = placa;
	}

	public string Placa { get; set; }
	public string Modelo { get; set; }
	public string Cor { get; set; }
	public string Fabricante { get; set; }
}

class Mecanico	{
	public Mecanico(string nome)
	{
		Nome = nome;
	}
	public string Nome { get; set; }
}	

class OrdemServico	{
	public OrdemServico(int id, Cliente cliente, Veiculo veiculo, double valor)
	{
		Id = id;
		Cliente = cliente;
		Veiculo = veiculo;
		Valor = valor;
    }

	public int Id { get; }
	public Cliente Cliente { get; set; }
	public Veiculo Veiculo { get; set; }
	public double Valor { get; }
	public Mecanico Mecanico { get; set; }

	public void AbrirOrdem(Mecanico mecanico)
	{
		Mecanico = mecanico;
		Console.WriteLine($"Ordem de serviço {Id} aberta para o cliente {Cliente.Nome} com o veículo {Veiculo.Modelo} e mecânico {Mecanico.Nome}. Valor: {Valor.ToString("C", CultureInfo.CurrentCulture)}");
    }

}


