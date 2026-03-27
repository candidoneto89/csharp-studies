namespace Alura.Geometria;

public interface IForma
{
    double CalcularArea();
    double CalcularPerimetro();
}

public class Circulo : IForma
{
    public double Raio { get; set; }
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}

public class Retangulo : IForma
{
    public double Largura { get; set; }
    public double Altura { get; set; }
    public double CalcularArea()
    {
        return Largura * Altura;
    }
    public double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }
}