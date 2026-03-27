namespace Alura.Geometria;

internal class Triangulo : FormaGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }   
    public double Lado3 { get; set; }
    public override void calcularArea()
    {
        base.calcularArea();
        double area = (Base * Altura) / 2;
        Console.WriteLine($"A área do triângulo é: {area}");
    }
    public override void calcularPerimetro()
    {
        base.calcularPerimetro();
        double perimetro = Lado1 + Lado2 + Lado3;
        Console.WriteLine($"O perímetro do triângulo é: {perimetro}");
    }
}
