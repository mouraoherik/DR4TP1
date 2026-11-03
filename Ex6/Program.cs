namespace Ex6;

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();

        Action<string> log = logger.LogToConsole;
        log += logger.LogToFile;
        log += logger.LogToDatabase;

        log("Aplicacao iniciada.");

        ProcessadorPedido pedido = new ProcessadorPedido(log);
        
        pedido.Processar(1);
    }
}