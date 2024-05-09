using MediatR.Example.Notifications;

namespace MediatR.Example.Requests.CreateProduct;

public class CreateProductRequestHandler
    : IRequestHandler<CreateProductRequest, int>
{
    private readonly IMediator _mediator;

    public CreateProductRequestHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<int> Handle(
        CreateProductRequest request,
        CancellationToken cancellationToken
    )
    {
        var id = new Random().Next(1, 10_000);
        Console.WriteLine($"Creating product {request.ProductName} (id: {id})");

        await _mediator.Publish(
            new ProductCreatedNotification(request.ProductName, id),
            cancellationToken
        );
        return id;
    }
}