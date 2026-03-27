namespace Alura.Financa;

internal class Conta
{
    public string Nome { get; set; }
    public double Saldo { get; private set; }
    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }
    public virtual double CalcularSaldo()
    {
        return Saldo;
    }
}
