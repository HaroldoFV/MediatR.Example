namespace MediatR.Example.Requests.ChangeProductPrice;

public class ChangeProductPriceRequestHandler : IRequestHandler<ChangeProductPriceRequest>
{
    public Task Handle(ChangeProductPriceRequest request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Changing price of product #{request.ProductId} to $ {request.NewPrice}");
        return Task.FromResult(Unit.Value);
    }
}