namespace Alura.Notification;

internal class SMS : INotificavel
{
    public void EnviarNotificacao()
    {
        Console.WriteLine("Enviando notificação por SMS.");
    }
}

internal class Email : INotificavel
{
    public void EnviarNotificacao()
    {
        Console.WriteLine("Enviando notificação por e-mail.");
    }
}
public interface INotificavel
{
    void EnviarNotificacao();
}
