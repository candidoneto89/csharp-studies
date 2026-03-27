namespace Alura.Veiculos;

internal class Veiculo : IPilotavel, IVoavel
{
    public void Pilotar()
    {
        Console.WriteLine("O veículo está sendo pilotado.");
    }
    public void Voar()
    {
        Console.WriteLine("O veículo está voando.");
    }
}

public interface IPilotavel
{
    void Pilotar();
}

public interface IVoavel
{
    void Voar();
}