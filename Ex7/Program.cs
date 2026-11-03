namespace Ex7;

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();

        Action<string> log = null;

        try
        {
            log?.Invoke("Esta mensagem vai para lugar nenhum");

            ProcessadorPedido pedido = new ProcessadorPedido(log);
            pedido.Processar(100);

            Console.WriteLine("Teste sem nenhuma exceção com o delegate vazio");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Teste Falhou: {ex.GetType().Name} - {ex.Message}");
        }
    }
}