namespace MediatR.Example.Notifications.Handlers;

public class PromotionsProductCreatedNotificationHandler : INotificationHandler<ProductCreatedNotification>
{
    public Task Handle(ProductCreatedNotification notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Adding product {notification.ProductName} to the Promotions slots system");
        return Task.CompletedTask;
    }
}