namespace Ex4;

public class Program
{
    public static void Main(string[] args)
    {
        TemperatureSensor t1 = new TemperatureSensor();
        NotificacaoTemperatura notificacao = new NotificacaoTemperatura();
        
        
        
        t1.TemperatureExceeded += notificacao.ExibirMensagem;
        
        t1.ChecarTemperatura(30);
        t1.ChecarTemperatura(30);
        t1.ChecarTemperatura(30);
        t1.ChecarTemperatura(30);
    }
}