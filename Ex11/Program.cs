public class Program
{
    public static void Main(string[] args)
    {
        Func<string, string, string> pipeline = Concatenar;
        pipeline += ParaMaiusculas;
        pipeline += RemoverEspacos;

        string resultado = pipeline("Ana Maria", "da Silva");
        Console.WriteLine($"Resultado final: \"{resultado}\"");

        static string Concatenar(string nome, string sobrenome)
        {
            string r = $"{nome} {sobrenome}";
            Console.WriteLine($"Concatenar -> \"{r}\"");
            return r;
        }

        static string ParaMaiusculas(string nome, string sobrenome)
        {
            string r = $"{nome} {sobrenome}".ToUpper();
            Console.WriteLine($"ParaMaiusculas -> \"{r}\"");
            return r;
        }

        static string RemoverEspacos(string nome, string sobrenome)
        {
            string r = $"{nome} {sobrenome}".Replace(" ", "");
            Console.WriteLine($"RemoverEspacos -> \"{r}\"");
            return r;
        }
    }
}
