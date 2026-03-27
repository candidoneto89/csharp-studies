namespace Alura.Geometria;

internal class Circulo : FormaGeometrica
{
    public double Raio { get; set; }
    public void calcularArea()
    {
        base.calcularArea();
        if (Raio > 0) {
            double area = Math.PI * Math.Pow(Raio, 2);
            Console.WriteLine($"A área do círculo é: {area}");
        } else {
            Console.WriteLine("O raio deve ser maior que zero para calcular a área.");
        }
    }
    public void calcularPerimetro()
    {
        base.calcularPerimetro();
        if (Raio > 0) {
            double perimetro = 2 * Math.PI * Raio;
            Console.WriteLine($"O perímetro do círculo é: {perimetro}");
        } else {
            Console.WriteLine("O raio deve ser maior que zero para calcular o perímetro.");
        }
    }
}
