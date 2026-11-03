namespace Ex5;

public class Program
{
    public static void Main(string[] args)
    {
        DownloadManager downloadManager = new DownloadManager();
        downloadManager.TamanhoArquivo = 5;

        DownloadNotification downloadNotification = new DownloadNotification();


        downloadManager.DownloadCompleto += downloadNotification.ExibirMensagem;
        
        downloadManager.BaixarArquivo();
    }
}