namespace Ex6;

public class Logger
{
    public string _caminhoArquivo;

    public Logger(string caminhoArquivo = "log.txt")
    {
        _caminhoArquivo = caminhoArquivo;
    }
    
    public void LogToConsole(string mensagem)
    {
        Console.WriteLine($"[Console] - {mensagem}");
    }

    public void LogToFile(string mensagem)
    {
        File.AppendAllText(_caminhoArquivo,
            $"{mensagem}{Environment.NewLine}");
        Console.WriteLine($"[Arquivo] Gravado em '{_caminhoArquivo}'.");
    }

    public void LogToDatabase(string mensagem)
    {
        Console.WriteLine($"[Banco] INSERT INTO Logs (Data, Mensagem) " +
                          $"VALUES ('{DateTime.Now:yyyy-MM-dd HH:mm:ss}', '{mensagem}')");;
    }
}