namespace MediatR.Example.Notifications.Handlers;

public class InteligenceProductCreatedNotificationHandler : INotificationHandler<ProductCreatedNotification>
{
    public Task Handle(ProductCreatedNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Adding product {notification.ProductName} to the Intelligence system");
        return Task.CompletedTask;
    }
}