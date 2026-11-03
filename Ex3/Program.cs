namespace Ex3;

internal class Program
{
    public static double CalcularArea(double n1, double n2)
    {
        return n1 * n2;
    }
    
    public static void Main(string[] args)
    {
        Func<double, double, double> funcArea = CalcularArea;
        Console.WriteLine("===== Calculo da Area de um Retangulo =====");

        Console.WriteLine("Digite a base do retangulo");
        double retanguloBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura do retangulo");
        double retanguloAltura = double.Parse(Console.ReadLine());

        double resultado = funcArea(retanguloBase, retanguloAltura);
        Console.WriteLine($"Area do retangulo de base {retanguloBase} e altura {retanguloAltura}: {resultado}");
    }
}