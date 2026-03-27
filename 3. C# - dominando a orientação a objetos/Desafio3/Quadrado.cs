namespace Alura.Geometria;

internal class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }
    public override void calcularArea()
    {
        base.calcularArea();
        double area = Lado * Lado;
        Console.WriteLine($"A área do quadrado é: {area}");
    }
    public override void calcularPerimetro()
    {
        base.calcularPerimetro();
        double perimetro = 4 * Lado;
        Console.WriteLine($"O perímetro do quadrado é: {perimetro}");
    }
}
