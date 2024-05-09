namespace MediatR.Example.Requests.ChangeProductPrice;

public class ChangeProductPriceRequest : IRequest
{
    public int ProductId { get; set; }
    public decimal NewPrice { get; set; }

    public ChangeProductPriceRequest(int productId, decimal newPrice)
    {
        ProductId = productId;
        NewPrice = newPrice;
    }
}