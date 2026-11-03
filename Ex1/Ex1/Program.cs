namespace DR4TP1.Ex1
{
    internal class Program
    {
        public delegate decimal CalculateDiscount(decimal n1,decimal desconto);
        
        public static decimal CalcularDesconto(decimal n1,decimal desconto)
        {
            return n1 - (n1 * desconto);
        }
        
        public static void Main(string[] args)
        {
            decimal retorno;
            CalculateDiscount del = new CalculateDiscount(CalcularDesconto);
            Console.WriteLine("Digite um preco");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Preco original: {preco}");
            retorno = del(preco, (decimal)0.1);
            Console.WriteLine($"Preco com 10% de desconto: {retorno}");

        }
        
    }
}

