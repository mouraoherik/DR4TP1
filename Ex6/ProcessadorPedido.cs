namespace Ex6;

public class ProcessadorPedido
{
    public Action<string> _log;
    public ProcessadorPedido(Action<string> log)
    {
        _log = log;
    }
    
    public void Processar(int pedidoId)
    {
        _log($"Pedido {pedidoId} recebido.");
        _log($"Pedido {pedidoId} processado com sucesso.");
    }
}