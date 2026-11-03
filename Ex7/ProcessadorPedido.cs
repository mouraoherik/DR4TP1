namespace Ex7;

public class ProcessadorPedido
{
    public Action<string> _log;
    public ProcessadorPedido(Action<string> log)
    {
        _log = log;
    }
    
    public void Processar(int pedidoId)
    {
        _log?.Invoke($"Pedido {pedidoId} recebido.");
        _log?.Invoke($"Pedido {pedidoId} processado com sucesso.");
    }
}