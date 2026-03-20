namespace Alura.Calculadora;

public class Calculadora
{
    public double Calcular(double a, double b, string operacao)
    {
        switch (operacao)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                if (b == 0)
                    throw new DivideByZeroException("Não é possível dividir por zero.");
                return a / b;
            case "sqrt":
                if (a < 0)
                    throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
                return Math.Sqrt(a);
            case "pow":
                return Math.Pow(a, b);
            default:
                throw new ArgumentException("Operação inválida.");
        }
    }
}
