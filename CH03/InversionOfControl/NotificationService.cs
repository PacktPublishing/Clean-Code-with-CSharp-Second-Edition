namespace CH3.InversionOfControl;

public class NotificationService : IMessageService
{
    private readonly IMessageService _messageService;

    // Constructor injection - the IMessageService is injected
    public NotificationService(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void SendMessage(string message)
    {
        _messageService.SendMessage(message);
    }
}
