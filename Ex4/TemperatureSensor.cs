namespace Ex4;

public delegate void NotificacaoDelegate(string mensagem);

public class TemperatureSensor
{
    public double Temperatura { get; set; }
        
    public event NotificacaoDelegate TemperatureExceeded;

    public void ChecarTemperatura(double n1)
    {
        Temperatura = Temperatura + n1;

        Console.WriteLine($"Temperatura esta em {Temperatura} Graus");

        if (Temperatura >= 100)
        {
            TemperatureExceeded("Temperatura acima de 100 Graus!!");
        }
    }
    
}   