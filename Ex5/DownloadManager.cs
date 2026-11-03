namespace Ex5;

public delegate void NotificacaoDelegate(string mensagem);

public class DownloadManager
{
    public int TamanhoArquivo;

    public event NotificacaoDelegate DownloadCompleto;

    public void BaixarArquivo(){

        for (int i = 0; i < TamanhoArquivo; i++)
        {
            Console.WriteLine("Baixando Arquivo...");
            Thread.Sleep(1000);
        }

        DownloadCompleto("Download Completo");
    }
}