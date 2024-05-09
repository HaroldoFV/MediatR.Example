namespace MediatR.Example.Notifications;

public class ProductCreatedNotification : INotification
{
    public string ProductName { get; set; }
    public int ProductId { get; set; }

    public ProductCreatedNotification(string productName, int productId)
    {
        ProductName = productName;
        ProductId = productId;
    }
}