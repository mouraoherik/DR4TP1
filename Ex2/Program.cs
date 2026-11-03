namespace DR4TP1.Ex2;

public class Ex2
{
    public static void Mensagem(string mensagem)
    {
        Console.WriteLine($"Mensagem: {mensagem}");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Selecione a linguagem\n1.Portugues\n2.Ingles\n3.Espanhol");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Action<string> actionMensagemPortugues = Mensagem;
                actionMensagemPortugues("Bem-vindo!");
                break;
            case 2:
                Action<string> actionMensagemIngles = Mensagem;
                actionMensagemIngles("Welcome!");
                break;
            case 3:
                Action<string> actionMensagemEspanhol = Mensagem;
                actionMensagemEspanhol("Bienvenido!");
                break;
            default:
                Console.WriteLine("Escolha invalida, tente novamente");
                break;
        }

    }
    

}